Public Class ViajesPorCliente


    Private Sub generarGrafico(ByVal consulta As String)
        Dim conexion As New ConexionBD
        Dim reporte As New rptEstadisticasClientes

        Dim tabla As New Data.DataTable
        tabla = conexion.ejecutarQuery(consulta)
        reporte.SetDataSource(tabla)
        CrystalReportViewer1.ReportSource = reporte
        CrystalReportViewer1.Show()
        CrystalReportViewer1.Refresh()
    End Sub
    Private Sub ViajesPorCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim combo As New ModeloCombo
        Dim cargarCombo As String = "select distinct DATEPART(YEAR,v.fecha_salida),DATEPART(YEAR,v.fecha_salida) from Viaje v group by v.fecha_salida"
        combo.cargar_combo(cboAñoViaje, "Viaje", cargarCombo)
        Dim consulta As String = "select COUNT(*) as cantidad,c.nombre_contacto "
        consulta &= " from Viaje v inner join Cliente c on v.nro_cuit = c.nro_cuit"
        consulta &= " group by c.nombre_contacto,c.mail order by cantidad desc"

        generarGrafico(consulta)
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Dim año As String = cboAñoViaje.SelectedValue
        Dim consulta As String = "select COUNT(*) as cantidad,c.nombre_contacto "
        consulta &= " from Viaje v inner join Cliente c on v.nro_cuit = c.nro_cuit "
        consulta &= " where DATEPART(YEAR,v.fecha_llegada) = '" & año & "' "
        consulta &= " group by c.nombre_contacto,c.mail order by cantidad desc"

        generarGrafico(consulta)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Listados.Show()
        Me.Close()
    End Sub
End Class