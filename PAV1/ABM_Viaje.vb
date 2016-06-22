Public Class ABM_Viaje
    'metodos carga de formulario
    Enum Base
        insertar
        modificar
    End Enum
    Dim carga As Boolean = False
    Dim b As Base = Base.insertar

#Region "CargaFormulario"

    Private Sub ABM_Viaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmb As New Combo

        cmb.cargar_combo(Me.cbx_patente, "patente", "Camion")
        cmb.cargar_combo(Me.cbx_tipo_documento, "id", "descripcion", "TipoDocumento")
        cmb.cargar_combo(Me.cbx_provincia_destino, "nro_provincia", "nombre", "Provincia")
        cmb.cargar_combo(Me.cbx_provincia_origen, "nro_provincia", "nombre", "Provincia")

        cmb.carga_dgv("viaje v, Chofer c, localidad o, localidad d", Me.dgv_ABM_Viaje, "v.patente, CONVERT(nvarchar(20),v.fecha_salida,103) 'fecha_salida', c.nombre, c.apellido, o.nombre as 'origen', d.nombre as 'destino'", "v.tipo_doc_chofer = c.tipo_doc and v.nro_doc_chofer = c.nro_doc and o.cp = v.localidad_origen and v.localidad_destino = d.cp")

        Me.iniciar()
    End Sub

    Private Sub iniciar()

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is GroupBox Then
                For Each c As Control In ctrl.Controls
                    Me.limpiar_control(c)
                Next
            Else
                Me.limpiar_control(ctrl)
            End If
        Next

        'group viaje
        Me.cbx_patente.Enabled = True
        Me.mtb_fecha_salida.Enabled = True
        Me.btn_crear_viaje.Enabled = True
        Me.btn_limpiar.Enabled = True
        Me.cbx_localidad_origen.Enabled = False
        Me.cbx_localidad_destino.Enabled = False
        carga = True
        Me.btn_volver.Enabled = True
    End Sub

    'metodo de limpieza general de controles. xq es necesario entrar dentro de cada uno de los groupbox para poder limpiarlos
    Private Sub limpiar_control(ByRef c As Control)
        btn_crear_viaje.Enabled = True
        mtb_fecha_salida.Enabled = True
        cbx_patente.Enabled = True

        If (TypeOf c Is TextBox) Or (TypeOf c Is MaskedTextBox) Then
            c.Text = ""
            c.Enabled = False
        ElseIf TypeOf c Is ComboBox Then
            Dim aux As ComboBox = c
            aux.SelectedIndex = -1
            c.Enabled = False
        ElseIf TypeOf c Is CheckBox Then
            Dim aux As CheckBox = c
            aux.Checked = False
            c.Enabled = False
        ElseIf TypeOf c Is Button Then
            c.Enabled = False
        End If
    End Sub

#End Region

#Region "Funciones de botones"

    'al presionar crear se consulta que no exista dicho viaje y se habilitan los campos inferiores
    Private Sub btn_crear_viaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear_viaje.Click
        b = Base.insertar

        If Me.completo_clave_viaje() Then
            Dim acceso As New AccesoDatos With {._nombre_tabla = "Viaje"}

            If acceso.leo_tabla("patente, fecha_salida", "patente = '" & Me.cbx_patente.SelectedValue & "' and fecha_salida = '" & Me.mtb_fecha_salida.Text & "'").Rows.Count = 0 Then
                Me.habilitar_controles()
                Me.btn_eliminar_viaje.Enabled = False
                Me.cbx_tipo_documento.Focus()
            Else
                MessageBox.Show("El viaje ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Cargar Campos Solicitados", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        cbx_confirma_datos_viaje.Checked = False

        Dim combo As New Combo
        combo.carga_dgv("viaje v, Chofer c, localidad o, localidad d", Me.dgv_ABM_Viaje, "v.patente, v.fecha_salida, c.nombre, c.apellido, o.nombre as 'origen', d.nombre as 'destino'", "v.tipo_doc_chofer = c.tipo_doc and v.nro_doc_chofer = c.nro_doc and o.cp = v.localidad_origen and v.localidad_destino = d.cp")


    End Sub

    'retorna true si los campos estan completos y false cuando al menos uno no lo este
    Private Function completo_clave_viaje() As Boolean
        If (Me.mtb_fecha_salida.MaskFull = False) Or (Me.cbx_patente.SelectedIndex = -1) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub habilitar_controles()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is GroupBox Then
                For Each c As Control In ctrl.Controls
                    c.Enabled = True
                Next
            Else
                ctrl.Enabled = True
            End If
        Next

        Me.grp_viaje.Enabled = False
        Me.btn_limpiar.Enabled = True
        Me.cbx_localidad_origen.Enabled = False
        Me.cbx_localidad_destino.Enabled = False
    End Sub

    Private Sub dgv_ABM_Viaje_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_ABM_Viaje.CellDoubleClick
        Dim t As DataTable = dgv_ABM_Viaje.DataSource

        b = Base.modificar

        Me.habilitar_controles()
        Me.cbx_localidad_origen.Enabled = True

        Dim p As String = t.Rows.Item(dgv_ABM_Viaje.CurrentRow.Index).Item("patente")
        Dim f_sal As Date = t.Rows.Item(dgv_ABM_Viaje.CurrentRow.Index).Item("fecha_salida")
        Dim f As String = Format(f_sal, "yyyy-MM-dd")
        Dim acceso As New AccesoDatos With {._nombre_tabla = "viaje v, localidad o, localidad d"}

        Dim tabla As DataTable = acceso.leo_tabla("v.*, convert(nvarchar(20),v.fecha_salida,103) 'salida', CONVERT(nvarchar(20), v.fecha_llegada, 103) 'llegada', o.nro_provincia 'origen', d.nro_provincia 'destino'", "v.patente = '" & p & "' and v.fecha_salida = '" & f & "' and v.localidad_origen = o.cp and v.localidad_destino = d.cp")
        Me.mtb_fecha_salida.Text = tabla.Rows(0).Item("salida")
        Me.cbx_patente.SelectedValue = p

        Me.cbx_tipo_documento.SelectedValue = tabla.Rows.Item(0).Item("tipo_doc_chofer")
        Me.txt_numero_documento.Text = tabla.Rows.Item(0).Item("nro_doc_chofer")

        If Not Me.cbx_tipo_documento.SelectedIndex = -1 Then

            acceso._nombre_tabla = "Chofer v"
            t = acceso.leo_tabla("v.nombre, v.apellido", "v.tipo_doc = '" & Me.cbx_tipo_documento.SelectedValue & "' and v.nro_doc = '" & Me.txt_numero_documento.Text & "'")
            If tabla.Rows.Count = 1 Then
                Me.nombre_chofer.Text = t.Rows.Item(0).Item(0) & " " & t.Rows.Item(0).Item(1)
            Else
                nombre_chofer.Text = "Nombre Chofer"
            End If
            lbl_alerta_campo.Visible = False
            lbl_alerta_numero_documento.Visible = False
        End If

        Me.cbx_provincia_origen.SelectedValue = tabla.Rows(0).Item("origen")
        Me.cbx_localidad_destino.SelectedValue = tabla.Rows(0).Item("localidad_origen")
        Me.cbx_provincia_destino.SelectedValue = tabla.Rows(0).Item("destino")
        Me.cbx_localidad_destino.SelectedValue = tabla.Rows(0).Item("localidad_destino")
        Me.mtb_fecha_llegada.Text = tabla.Rows(0).Item("llegada")
        Me.txt_kilometros.Text = tabla.Rows(0).Item("kilometros")
        Me.txt_domiciolio_entrega.Text = tabla.Rows(0).Item("domicilio_entrega")
        Me.txt_numero_cliente.Text = tabla.Rows(0).Item("nro_cuit")
    End Sub

    Private Sub btn_volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_volver.Click
        Me.Close()
    End Sub

    Private Sub btn_guardar_viaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar_viaje.Click

        If Me.cbx_confirma_datos_viaje.Checked Then
            If validar_fechas() Then
                If completo_viaje() Then
                    Dim acceso As New AccesoDatos With {._nombre_tabla = "Viaje"}

                    If b = Base.insertar Then

                        acceso.insertar2("(patente, fecha_salida, nro_cuit, localidad_origen, fecha_llegada, domicilio_entrega, localidad_destino, kilometros, tipo_doc_chofer, nro_doc_chofer) VALUES ('" _
                                        & Me.cbx_patente.SelectedValue & "',CONVERT(varchar(10),'" & Me.mtb_fecha_salida.Text & "',103),'" & Me.txt_numero_cliente.Text & "'," & Me.cbx_localidad_origen.SelectedValue & ",CONVERT(varchar(10),'" & _
                                        Me.mtb_fecha_llegada.Text & "',103),'" & Me.txt_domiciolio_entrega.Text & "'," & Me.cbx_localidad_destino.SelectedValue & "," & Me.txt_kilometros.Text & ",'" _
                                        & Me.cbx_tipo_documento.SelectedValue & "','" & Me.txt_numero_documento.Text & "')")
                        acceso._nombre_tabla = "Camion"
                        Dim km As Integer = acceso.leo_tabla("kilometraje", " patente = '" & cbx_patente.SelectedValue & "'").Rows(0).Item(0)

                        acceso.modificar("kilometraje = " & (km + txt_kilometros.Text), " patente = '" & cbx_patente.SelectedValue & "'")


                        MessageBox.Show("Operacion realizada exitosamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        b = Base.modificar
                        btn_eliminar_viaje.Enabled = False
                    Else
                        acceso.modificar("nro_cuit = '" & Me.txt_numero_cliente.Text & "', localidad_origen = " & Me.cbx_localidad_origen.SelectedValue & ", fecha_llegada = CONVERT(varchar(10), '" & Me.mtb_fecha_llegada.Text & "',103), domicilio_entrega = '" & Me.txt_domiciolio_entrega.Text & "', localidad_destino = " & Me.cbx_localidad_destino.SelectedValue & ", kilometros = " & Me.txt_kilometros.Text & ", tipo_doc_chofer = " & Me.cbx_tipo_documento.SelectedValue & ", nro_doc_chofer = " & Me.txt_numero_documento.Text, "patente = '" & Me.cbx_patente.SelectedValue & "' and fecha_salida = '" & mtb_fecha_salida.Text & "'")
                    End If

                    Dim cmb As New Combo
                    cmb.carga_dgv("viaje v, Chofer c, localidad o, localidad d", Me.dgv_ABM_Viaje, "v.patente, v.fecha_salida, c.nombre, c.apellido, o.nombre as 'origen', d.nombre as 'destino'", "v.tipo_doc_chofer = c.tipo_doc and v.nro_doc_chofer = c.nro_doc and o.cp = v.localidad_origen and v.localidad_destino = d.cp")
                Else
                    MessageBox.Show("Hay campos sin completar!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
            Else
                MessageBox.Show("La fecha de LLegada debe ser mayor o igual a la de salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else
            MessageBox.Show("Debe confirmar la operación!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        cbx_confirma_datos_viaje.Checked = False
    End Sub


    Private Function completo_viaje() As Boolean
        If Me.cbx_tipo_documento.SelectedIndex = -1 Or Me.txt_numero_documento.MaskFull = False Or cbx_localidad_origen.SelectedIndex = -1 Or cbx_localidad_destino.SelectedIndex = -1 Or mtb_fecha_llegada.MaskCompleted = False Or txt_kilometros.Text = "" Or txt_domiciolio_entrega.Text = "" Or txt_numero_cliente.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btn_agregar_carga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar_carga.Click
        Dim acceso As New AccesoDatos With {._nombre_tabla = "Viaje"}

        If cbx_confirma_datos_viaje.Checked Then
            If acceso.leo_tabla("*", "patente = '" & Me.cbx_patente.SelectedValue & "' and fecha_salida = '" & mtb_fecha_salida.Text & "'").Rows.Count() = 1 Then
                ABM_Detalle_Viajes._patente = Me.cbx_patente.SelectedValue
                ABM_Detalle_Viajes._fecha_salida = Me.mtb_fecha_salida.Text
                ABM_Detalle_Viajes.Show()
            Else
                MessageBox.Show("Debe crear el viaje antes de agregar cargas.!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else
            MessageBox.Show("Debe confirmar la operación!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        cbx_confirma_datos_viaje.Checked = False
    End Sub

    Private Sub btn_eliminar_viaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_viaje.Click
        Dim acceso As New AccesoDatos With {._nombre_tabla = "Viaje"}

        If cbx_confirma_datos_viaje.Checked Then
            acceso.borrar("patente = '" & Me.cbx_patente.SelectedValue & "' and fecha_salida = '" & mtb_fecha_salida.Text & "'")
        Else
            MessageBox.Show("Debe confirmar la operación!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        cbx_confirma_datos_viaje.Checked = False
        Dim combo As New Combo
        combo.carga_dgv("viaje v, Chofer c, localidad o, localidad d", Me.dgv_ABM_Viaje, "v.patente, v.fecha_salida, c.nombre, c.apellido, o.nombre as 'origen', d.nombre as 'destino'", "v.tipo_doc_chofer = c.tipo_doc and v.nro_doc_chofer = c.nro_doc and o.cp = v.localidad_origen and v.localidad_destino = d.cp")

        Me.iniciar()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        Me.iniciar()
        mtb_fecha_salida.Enabled = True
        mtb_fecha_salida.Focus()
        cbx_patente.Enabled = True
        btn_crear_viaje.Enabled = True
        nombre_chofer.Text = ""
    End Sub

#End Region

    'Funciones tab para cambio de campo
#Region "Verifica Ingreso de datos"
    'GroupBox Viaje
    Private Sub mtb_fecha_salida_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtb_fecha_salida.LostFocus
        If Me.mtb_fecha_salida.MaskCompleted = False Then
            Me.lbl_alerta_fecha_salida.Visible = True
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            Me.lbl_alerta_campo.Visible = True
        Else
            Me.lbl_alerta_campo.Visible = False
            Me.lbl_alerta_fecha_salida.Visible = False
        End If
    End Sub

    Private Function validar_fechas() As Boolean
        Dim b As Boolean = True

        If mtb_fecha_llegada.MaskCompleted Then
            If Convert.ToDateTime(mtb_fecha_salida.Text) > Convert.ToDateTime(mtb_fecha_llegada.Text) Then
                b = False
            End If
        Else
            b = False
        End If
        Return b
    End Function


    Private Sub cbx_patente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_patente.LostFocus
        If Me.cbx_patente.SelectedIndex = -1 Then
            Me.lbl_alerta_patente.Visible = True
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            Me.lbl_alerta_campo.Visible = True
        Else
            Me.lbl_alerta_campo.Visible = False
            Me.lbl_alerta_patente.Visible = False
        End If
    End Sub

    'GroupBox Chofer
    Private Sub cbx_tipo_documento_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_tipo_documento.LostFocus
        If Me.cbx_tipo_documento.SelectedIndex = -1 Then
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            lbl_alerta_campo.Visible = True
            lbl_alerta_tipo_documento.Visible = True
        Else
            lbl_alerta_campo.Visible = False
            lbl_alerta_tipo_documento.Visible = False
        End If
    End Sub

    Private Sub txt_numero_documento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_numero_documento.LostFocus
        If Me.txt_numero_documento.MaskCompleted = False Then
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            lbl_alerta_campo.Visible = True
            lbl_alerta_numero_documento.Visible = True
        Else
            If Not Me.cbx_tipo_documento.SelectedIndex = -1 Then
                Dim acceso As New AccesoDatos With {._nombre_tabla = "Chofer"}
                Dim tabla As DataTable = acceso.leo_tabla("nombre, apellido", "tipo_doc = '" & Me.cbx_tipo_documento.SelectedValue & "' and nro_doc = '" & Me.txt_numero_documento.Text & "';")
                If tabla.Rows.Count = 1 Then
                    Me.nombre_chofer.Text = tabla.Rows.Item(0).Item(0) & " " & tabla.Rows.Item(0).Item(1)
                Else
                    MessageBox.Show("El Chofer no exiate!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    nombre_chofer.Text = "Nombre Chofer"
                End If
                lbl_alerta_campo.Visible = False
                lbl_alerta_numero_documento.Visible = False
            End If
        End If
    End Sub

    'Group Detalle Viaje
    Private Sub cbx_provincia_origen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_provincia_origen.LostFocus
        If cbx_provincia_origen.SelectedIndex = -1 Then
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            lbl_alerta_campo.Visible = True
            lbl_alerta_localidad_origen.Visible = True
        Else
            lbl_alerta_campo.Visible = False
            lbl_alerta_localidad_origen.Visible = False
        End If
    End Sub

    Private Sub cbx_localidad_origen_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_localidad_origen.LostFocus
        If cbx_localidad_origen.SelectedIndex = -1 Then
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            lbl_alerta_campo.Visible = True
            lbl_alerta_localidad_origen.Visible = True
        Else
            lbl_alerta_campo.Visible = False
            lbl_alerta_localidad_origen.Visible = False
        End If
    End Sub

    Private Sub cbx_provincia_destino_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_provincia_destino.LostFocus
        If cbx_provincia_destino.SelectedIndex = -1 Then
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            lbl_alerta_campo.Visible = True
            lbl_alerta_localidad_destino.Visible = True
        Else
            lbl_alerta_campo.Visible = False
            lbl_alerta_localidad_destino.Visible = False
        End If
    End Sub

    'Carga de Localidades cando cambia el selectedindex de combos provincia
    Private Sub cbx_provincia_origen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_provincia_origen.SelectedIndexChanged, cbx_provincia_destino.SelectedIndexChanged
        Dim combo As ComboBox = sender
        Dim cmb As New Combo

        If carga Then
            If combo.Name = "cbx_provincia_destino" Then
                cmb.cargar_combo(Me.cbx_localidad_destino, "cp", "cp, nombre, nro_provincia", "nombre", " nro_provincia = '" & cbx_provincia_destino.SelectedValue & "'", "Localidad")
                Me.cbx_localidad_destino.Enabled = True
            Else
                cmb.cargar_combo(Me.cbx_localidad_origen, "cp", "cp, nombre, nro_provincia", "nombre", " nro_provincia = '" & (Me.cbx_provincia_origen.SelectedIndex + 1) & "'", "Localidad")
                Me.cbx_localidad_origen.Enabled = True
            End If
        End If
    End Sub

    Private Sub cbx_localidad_destino_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_localidad_destino.LostFocus
        If cbx_localidad_destino.Text = "" Then
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            lbl_alerta_campo.Visible = True
            lbl_alerta_localidad_destino.Visible = True
        Else
            lbl_alerta_campo.Visible = False
            lbl_alerta_localidad_destino.Visible = False
        End If
    End Sub

    Private Sub mtb_fecha_llegada_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mtb_fecha_llegada.LostFocus
        If mtb_fecha_llegada.MaskCompleted = False Then
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            lbl_alerta_campo.Visible = True
            lbl_alerta_fecha_llegada.Visible = True
        Else
            If Convert.ToDateTime(mtb_fecha_salida.Text) > Convert.ToDateTime(mtb_fecha_llegada.Text) Then
                MessageBox.Show("La fecha de llegada debe ser mayor a la de salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mtb_fecha_llegada.Focus()
            Else
                Me.lbl_alerta_campo.Visible = False
                Me.lbl_alerta_fecha_salida.Visible = False
            End If
        End If
    End Sub

    Private Sub txt_kilometros_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_kilometros.LostFocus
        If txt_kilometros.Text = "" Then
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            lbl_alerta_campo.Visible = True
            lbl_alerta_kilometros.Visible = True
        Else
            If txt_kilometros.Text <= 0 Then
                MessageBox.Show("Este campo no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mtb_fecha_llegada.Focus()
            Else
                Me.lbl_alerta_campo.Visible = False
                Me.lbl_alerta_fecha_salida.Visible = False
            End If
        End If
    End Sub

    'Verifica al tipear q sea numero o backspace
    Private Sub txt_kilometros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_kilometros.KeyPress
        If (Not Char.IsNumber(e.KeyChar)) And (Not e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txt_domicilio_entrega_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_domiciolio_entrega.LostFocus
        If txt_domiciolio_entrega.Text = "" Then
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            lbl_alerta_campo.Visible = True
            lbl_alerta_domicilio_entrega.Visible = True
        Else
            lbl_alerta_campo.Visible = False
            lbl_alerta_domicilio_entrega.Visible = False
        End If
    End Sub

    Private Sub txt_numero_cliente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_numero_cliente.LostFocus
        If txt_numero_cliente.Text = "" Then
            Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
            lbl_alerta_campo.Visible = True
            lbl_alerta_numero_cliente.Visible = True
        Else
            Dim acceso As New AccesoDatos With {._nombre_tabla = "Cliente"}
            If acceso.leo_tabla("*", "nro_cuit = " & txt_numero_cliente.Text).Rows.Count = 0 Then
                MessageBox.Show("El cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                mtb_fecha_llegada.Focus()
            Else
                Me.lbl_alerta_campo.Visible = False
                Me.lbl_alerta_fecha_salida.Visible = False
            End If
        End If
    End Sub

    'Verifica al tipear q sea numero o backspace
    Private Sub txt_numero_cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_numero_cliente.KeyPress
        If (Not Char.IsNumber(e.KeyChar)) And (Not e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub


    '    Private Sub cbx_patente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_patente.KeyPress
    '        Dim letras As Integer = 3
    '        Dim numero As Integer = 3

    '        If letras > 0 Then
    '            If Char.IsLetter(e.KeyChar) Then
    '                e.Handled = False
    '                letras = letras - 1
    '            Else
    '                e.Handled = True
    '            End If

    '        ElseIf letras = 0 And numero > 0 Then
    '            If Char.IsNumber(e.KeyChar) Then
    '                e.Handled = False
    '                numero -= 1
    '            Else
    '                e.Handled = True
    '            End If
    '        End If
    '    End Sub


#End Region


    '
    'metodos de acceso y carga de datos

    '
End Class