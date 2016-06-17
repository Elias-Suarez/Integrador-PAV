Public Class ABM_Taller
    Dim acceso As ConexionBD
    Dim consultas As New ModeloCombo

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If validar() Then


            acceso = New ConexionBD
            Dim sql As String = "INSERT INTO taller (nombre,domicilio,localidad) VALUES("
            sql &= "'" & Me.txtNombreTaller.Text & "','" & Me.txtDomicilio.Text & "'," & Me.cboLocalidad.SelectedValue & ")"
            Try
                acceso.insertar(sql)
                Me.grillaTaller.Rows.Add(Me.txtCodigoTaller.Text _
                               , Me.txtNombreTaller.Text, Me.txtDomicilio.Text, Me.cboLocalidad.SelectedValue)
                Me.consultas.limpiar(Me.GroupBox1.Controls)
                MsgBox("El taller se agrego con exito! :)")
            Catch ex As Exception
                MsgBox("No se ha podido insertar el taller: " & ex.Message)
            End Try
        End If
    End Sub
    Private Function validar() As Boolean
        If txtNombreTaller.Text = "" Then
            error1.Visible = True
            txtNombreTaller.Focus()
            mjeError.Visible = True
            Return False
        End If
        If txtDomicilio.Text = "" Then
            error2.Visible = True
            txtDomicilio.Focus()
            mjeError.Visible = True
            Return False
        End If
        If cboProvincia.SelectedIndex = -1 Then
            error3.Visible = True
            cboProvincia.Focus()
            mjeError.Visible = True
            Return False
        End If
        Return True
    End Function
    Private Sub ABM_Taller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        consultas.cargar_combo(cboProvincia, "Provincia")
        cboProvincia.SelectedValue = -1
    End Sub

    Private Sub cboProvincia_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectionChangeCommitted
        Dim query As String = "SELECT loc.cp,loc.nombre "
        query &= " FROM Localidad loc INNER JOIN Provincia pr ON loc.nro_provincia = pr.nro_provincia"
        query &= " WHERE loc.nro_provincia= " & cboProvincia.SelectedValue
        consultas.cargar_combo(cboLocalidad, "Localidad", query)
    End Sub

   
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim limpiarCajas As New ModeloCombo
        limpiarCajas.limpiar(Me.GroupBox1.Controls)
        cboProvincia.SelectedIndex = -1
        cboLocalidad.SelectedIndex = -1
        txtNombreTaller.Focus()
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class