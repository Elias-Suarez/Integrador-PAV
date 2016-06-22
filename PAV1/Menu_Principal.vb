Public Class Menu_Principal

    Private Sub btn_muestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_viajes.Click
        ABM_Viaje.Show()
    End Sub

    Private Sub btn_cargas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cargas.Click
        ABM_Carga.Show()

    End Sub

    Private Sub btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_choferes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_choferes.Click
        ABM_Chofer.Show()
    End Sub

   

    Private Sub btn_clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clientes.Click
        ABM_Clientes.Show()
    End Sub

    Private Sub btn_camiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_camiones.Click
        Camion.Show()
    End Sub

    Private Sub btnTaller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaller.Click
        ABM_Taller.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ABM_Mantenimiento.Show()
    End Sub

    Private Sub btn_listados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_listados.Click
        Listados.Show()
        'Me.Close()
    End Sub
End Class