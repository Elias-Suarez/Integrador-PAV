Public Class ABM_Carga
    Dim completo As Boolean = False

    Dim acceso As New ConexionBD

    Public Sub deshabilitar()
        If chbx_confirma_tipo_carga.Checked = False Then
            btn_crear_carga.Enabled = True
            btn_eliminar.Enabled = False
            btn_guardar_carga.Enabled = False
            lbl_nombre.Visible = False

            lbl_descripcion.Visible = False
        End If
    End Sub

    Public Sub habilitar()
        If chbx_confirma_tipo_carga.Checked = True Then
            btn_crear_carga.Enabled = True
            btn_eliminar.Enabled = True
            btn_guardar_carga.Enabled = True
        End If
    End Sub
    Public Sub completos()
        If txt_descripcion_carga.Text = "" And txt_nombre_carga.Text = "" Then
            completo = False
        Else
            completo = True
        End If
    End Sub

    Private Sub chbx_confirma_tipo_carga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbx_confirma_tipo_carga.CheckedChanged
        completos()
        If completo Then
            habilitar()
        Else
            chbx_confirma_tipo_carga.Checked = False
            deshabilitar()
            MsgBox("Uno de los campos esta incompleto.")
        End If
    End Sub

    Private Sub ABM_Carga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deshabilitar()

        btn_volver.Enabled = True
    End Sub

    'nuevo

    'Private Sub txt_nombre_carga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If cbx_tipo_carga.Text = "" Then
    '        cbx_tipo_carga.Focus()
    '        lbl_alerta.Visible = True
    '        lbl_carga.Visible = True
    '    Else
    '        lbl_alerta.Visible = False
    '        lbl_carga.Visible = False
    '    End If
    'End Sub

    Private Sub txt_descripcion_carga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txt_nombre_carga.Text = "" Then
            txt_nombre_carga.Focus()
            lbl_alerta.Visible = True
            lbl_nombre.Visible = True
        Else
            lbl_alerta.Visible = False
            lbl_nombre.Visible = False
        End If
    End Sub

    'Funciones tab para cambio de campo

    Private Sub txt_nombre_carga_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nombre_carga.LostFocus
        If txt_nombre_carga.Text = "" Then
            txt_nombre_carga.Focus()
            lbl_alerta.Text = "Necesita completar los campos"
            lbl_alerta.Visible = True
            lbl_nombre.Visible = True
        Else
            lbl_alerta.Visible = False
            lbl_nombre.Visible = False
        End If
    End Sub

    Private Sub txt_descripcion_carga_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_descripcion_carga.LostFocus
        If txt_descripcion_carga.Text = "" Then
            txt_descripcion_carga.Focus()
            lbl_alerta.Text = "Necesita completar los campos"
            lbl_alerta.Visible = True
            lbl_descripcion.Visible = True
        Else
            lbl_alerta.Visible = False
            lbl_descripcion.Visible = False
        End If
    End Sub


    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub txt_nombre_carga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre_carga.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            lbl_alerta.Visible = False
        Else
            e.Handled = True
            lbl_alerta.Text = "Solo carácteres alfabéticos"
            lbl_alerta.Visible = True

        End If
    End Sub

    Private Sub btn_crear_carga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear_carga.Click
        btn_eliminar.Enabled = False
        btn_crear_carga.Enabled = False
        btn_guardar_carga.Enabled = True
        txt_descripcion_carga.Text = ""
        txt_nombre_carga.Text = ""
    End Sub

    Private Sub btn_guardar_carga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar_carga.Click
        Me.lbx_ABM_Cargas.Items.Add(txt_nombre_carga.Text)
        btn_crear_carga.Enabled = True
        Dim query As String = ""
        query = "INSERT INTO TipoCArga(nombre,descripcion) VALUES('" & Me.txt_nombre_carga.Text & "','" & Me.txt_descripcion_carga.Text & "')"
        acceso.insertar(query)
        Dim consulta As New ModeloCombo
        consulta.limpiar(GroupBox1.Controls)
        chbx_confirma_tipo_carga.Checked = False
    End Sub


    Private Sub lbx_ABM_Cargas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbx_ABM_Cargas.SelectedIndexChanged
        txt_nombre_carga.Text = ""
        txt_descripcion_carga.Text = ""

        txt_nombre_carga.Text = lbx_ABM_Cargas.SelectedItem.ToString
        btn_eliminar.Enabled = False
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class