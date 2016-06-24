Public Class ABM_Mantenimiento
    Enum Guardar
        insertar
        modificar

    End Enum

    Dim accionGuardar As Guardar = Guardar.insertar

#Region "Carga de Pantalla"

    Private Sub ABM_Mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim combo As New Combo

        combo.cargar_combo(Me.cmb_patente, "Camion")
        combo.cargar_combo(Me.cmb_taller, "codigo_taller", "nombre", "Taller")

        Me.modo_limpiar()

        Me.actualiza_grilla()

    End Sub

    Private Sub actualiza_grilla()
        Dim combo As New Combo
        combo.carga_dgv(" Mantenimiento m, Taller t ", Me.dgv_mantenimiento, " m.patente, m.fecha, m.kilometraje, t.nombre 'nombre_taller' ", " m.cod_taller = t.codigo_taller ")
    End Sub

    Private Sub modo_limpiar()
        Dim modelo As New ModeloCombo

        modelo.limpiar(Me.Controls)

        Me.gbx_datos.Enabled = False
        Me.gbx_mantenimiento.Enabled = True

        Me.btn_guardar.Enabled = False
        Me.btn_agregar.Enabled = False

        Me.lbl_alerta_fecha.Visible = False
        Me.lbl_alerta_patente.Visible = False
        Me.lbl_alerta_kilometros.Visible = False
        Me.lbl_alerta_taller.Visible = False

        Me.chk_confirma.Checked = False
    End Sub

    Private Sub modo_crear()
        Me.gbx_mantenimiento.Enabled = False
        Me.gbx_datos.Enabled = True

        Me.btn_guardar.Enabled = True
        Me.btn_agregar.Enabled = False

        Me.chk_confirma.Checked = False

        accionGuardar = Guardar.insertar
    End Sub

    Private Sub modo_editar()
        Me.gbx_mantenimiento.Enabled = False
        Me.gbx_datos.Enabled = True

        Me.btn_guardar.Enabled = True
        Me.btn_agregar.Enabled = True

        Me.chk_confirma.Checked = False
    End Sub
#End Region




#Region "Funciones Botones"
    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        If cmb_patente.SelectedIndex = -1 Or Not mtb_fecha.MaskCompleted Then
            MessageBox.Show("Completar los controles señalados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim acceso As New AccesoDatos With {._nombre_tabla = "Mantenimiento"}
            Dim restriccion As String = ""
            restriccion = "patente = '" & cmb_patente.SelectedValue & "'"
            restriccion &= " and fecha = CONVERT( VARCHAR(10), '" & mtb_fecha.Text & "',103)"

            Dim tabla As DataTable = acceso.leo_tabla("*", restriccion)

            If tabla.Rows.Count = 0 Then
                Me.modo_crear()
            Else
                MessageBox.Show("Ya existe el mantenimiento ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Dim acceso As New AccesoDatos With {._nombre_tabla = "Mantenimiento"}
        Dim cadena As String = ""
        Dim rest As String = ""
        
        If chk_confirma.Checked Then
            If Not Me.txt_kilometros.Text = "" Or Me.cmb_taller.SelectedIndex = -1 Then
                If accionGuardar = Guardar.insertar Then

                    cadena = "(patente, fecha, cod_taller, kilometraje) VALUES ( '"
                    cadena &= Me.cmb_patente.SelectedValue & "', "
                    cadena &= " CONVERT( VARCHAR(10), '" & mtb_fecha.Text & "',103), "
                    cadena &= Me.cmb_taller.SelectedValue & ", "
                    cadena &= Me.txt_kilometros.Text
                    cadena &= ")"

                    acceso.insertar2(cadena)

                    accionGuardar = Guardar.modificar
                    MessageBox.Show("Se guardaron correctamente los datos", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    rest = "patente = '" & Me.cmb_patente.SelectedValue & "' "
                    rest &= " and fecha = CONVERT( VARCHAR(10), '" & mtb_fecha.Text & "',103) "

                    cadena = " cod_taller = " & Me.cmb_taller.SelectedValue & ", "
                    cadena &= "kilometraje = " & Me.txt_kilometros.Text

                    acceso.modificar(cadena, rest)

                    MessageBox.Show("Se guardaron correctamente los datos", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                Me.actualiza_grilla()
                Me.modo_editar()
            Else
                MessageBox.Show("Completar los controles señalados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Debe confirmar la operación!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        Me.modo_limpiar()
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click

        If chk_confirma.Checked Then
            ABM_Detalle_Mantenimiento._patente = cmb_patente.SelectedValue
            ABM_Detalle_Mantenimiento._fecha = mtb_fecha.Text
            ABM_Detalle_Mantenimiento.Show()
        Else
            MessageBox.Show("Debe confirmar la operación!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub dgv_mantenimiento_CellDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv_mantenimiento.CellDoubleClick
        Dim acceso As New AccesoDatos With {._nombre_tabla = " Mantenimiento m, taller t "}
        Dim col As String = ""
        Dim rest As String = ""
        Dim t As DataTable = dgv_mantenimiento.DataSource
        Dim f_man As Date = t.Rows.Item(dgv_mantenimiento.CurrentRow.Index).Item("fecha")
        Dim f As String = Format(f_man, "yyyy-MM-dd")



        col = " m.patente, m.fecha, m.kilometraje, t.* "
        rest = " m.fecha = '" & f & "' and m.patente = '" & t.Rows.Item(dgv_mantenimiento.CurrentRow.Index).Item("Patente") & "' and m.cod_taller = t.codigo_taller"

        t = acceso.leo_tabla(col, rest)

        Me.cmb_patente.SelectedValue = t.Rows.Item(0).Item("patente")
        Me.mtb_fecha.Text = Convert.ToDateTime(t.Rows.Item(0).Item("fecha"))
        Me.txt_kilometros.Text = t.Rows.Item(0).Item("kilometraje")
        Me.cmb_taller.SelectedValue = t.Rows.Item(0).Item("codigo_taller")

        Me.accionGuardar = Guardar.modificar
        Me.modo_editar()
    End Sub

#End Region





#Region "Validaciones"
    Private Sub cmb_patente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_patente.LostFocus
        Me.alerta_foco(cmb_patente, lbl_alerta_patente)
    End Sub

    Private Sub mtb_fecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtb_fecha.LostFocus
        Me.alerta_foco(mtb_fecha, lbl_alerta_fecha)

        If mtb_fecha.MaskCompleted And Not IsDate(mtb_fecha.Text) Then
            MessageBox.Show("El dato ingresado no es una fecha válida", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txt_kilometros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_kilometros.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_kilometros_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_kilometros.LostFocus
        Me.alerta_foco(txt_kilometros, lbl_alerta_kilometros)
    End Sub

    Private Sub cmb_taller_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_taller.LostFocus
        Me.alerta_foco(cmb_taller, lbl_alerta_taller)
    End Sub

    Private Sub alerta_foco(ByRef ctrl As Control, ByRef alerta As Label)
        Dim b As Boolean = False

        Select Case ctrl.GetType.Name.ToString
            Case "TextBox"
                If ctrl.Text = "" Then
                    b = True
                End If
            Case "MaskedTextBox"
                If Not CType(ctrl, MaskedTextBox).MaskCompleted Then
                    b = True
                End If
            Case "ComboBox"
                Dim c As ComboBox = ctrl
                If c.SelectedIndex = -1 Then
                    b = True
                End If
        End Select

        alerta.Visible = b

    End Sub


#End Region


    
End Class