<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Detalle_Viajes
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
        Me.grp_viaje = New System.Windows.Forms.GroupBox()
        Me.btn_crear_carga = New System.Windows.Forms.Button()
        Me.txt_patente = New System.Windows.Forms.TextBox()
        Me.lbl_toneladas = New System.Windows.Forms.Label()
        Me.lbl_volumen = New System.Windows.Forms.Label()
        Me.lbl_carga = New System.Windows.Forms.Label()
        Me.txt_toneladas = New System.Windows.Forms.TextBox()
        Me.txt_volumen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtb_fecha_salida = New System.Windows.Forms.MaskedTextBox()
        Me.cbx_tipo_carga = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_crear_detalle_viaje = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.chbx_confirmacion_detalle_viaje = New System.Windows.Forms.CheckBox()
        Me.btn_eliminar_detalle_viaje = New System.Windows.Forms.Button()
        Me.lbl_alerta = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.dgv_ABM_Detalle_Viaje = New System.Windows.Forms.DataGridView()
        Me.tipo_carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.volumen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toneladas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_viaje.SuspendLayout()
        CType(Me.dgv_ABM_Detalle_Viaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_viaje
        '
        Me.grp_viaje.Controls.Add(Me.btn_crear_carga)
        Me.grp_viaje.Controls.Add(Me.txt_patente)
        Me.grp_viaje.Controls.Add(Me.lbl_toneladas)
        Me.grp_viaje.Controls.Add(Me.lbl_volumen)
        Me.grp_viaje.Controls.Add(Me.lbl_carga)
        Me.grp_viaje.Controls.Add(Me.txt_toneladas)
        Me.grp_viaje.Controls.Add(Me.txt_volumen)
        Me.grp_viaje.Controls.Add(Me.Label2)
        Me.grp_viaje.Controls.Add(Me.Label1)
        Me.grp_viaje.Controls.Add(Me.mtb_fecha_salida)
        Me.grp_viaje.Controls.Add(Me.cbx_tipo_carga)
        Me.grp_viaje.Controls.Add(Me.Label6)
        Me.grp_viaje.Controls.Add(Me.Label7)
        Me.grp_viaje.Controls.Add(Me.Label3)
        Me.grp_viaje.Location = New System.Drawing.Point(12, 12)
        Me.grp_viaje.Name = "grp_viaje"
        Me.grp_viaje.Size = New System.Drawing.Size(274, 178)
        Me.grp_viaje.TabIndex = 23
        Me.grp_viaje.TabStop = False
        Me.grp_viaje.Text = "Detalle del Viaje"
        '
        'btn_crear_carga
        '
        Me.btn_crear_carga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear_carga.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_crear_carga.Location = New System.Drawing.Point(234, 94)
        Me.btn_crear_carga.Name = "btn_crear_carga"
        Me.btn_crear_carga.Size = New System.Drawing.Size(23, 21)
        Me.btn_crear_carga.TabIndex = 26
        Me.btn_crear_carga.Text = "+"
        Me.btn_crear_carga.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_crear_carga.UseVisualStyleBackColor = True
        '
        'txt_patente
        '
        Me.txt_patente.Location = New System.Drawing.Point(98, 47)
        Me.txt_patente.Name = "txt_patente"
        Me.txt_patente.Size = New System.Drawing.Size(110, 20)
        Me.txt_patente.TabIndex = 26
        '
        'lbl_toneladas
        '
        Me.lbl_toneladas.AutoSize = True
        Me.lbl_toneladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_toneladas.ForeColor = System.Drawing.Color.Red
        Me.lbl_toneladas.Location = New System.Drawing.Point(214, 151)
        Me.lbl_toneladas.Name = "lbl_toneladas"
        Me.lbl_toneladas.Size = New System.Drawing.Size(14, 16)
        Me.lbl_toneladas.TabIndex = 18
        Me.lbl_toneladas.Text = "*"
        '
        'lbl_volumen
        '
        Me.lbl_volumen.AutoSize = True
        Me.lbl_volumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_volumen.ForeColor = System.Drawing.Color.Red
        Me.lbl_volumen.Location = New System.Drawing.Point(214, 125)
        Me.lbl_volumen.Name = "lbl_volumen"
        Me.lbl_volumen.Size = New System.Drawing.Size(14, 16)
        Me.lbl_volumen.TabIndex = 18
        Me.lbl_volumen.Text = "*"
        '
        'lbl_carga
        '
        Me.lbl_carga.AutoSize = True
        Me.lbl_carga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_carga.ForeColor = System.Drawing.Color.Red
        Me.lbl_carga.Location = New System.Drawing.Point(214, 99)
        Me.lbl_carga.Name = "lbl_carga"
        Me.lbl_carga.Size = New System.Drawing.Size(14, 16)
        Me.lbl_carga.TabIndex = 18
        Me.lbl_carga.Text = "*"
        '
        'txt_toneladas
        '
        Me.txt_toneladas.Location = New System.Drawing.Point(98, 147)
        Me.txt_toneladas.Name = "txt_toneladas"
        Me.txt_toneladas.Size = New System.Drawing.Size(110, 20)
        Me.txt_toneladas.TabIndex = 4
        '
        'txt_volumen
        '
        Me.txt_volumen.Location = New System.Drawing.Point(98, 121)
        Me.txt_volumen.Name = "txt_volumen"
        Me.txt_volumen.Size = New System.Drawing.Size(110, 20)
        Me.txt_volumen.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Volumen: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Toneladas: "
        '
        'mtb_fecha_salida
        '
        Me.mtb_fecha_salida.Location = New System.Drawing.Point(98, 19)
        Me.mtb_fecha_salida.Mask = "00/00/0000"
        Me.mtb_fecha_salida.Name = "mtb_fecha_salida"
        Me.mtb_fecha_salida.Size = New System.Drawing.Size(110, 20)
        Me.mtb_fecha_salida.TabIndex = 0
        Me.mtb_fecha_salida.ValidatingType = GetType(Date)
        '
        'cbx_tipo_carga
        '
        Me.cbx_tipo_carga.FormattingEnabled = True
        Me.cbx_tipo_carga.Location = New System.Drawing.Point(98, 94)
        Me.cbx_tipo_carga.Name = "cbx_tipo_carga"
        Me.cbx_tipo_carga.Size = New System.Drawing.Size(110, 21)
        Me.cbx_tipo_carga.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tipo de Carga: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha de Salida: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Patente: "
        '
        'btn_crear_detalle_viaje
        '
        Me.btn_crear_detalle_viaje.Location = New System.Drawing.Point(389, 226)
        Me.btn_crear_detalle_viaje.Name = "btn_crear_detalle_viaje"
        Me.btn_crear_detalle_viaje.Size = New System.Drawing.Size(67, 23)
        Me.btn_crear_detalle_viaje.TabIndex = 1
        Me.btn_crear_detalle_viaje.Text = "Crear"
        Me.btn_crear_detalle_viaje.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(568, 226)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(67, 23)
        Me.btn_volver.TabIndex = 2
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'chbx_confirmacion_detalle_viaje
        '
        Me.chbx_confirmacion_detalle_viaje.AutoSize = True
        Me.chbx_confirmacion_detalle_viaje.Location = New System.Drawing.Point(12, 196)
        Me.chbx_confirmacion_detalle_viaje.Name = "chbx_confirmacion_detalle_viaje"
        Me.chbx_confirmacion_detalle_viaje.Size = New System.Drawing.Size(257, 17)
        Me.chbx_confirmacion_detalle_viaje.TabIndex = 0
        Me.chbx_confirmacion_detalle_viaje.Text = "Confirmo que los datos ingresados son correctos."
        Me.chbx_confirmacion_detalle_viaje.UseVisualStyleBackColor = True
        '
        'btn_eliminar_detalle_viaje
        '
        Me.btn_eliminar_detalle_viaje.Location = New System.Drawing.Point(12, 226)
        Me.btn_eliminar_detalle_viaje.Name = "btn_eliminar_detalle_viaje"
        Me.btn_eliminar_detalle_viaje.Size = New System.Drawing.Size(67, 23)
        Me.btn_eliminar_detalle_viaje.TabIndex = 24
        Me.btn_eliminar_detalle_viaje.Text = "Eliminar"
        Me.btn_eliminar_detalle_viaje.UseVisualStyleBackColor = True
        '
        'lbl_alerta
        '
        Me.lbl_alerta.AutoSize = True
        Me.lbl_alerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta.Location = New System.Drawing.Point(376, 197)
        Me.lbl_alerta.Name = "lbl_alerta"
        Me.lbl_alerta.Size = New System.Drawing.Size(193, 16)
        Me.lbl_alerta.TabIndex = 18
        Me.lbl_alerta.Text = "Quedan datos Incompletos"
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(214, 226)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(67, 23)
        Me.btn_guardar.TabIndex = 1
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'dgv_ABM_Detalle_Viaje
        '
        Me.dgv_ABM_Detalle_Viaje.AllowUserToAddRows = False
        Me.dgv_ABM_Detalle_Viaje.AllowUserToDeleteRows = False
        Me.dgv_ABM_Detalle_Viaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ABM_Detalle_Viaje.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tipo_carga, Me.volumen, Me.toneladas, Me.id_tipo_carga})
        Me.dgv_ABM_Detalle_Viaje.Location = New System.Drawing.Point(292, 12)
        Me.dgv_ABM_Detalle_Viaje.Name = "dgv_ABM_Detalle_Viaje"
        Me.dgv_ABM_Detalle_Viaje.ReadOnly = True
        Me.dgv_ABM_Detalle_Viaje.Size = New System.Drawing.Size(343, 178)
        Me.dgv_ABM_Detalle_Viaje.TabIndex = 25
        '
        'tipo_carga
        '
        Me.tipo_carga.DataPropertyName = "nombre"
        Me.tipo_carga.HeaderText = "Tipo Carga"
        Me.tipo_carga.Name = "tipo_carga"
        Me.tipo_carga.ReadOnly = True
        '
        'volumen
        '
        Me.volumen.DataPropertyName = "volumen"
        Me.volumen.HeaderText = "Volumen"
        Me.volumen.Name = "volumen"
        Me.volumen.ReadOnly = True
        '
        'toneladas
        '
        Me.toneladas.DataPropertyName = "toneladas"
        Me.toneladas.HeaderText = "Toneladas"
        Me.toneladas.Name = "toneladas"
        Me.toneladas.ReadOnly = True
        '
        'id_tipo_carga
        '
        Me.id_tipo_carga.DataPropertyName = "tipo_carga"
        Me.id_tipo_carga.HeaderText = "id_tipo_carga"
        Me.id_tipo_carga.Name = "id_tipo_carga"
        Me.id_tipo_carga.ReadOnly = True
        Me.id_tipo_carga.Visible = False
        '
        'ABM_Detalle_Viajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 256)
        Me.Controls.Add(Me.dgv_ABM_Detalle_Viaje)
        Me.Controls.Add(Me.lbl_alerta)
        Me.Controls.Add(Me.btn_eliminar_detalle_viaje)
        Me.Controls.Add(Me.chbx_confirmacion_detalle_viaje)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_crear_detalle_viaje)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.grp_viaje)
        Me.Name = "ABM_Detalle_Viajes"
        Me.Text = "ABM Detalle Viajes"
        Me.grp_viaje.ResumeLayout(False)
        Me.grp_viaje.PerformLayout()
        CType(Me.dgv_ABM_Detalle_Viaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_viaje As System.Windows.Forms.GroupBox
    Friend WithEvents mtb_fecha_salida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbx_tipo_carga As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_crear_detalle_viaje As System.Windows.Forms.Button
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_toneladas As System.Windows.Forms.TextBox
    Friend WithEvents txt_volumen As System.Windows.Forms.TextBox
    Friend WithEvents chbx_confirmacion_detalle_viaje As System.Windows.Forms.CheckBox
    Friend WithEvents btn_eliminar_detalle_viaje As System.Windows.Forms.Button
    Friend WithEvents lbl_toneladas As System.Windows.Forms.Label
    Friend WithEvents lbl_volumen As System.Windows.Forms.Label
    Friend WithEvents lbl_carga As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents dgv_ABM_Detalle_Viaje As System.Windows.Forms.DataGridView
    Friend WithEvents tipo_carga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents volumen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toneladas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_carga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_patente As System.Windows.Forms.TextBox
    Friend WithEvents btn_crear_carga As System.Windows.Forms.Button
End Class
