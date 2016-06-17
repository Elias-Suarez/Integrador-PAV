Public Class Mantenimientos_Mas_Realizados

#Region "Carga datos"
    Private Sub Mantenimientos_Mas_Realizados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.modo_inicio()
    End Sub

    Private Sub modo_inicio()
        Dim combo As New Combo
        combo.cargar_combo(cmb_taller, "codigo_taller", "nombre", "Taller")
        cmb_taller.SelectedIndex = -1
    End Sub



#End Region


#Region "Funcion Botones"
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim columnas As String = " tm.id_trabajo 'trabajo', tr.nombre 'nombre', COUNT(tm.id_trabajo) 'cantidad' "
        Dim restricciones As String = " tm.id_trabajo = tr.id "
        Dim tablas As String = " TrabajoXMantenimiento tm, Trabajo tr "
        Dim sql As String = ""

        Dim tabla As New DataTable
        Dim reporte As New Report_Manteimiento_mas_realizad

        If mtb_fecha_desde.MaskCompleted And mtb_fecha_hasta.MaskCompleted Then
            restricciones &= " AND tm.fecha >= CONVERT( VARCHAR(10), '" & mtb_fecha_desde.Text & "',103) "
            restricciones &= " AND tm.fecha <= CONVERT( VARCHAR(10), '" & mtb_fecha_hasta.Text & "',103) "

            If Not cmb_taller.SelectedIndex = -1 Then
                tablas &= ", Mantenimiento m "
                restricciones &= " AND tm.patente = m.patente AND tm.fecha = m.fecha"
                restricciones &= " AND m.cod_taller = " & cmb_taller.SelectedValue & " "
            End If

            Dim acceso As New AccesoDatos With {._nombre_tabla = tablas}

            sql = "SELECT " & columnas
            sql &= " FROM " & tablas
            sql &= " WHERE " & restricciones
            sql &= " GROUP BY id_trabajo, tr.nombre ORDER BY Cantidad DESC"

            tabla = acceso.leo_Consulta(sql)
            reporte.SetDataSource(tabla)

            rpv_reporte.ReportSource = reporte
            rpv_reporte.Show()
            rpv_reporte.Refresh()
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
            If Convert.ToDateTime(mtb_fecha_desde.Text) > Convert.ToDateTime(mtb_fecha_hasta.Text) Then
                MsgBox("La fecha DESDE no puede ser mayor que la fecha HASTA")
            End If
        End If
    End Sub

    Private Sub mtb_fecha_desde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtb_fecha_desde.LostFocus
        Me.validar_fechas()
        Me.lbl_alerta_fecha_desde.Visible = Not mtb_fecha_desde.MaskCompleted
    End Sub

    Private Sub mtb_fecha_hasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtb_fecha_hasta.LostFocus
        Me.validar_fechas()
        Me.lbl_alerta_fecha_desde.Visible = Not mtb_fecha_hasta.MaskCompleted
    End Sub

#End Region

End Class