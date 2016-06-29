<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Viaje
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.cbx_confirma_datos_viaje = New System.Windows.Forms.CheckBox()
        Me.btn_guardar_viaje = New System.Windows.Forms.Button()
        Me.btn_eliminar_viaje = New System.Windows.Forms.Button()
        Me.grp_datos_viaje = New System.Windows.Forms.GroupBox()
        Me.cbx_provincia_destino = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbx_localidad_origen = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_alerta_numero_cliente = New System.Windows.Forms.Label()
        Me.lbl_alerta_domicilio_entrega = New System.Windows.Forms.Label()
        Me.lbl_alerta_kilometros = New System.Windows.Forms.Label()
        Me.lbl_alerta_fecha_llegada = New System.Windows.Forms.Label()
        Me.txt_numero_cliente = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_alerta_localidad_destino = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_alerta_localidad_origen = New System.Windows.Forms.Label()
        Me.txt_domiciolio_entrega = New System.Windows.Forms.MaskedTextBox()
        Me.txt_kilometros = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_fecha_llegada = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_provincia_origen = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbx_localidad_destino = New System.Windows.Forms.ComboBox()
        Me.grp_viaje = New System.Windows.Forms.GroupBox()
        Me.btn_crear_viaje = New System.Windows.Forms.Button()
        Me.lbl_alerta_patente = New System.Windows.Forms.Label()
        Me.lbl_alerta_fecha_salida = New System.Windows.Forms.Label()
        Me.mtb_fecha_salida = New System.Windows.Forms.MaskedTextBox()
        Me.cbx_patente = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.grp_chofer = New System.Windows.Forms.GroupBox()
        Me.nombre_chofer = New System.Windows.Forms.Label()
        Me.txt_numero_documento = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_alerta_numero_documento = New System.Windows.Forms.Label()
        Me.cbx_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.lbl_alerta_tipo_documento = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_alerta_campo = New System.Windows.Forms.Label()
        Me.btn_agregar_carga = New System.Windows.Forms.Button()
        Me.dgv_ABM_Viaje = New System.Windows.Forms.DataGridView()
        Me.dgv_patente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_fecha_salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_nombre_chofer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_apellido_chofer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cp_origen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cp_destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_datos_viaje.SuspendLayout()
        Me.grp_viaje.SuspendLayout()
        Me.grp_chofer.SuspendLayout()
        CType(Me.dgv_ABM_Viaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(537, 509)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(67, 23)
        Me.btn_volver.TabIndex = 7
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'cbx_confirma_datos_viaje
        '
        Me.cbx_confirma_datos_viaje.AutoSize = True
        Me.cbx_confirma_datos_viaje.Location = New System.Drawing.Point(12, 486)
        Me.cbx_confirma_datos_viaje.Name = "cbx_confirma_datos_viaje"
        Me.cbx_confirma_datos_viaje.Size = New System.Drawing.Size(257, 17)
        Me.cbx_confirma_datos_viaje.TabIndex = 3
        Me.cbx_confirma_datos_viaje.Text = "Confirmo que los datos ingresados son correctos."
        Me.cbx_confirma_datos_viaje.UseVisualStyleBackColor = True
        '
        'btn_guardar_viaje
        '
        Me.btn_guardar_viaje.Location = New System.Drawing.Point(183, 509)
        Me.btn_guardar_viaje.Name = "btn_guardar_viaje"
        Me.btn_guardar_viaje.Size = New System.Drawing.Size(67, 23)
        Me.btn_guardar_viaje.TabIndex = 5
        Me.btn_guardar_viaje.Text = "Guardar"
        Me.btn_guardar_viaje.UseVisualStyleBackColor = True
        '
        'btn_eliminar_viaje
        '
        Me.btn_eliminar_viaje.Location = New System.Drawing.Point(12, 509)
        Me.btn_eliminar_viaje.Name = "btn_eliminar_viaje"
        Me.btn_eliminar_viaje.Size = New System.Drawing.Size(67, 23)
        Me.btn_eliminar_viaje.TabIndex = 4
        Me.btn_eliminar_viaje.Text = "Eliminar"
        Me.btn_eliminar_viaje.UseVisualStyleBackColor = True
        '
        'grp_datos_viaje
        '
        Me.grp_datos_viaje.Controls.Add(Me.cbx_provincia_destino)
        Me.grp_datos_viaje.Controls.Add(Me.Label13)
        Me.grp_datos_viaje.Controls.Add(Me.cbx_localidad_origen)
        Me.grp_datos_viaje.Controls.Add(Me.Label12)
        Me.grp_datos_viaje.Controls.Add(Me.lbl_alerta_numero_cliente)
        Me.grp_datos_viaje.Controls.Add(Me.lbl_alerta_domicilio_entrega)
        Me.grp_datos_viaje.Controls.Add(Me.lbl_alerta_kilometros)
        Me.grp_datos_viaje.Controls.Add(Me.lbl_alerta_fecha_llegada)
        Me.grp_datos_viaje.Controls.Add(Me.txt_numero_cliente)
        Me.grp_datos_viaje.Controls.Add(Me.lbl_alerta_localidad_destino)
        Me.grp_datos_viaje.Controls.Add(Me.Label4)
        Me.grp_datos_viaje.Controls.Add(Me.lbl_alerta_localidad_origen)
        Me.grp_datos_viaje.Controls.Add(Me.txt_domiciolio_entrega)
        Me.grp_datos_viaje.Controls.Add(Me.txt_kilometros)
        Me.grp_datos_viaje.Controls.Add(Me.mtb_fecha_llegada)
        Me.grp_datos_viaje.Controls.Add(Me.Label11)
        Me.grp_datos_viaje.Controls.Add(Me.Label2)
        Me.grp_datos_viaje.Controls.Add(Me.cbx_provincia_origen)
        Me.grp_datos_viaje.Controls.Add(Me.Label10)
        Me.grp_datos_viaje.Controls.Add(Me.Label9)
        Me.grp_datos_viaje.Controls.Add(Me.Label8)
        Me.grp_datos_viaje.Controls.Add(Me.cbx_localidad_destino)
        Me.grp_datos_viaje.Location = New System.Drawing.Point(12, 167)
        Me.grp_datos_viaje.Name = "grp_datos_viaje"
        Me.grp_datos_viaje.Size = New System.Drawing.Size(592, 127)
        Me.grp_datos_viaje.TabIndex = 2
        Me.grp_datos_viaje.TabStop = False
        Me.grp_datos_viaje.Text = "Datos de Viaje"
        '
        'cbx_provincia_destino
        '
        Me.cbx_provincia_destino.FormattingEnabled = True
        Me.cbx_provincia_destino.Location = New System.Drawing.Point(117, 47)
        Me.cbx_provincia_destino.Name = "cbx_provincia_destino"
        Me.cbx_provincia_destino.Size = New System.Drawing.Size(166, 21)
        Me.cbx_provincia_destino.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Provincia Destino:"
        '
        'cbx_localidad_origen
        '
        Me.cbx_localidad_origen.FormattingEnabled = True
        Me.cbx_localidad_origen.Location = New System.Drawing.Point(445, 19)
        Me.cbx_localidad_origen.Name = "cbx_localidad_origen"
        Me.cbx_localidad_origen.Size = New System.Drawing.Size(121, 21)
        Me.cbx_localidad_origen.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(346, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Localidad Origen: "
        '
        'lbl_alerta_numero_cliente
        '
        Me.lbl_alerta_numero_cliente.AutoSize = True
        Me.lbl_alerta_numero_cliente.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_numero_cliente.Location = New System.Drawing.Point(569, 107)
        Me.lbl_alerta_numero_cliente.Name = "lbl_alerta_numero_cliente"
        Me.lbl_alerta_numero_cliente.Size = New System.Drawing.Size(11, 13)
        Me.lbl_alerta_numero_cliente.TabIndex = 47
        Me.lbl_alerta_numero_cliente.Text = "*"
        Me.lbl_alerta_numero_cliente.Visible = False
        '
        'lbl_alerta_domicilio_entrega
        '
        Me.lbl_alerta_domicilio_entrega.AutoSize = True
        Me.lbl_alerta_domicilio_entrega.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_domicilio_entrega.Location = New System.Drawing.Point(289, 103)
        Me.lbl_alerta_domicilio_entrega.Name = "lbl_alerta_domicilio_entrega"
        Me.lbl_alerta_domicilio_entrega.Size = New System.Drawing.Size(11, 13)
        Me.lbl_alerta_domicilio_entrega.TabIndex = 46
        Me.lbl_alerta_domicilio_entrega.Text = "*"
        Me.lbl_alerta_domicilio_entrega.Visible = False
        '
        'lbl_alerta_kilometros
        '
        Me.lbl_alerta_kilometros.AutoSize = True
        Me.lbl_alerta_kilometros.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_kilometros.Location = New System.Drawing.Point(569, 81)
        Me.lbl_alerta_kilometros.Name = "lbl_alerta_kilometros"
        Me.lbl_alerta_kilometros.Size = New System.Drawing.Size(11, 13)
        Me.lbl_alerta_kilometros.TabIndex = 45
        Me.lbl_alerta_kilometros.Text = "*"
        Me.lbl_alerta_kilometros.Visible = False
        '
        'lbl_alerta_fecha_llegada
        '
        Me.lbl_alerta_fecha_llegada.AutoSize = True
        Me.lbl_alerta_fecha_llegada.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_fecha_llegada.Location = New System.Drawing.Point(289, 77)
        Me.lbl_alerta_fecha_llegada.Name = "lbl_alerta_fecha_llegada"
        Me.lbl_alerta_fecha_llegada.Size = New System.Drawing.Size(11, 13)
        Me.lbl_alerta_fecha_llegada.TabIndex = 44
        Me.lbl_alerta_fecha_llegada.Text = "*"
        Me.lbl_alerta_fecha_llegada.Visible = False
        '
        'txt_numero_cliente
        '
        Me.txt_numero_cliente.Location = New System.Drawing.Point(445, 100)
        Me.txt_numero_cliente.Name = "txt_numero_cliente"
        Me.txt_numero_cliente.Size = New System.Drawing.Size(121, 20)
        Me.txt_numero_cliente.TabIndex = 7
        '
        'lbl_alerta_localidad_destino
        '
        Me.lbl_alerta_localidad_destino.AutoSize = True
        Me.lbl_alerta_localidad_destino.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_localidad_destino.Location = New System.Drawing.Point(569, 55)
        Me.lbl_alerta_localidad_destino.Name = "lbl_alerta_localidad_destino"
        Me.lbl_alerta_localidad_destino.Size = New System.Drawing.Size(11, 13)
        Me.lbl_alerta_localidad_destino.TabIndex = 43
        Me.lbl_alerta_localidad_destino.Text = "*"
        Me.lbl_alerta_localidad_destino.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Numero de Cliente: "
        '
        'lbl_alerta_localidad_origen
        '
        Me.lbl_alerta_localidad_origen.AutoSize = True
        Me.lbl_alerta_localidad_origen.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_localidad_origen.Location = New System.Drawing.Point(569, 27)
        Me.lbl_alerta_localidad_origen.Name = "lbl_alerta_localidad_origen"
        Me.lbl_alerta_localidad_origen.Size = New System.Drawing.Size(11, 13)
        Me.lbl_alerta_localidad_origen.TabIndex = 42
        Me.lbl_alerta_localidad_origen.Text = "*"
        Me.lbl_alerta_localidad_origen.Visible = False
        '
        'txt_domiciolio_entrega
        '
        Me.txt_domiciolio_entrega.Location = New System.Drawing.Point(117, 100)
        Me.txt_domiciolio_entrega.Name = "txt_domiciolio_entrega"
        Me.txt_domiciolio_entrega.Size = New System.Drawing.Size(166, 20)
        Me.txt_domiciolio_entrega.TabIndex = 6
        '
        'txt_kilometros
        '
        Me.txt_kilometros.Location = New System.Drawing.Point(445, 74)
        Me.txt_kilometros.Name = "txt_kilometros"
        Me.txt_kilometros.Size = New System.Drawing.Size(121, 20)
        Me.txt_kilometros.TabIndex = 5
        '
        'mtb_fecha_llegada
        '
        Me.mtb_fecha_llegada.Location = New System.Drawing.Point(117, 74)
        Me.mtb_fecha_llegada.Mask = "00/00/0000"
        Me.mtb_fecha_llegada.Name = "mtb_fecha_llegada"
        Me.mtb_fecha_llegada.Size = New System.Drawing.Size(166, 20)
        Me.mtb_fecha_llegada.TabIndex = 4
        Me.mtb_fecha_llegada.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(378, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Kilometros: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Domicilio de Entrega: "
        '
        'cbx_provincia_origen
        '
        Me.cbx_provincia_origen.FormattingEnabled = True
        Me.cbx_provincia_origen.Location = New System.Drawing.Point(117, 19)
        Me.cbx_provincia_origen.Name = "cbx_provincia_origen"
        Me.cbx_provincia_origen.Size = New System.Drawing.Size(166, 21)
        Me.cbx_provincia_origen.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Fecha de Llegada: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(343, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Localidad Destino: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Provincia Origen: "
        '
        'cbx_localidad_destino
        '
        Me.cbx_localidad_destino.FormattingEnabled = True
        Me.cbx_localidad_destino.Location = New System.Drawing.Point(445, 47)
        Me.cbx_localidad_destino.Name = "cbx_localidad_destino"
        Me.cbx_localidad_destino.Size = New System.Drawing.Size(121, 21)
        Me.cbx_localidad_destino.TabIndex = 3
        '
        'grp_viaje
        '
        Me.grp_viaje.Controls.Add(Me.btn_crear_viaje)
        Me.grp_viaje.Controls.Add(Me.lbl_alerta_patente)
        Me.grp_viaje.Controls.Add(Me.lbl_alerta_fecha_salida)
        Me.grp_viaje.Controls.Add(Me.mtb_fecha_salida)
        Me.grp_viaje.Controls.Add(Me.cbx_patente)
        Me.grp_viaje.Controls.Add(Me.Label7)
        Me.grp_viaje.Controls.Add(Me.Label3)
        Me.grp_viaje.Location = New System.Drawing.Point(12, 12)
        Me.grp_viaje.Name = "grp_viaje"
        Me.grp_viaje.Size = New System.Drawing.Size(592, 61)
        Me.grp_viaje.TabIndex = 0
        Me.grp_viaje.TabStop = False
        Me.grp_viaje.Text = "Viaje"
        '
        'btn_crear_viaje
        '
        Me.btn_crear_viaje.Location = New System.Drawing.Point(476, 23)
        Me.btn_crear_viaje.Name = "btn_crear_viaje"
        Me.btn_crear_viaje.Size = New System.Drawing.Size(88, 23)
        Me.btn_crear_viaje.TabIndex = 2
        Me.btn_crear_viaje.Text = "Crear"
        Me.btn_crear_viaje.UseVisualStyleBackColor = True
        '
        'lbl_alerta_patente
        '
        Me.lbl_alerta_patente.AutoSize = True
        Me.lbl_alerta_patente.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_patente.Location = New System.Drawing.Point(459, 28)
        Me.lbl_alerta_patente.Name = "lbl_alerta_patente"
        Me.lbl_alerta_patente.Size = New System.Drawing.Size(11, 13)
        Me.lbl_alerta_patente.TabIndex = 28
        Me.lbl_alerta_patente.Text = "*"
        Me.lbl_alerta_patente.Visible = False
        '
        'lbl_alerta_fecha_salida
        '
        Me.lbl_alerta_fecha_salida.AutoSize = True
        Me.lbl_alerta_fecha_salida.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_fecha_salida.Location = New System.Drawing.Point(244, 28)
        Me.lbl_alerta_fecha_salida.Name = "lbl_alerta_fecha_salida"
        Me.lbl_alerta_fecha_salida.Size = New System.Drawing.Size(11, 13)
        Me.lbl_alerta_fecha_salida.TabIndex = 27
        Me.lbl_alerta_fecha_salida.Text = "*"
        Me.lbl_alerta_fecha_salida.Visible = False
        '
        'mtb_fecha_salida
        '
        Me.mtb_fecha_salida.Location = New System.Drawing.Point(117, 25)
        Me.mtb_fecha_salida.Mask = "00/00/0000"
        Me.mtb_fecha_salida.Name = "mtb_fecha_salida"
        Me.mtb_fecha_salida.Size = New System.Drawing.Size(121, 20)
        Me.mtb_fecha_salida.TabIndex = 0
        Me.mtb_fecha_salida.ValidatingType = GetType(Date)
        '
        'cbx_patente
        '
        Me.cbx_patente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbx_patente.FormattingEnabled = True
        Me.cbx_patente.Location = New System.Drawing.Point(332, 25)
        Me.cbx_patente.Name = "cbx_patente"
        Me.cbx_patente.Size = New System.Drawing.Size(121, 21)
        Me.cbx_patente.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha de Salida: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Patente: "
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(478, 53)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(88, 23)
        Me.btn_limpiar.TabIndex = 2
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'grp_chofer
        '
        Me.grp_chofer.Controls.Add(Me.btn_limpiar)
        Me.grp_chofer.Controls.Add(Me.nombre_chofer)
        Me.grp_chofer.Controls.Add(Me.txt_numero_documento)
        Me.grp_chofer.Controls.Add(Me.lbl_alerta_numero_documento)
        Me.grp_chofer.Controls.Add(Me.cbx_tipo_documento)
        Me.grp_chofer.Controls.Add(Me.lbl_alerta_tipo_documento)
        Me.grp_chofer.Controls.Add(Me.Label5)
        Me.grp_chofer.Controls.Add(Me.Label1)
        Me.grp_chofer.Location = New System.Drawing.Point(12, 79)
        Me.grp_chofer.Name = "grp_chofer"
        Me.grp_chofer.Size = New System.Drawing.Size(592, 82)
        Me.grp_chofer.TabIndex = 1
        Me.grp_chofer.TabStop = False
        Me.grp_chofer.Text = "Datos de Chofer"
        '
        'nombre_chofer
        '
        Me.nombre_chofer.AutoSize = True
        Me.nombre_chofer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_chofer.Location = New System.Drawing.Point(117, 56)
        Me.nombre_chofer.Name = "nombre_chofer"
        Me.nombre_chofer.Size = New System.Drawing.Size(112, 16)
        Me.nombre_chofer.TabIndex = 33
        Me.nombre_chofer.Text = "Nombre Chofer"
        '
        'txt_numero_documento
        '
        Me.txt_numero_documento.Location = New System.Drawing.Point(445, 22)
        Me.txt_numero_documento.Mask = "99999999"
        Me.txt_numero_documento.Name = "txt_numero_documento"
        Me.txt_numero_documento.Size = New System.Drawing.Size(121, 20)
        Me.txt_numero_documento.TabIndex = 1
        '
        'lbl_alerta_numero_documento
        '
        Me.lbl_alerta_numero_documento.AutoSize = True
        Me.lbl_alerta_numero_documento.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_numero_documento.Location = New System.Drawing.Point(570, 28)
        Me.lbl_alerta_numero_documento.Name = "lbl_alerta_numero_documento"
        Me.lbl_alerta_numero_documento.Size = New System.Drawing.Size(11, 13)
        Me.lbl_alerta_numero_documento.TabIndex = 31
        Me.lbl_alerta_numero_documento.Text = "*"
        Me.lbl_alerta_numero_documento.Visible = False
        '
        'cbx_tipo_documento
        '
        Me.cbx_tipo_documento.FormattingEnabled = True
        Me.cbx_tipo_documento.Location = New System.Drawing.Point(120, 21)
        Me.cbx_tipo_documento.Name = "cbx_tipo_documento"
        Me.cbx_tipo_documento.Size = New System.Drawing.Size(166, 21)
        Me.cbx_tipo_documento.TabIndex = 0
        '
        'lbl_alerta_tipo_documento
        '
        Me.lbl_alerta_tipo_documento.AutoSize = True
        Me.lbl_alerta_tipo_documento.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_tipo_documento.Location = New System.Drawing.Point(289, 25)
        Me.lbl_alerta_tipo_documento.Name = "lbl_alerta_tipo_documento"
        Me.lbl_alerta_tipo_documento.Size = New System.Drawing.Size(11, 13)
        Me.lbl_alerta_tipo_documento.TabIndex = 30
        Me.lbl_alerta_tipo_documento.Text = "*"
        Me.lbl_alerta_tipo_documento.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(316, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero de Documento: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipo de Documento: "
        '
        'lbl_alerta_campo
        '
        Me.lbl_alerta_campo.AutoSize = True
        Me.lbl_alerta_campo.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_campo.Location = New System.Drawing.Point(341, 487)
        Me.lbl_alerta_campo.Name = "lbl_alerta_campo"
        Me.lbl_alerta_campo.Size = New System.Drawing.Size(250, 13)
        Me.lbl_alerta_campo.TabIndex = 30
        Me.lbl_alerta_campo.Text = "Completar los campos marcados antes de continuar"
        Me.lbl_alerta_campo.Visible = False
        '
        'btn_agregar_carga
        '
        Me.btn_agregar_carga.Location = New System.Drawing.Point(365, 509)
        Me.btn_agregar_carga.Name = "btn_agregar_carga"
        Me.btn_agregar_carga.Size = New System.Drawing.Size(96, 23)
        Me.btn_agregar_carga.TabIndex = 6
        Me.btn_agregar_carga.Text = "Agregar Carga"
        Me.btn_agregar_carga.UseVisualStyleBackColor = True
        '
        'dgv_ABM_Viaje
        '
        Me.dgv_ABM_Viaje.AllowUserToAddRows = False
        Me.dgv_ABM_Viaje.AllowUserToDeleteRows = False
        Me.dgv_ABM_Viaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ABM_Viaje.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_patente, Me.dgv_fecha_salida, Me.dgv_nombre_chofer, Me.dgv_apellido_chofer, Me.dgv_origen, Me.dgv_destino, Me.cp_origen, Me.cp_destino, Me.tipo_doc, Me.nro_doc})
        Me.dgv_ABM_Viaje.Location = New System.Drawing.Point(12, 300)
        Me.dgv_ABM_Viaje.Name = "dgv_ABM_Viaje"
        Me.dgv_ABM_Viaje.ReadOnly = True
        Me.dgv_ABM_Viaje.Size = New System.Drawing.Size(594, 180)
        Me.dgv_ABM_Viaje.TabIndex = 31
        '
        'dgv_patente
        '
        Me.dgv_patente.DataPropertyName = "patente"
        Me.dgv_patente.HeaderText = "Patente"
        Me.dgv_patente.Name = "dgv_patente"
        Me.dgv_patente.ReadOnly = True
        '
        'dgv_fecha_salida
        '
        Me.dgv_fecha_salida.DataPropertyName = "fecha_salida"
        Me.dgv_fecha_salida.HeaderText = "Fecha Salida"
        Me.dgv_fecha_salida.Name = "dgv_fecha_salida"
        Me.dgv_fecha_salida.ReadOnly = True
        '
        'dgv_nombre_chofer
        '
        Me.dgv_nombre_chofer.DataPropertyName = "nombre"
        Me.dgv_nombre_chofer.HeaderText = "Nombre Chofer"
        Me.dgv_nombre_chofer.Name = "dgv_nombre_chofer"
        Me.dgv_nombre_chofer.ReadOnly = True
        '
        'dgv_apellido_chofer
        '
        Me.dgv_apellido_chofer.DataPropertyName = "apellido"
        Me.dgv_apellido_chofer.HeaderText = "Apellido Chofer"
        Me.dgv_apellido_chofer.Name = "dgv_apellido_chofer"
        Me.dgv_apellido_chofer.ReadOnly = True
        '
        'dgv_origen
        '
        Me.dgv_origen.DataPropertyName = "origen"
        Me.dgv_origen.HeaderText = "Origen"
        Me.dgv_origen.Name = "dgv_origen"
        Me.dgv_origen.ReadOnly = True
        '
        'dgv_destino
        '
        Me.dgv_destino.DataPropertyName = "destino"
        Me.dgv_destino.HeaderText = "Destino"
        Me.dgv_destino.Name = "dgv_destino"
        Me.dgv_destino.ReadOnly = True
        '
        'cp_origen
        '
        Me.cp_origen.DataPropertyName = "localidad_origen"
        Me.cp_origen.HeaderText = "cp_origen"
        Me.cp_origen.Name = "cp_origen"
        Me.cp_origen.ReadOnly = True
        Me.cp_origen.Visible = False
        '
        'cp_destino
        '
        Me.cp_destino.DataPropertyName = "localidad_destino"
        Me.cp_destino.HeaderText = "cp_destino"
        Me.cp_destino.Name = "cp_destino"
        Me.cp_destino.ReadOnly = True
        Me.cp_destino.Visible = False
        '
        'tipo_doc
        '
        Me.tipo_doc.HeaderText = "tipo_doc"
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.ReadOnly = True
        Me.tipo_doc.Visible = False
        '
        'nro_doc
        '
        Me.nro_doc.HeaderText = "nro_doc"
        Me.nro_doc.Name = "nro_doc"
        Me.nro_doc.ReadOnly = True
        Me.nro_doc.Visible = False
        '
        'ABM_Viaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 548)
        Me.Controls.Add(Me.dgv_ABM_Viaje)
        Me.Controls.Add(Me.lbl_alerta_campo)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.cbx_confirma_datos_viaje)
        Me.Controls.Add(Me.btn_agregar_carga)
        Me.Controls.Add(Me.btn_guardar_viaje)
        Me.Controls.Add(Me.btn_eliminar_viaje)
        Me.Controls.Add(Me.grp_datos_viaje)
        Me.Controls.Add(Me.grp_viaje)
        Me.Controls.Add(Me.grp_chofer)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 800)
        Me.MinimumSize = New System.Drawing.Size(599, 540)
        Me.Name = "ABM_Viaje"
        Me.Text = "ABM Viaje"
        Me.grp_datos_viaje.ResumeLayout(False)
        Me.grp_datos_viaje.PerformLayout()
        Me.grp_viaje.ResumeLayout(False)
        Me.grp_viaje.PerformLayout()
        Me.grp_chofer.ResumeLayout(False)
        Me.grp_chofer.PerformLayout()
        CType(Me.dgv_ABM_Viaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents cbx_confirma_datos_viaje As System.Windows.Forms.CheckBox
    Friend WithEvents btn_guardar_viaje As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar_viaje As System.Windows.Forms.Button
    Friend WithEvents grp_datos_viaje As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_alerta_numero_cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta_domicilio_entrega As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta_kilometros As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta_fecha_llegada As System.Windows.Forms.Label
    Friend WithEvents txt_numero_cliente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_alerta_localidad_destino As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta_localidad_origen As System.Windows.Forms.Label
    Friend WithEvents txt_domiciolio_entrega As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_kilometros As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtb_fecha_llegada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbx_provincia_origen As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbx_localidad_destino As System.Windows.Forms.ComboBox
    Friend WithEvents grp_viaje As System.Windows.Forms.GroupBox
    Friend WithEvents btn_crear_viaje As System.Windows.Forms.Button
    Friend WithEvents lbl_alerta_patente As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta_fecha_salida As System.Windows.Forms.Label
    Friend WithEvents mtb_fecha_salida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbx_patente As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grp_chofer As System.Windows.Forms.GroupBox
    Friend WithEvents txt_numero_documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_alerta_numero_documento As System.Windows.Forms.Label
    Friend WithEvents cbx_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_alerta_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta_campo As System.Windows.Forms.Label
    Friend WithEvents btn_agregar_carga As System.Windows.Forms.Button
    Friend WithEvents nombre_chofer As System.Windows.Forms.Label
    Friend WithEvents cbx_provincia_destino As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbx_localidad_origen As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgv_ABM_Viaje As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_patente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_fecha_salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_nombre_chofer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_apellido_chofer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cp_origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cp_destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
End Class
