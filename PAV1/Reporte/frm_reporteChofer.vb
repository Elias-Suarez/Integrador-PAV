Public Class frm_reporteChofer
    Dim conexion As New ConexionBD
    Dim tabla As New Data.DataTable
    Dim ds As New dsChofer
    Dim reporte As New reporteChofer
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        Me.cbChofer.SelectedIndex = -1
        Dim consulta As String = "SELECT   SUM(v.kilometros) AS km,c.apellido + ', '+ c.nombre	as chofer, c.nro_doc as documento "
        consulta &= " FROM Viaje v INNER JOIN Chofer c ON v.nro_doc_chofer =c.nro_doc group by  c.apellido,c.nombre, c.nro_doc order by km desc"
        tabla = conexion.ejecutarQuery(consulta)
        reporte.SetDataSource(tabla)

        Me.CrystalReportViewer1.ReportSource = reporte
        Me.CrystalReportViewer1.Show()
        Me.CrystalReportViewer1.Refresh()

    End Sub
    Private Sub frm_reporteChofer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim modelo As New ModeloCombo
        Dim sql As String = "select nro_doc, (c.nombre +', '+c.apellido) as chofer from Chofer c"
        modelo.cargar_combo(cbChofer, "Chofer", sql)
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim chofer As Integer = cbChofer.SelectedValue
        Dim fechaDesde As String = Format(dtFechaDesde.Value, "yyyy-MM-dd")
        Dim fechaHasta As String = Format(dtHasta.Value, "yyyy-MM-dd")

        Dim sql As String = "SELECT v.kilometros as km, v.patente as patente, v.domicilio_entrega as domicilio, cl.nombre_contacto,V.fecha_salida, V.fecha_llegada,c.apellido + ','+ c.nombre as chofer"
        sql &= " FROM Viaje v INNER JOIN Chofer c ON c.nro_doc = v.nro_doc_chofer  INNER JOIN Cliente cl ON v.nro_cuit = cl.nro_cuit "
        sql &= " WHERE c.nro_doc = " & chofer
        sql &= " AND v.fecha_salida  > ='" & fechaDesde & "' AND v.fecha_salida <= '" & fechaHasta & "'"
        sql &= " GROUP BY v.kilometros, v.patente, v.domicilio_entrega , cl.nombre_contacto,V.fecha_salida, V.fecha_llegada,c.nombre,c.apellido"

        Dim reporteFiltro As New rptChofer_filtro
        Dim tabla As New Data.DataTable
        tabla = conexion.ejecutarQuery(sql)
        reporteFiltro.SetDataSource(tabla)
        Me.CrystalReportViewer1.ReportSource = reporteFiltro
        Me.CrystalReportViewer1.Show()
        Me.CrystalReportViewer1.Refresh()

    End Sub

    Private Function validar() As Boolean
        If cbChofer.SelectedIndex - 1 Then
            Label4.Visible = True
            cbChofer.Focus()
            Return False
        Else
            Label4.Visible = False
            Return True
        End If
        If dtFechaDesde.Value.Year < Date.Today.Year Then
            Label5.Visible = True
            dtFechaDesde.Focus()
            Return False
        Else
            Label5.Visible = False
            Return True
        End If
        If dtHasta.Value.Year < Date.Today.Year Then
            dtHasta.Focus()
            Label6.Visible = True
            Return False
        Else
            Label6.Visible = False
            Return True
        End If
        Return True
    End Function

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Listados.Show()
        Me.Close()

    End Sub
End Class