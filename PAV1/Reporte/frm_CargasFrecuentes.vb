Public Class frm_CargasFrecuentes
    Dim conexion As New ConexionBD
    Dim ds As New dsTipoCarga
    Dim reporte As New reporteCarga
    Private Sub frm_CargasFrecuentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT COUNT(dv.tipo_carga) AS cantidad, tc.nombre,tc.descripcion"
        sql &= " FROM DetalleViaje dv INNER JOIN TipoCarga	tc ON dv.tipo_carga = tc.id"
        sql &= " GROUP BY tc.nombre,tc.descripcion"

        Dim tabla As New Data.DataTable
        tabla = conexion.ejecutarQuery(sql)
        reporte.SetDataSource(tabla)

        CrystalReportViewer1.ReportSource = reporte
        CrystalReportViewer1.Show()
        CrystalReportViewer1.Refresh()

    End Sub

    Private Sub dtFechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaDesde.ValueChanged

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Listados.Show()
        Me.Close()

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        'Dim chofer As Integer = cbChofer.SelectedValue
        Dim fechaDesde As String = Format(dtFechaDesde.Value, "yyyy-MM-dd")
        Dim fechaHasta As String = Format(dtHasta.Value, "yyyy-MM-dd")

        Dim sql As String = "SELECT COUNT(dv.tipo_carga) AS cantidad, tc.nombre,tc.descripcion, dv.fecha_salida"
        sql &= " FROM DetalleViaje dv INNER JOIN TipoCarga	tc ON dv.tipo_carga = tc.id "
        sql &= " INNER JOIN Viaje v ON v.fecha_salida = dv.fecha_salida "
        sql &= "  WHERE  dv.fecha_salida >='" & fechaDesde & "'AND dv.fecha_salida <=  '" & fechaHasta & "'"
        sql &= " GROUP BY tc.nombre,tc.descripcion, dv.fecha_salida ORDER BY cantidad desc"

        Dim reporteFiltro As New rptTipoCarga_filtro
        Dim tabla As New Data.DataTable
        tabla = conexion.ejecutarQuery(sql)
        reporteFiltro.SetDataSource(tabla)
        Me.CrystalReportViewer1.ReportSource = reporteFiltro
        Me.CrystalReportViewer1.Show()
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class