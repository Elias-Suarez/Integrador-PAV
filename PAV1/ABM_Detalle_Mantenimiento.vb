Public Class ABM_Detalle_Mantenimiento
    Public Property _patente
        Get
            Return Me.txt_patente.Text
        End Get
        Set(ByVal value)
            Me.txt_patente.Text = value
        End Set
    End Property
    Public Property _fecha
        Get
            Return Me.mtb_fecha.Text
        End Get
        Set(ByVal value)
            Me.mtb_fecha.Text = value
        End Set
    End Property

    Enum Guardar
        insertar
        modificar
    End Enum

    Dim accionGuardar = Guardar.insertar

#Region "Carga Pantalla"
    Private Sub ABM_Detalle_Mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim combo As New Combo

        combo.cargar_combo(cmb_trabajo, "id", "nombre", " Trabajo ")

        'Dim acceso As New AccesoDatos With {._nombre_tabla = " Trabajo "}
        'Dim tabla As DataTable = acceso.leo_tabla()

        'If Not tabla.Rows.Count = 0 Then
        '    cmb_trabajo.Items.Clear()
        '    cmb_trabajo.DataSource = tabla

        '    cmb_trabajo.DisplayMember = "nombre"
        '    cmb_trabajo.ValueMember = "id"
        'Else
        '    MsgBox("No se pudo cargar el combo 'Trabajo'")
        'End If

        modo_eliminar()
    End Sub

    Public Sub limpiar_controles()
        Me.txt_costo.Text = ""
        Me.cmb_trabajo.SelectedIndex = -1
        Me.actualiza_grilla()
    End Sub

    Public Sub modo_eliminar()
        Me.limpiar_controles()

        grp_mantenimiento.Enabled = False
        grp_trabajos.Enabled = False

        btn_crear.Enabled = True
        btn_eliminar.Enabled = False
        btn_guardar.Enabled = False

        Me.lbl_alerta_costo.Visible = False
        Me.lbl_alerta_trabajo.Visible = False

        chk_confirmar.Checked = False
    End Sub

    Public Sub modo_crear()
        Me.limpiar_controles()

        grp_trabajos.Enabled = True

        btn_eliminar.Enabled = False
        btn_crear.Enabled = False
        btn_guardar.Enabled = True

        cmb_trabajo.Enabled = True

        accionGuardar = Guardar.insertar

        chk_confirmar.Checked = False
    End Sub

    Public Sub modo_editar()
        grp_trabajos.Enabled = True

        btn_eliminar.Enabled = True
        btn_crear.Enabled = True
        btn_guardar.Enabled = True

        cmb_trabajo.Enabled = False

        accionGuardar = Guardar.modificar

        chk_confirmar.Checked = False
    End Sub

    Private Sub actualiza_grilla()
        Dim combo As New Combo
        Dim nombre As String = ""
        Dim columnas As String = ""
        Dim restriccion As String = ""

        columnas = " t.costo, w.id, w.nombre "

        nombre = " TrabajoXMantenimiento t, Trabajo w "

        restriccion = " t.patente = '" & txt_patente.Text & "' "
        restriccion &= " AND t.fecha = '" & mtb_fecha.Text & "' "
        restriccion &= " AND t.id_trabajo = w.id"

        combo.carga_dgv(nombre, dgv_trabajos, columnas, restriccion)
    End Sub
#End Region





#Region "Funciones Botones"
    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim acceso As New AccesoDatos With {._nombre_tabla = "TrabajoXMantenimiento"}

        If chk_confirmar.Checked Then
            If acceso.leo_tabla("*", "patente = '" & Me.txt_patente.Text & "' and fecha = '" & mtb_fecha.Text & "' and id_trabajo = " & Me.cmb_trabajo.SelectedValue).Rows.Count = 1 Then

                acceso.borrar("patente = '" & Me.txt_patente.Text & "' and fecha = '" & mtb_fecha.Text & "' and id_trabajo = " & Me.cmb_trabajo.SelectedValue)

                Me.modo_eliminar()
                MessageBox.Show("La operacion se completo exitosamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("No se puede borrar el elemento seleccionado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe confirmar la operación!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click

        Dim acceso As New AccesoDatos With {._nombre_tabla = "TrabajoXMantenimiento"}
        Dim cadena As String = ""
        Dim rest As String = ""

        If chk_confirmar.Checked Then
            If Not Me.txt_costo.Text = "" Or Me.cmb_trabajo.SelectedIndex = -1 Then

                rest = "patente = '" & Me.txt_patente.Text & "' "
                rest &= " and fecha = '" & Me.mtb_fecha.Text & "' "
                rest &= " AND id_trabajo = " & cmb_trabajo.SelectedValue
                If accionGuardar = Guardar.insertar Then
                    If (acceso.leo_tabla("*", rest).Rows.Count = 0) Then
                        cadena = "(patente, fecha, id_trabajo, costo) VALUES ( '"
                        cadena &= Me.txt_patente.Text & "', '"
                        cadena &= Me.mtb_fecha.Text & "', "
                        cadena &= Me.cmb_trabajo.SelectedValue & ", "
                        cadena &= Me.txt_costo.Text
                        cadena &= ")"

                        acceso.insertar2(cadena)
                        Me.modo_editar()
                        accionGuardar = Guardar.modificar
                        MessageBox.Show("Se guardaron correctamente los datos", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("El trabajo de mantenimiento ya se encuentra cargado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                Else
                    cadena = "costo = " & Me.txt_costo.Text

                    acceso.modificar(cadena, rest)

                    MessageBox.Show("Se guardaron correctamente los datos", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.modo_editar()
                End If
                    Me.actualiza_grilla()

                
            Else
                MessageBox.Show("Completar los controles señalados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Debe confirmar la operación!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click
        Me.modo_crear()
    End Sub

    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub dgv_trabajos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_trabajos.CellDoubleClick
        Dim acceso As New AccesoDatos With {._nombre_tabla = " Trabajo "}
        Dim col As String = ""
        Dim rest As String = ""
        Dim t As DataTable = dgv_trabajos.DataSource

        col = " id "
        rest = " nombre = '" & t.Rows.Item(dgv_trabajos.CurrentRow.Index).Item("nombre") & "'"

        Me.txt_costo.Text = t.Rows.Item(dgv_trabajos.CurrentRow.Index).Item("Costo")

        t = acceso.leo_tabla(col, rest)

        Me.cmb_trabajo.SelectedValue = t.Rows.Item(0).Item(0)

        Me.accionGuardar = Guardar.modificar
        Me.modo_editar()
    End Sub


#End Region


#Region "Validaciones"

    Private Sub cmb_trabajo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_trabajo.LostFocus
        Me.alerta_foco(cmb_trabajo, lbl_alerta_trabajo)
    End Sub
    Private Sub txt_costo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_costo.LostFocus
        Me.alerta_foco(txt_costo, lbl_alerta_costo)
    End Sub

    Private Sub alerta_foco(ByRef ctrl As Control, ByRef alerta As Label)
        Dim b As Boolean = False

        Select Case ctrl.GetType.Name.ToString
            Case "TextBox"
                If ctrl.Text = "" Then
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

    Private Sub txt_costo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_costo.KeyPress
        If Char.IsNumber(e.KeyChar) Or e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_mas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mas.Click
        ABM_Trabajo.show()
    End Sub
End Class