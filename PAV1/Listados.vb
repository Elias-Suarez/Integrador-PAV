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
End Class