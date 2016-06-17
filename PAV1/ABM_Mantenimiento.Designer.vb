<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Mantenimiento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbx_mantenimiento = New System.Windows.Forms.GroupBox()
        Me.lbl_alerta_fecha = New System.Windows.Forms.Label()
        Me.lbl_alerta_patente = New System.Windows.Forms.Label()
        Me.mtb_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.cmb_patente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbx_datos = New System.Windows.Forms.GroupBox()
        Me.lbl_alerta_taller = New System.Windows.Forms.Label()
        Me.lbl_alerta_kilometros = New System.Windows.Forms.Label()
        Me.txt_kilometros = New System.Windows.Forms.TextBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_taller = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_mantenimiento = New System.Windows.Forms.DataGridView()
        Me.patente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_taller = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taller = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kilometraje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.chk_confirma = New System.Windows.Forms.CheckBox()
        Me.gbx_mantenimiento.SuspendLayout()
        Me.gbx_datos.SuspendLayout()
        CType(Me.dgv_mantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patente"
        '
        'gbx_mantenimiento
        '
        Me.gbx_mantenimiento.Controls.Add(Me.lbl_alerta_fecha)
        Me.gbx_mantenimiento.Controls.Add(Me.lbl_alerta_patente)
        Me.gbx_mantenimiento.Controls.Add(Me.mtb_fecha)
        Me.gbx_mantenimiento.Controls.Add(Me.btn_crear)
        Me.gbx_mantenimiento.Controls.Add(Me.cmb_patente)
        Me.gbx_mantenimiento.Controls.Add(Me.Label2)
        Me.gbx_mantenimiento.Controls.Add(Me.Label1)
        Me.gbx_mantenimiento.Location = New System.Drawing.Point(12, 12)
        Me.gbx_mantenimiento.Name = "gbx_mantenimiento"
        Me.gbx_mantenimiento.Size = New System.Drawing.Size(428, 75)
        Me.gbx_mantenimiento.TabIndex = 0
        Me.gbx_mantenimiento.TabStop = False
        Me.gbx_mantenimiento.Text = "Mantenimiento"
        '
        'lbl_alerta_fecha
        '
        Me.lbl_alerta_fecha.AutoSize = True
        Me.lbl_alerta_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta_fecha.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_fecha.Location = New System.Drawing.Point(388, 26)
        Me.lbl_alerta_fecha.Name = "lbl_alerta_fecha"
        Me.lbl_alerta_fecha.Size = New System.Drawing.Size(12, 13)
        Me.lbl_alerta_fecha.TabIndex = 4
        Me.lbl_alerta_fecha.Text = "*"
        '
        'lbl_alerta_patente
        '
        Me.lbl_alerta_patente.AutoSize = True
        Me.lbl_alerta_patente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta_patente.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_patente.Location = New System.Drawing.Point(190, 26)
        Me.lbl_alerta_patente.Name = "lbl_alerta_patente"
        Me.lbl_alerta_patente.Size = New System.Drawing.Size(12, 13)
        Me.lbl_alerta_patente.TabIndex = 4
        Me.lbl_alerta_patente.Text = "*"
        '
        'mtb_fecha
        '
        Me.mtb_fecha.Location = New System.Drawing.Point(282, 19)
        Me.mtb_fecha.Mask = "00/00/0000"
        Me.mtb_fecha.Name = "mtb_fecha"
        Me.mtb_fecha.Size = New System.Drawing.Size(100, 20)
        Me.mtb_fecha.TabIndex = 1
        Me.mtb_fecha.ValidatingType = GetType(Date)
        '
        'btn_crear
        '
        Me.btn_crear.Location = New System.Drawing.Point(307, 45)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(75, 23)
        Me.btn_crear.TabIndex = 2
        Me.btn_crear.Text = "Crear"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'cmb_patente
        '
        Me.cmb_patente.FormattingEnabled = True
        Me.cmb_patente.Location = New System.Drawing.Point(63, 19)
        Me.cmb_patente.Name = "cmb_patente"
        Me.cmb_patente.Size = New System.Drawing.Size(121, 21)
        Me.cmb_patente.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha"
        '
        'gbx_datos
        '
        Me.gbx_datos.Controls.Add(Me.lbl_alerta_taller)
        Me.gbx_datos.Controls.Add(Me.lbl_alerta_kilometros)
        Me.gbx_datos.Controls.Add(Me.txt_kilometros)
        Me.gbx_datos.Controls.Add(Me.btn_limpiar)
        Me.gbx_datos.Controls.Add(Me.Label3)
        Me.gbx_datos.Controls.Add(Me.cmb_taller)
        Me.gbx_datos.Controls.Add(Me.Label4)
        Me.gbx_datos.Location = New System.Drawing.Point(12, 93)
        Me.gbx_datos.Name = "gbx_datos"
        Me.gbx_datos.Size = New System.Drawing.Size(428, 85)
        Me.gbx_datos.TabIndex = 1
        Me.gbx_datos.TabStop = False
        Me.gbx_datos.Text = "Datos de Mantenimiento"
        '
        'lbl_alerta_taller
        '
        Me.lbl_alerta_taller.AutoSize = True
        Me.lbl_alerta_taller.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta_taller.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_taller.Location = New System.Drawing.Point(190, 37)
        Me.lbl_alerta_taller.Name = "lbl_alerta_taller"
        Me.lbl_alerta_taller.Size = New System.Drawing.Size(12, 13)
        Me.lbl_alerta_taller.TabIndex = 4
        Me.lbl_alerta_taller.Text = "*"
        '
        'lbl_alerta_kilometros
        '
        Me.lbl_alerta_kilometros.AutoSize = True
        Me.lbl_alerta_kilometros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta_kilometros.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_kilometros.Location = New System.Drawing.Point(388, 36)
        Me.lbl_alerta_kilometros.Name = "lbl_alerta_kilometros"
        Me.lbl_alerta_kilometros.Size = New System.Drawing.Size(12, 13)
        Me.lbl_alerta_kilometros.TabIndex = 4
        Me.lbl_alerta_kilometros.Text = "*"
        '
        'txt_kilometros
        '
        Me.txt_kilometros.Location = New System.Drawing.Point(282, 29)
        Me.txt_kilometros.Name = "txt_kilometros"
        Me.txt_kilometros.Size = New System.Drawing.Size(100, 20)
        Me.txt_kilometros.TabIndex = 1
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(307, 55)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 2
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Taller"
        '
        'cmb_taller
        '
        Me.cmb_taller.FormattingEnabled = True
        Me.cmb_taller.Location = New System.Drawing.Point(63, 29)
        Me.cmb_taller.Name = "cmb_taller"
        Me.cmb_taller.Size = New System.Drawing.Size(121, 21)
        Me.cmb_taller.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Kilometros"
        '
        'dgv_mantenimiento
        '
        Me.dgv_mantenimiento.AllowUserToAddRows = False
        Me.dgv_mantenimiento.AllowUserToDeleteRows = False
        Me.dgv_mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mantenimiento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.patente, Me.fecha, Me.cod_taller, Me.taller, Me.kilometraje})
        Me.dgv_mantenimiento.Location = New System.Drawing.Point(12, 184)
        Me.dgv_mantenimiento.Name = "dgv_mantenimiento"
        Me.dgv_mantenimiento.ReadOnly = True
        Me.dgv_mantenimiento.Size = New System.Drawing.Size(428, 120)
        Me.dgv_mantenimiento.TabIndex = 2
        '
        'patente
        '
        Me.patente.DataPropertyName = "patente"
        Me.patente.HeaderText = "Patente"
        Me.patente.Name = "patente"
        Me.patente.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'cod_taller
        '
        Me.cod_taller.DataPropertyName = "cod_taller"
        Me.cod_taller.HeaderText = "Cod Taller"
        Me.cod_taller.Name = "cod_taller"
        Me.cod_taller.ReadOnly = True
        Me.cod_taller.Visible = False
        '
        'taller
        '
        Me.taller.DataPropertyName = "nombre_taller"
        Me.taller.HeaderText = "Taller"
        Me.taller.Name = "taller"
        Me.taller.ReadOnly = True
        '
        'kilometraje
        '
        Me.kilometraje.DataPropertyName = "kilometraje"
        Me.kilometraje.HeaderText = "Kilometraje"
        Me.kilometraje.Name = "kilometraje"
        Me.kilometraje.ReadOnly = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(365, 333)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 6
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(236, 333)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(97, 23)
        Me.btn_agregar.TabIndex = 5
        Me.btn_agregar.Text = "Agregar Trabajo"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(121, 333)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 4
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'chk_confirma
        '
        Me.chk_confirma.AutoSize = True
        Me.chk_confirma.Location = New System.Drawing.Point(13, 310)
        Me.chk_confirma.Name = "chk_confirma"
        Me.chk_confirma.Size = New System.Drawing.Size(257, 17)
        Me.chk_confirma.TabIndex = 3
        Me.chk_confirma.Text = "Confirmar que los datos ingresados son correctos"
        Me.chk_confirma.UseVisualStyleBackColor = True
        '
        'ABM_Mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 364)
        Me.Controls.Add(Me.chk_confirma)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.dgv_mantenimiento)
        Me.Controls.Add(Me.gbx_datos)
        Me.Controls.Add(Me.gbx_mantenimiento)
        Me.Name = "ABM_Mantenimiento"
        Me.Text = "ABM_Mantenimiento"
        Me.gbx_mantenimiento.ResumeLayout(False)
        Me.gbx_mantenimiento.PerformLayout()
        Me.gbx_datos.ResumeLayout(False)
        Me.gbx_datos.PerformLayout()
        CType(Me.dgv_mantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbx_mantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents mtb_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_crear As System.Windows.Forms.Button
    Friend WithEvents cmb_patente As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbx_datos As System.Windows.Forms.GroupBox
    Friend WithEvents txt_kilometros As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_taller As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgv_mantenimiento As System.Windows.Forms.DataGridView
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents chk_confirma As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_alerta_patente As System.Windows.Forms.Label
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents lbl_alerta_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta_taller As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta_kilometros As System.Windows.Forms.Label
    Friend WithEvents patente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_taller As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents taller As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kilometraje As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
