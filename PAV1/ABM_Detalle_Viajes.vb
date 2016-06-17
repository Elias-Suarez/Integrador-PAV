Public Class ABM_Detalle_Viajes
    Public Property _patente
        Get
            Return txt_patente.Text
        End Get
        Set(ByVal value)
            txt_patente.Text = value
        End Set
    End Property

    Public Property _fecha_salida
        Get
            Return mtb_fecha_salida.Text
        End Get
        Set(ByVal value)
            mtb_fecha_salida.Text = value
        End Set
    End Property
    Dim fecha As String
    Enum Accion
        insertar
        modificar
    End Enum
    Dim action As Accion = Accion.insertar


#Region "Carga Datos"

    'cargar valores de patnte y fecha

    Private Sub ABM_Detalle_Viajes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deshabilitar_botones()
        alertas_deshabilitadas()
        limpiar_controles()
        btn_crear_detalle_viaje.Enabled = True

        Dim combo As New Combo
        combo.cargar_combo(Me.cbx_tipo_carga, "id", "nombre", "TipoCarga")
        Me.cargar_data()
    End Sub

    Private Sub deshabilitar_botones()
        grp_viaje.Enabled = False

        txt_patente.ReadOnly = True
        mtb_fecha_salida.ReadOnly = True

        btn_crear_detalle_viaje.Enabled = False
        btn_eliminar_detalle_viaje.Enabled = False
        btn_guardar.Enabled = False
        chbx_confirmacion_detalle_viaje.Enabled = False

    End Sub

    Private Sub alertas_deshabilitadas()
        lbl_carga.Visible = False
        lbl_toneladas.Visible = False
        lbl_volumen.Visible = False
        lbl_alerta.Visible = False
    End Sub

    Private Sub limpiar_controles()
        cbx_tipo_carga.SelectedIndex = -1
        txt_toneladas.Text = ""
        txt_volumen.Text = ""
    End Sub

    Private Sub cargar_data()
        Dim combo As New Combo
        combo.carga_dgv("DetalleViaje v, TipoCarga c", Me.dgv_ABM_Detalle_Viaje, "v.tipo_carga, v.toneladas, v.volumen, c.nombre", "patente = '" & txt_patente.Text & "' and fecha_salida = '" & mtb_fecha_salida.Text & "' and v.tipo_carga = c.id")
    End Sub

#End Region

#Region "botones"

    Private Sub btn_crear_detalle_viaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear_detalle_viaje.Click
        action = Accion.insertar
        btn_guardar.Enabled = True
        cbx_tipo_carga.Enabled = True
        alertas_deshabilitadas()
        limpiar_controles()
        chbx_confirmacion_detalle_viaje.Enabled = True
        btn_eliminar_detalle_viaje.Enabled = False
        grp_viaje.Enabled = True
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim acceso As New AccesoDatos With {._nombre_tabla = "DetalleViaje v, TipoCarga c"}
        Dim tabla As DataTable = acceso.leo_tabla("*", "patente = '" & txt_patente.Text & "' and fecha_salida = '" & mtb_fecha_salida.Text & "' and tipo_carga = " & cbx_tipo_carga.SelectedValue & " and v.tipo_carga = c.id")

        acceso._nombre_tabla = "DetalleViaje"

        If chbx_confirmacion_detalle_viaje.Checked Then
            If completos() Then
                If action = Accion.insertar Then
                    If tabla.Rows.Count = 0 Then
                        acceso.insertar2("(patente, fecha_salida, toneladas, volumen, tipo_carga) values ('" & txt_patente.Text & "', '" & mtb_fecha_salida.Text & "', " & txt_toneladas.Text & "," & txt_volumen.Text & "," & cbx_tipo_carga.SelectedValue & ")")
                        cargar_data()

                        action = Accion.modificar
                        btn_eliminar_detalle_viaje.Enabled = True
                    Else
                        MessageBox.Show("Ya existe la carga que desea registrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If tabla.Rows.Count = 1 Then
                        acceso.modificar("toneladas = '" & Me.txt_toneladas.Text & "', volumen = " & Me.txt_volumen.Text, "patente = '" & Me.txt_patente.Text & "' and fecha_salida = '" & mtb_fecha_salida.Text & "' and tipo_carga = " & Me.cbx_tipo_carga.SelectedValue)
                        cargar_data()
                    End If
                End If
            Else
                MessageBox.Show("Existen campos sin completar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else
            MessageBox.Show("Debe confirmar la operación!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        chbx_confirmacion_detalle_viaje.Checked = False
    End Sub

    Private Sub btn_eliminar_detalle_viaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_detalle_viaje.Click
        Dim acceso As New AccesoDatos With {._nombre_tabla = "DetalleViaje"}

        If chbx_confirmacion_detalle_viaje.Checked Then
            If acceso.leo_tabla("*", "patente = '" & Me.txt_patente.Text & "' and fecha_salida = '" & mtb_fecha_salida.Text & "' and tipo_carga = " & Me.cbx_tipo_carga.SelectedValue).Rows.Count = 1 Then

                acceso.borrar("patente = '" & Me.txt_patente.Text & "' and fecha_salida = '" & mtb_fecha_salida.Text & "' and tipo_carga = " & Me.cbx_tipo_carga.SelectedValue)

                cargar_data()
                action = Accion.insertar

                deshabilitar_botones()
                alertas_deshabilitadas()
                limpiar_controles()
                btn_eliminar_detalle_viaje.Enabled = False
                btn_crear_detalle_viaje.Enabled = True
            Else
                MessageBox.Show("No se puede borrar el elemento seleccionado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe confirmar la operación!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        chbx_confirmacion_detalle_viaje.Checked = False
    End Sub


    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub dgv_ABM_Detalle_Viaje_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_ABM_Detalle_Viaje.CellDoubleClick
        Dim t As DataTable = dgv_ABM_Detalle_Viaje.DataSource

        action = Accion.modificar

        btn_crear_detalle_viaje.Enabled = True
        btn_eliminar_detalle_viaje.Enabled = True
        btn_guardar.Enabled = True
        chbx_confirmacion_detalle_viaje.Enabled = True
        grp_viaje.Enabled = True
        cbx_tipo_carga.Enabled = False

        Dim acceso As New AccesoDatos With {._nombre_tabla = "DetalleViaje d"}

        'Dim tabla As DataTable = acceso.leo_tabla("d.toneladas, d.volumen, d.tipo_carga", "d.patente = '" & txt_patente.Text & "' and d.fecha_salida = '" & mtb_fecha_salida.Text & "' and d.tipo_carga = " & t.Rows.Item(dgv_ABM_Detalle_Viaje.CurrentCell.RowIndex).Item("tipo_carga"))
        'Me.mtb_fecha_salida.Text = tabla.Rows(0).Item("fecha")
        'Me.txt_patente.Text = tabla.Rows.Item(0).Item("patente")

        Me.txt_toneladas.Text = t.Rows.Item(dgv_ABM_Detalle_Viaje.CurrentCell.RowIndex).Item("toneladas")
        Me.txt_volumen.Text = t.Rows.Item(dgv_ABM_Detalle_Viaje.CurrentCell.RowIndex).Item("volumen")
        Me.cbx_tipo_carga.SelectedValue = t.Rows.Item(dgv_ABM_Detalle_Viaje.CurrentCell.RowIndex).Item("tipo_carga")

    End Sub

#End Region


#Region "Validar"

    Private Sub cbx_tipo_carga_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_tipo_carga.LostFocus
        If cbx_tipo_carga.SelectedIndex = -1 Then
            lbl_carga.Visible = True
            lbl_alerta.Text = "Quedan datos Incompletos"
            lbl_alerta.Visible = True
        Else
            lbl_carga.Visible = False
            lbl_alerta.Visible = False
        End If
    End Sub

    Private Sub txt_toneladas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_toneladas.LostFocus
        If txt_toneladas.Text = "" Then
            lbl_toneladas.Visible = True
            lbl_alerta.Text = "Quedan datos Incompletos"
            lbl_alerta.Visible = True
        Else
            lbl_toneladas.Visible = False
            lbl_alerta.Visible = False
        End If
    End Sub

    Private Sub txt_volumen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_volumen.LostFocus
        If txt_volumen.Text = "" Then
            lbl_volumen.Visible = True
            lbl_alerta.Text = "Quedan datos Incompletos"
            lbl_alerta.Visible = True
        Else
            lbl_volumen.Visible = False
            lbl_alerta.Visible = False
        End If
    End Sub

    Private Sub txt_volumen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_volumen.KeyPress, txt_toneladas.KeyPress
        If (Not Char.IsNumber(e.KeyChar)) And (Not e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Function completos() As Boolean
        If (txt_toneladas.Text = "") Or (txt_volumen.Text = "") Or (cbx_tipo_carga.SelectedValue = -1) Then
            Return False
        Else
            Return True
        End If
    End Function
#End Region
    



    Private Sub btn_crear_carga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear_carga.Click
        ABM_Carga.Show()
    End Sub
End Class