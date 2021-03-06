﻿Public Class Clientes_Mas_Referidos

#Region "Carga datos"
    Private Sub Mantenimientos_Mas_Realizados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.modo_inicio()
    End Sub

    Private Sub modo_inicio()
        lbl_alerta_fecha_desde.Visible = False
        lbl_alerta_fecha_hasta.Visible = False
    End Sub



#End Region


#Region "Funcion Botones"
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Dim columnas As String = " c.nro_cuit 'cuil', c.razon_social 'nombre', c.nombre_contacto 'contacto', COUNT(c.nro_cuit) 'cantidad' "
        Dim restricciones As String = " v.nro_cuit = c.nro_cuit "
        Dim tablas As String = "  Cliente c, Viaje v   "
        Dim sql As String = ""

        Dim tabla As New DataTable
        Dim reporte As New Report_Clientes_Mas_Requeridos

        If mtb_fecha_desde.MaskCompleted And mtb_fecha_hasta.MaskCompleted Then
            If mtb_fecha_desde.Text <= mtb_fecha_hasta.Text Then
                restricciones &= " AND v.fecha_salida >= CONVERT( VARCHAR(10), '" & mtb_fecha_desde.Text & "',103) "
                restricciones &= " AND v.fecha_salida <= CONVERT( VARCHAR(10), '" & mtb_fecha_hasta.Text & "',103) "



                Dim acceso As New AccesoDatos With {._nombre_tabla = tablas}

                sql = "SELECT " & columnas
                sql &= " FROM " & tablas
                sql &= " WHERE " & restricciones
                sql &= " GROUP BY c.nro_cuit, c.razon_social, c.nombre_contacto ORDER BY cantidad DESC"


                tabla = acceso.leo_Consulta(sql)


                If tabla.Rows.Count = 0 Then

                    MessageBox.Show("No existen datos para mostrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    reporte.SetDataSource(tabla)

                    rpv_reporte.ReportSource = reporte
                    rpv_reporte.Show()
                    rpv_reporte.Refresh()
                End If
            End If
        Else
            MessageBox.Show("Ingrese el período del informe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub btn_volver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Listados.Show()
        Me.Close()
    End Sub

#End Region


#Region "Validaciones"

    Private Sub validar_fechas()
        If mtb_fecha_desde.MaskCompleted And mtb_fecha_hasta.MaskCompleted Then
            If IsDate(mtb_fecha_desde.Text) And IsDate(mtb_fecha_hasta.Text) Then
                If Convert.ToDateTime(mtb_fecha_desde.Text) > Convert.ToDateTime(mtb_fecha_hasta.Text) Then
                    MsgBox("La fecha DESDE no puede ser mayor que la fecha HASTA")
                End If
            Else
                MessageBox.Show("Una o más fechas no tienen formato de fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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