Public Class Form_Mantenimientos_Mensuales

#Region "Carga Formulario"
    Private Sub Estadistica_Viajes_Por_Localidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargar_combo()
        Me.txt_año.Text = "2016"
        Me.rpv_estadistica.RefreshReport()
    End Sub

    Private Sub cargar_combo()

        Dim dt As New DataTable

        dt.Columns.Add("Value")
        dt.Columns.Add("Display")

        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Value") = "1"
        dr("Display") = "Enero"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Value") = "2"
        dr("Display") = "Febrero"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Value") = "3"
        dr("Display") = "Marzo"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Value") = "4"
        dr("Display") = "Abril"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Value") = "5"
        dr("Display") = "Mayo"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Value") = "6"
        dr("Display") = "Junio"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Value") = "7"
        dr("Display") = "Julio"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Value") = "8"
        dr("Display") = "Agosto"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Value") = "9"
        dr("Display") = "Septiembre"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Value") = "10"
        dr("Display") = "Octubre"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Value") = "11"
        dr("Display") = "Noviembre"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Value") = "12"
        dr("Display") = "Diciembre"
        dt.Rows.Add(dr)


        cmb_mes.DataSource = dt
        cmb_mes.ValueMember = "Value"
        cmb_mes.DisplayMember = "Display"
    End Sub

#End Region


#Region "Funciones de Botones"

    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim sql As String = ""

        Dim acceso As New AccesoDatos
        Dim tabla As New DataTable

        sql = "SELECT t.nombre 'nombre', COUNT(m.id_trabajo) 'cantidad' "
        sql &= " FROM TrabajoXMantenimiento m, Trabajo t "
        sql &= " WHERE MONTH(fecha) = " & cmb_mes.SelectedValue & " and YEAR(fecha) = " & txt_año.Text & " and m.id_trabajo = t.id "
        sql &= " GROUP BY t.nombre "

        tabla = acceso.leo_Consulta(sql)

        If Not tabla.Rows.Count = 0 Then

            MantenimientosBindingSource.DataSource = tabla
            rpv_estadistica.RefreshReport()
        Else
            MessageBox.Show("No existen coincidencias para la fecha: " & cmb_mes.SelectedValue & "/" & txt_año.Text, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

#End Region


#Region "Validaciones"

    Private Sub txt_año_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_año.KeyPress
        If (Not Char.IsNumber(e.KeyChar)) And (Not e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txt_año_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_año.LostFocus
        If txt_año.Text = "" Or txt_año.Text > 3000 Then
            MessageBox.Show("Debe ingresar un año válido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

#End Region


End Class