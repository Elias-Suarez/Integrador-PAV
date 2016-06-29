Public Class Camiones_Mas_Reparados
#Region "Carga datos"
    Private Sub Mantenimientos_Mas_Realizados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.modo_inicio()

    End Sub

    Private Sub modo_inicio()
        Dim combo As New Combo
        combo.cargar_combo(cmb_taller, "codigo_taller", "nombre", "Taller")
        cmb_taller.SelectedIndex = -1

        combo.cargar_combo(cmb_trabajo, "id", "nombre", "Trabajo")
        cmb_trabajo.SelectedIndex = -1
    End Sub



#End Region


#Region "Funcion Botones"
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim columnas As String = " c.patente 'patente', COUNT(tm.id_trabajo) 'cantidad', SUM(tm.costo) 'costo_total' "
        Dim restricciones As String = " c.patente = tm.patente "
        Dim tablas As String = " Camion c, TrabajoXMantenimiento tm "
        Dim sql As String = ""
        Dim tabla As New DataTable
        Dim reporte As New Report_Camiones_mas_reparados
        Dim ds As New Data_camiones_mas_reparados



        If mtb_fecha_desde.MaskCompleted And mtb_fecha_hasta.MaskCompleted Then
            restricciones &= " AND tm.fecha >= CONVERT( VARCHAR(10), '" & mtb_fecha_desde.Text & "',103) "
            restricciones &= " AND tm.fecha <= CONVERT( VARCHAR(10), '" & mtb_fecha_hasta.Text & "',103) "

            If Not cmb_trabajo.SelectedIndex = -1 Then
                tablas &= ", Trabajo tr "
                restricciones &= " AND tm.id_trabajo = tr.id AND tr.id = " & cmb_trabajo.SelectedValue & " "
            End If

            If Not cmb_taller.SelectedIndex = -1 Then
                tablas &= ", Mantenimiento m "
                restricciones &= " AND tm.patente = m.patente AND tm.fecha = m.fecha"
                restricciones &= " AND m.cod_taller = " & cmb_taller.SelectedValue & " "
            End If

            Dim acceso As New AccesoDatos With {._nombre_tabla = tablas}

            sql = "SELECT " & columnas
            sql &= " FROM " & tablas
            sql &= " WHERE " & restricciones
            sql &= " GROUP BY c.patente ORDER BY Cantidad DESC"

            tabla = acceso.leo_Consulta(sql)

            reporte.SetDataSource(tabla)

            crv_reporte.ReportSource = reporte
            crv_reporte.Show()
            crv_reporte.Refresh()

        Else
            MessageBox.Show("Ingrese el período del informe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

    End Sub

    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub


#End Region


#Region "Validaciones"

    Private Sub validar_fechas()
        If mtb_fecha_desde.MaskCompleted And mtb_fecha_hasta.MaskCompleted Then

            If mtb_fecha_desde.MaskCompleted And mtb_fecha_hasta.MaskCompleted Then
                If IsDate(mtb_fecha_desde.Text) And IsDate(mtb_fecha_hasta.Text) Then
                    If Convert.ToDateTime(mtb_fecha_desde.Text) > Convert.ToDateTime(mtb_fecha_hasta.Text) Then
                        MsgBox("La fecha DESDE no puede ser mayor que la fecha HASTA")
                    End If
                Else
                    MessageBox.Show("Una o más fechas no tienen formato de fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            End If
    End Sub

    Private Sub mtb_fecha_desde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtb_fecha_desde.LostFocus
        Me.validar_fechas()
        Me.lbl_alerta_fecha_desde.Visible = Not mtb_fecha_desde.MaskCompleted
    End Sub

    Private Sub mtb_fecha_hasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtb_fecha_hasta.LostFocus
        Me.validar_fechas()
        Me.lbl_alerta_fecha_hasta.Visible = Not mtb_fecha_hasta.MaskCompleted
    End Sub



#End Region

End Class