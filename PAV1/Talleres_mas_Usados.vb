Public Class Talleres_mas_Usados

#Region "Carga datos"
    Private Sub Mantenimientos_Mas_Realizados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.modo_inicio()
    End Sub

    Private Sub modo_inicio()
    End Sub



#End Region


#Region "Funcion Botones"
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim columnas As String = " t.nombre 'nombre',   t.domicilio 'domicilio', l.nombre 'localidad', COUNT(t.codigo_taller) 'cantidad' "
        Dim restricciones As String = " where m.cod_taller = t.codigo_taller and t.localidad = l.cp  "
        Dim tablas As String = "  Taller t, localidad l  "
        Dim sql As String = ""

        Dim tabla As New DataTable
        Dim reporte As New CrystalReport2

        If mtb_fecha_desde.MaskCompleted And mtb_fecha_hasta.MaskCompleted Then
            restricciones &= " AND m.fecha >= CONVERT( VARCHAR(10), '" & mtb_fecha_desde.Text & "',103) "
            restricciones &= " AND m.fecha <= CONVERT( VARCHAR(10), '" & mtb_fecha_hasta.Text & "',103) "

        

            Dim acceso As New AccesoDatos With {._nombre_tabla = tablas}

            sql = "SELECT " & columnas
            sql &= " FROM " & tablas
            sql &= " WHERE " & restricciones
            sql &= " group by t.nombre, t.domicilio, l.nombre order by cantidad desc"


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

    Private Sub cmb_taller_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Listados.Show()
        Me.Close()
    End Sub
End Class