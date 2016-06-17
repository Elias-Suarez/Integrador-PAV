<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Detalle_Mantenimiento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_patente = New System.Windows.Forms.TextBox()
        Me.grp_mantenimiento = New System.Windows.Forms.GroupBox()
        Me.mtb_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.grp_trabajos = New System.Windows.Forms.GroupBox()
        Me.cmb_trabajo = New System.Windows.Forms.ComboBox()
        Me.lbl_alerta_costo = New System.Windows.Forms.Label()
        Me.lbl_alerta_trabajo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_costo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_trabajos = New System.Windows.Forms.DataGridView()
        Me.clm_trabajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_id_trabajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm_costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.chk_confirmar = New System.Windows.Forms.CheckBox()
        Me.btn_mas = New System.Windows.Forms.Button()
        Me.grp_mantenimiento.SuspendLayout()
        Me.grp_trabajos.SuspendLayout()
        CType(Me.dgv_trabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha"
        '
        'txt_patente
        '
        Me.txt_patente.Location = New System.Drawing.Point(56, 22)
        Me.txt_patente.Name = "txt_patente"
        Me.txt_patente.Size = New System.Drawing.Size(100, 20)
        Me.txt_patente.TabIndex = 0
        '
        'grp_mantenimiento
        '
        Me.grp_mantenimiento.Controls.Add(Me.mtb_fecha)
        Me.grp_mantenimiento.Controls.Add(Me.Label1)
        Me.grp_mantenimiento.Controls.Add(Me.Label2)
        Me.grp_mantenimiento.Controls.Add(Me.txt_patente)
        Me.grp_mantenimiento.Location = New System.Drawing.Point(12, 12)
        Me.grp_mantenimiento.Name = "grp_mantenimiento"
        Me.grp_mantenimiento.Size = New System.Drawing.Size(226, 80)
        Me.grp_mantenimiento.TabIndex = 0
        Me.grp_mantenimiento.TabStop = False
        Me.grp_mantenimiento.Text = "Mantenimiento"
        '
        'mtb_fecha
        '
        Me.mtb_fecha.Location = New System.Drawing.Point(56, 48)
        Me.mtb_fecha.Mask = "00/00/0000"
        Me.mtb_fecha.Name = "mtb_fecha"
        Me.mtb_fecha.Size = New System.Drawing.Size(100, 20)
        Me.mtb_fecha.TabIndex = 1
        Me.mtb_fecha.ValidatingType = GetType(Date)
        '
        'grp_trabajos
        '
        Me.grp_trabajos.Controls.Add(Me.btn_mas)
        Me.grp_trabajos.Controls.Add(Me.cmb_trabajo)
        Me.grp_trabajos.Controls.Add(Me.lbl_alerta_costo)
        Me.grp_trabajos.Controls.Add(Me.lbl_alerta_trabajo)
        Me.grp_trabajos.Controls.Add(Me.Label3)
        Me.grp_trabajos.Controls.Add(Me.txt_costo)
        Me.grp_trabajos.Controls.Add(Me.Label4)
        Me.grp_trabajos.Location = New System.Drawing.Point(13, 102)
        Me.grp_trabajos.Name = "grp_trabajos"
        Me.grp_trabajos.Size = New System.Drawing.Size(225, 77)
        Me.grp_trabajos.TabIndex = 1
        Me.grp_trabajos.TabStop = False
        Me.grp_trabajos.Text = "Trabajos de Mantenimiento"
        '
        'cmb_trabajo
        '
        Me.cmb_trabajo.FormattingEnabled = True
        Me.cmb_trabajo.Location = New System.Drawing.Point(55, 18)
        Me.cmb_trabajo.Name = "cmb_trabajo"
        Me.cmb_trabajo.Size = New System.Drawing.Size(122, 21)
        Me.cmb_trabajo.TabIndex = 0
        '
        'lbl_alerta_costo
        '
        Me.lbl_alerta_costo.AutoSize = True
        Me.lbl_alerta_costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta_costo.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_costo.Location = New System.Drawing.Point(183, 49)
        Me.lbl_alerta_costo.Name = "lbl_alerta_costo"
        Me.lbl_alerta_costo.Size = New System.Drawing.Size(13, 16)
        Me.lbl_alerta_costo.TabIndex = 0
        Me.lbl_alerta_costo.Text = "*"
        '
        'lbl_alerta_trabajo
        '
        Me.lbl_alerta_trabajo.AutoSize = True
        Me.lbl_alerta_trabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta_trabajo.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_trabajo.Location = New System.Drawing.Point(183, 23)
        Me.lbl_alerta_trabajo.Name = "lbl_alerta_trabajo"
        Me.lbl_alerta_trabajo.Size = New System.Drawing.Size(13, 16)
        Me.lbl_alerta_trabajo.TabIndex = 0
        Me.lbl_alerta_trabajo.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Trabajo"
        '
        'txt_costo
        '
        Me.txt_costo.Location = New System.Drawing.Point(55, 45)
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Size = New System.Drawing.Size(122, 20)
        Me.txt_costo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Costo"
        '
        'dgv_trabajos
        '
        Me.dgv_trabajos.AllowUserToAddRows = False
        Me.dgv_trabajos.AllowUserToDeleteRows = False
        Me.dgv_trabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_trabajos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm_trabajo, Me.clm_id_trabajo, Me.clm_costo})
        Me.dgv_trabajos.Location = New System.Drawing.Point(244, 12)
        Me.dgv_trabajos.Name = "dgv_trabajos"
        Me.dgv_trabajos.ReadOnly = True
        Me.dgv_trabajos.Size = New System.Drawing.Size(257, 167)
        Me.dgv_trabajos.TabIndex = 3
        '
        'clm_trabajo
        '
        Me.clm_trabajo.DataPropertyName = "nombre"
        Me.clm_trabajo.HeaderText = "Trabajo"
        Me.clm_trabajo.Name = "clm_trabajo"
        Me.clm_trabajo.ReadOnly = True
        '
        'clm_id_trabajo
        '
        Me.clm_id_trabajo.DataPropertyName = "id"
        Me.clm_id_trabajo.HeaderText = "ID Trabajo"
        Me.clm_id_trabajo.Name = "clm_id_trabajo"
        Me.clm_id_trabajo.ReadOnly = True
        Me.clm_id_trabajo.Visible = False
        '
        'clm_costo
        '
        Me.clm_costo.DataPropertyName = "costo"
        Me.clm_costo.HeaderText = "Costo"
        Me.clm_costo.Name = "clm_costo"
        Me.clm_costo.ReadOnly = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(397, 208)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 7
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_crear
        '
        Me.btn_crear.Location = New System.Drawing.Point(274, 208)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(74, 23)
        Me.btn_crear.TabIndex = 6
        Me.btn_crear.Text = "Crear"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(147, 208)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 5
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(12, 208)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'chk_confirmar
        '
        Me.chk_confirmar.AutoSize = True
        Me.chk_confirmar.Location = New System.Drawing.Point(12, 185)
        Me.chk_confirmar.Name = "chk_confirmar"
        Me.chk_confirmar.Size = New System.Drawing.Size(257, 17)
        Me.chk_confirmar.TabIndex = 2
        Me.chk_confirmar.Text = "Confirmar que los datos ingresados son correctos"
        Me.chk_confirmar.UseVisualStyleBackColor = True
        '
        'btn_mas
        '
        Me.btn_mas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mas.Location = New System.Drawing.Point(199, 18)
        Me.btn_mas.Name = "btn_mas"
        Me.btn_mas.Size = New System.Drawing.Size(20, 23)
        Me.btn_mas.TabIndex = 2
        Me.btn_mas.Text = "+"
        Me.btn_mas.UseVisualStyleBackColor = True
        '
        'ABM_Detalle_Mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 244)
        Me.Controls.Add(Me.chk_confirmar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.dgv_trabajos)
        Me.Controls.Add(Me.grp_trabajos)
        Me.Controls.Add(Me.grp_mantenimiento)
        Me.Name = "ABM_Detalle_Mantenimiento"
        Me.Text = "ABM_Detalle_Mantenimiento"
        Me.grp_mantenimiento.ResumeLayout(False)
        Me.grp_mantenimiento.PerformLayout()
        Me.grp_trabajos.ResumeLayout(False)
        Me.grp_trabajos.PerformLayout()
        CType(Me.dgv_trabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_patente As System.Windows.Forms.TextBox
    Friend WithEvents grp_mantenimiento As System.Windows.Forms.GroupBox
    Friend WithEvents grp_trabajos As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_trabajo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_alerta_costo As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta_trabajo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_costo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgv_trabajos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents btn_crear As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents chk_confirmar As System.Windows.Forms.CheckBox
    Friend WithEvents mtb_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents clm_trabajo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_id_trabajo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm_costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_mas As System.Windows.Forms.Button
End Class
