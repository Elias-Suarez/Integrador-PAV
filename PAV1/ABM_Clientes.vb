Public Class ABM_Clientes

    Enum Estado
        insertar
        modificar
    End Enum

    Enum termino
        aprobado
        rechazado
    End Enum

    Dim cargarProvYLoc As New ModeloCombo
    Dim accion As Estado = Estado.insertar
    Dim conexionBD As String = "Data Source=(local);Initial Catalog=BD_Transporte_Don_Luis;User ID=sa;Password=jinjo32"
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

    'Private Sub cargarCombo(ByRef combo As ComboBox, ByVal dato As Data.DataTable, ByVal pk As String, ByVal descipcion As String)

    '    combo.Items.Clear()
    '    combo.DataSource = dato
    '    combo.ValueMember = pk
    '    combo.DisplayMember = descipcion

    'End Sub

    Private Sub cargaGrilla()

        Dim tabla As New Data.DataTable 'objeto multi objeto internamente, el objeto no ah sido creado hasta colocar el NEW
        Dim txt_sql As String = ""

        txt_sql = " SELECT *" 'cl.nro_cuit, cl.razon_social, cl.nombre_contacto, cl.mail, cl.telefono, cl.domicilio, cl.localidad"
        txt_sql += " FROM dbo.Cliente " ' cl dbo.TipoDocumento td INER JOIN  cl.cuit  = td.id"
        'trae un conjunto de datos q luego meto temporalmente en la tabla
        tabla = Me.ejecutoSQL(txt_sql)

        Dim c As Integer = 0
        'for cantidad de filas de la tabla
        'Me.grd1.Rows.Add(tabla.Rows(c) agregar una fila a la grilla

        For c = 0 To tabla.Rows.Count - 1
            Me.dgv_clientes.Rows.Add(tabla.Rows(c)("nro_cuit"), _
                             tabla.Rows(c)("razon_social"), _
                             tabla.Rows(c)("nombre_contacto"), _
                             tabla.Rows(c)("mail"), _
                             tabla.Rows(c)("telefono"), _
                             tabla.Rows(c)("domicilio"), _
                             tabla.Rows(c)("localidad"))
            ' tabla.Rows(c)("provincia"))
        Next

    End Sub

    Private Function validar() As Boolean

        If Me.mtb_cuit.MaskFull = False Then
            MessageBox.Show("EL CAMPO CUIT ESTA VACIO")
            Return False
        End If

        If Me.txt_razon_social.Text = "" Then
            MessageBox.Show("EL CAMPO RAZON SOCIAL ESTA VACIO")
            Return False
        End If

        If Me.txt_nombre.Text = "" Then
            MessageBox.Show("EL CAMPO NOMBRE ESTA VACIO")
            Return False
        End If

        If Me.txt_telefono.Text = "" Then
            MessageBox.Show("EL CAMPO TELEFONO ESTA VACIO")
            Return False
        End If

        If Me.txt_domicilio.Text = "" Then
            MessageBox.Show("EL CAMPO DOMICILIO ESTA VACIO")
            Return False
        End If

        If Me.cbx_localidad.SelectedValue = -1 Then
            MessageBox.Show("EL CAMPO LOCALIDAD ESTA VACIO")
            Return False
        End If

        If Me.cbx_provincia.SelectedValue = -1 Then
            MessageBox.Show("EL CAMPO PROVINCIA ESTA VACIO")
            Return False
        End If

        Return True

    End Function

    Private Sub limpiarGrilla()

        Me.dgv_clientes.Rows.Clear()
        Me.dgv_clientes.DataSource = Nothing

    End Sub

    Private Sub limpiar()

        mtb_cuit.Text = ""
        txt_domicilio.Text = ""
        txt_email.Text = ""
        cbx_localidad.SelectedValue = -1
        txt_nombre.Text = ""
        txt_razon_social.Text = ""
        txt_telefono.Text = ""
        cbx_provincia.SelectedValue = -1

    End Sub

    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As New Data.DataTable
        consulta = "SELECT * FROM dbo.Cliente "
        consulta &= "WHERE nro_cuit = " & Me.mtb_cuit.Text
        tabla = Me.ejecutoSQL(consulta)

        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function

    Private Function insertar() As termino
        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand ' Ejecutara mi consulta SQL
        conexion.ConnectionString = Me.conexionBD 'Le decimos cual sera nuestra cadena de conexion
        conexion.Open()
        Dim consulta As String = ""
        consulta = "INSERT INTO dbo.Cliente ("
        consulta &= "nro_cuit,razon_social,nombre_contacto,mail,"
        consulta &= "telefono, domicilio,localidad)"
        consulta &= " VALUES (" & Me.mtb_cuit.Text & ",'"
        consulta &= Me.txt_razon_social.Text & "','" & Me.txt_nombre.Text & "','"
        consulta &= Me.txt_email.Text & "','"
        consulta &= Me.txt_telefono.Text & "','" & Me.txt_domicilio.Text & "','" & Me.cbx_localidad.SelectedValue & " ')"

        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta
        cmd.Connection = conexion
        cmd.ExecuteNonQuery()
        conexion.Close()

        Return termino.aprobado
    End Function


    Private Sub ABM_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarProvYLoc.cargar_combo(cbx_provincia, "Provincia")
        Me.cbx_provincia.SelectedIndex = -1
        Me.mtb_cuit.Focus()
        'Me.cargaGrilla()
    End Sub


    Private Sub dgv_clientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick

        Dim conexion As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand
        Dim tabla As New Data.DataTable
        Dim consulta As String = ""

        consulta = "SELECT * FROM Cliente WHERE nro_cuit = " & Me.dgv_clientes.CurrentRow.Cells(0).Value


        conexion.ConnectionString = Me.conexionBD
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = consulta

        tabla.Load(cmd.ExecuteReader())

        Me.mtb_cuit.Text = tabla.Rows(0)("nro_cuit")
        Me.txt_razon_social.Text = tabla.Rows(0)("razon_social")
        Me.txt_nombre.Text = tabla.Rows(0)("nombre_contacto")
        Me.txt_email.Text = tabla.Rows(0)("mail")
        Me.txt_domicilio.Text = tabla.Rows(0)("domicilio")
        Me.txt_telefono.Text = tabla.Rows(0)("telefono")
        Me.cbx_localidad.SelectedValue = tabla.Rows(0)("localidad")
        Me.cbx_provincia.SelectedValue = tabla.Rows(0)("nombre")



        Me.mtb_cuit.Enabled = False

        Me.accion = Estado.modificar

        conexion.Close()

    End Sub

    Private Sub btnInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertar.Click

        If validar() Then
            If Me.accion = Estado.insertar Then
                If Me.validar_existencia() = termino.aprobado Then
                    Me.insertar()
                Else
                    MessageBox.Show("Ya esta cargado ese CUIT", "Importante",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

            End If
            limpiarGrilla()
            ' Me.cargaGrilla()
            limpiar()
            MessageBox.Show("Se cargo exitosamente " + txt_nombre.Text + " CUIT: " + mtb_cuit.Text, "importante", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    
    Private Sub cbx_provincia_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_provincia.SelectionChangeCommitted
        'cargarProvYLoc = New ModeloCombo
        Dim query As String = "SELECT loc.cp,loc.nombre "
        query &= " FROM Localidad loc INNER JOIN Provincia pr ON loc.nro_provincia = pr.nro_provincia"
        query &= " WHERE loc.nro_provincia= " & cbx_provincia.SelectedValue
        Me.cargarProvYLoc.cargar_combo(cbx_localidad, "Localidad", query)
    End Sub

    Private Sub txt_email_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_email.Leave
        Dim res As Boolean = Me.cargarProvYLoc.validarEmail(Me.txt_email.Text)
        If res = False Then
            MsgBox("Debe ingresar un email valido!")
            txt_email.Text = ""
            txt_email.Focus()

        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        'Me.cargarProvYLoc.limpiar(Me.Controls)
        MsgBox("El valor es : " & Me.mtb_cuit.Text)

    End Sub
End Class


