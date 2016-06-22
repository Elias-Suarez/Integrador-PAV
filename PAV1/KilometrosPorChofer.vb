Public Class KilometrosPorChofer
    Private Sub generarGrafico(ByVal consulta As String)
        Dim conexion As New ConexionBD
        Dim reporte As New rptKmMensuales

        Dim tabla As New Data.DataTable
        tabla = conexion.ejecutarQuery(consulta)
        reporte.SetDataSource(tabla)
        CrystalReportViewer1.ReportSource = reporte
        CrystalReportViewer1.Show()
        CrystalReportViewer1.Refresh()
    End Sub
    Private Sub KilometrosPorChofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim consulta As String = "SET LANGUAGE 'Spanish';"
        consulta &= "SELECT  SUM(v.kilometros) km ,datename(MONTH,v.fecha_llegada) mes, c.nombre "
        consulta &= "FROM  Viaje v INNER JOIN Chofer c ON c.nro_doc = v.nro_doc_chofer "
        consulta &= "GROUP BY datename(MONTH,v.fecha_llegada),c.nombre"
        generarGrafico(consulta)
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Listados.Show()
        Me.Close()
    End Sub
End Class