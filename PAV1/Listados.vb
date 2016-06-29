Public Class Listados

    Private Sub btnMantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMantenimiento.Click
        Mantenimientos_Mas_Realizados.Show()
        Me.Close()

    End Sub

    Private Sub btnCamiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCamiones.Click
        Camiones_Mas_Reparados.Show()
        Me.Close()

    End Sub

    Private Sub btnChofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChofer.Click
        frm_reporteChofer.Show()
        Me.Close()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Menu_Principal.Show()
        Me.Close()

    End Sub

    Private Sub btnCargas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargas.Click
        frm_CargasFrecuentes.Show()
        Me.Close()

    End Sub

    Private Sub btnTaller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaller.Click
        Talleres_mas_Usados.Show()
        Me.Close()

    End Sub

    Private Sub btnKMMensuales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKMMensuales.Click
        KilometrosPorChofer.Show()
        Me.Close()
    End Sub

    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        ViajesPorCliente.Show()
        Me.Close()
    End Sub

    Private Sub btn_viajes_por_localidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_viajes_por_localidad.Click
        Estad_Viajes_Por_Localidad.Show()
        Me.Close()
    End Sub

    Private Sub btn_mantenimientos_menusales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mantenimientos_menusales.Click
        Form_Mantenimientos_Mensuales.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clientes_frecuentes.Click
        Clientes_Mas_Referidos.Show()
        Me.Close()
    End Sub
End Class