Public Class ABM_Chofer
    Enum Estado
        insertar
        modificar
    End Enum
    Enum termino
        aprobado
        rechazado
    End Enum
    Dim accion As Estado = Estado.insertar
    Dim conexionBD As String = "Data Source=(local);Initial Catalog=BD_Transporte_Don_Luis;User ID=sa;Password=jinjo32"


    'Funcion para ejecutar consulta SQL
    Private Function ejecutoSQL(ByVal consulta As String) As Data.DataTable
        Dim conexion As SqlClient.SqlConnection = New Data.SqlClient.SqlConnection
        Dim cmd As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable

        conexion.ConnectionString = Me.conexionBD
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta

        tabla.Load(cmd.ExecuteReader())
        conexion.Close()
        Return tabla
    End Function
    Private Function leoConsulta(ByVal consulta As String) As Data.DataTable
        Return ejecutoSQL("select * from " & consulta)
    End Function

    'Cargo los combos
    Private Sub cargarCombo(ByRef combo As ComboBox, ByVal dato As Data.DataTable, ByVal pk As String, ByVal descipcion As String)
        combo.Items.Clear()
        combo.DataSource = dato
        combo.ValueMember = pk
        combo.DisplayMember = descipcion
    End Sub

    Private Function insertar() As termino

        Try
            Dim conexion As SqlClient.SqlConnection
            conexion = New Data.SqlClient.SqlConnection
            Dim cmd As New Data.SqlClient.SqlCommand ' Ejecutara mi consulta SQL
            conexion.ConnectionString = Me.conexionBD 'Le decimos cual sera nuestra cadena de conexion
            conexion.Open()
            Dim consulta As String = ""
            consulta = "INSERT INTO dbo.Chofer ("
            consulta &= "tipo_doc,nro_doc,nombre,apellido,"
            consulta &= "fecha_nacimiento, fecha_ingreso,celular,tel_fijo)"
            consulta &= " VALUES (" & Me.cmbTipoDni.SelectedValue & ", "
            consulta &= Me.mskDni.Text & ",'" & Me.txtNombre.Text & "','"
            consulta &= Me.txtApellido.Text & "','"
            consulta &= Convert.ToDateTime(Me.mskFechaNac.Text)
            consulta &= "',' " & Convert.ToDateTime(Me.mskFechaIngreso.Text)
            consulta &= "', '" & Me.txtCelular.Text & "','" & Me.mskTelFijo.Text & "')"

            cmd.CommandType = CommandType.Text
            cmd.CommandText = consulta
            cmd.Connection = conexion
            cmd.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("UPS, controla tus datos", "Importante",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            mskDni.Focus()

        End Try
        

        Return termino.aprobado
    End Function

    Private Function eliminar(ByVal nroDoc As String) As termino
        Dim conexion As SqlClient.SqlConnection
        conexion = New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand ' Ejecutara mi consulta SQL
        conexion.ConnectionString = Me.conexionBD 'Le decimos cual sera nuestra cadena de conexion
        conexion.Open()
        Dim consulta As String = ""
        consulta = "DELETE FROM Chofer WHERE nro_doc = " & nroDoc
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        cmd.ExecuteNonQuery()
        conexion.Close()
        limpiar()
        btnNuevo.Focus()
        Return termino.aprobado
    End Function
    Private Sub cargaGrilla()

        Dim tabla As New Data.DataTable 'objeto multi objeto internamente, el objeto no ah sido creado hasta colocar el NEW
        Dim txt_sql As String = ""

        txt_sql = " SELECT ch.apellido, ch.nombre, ch.nro_doc, ch.tipo_doc,ch.fecha_nacimiento,ch.fecha_ingreso,ch.celular,ch.tel_fijo"
        txt_sql += " FROM dbo.Chofer ch JOIN dbo.TipoDocumento td ON  ch.tipo_doc  = td.id"
        'trae un conjunto de datos q luego meto temporalmente en la tabla
        tabla = Me.ejecutoSQL(txt_sql)

        Dim c As Integer = 0
        'for cantidad de filas de la tabla
        'Me.grd1.Rows.Add(tabla.Rows(c) agregar una fila a la grilla

        For c = 0 To tabla.Rows.Count - 1
            Me.dgvChofer.Rows.Add(tabla.Rows(c)("apellido"), _
                             tabla.Rows(c)("nombre"), _
                             tabla.Rows(c)("tipo_doc"), _
                             tabla.Rows(c)("nro_doc"), _
                             tabla.Rows(c)("fecha_nacimiento"), _
                             tabla.Rows(c)("fecha_ingreso"), _
                             tabla.Rows(c)("celular"), _
                             tabla.Rows(c)("tel_fijo"))
        Next

    End Sub

    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As New Data.DataTable
        consulta = "SELECT * FROM dbo.Chofer "
        consulta &= "WHERE nro_doc = " & Me.mskDni.Text
        consulta &= "and tipo_doc = " & Me.cmbTipoDni.SelectedValue
        tabla = Me.ejecutoSQL(consulta)

        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function
    Private Sub limpiarGrilla()
        Me.dgvChofer.Rows.Clear()
        Me.dgvChofer.DataSource = Nothing
    End Sub
    Private Function validar() As Boolean
        If Me.mskDni.Text = "" Then
            lblDni.Visible = True
            lblAlerta.Visible = True
            Me.mskDni.Focus()
            Return False
        Else
            lblDni.Visible = False
            lblAlerta.Visible = False
        End If
        If Me.cmbTipoDni.SelectedValue = -1 Then
            lblAlertaTD.Visible = True
            lblAlerta.Visible = True
            Me.cmbTipoDni.Focus()
            Return False
        Else
            lblAlertaTD.Visible = False
            lblAlerta.Visible = False
        End If
       
        If Me.txtApellido.Text = "" Then
            lblAlertaApellido.Visible = True
            lblAlerta.Visible = True
            Me.txtApellido.Focus()
            Return False
        Else
            lblAlertaApellido.Visible = False
            lblAlerta.Visible = False
        End If
        If Me.txtNombre.Text = "" Then
            lblAlertaNombre.Visible = True
            lblAlerta.Visible = True
            Me.txtNombre.Focus()
            Return False
        Else
            lblAlertaNombre.Visible = False
            lblAlerta.Visible = False
        End If
        If mskFechaNac.MaskCompleted = False Then
            lblAlertaFecNac.Visible = True
            lblAlerta.Visible = True
            Me.mskFechaNac.Focus()
            Return False
        Else
            lblAlertaFecNac.Visible = False
            lblAlerta.Visible = False
        End If
        If Me.mskFechaIngreso.MaskCompleted = False Then
            lblFecIng.Visible = True
            lblAlerta.Visible = True
            Me.mskFechaIngreso.Focus()
            Return False
        Else
            lblFecIng.Visible = False
            lblAlerta.Visible = False
        End If
        If txtCelular.Text = "" Then
            lblAlertaCel.Visible = True
            lblAlerta.Visible = True
            txtCelular.Focus()
            Return False
        Else
            lblAlertaCel.Visible = False
            lblAlerta.Visible = False
        End If

        If Me.mskTelFijo.MaskCompleted = False Then
            lblAlertaTelFijo.Visible = True
            lblAlerta.Visible = True
            Me.mskTelFijo.Focus()
            Return False
        Else
            lblAlertaTelFijo.Visible = False
            lblAlerta.Visible = False
        End If

        Return True
        lblAlerta.Visible = False
    End Function
    Private Sub limpiar()
        txtApellido.Text = ""
        txtCelular.Text = ""
        txtNombre.Text = ""
        mskDni.Text = ""
        mskFechaNac.Text = ""
        mskFechaIngreso.Text = ""
        mskTelFijo.Text = ""
    End Sub
    Private Sub btnInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertar.Click
        If validar() Then
            If Me.accion = Estado.insertar Then
                If Me.validar_existencia() = termino.aprobado Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya esta cargada una persona con ese documento", "Importante",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiar()
                    Exit Sub
                End If
                'Else
                ' Me.modificar()
            End If
            limpiarGrilla()
            Me.cargaGrilla()
            limpiar()
            MessageBox.Show("Se cargo exitosamente " + txtNombre.Text, "importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ABM_Chofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarCombo(Me.cmbTipoDni, Me.leoConsulta("TipoDocumento"), "id", "descripcion")
        Me.txtApellido.Focus()
        Me.cargaGrilla()
        habilitar(False)
    End Sub

    Private Sub dgvChofer_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvChofer.CellContentClick

    End Sub

    Private Sub dgvChofer_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvChofer.CellDoubleClick
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String = ""

        consulta = "SELECT * FROM Chofer WHERE nro_doc = " & Me.dgvChofer.CurrentRow.Cells(3).Value
        consulta &= " and tipo_doc = " & Me.dgvChofer.CurrentRow.Cells(2).Value

        conexion.ConnectionString = Me.conexionBD
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta

        tabla.Load(cmd.ExecuteReader())

        Me.txtApellido.Text = tabla.Rows(0)("apellido")
        Me.txtNombre.Text = tabla.Rows(0)("nombre")
        Me.mskDni.Text = tabla.Rows(0)("nro_doc")
        Me.cmbTipoDni.SelectedValue = tabla.Rows(0)("tipo_doc")
        'Me.mskFechaNac.Text = Format(tabla.Rows(0)("fecha_nacimiento"), "dd/MM/yyyy")
        ' Me.mskFechaIngreso.Text = Format(tabla.Rows(0)("fecha_ingreso"), "dd/MM/yyyy")
        Me.mskTelFijo.Text = tabla.Rows(0)("tel_fijo")
        Me.txtCelular.Text = tabla.Rows(0)("celular")


        Me.mskDni.Enabled = False
        Me.cmbTipoDni.Enabled = False

        Me.accion = Estado.modificar

        conexion.Close()
    End Sub

    Private Sub habilitar(ByVal valor As Boolean)
        mskDni.Enabled = valor
        cmbTipoDni.Enabled = valor
        txtApellido.Enabled = valor
        txtNombre.Enabled = valor
        txtCelular.Enabled = valor
        mskFechaNac.Enabled = valor
        mskFechaIngreso.Enabled = valor
        mskTelFijo.Enabled = valor
        btnInsertar.Enabled = valor
        'btnModificar.Enabled = valor
        btnNuevo.Enabled = Not valor
    End Sub

    Private Sub mskDni_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskDni.Leave
        ' MessageBox.Show("El chofer ya existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Try
            If Me.validar_existencia = termino.rechazado Then
                MessageBox.Show("El chofer ya existe", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mskDni.Focus()
                limpiar()
            End If
        Catch ex As Exception
            mskDni.Focus()
            lblDni.Visible = True
            lblAlerta.Visible = True
        End Try
    End Sub


    Private Sub mskDni_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskDni.TabIndexChanged
        'If Me.validar_existencia = termino.rechazado Then
        '    MessageBox.Show("El chofer ya existe", "Importante",
        '                             MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    mskDni.Focus()
        'End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        habilitar(True)
        mskDni.Focus()

    End Sub

    Private Sub mskDni_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskDni.MaskInputRejected

    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgvChofer.SelectedRows.Count > 0 Then
            Dim nroDoc As Integer = Convert.ToInt32(dgvChofer.CurrentRow.Cells(3).Value)
            eliminar(nroDoc)
            limpiarGrilla()
            cargaGrilla()
        End If
    End Sub
End Class