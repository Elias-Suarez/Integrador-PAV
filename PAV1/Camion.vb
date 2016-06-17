Public Class Camion
    Dim acceso As New ConexionBD

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
    Dim cargarCombo As ModeloCombo
    
    Private Sub cargaGrilla()

        Dim tabla As New Data.DataTable 'objeto multi objeto internamente, el objeto no ah sido creado hasta colocar el NEW
        Dim txt_sql As String = ""

        txt_sql = " SELECT c.patente c.año mc.nombre md.nombre"
        txt_sql += " FROM dbo.Camion c, dbo.Marca mc, dbo.Modelo md"
        txt_sql += " WHERE md.codigo = c.modelo AND mc.codigo = md.idMarca"
        'trae un conjunto de datos q luego meto temporalmente en la tabla
        tabla = acceso.ejecutarQuery(txt_sql)
        DataGridView1.DataSource = tabla

        Dim c As Integer = 0
        'for cantidad de filas de la tabla
        'DataGridView1.Rows.Add(tabla.Rows(c) agregar una fila a la grilla

        For c = 0 To tabla.Rows.Count - 1
            DataGridView1.Rows.Add(tabla.Rows(c)("patente"), _
                                 tabla.Rows(c)("año"), _
                                 tabla.Rows(c)("marca"), _
                                 tabla.Rows(c)("modelo"))
        Next
     
    End Sub
    Private Function validar() As Boolean
        If mtb_patente.Text = "" Then
            error1.Visible = True
            mtb_patente.Focus()
            mjeError.Visible = True
            Return False
        End If
        If txt_año.Text = "" Then
            error2.Visible = True
            txt_año.Focus()
            mjeError.Visible = True
            Return False
        End If
        If cbx_marca.SelectedIndex = -1 Then
            error3.Visible = True
            cbx_marca.Focus()
            mjeError.Visible = True
            Return False
        End If
        If cbx_modelo.SelectedIndex = -1 Then
            error3.Visible = True
            cbx_modelo.Focus()
            mjeError.Visible = True
            Return False
        End If

        If txt_kilometraje_inicial.Text = "" Then
            error3.Visible = True
            txt_kilometraje_inicial.Focus()
            mjeError.Visible = True
            Return False
        End If
        Return True
    End Function
    Private Sub Camion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargaGrilla()
        mtb_patente.Focus()
        cargarCombo = New ModeloCombo
        Me.cargarCombo.cargar_combo(Me.cbx_marca, "Marca")
        Me.cbx_marca.SelectedIndex = -1


    End Sub

    Private Function validar_existencia() As termino
        Dim consulta As String = ""
        Dim tabla As New Data.DataTable
        consulta = "SELECT * FROM dbo.Camion "
        consulta &= "WHERE patente = '" & Me.mtb_patente.Text & "'"
        tabla = acceso.ejecutarQuery(consulta)

        If tabla.Rows.Count() = 1 Then
            Return termino.rechazado
        Else
            Return termino.aprobado
        End If
    End Function
    Private Sub btn_insertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insertar.Click
        If Me.validar Then
            If validar_existencia() = termino.aprobado Then


                Dim sql As String = "INSERT INTO camion(patente,modelo,año,kilometraje) VALUES("
                sql &= Me.mtb_patente.Text & "," & Me.cbx_modelo.SelectedValue & "," & Me.txt_año.Text & "," & Me.txt_kilometraje_inicial.Text & ")"
                acceso.insertar(sql)
            Else
                MsgBox("El camion ya existe!")
                Dim con As New ModeloCombo
                con.limpiar(Me.GroupBox1.Controls)
                cbx_marca.SelectedIndex = -1
                cbx_modelo.SelectedIndex = -1
                mtb_patente.Focus()
            End If
        End If
    End Sub

    Private Sub cbx_marca_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_marca.SelectionChangeCommitted
        cargarCombo = New ModeloCombo
        Dim consulta As String = "select md.codigo, md.nombre from Marca mc, Modelo md  Where mc.codigo = md.idMarca and  md.idMarca = " & cbx_marca.SelectedValue
        Me.cargarCombo.cargar_combo(Me.cbx_modelo, "Modelo", consulta)
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        Me.Close()
    End Sub

End Class