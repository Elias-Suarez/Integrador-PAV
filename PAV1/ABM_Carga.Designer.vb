<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Carga
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
        Me.btn_crear_carga = New System.Windows.Forms.Button()
        Me.btn_guardar_carga = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_descripcion_carga = New System.Windows.Forms.TextBox()
        Me.txt_nombre_carga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbx_ABM_Cargas = New System.Windows.Forms.ListBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.lbl_alerta = New System.Windows.Forms.Label()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.chbx_confirma_tipo_carga = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_crear_carga
        '
        Me.btn_crear_carga.Location = New System.Drawing.Point(315, 190)
        Me.btn_crear_carga.Name = "btn_crear_carga"
        Me.btn_crear_carga.Size = New System.Drawing.Size(67, 23)
        Me.btn_crear_carga.TabIndex = 2
        Me.btn_crear_carga.Text = "Crear"
        Me.btn_crear_carga.UseVisualStyleBackColor = True
        '
        'btn_guardar_carga
        '
        Me.btn_guardar_carga.Location = New System.Drawing.Point(174, 190)
        Me.btn_guardar_carga.Name = "btn_guardar_carga"
        Me.btn_guardar_carga.Size = New System.Drawing.Size(67, 23)
        Me.btn_guardar_carga.TabIndex = 1
        Me.btn_guardar_carga.Text = "Guardar"
        Me.btn_guardar_carga.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_descripcion)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion_carga)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_carga)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 133)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Carga"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.ForeColor = System.Drawing.Color.Red
        Me.lbl_descripcion.Location = New System.Drawing.Point(219, 55)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(11, 13)
        Me.lbl_descripcion.TabIndex = 24
        Me.lbl_descripcion.Text = "*"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Red
        Me.lbl_nombre.Location = New System.Drawing.Point(218, 22)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(11, 13)
        Me.lbl_nombre.TabIndex = 24
        Me.lbl_nombre.Text = "*"
        '
        'txt_descripcion_carga
        '
        Me.txt_descripcion_carga.Location = New System.Drawing.Point(72, 45)
        Me.txt_descripcion_carga.Multiline = True
        Me.txt_descripcion_carga.Name = "txt_descripcion_carga"
        Me.txt_descripcion_carga.Size = New System.Drawing.Size(141, 82)
        Me.txt_descripcion_carga.TabIndex = 2
        '
        'txt_nombre_carga
        '
        Me.txt_nombre_carga.Location = New System.Drawing.Point(71, 19)
        Me.txt_nombre_carga.Name = "txt_nombre_carga"
        Me.txt_nombre_carga.Size = New System.Drawing.Size(141, 20)
        Me.txt_nombre_carga.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Descripción: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre: "
        '
        'lbx_ABM_Cargas
        '
        Me.lbx_ABM_Cargas.FormattingEnabled = True
        Me.lbx_ABM_Cargas.Location = New System.Drawing.Point(252, 12)
        Me.lbx_ABM_Cargas.Name = "lbx_ABM_Cargas"
        Me.lbx_ABM_Cargas.Size = New System.Drawing.Size(279, 147)
        Me.lbx_ABM_Cargas.TabIndex = 3
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(12, 190)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(67, 23)
        Me.btn_eliminar.TabIndex = 23
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'lbl_alerta
        '
        Me.lbl_alerta.AutoSize = True
        Me.lbl_alerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta.Location = New System.Drawing.Point(19, 148)
        Me.lbl_alerta.Name = "lbl_alerta"
        Me.lbl_alerta.Size = New System.Drawing.Size(227, 16)
        Me.lbl_alerta.TabIndex = 24
        Me.lbl_alerta.Text = "Necesita completar los campos"
        Me.lbl_alerta.Visible = False
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(464, 190)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(67, 23)
        Me.btn_volver.TabIndex = 2
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'chbx_confirma_tipo_carga
        '
        Me.chbx_confirma_tipo_carga.AutoSize = True
        Me.chbx_confirma_tipo_carga.Location = New System.Drawing.Point(12, 167)
        Me.chbx_confirma_tipo_carga.Name = "chbx_confirma_tipo_carga"
        Me.chbx_confirma_tipo_carga.Size = New System.Drawing.Size(257, 17)
        Me.chbx_confirma_tipo_carga.TabIndex = 0
        Me.chbx_confirma_tipo_carga.Text = "Confirmo que los datos ingresados son correctos."
        Me.chbx_confirma_tipo_carga.UseVisualStyleBackColor = True
        '
        'ABM_Carga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(543, 225)
        Me.Controls.Add(Me.lbl_alerta)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.chbx_confirma_tipo_carga)
        Me.Controls.Add(Me.lbx_ABM_Cargas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_crear_carga)
        Me.Controls.Add(Me.btn_guardar_carga)
        Me.Name = "ABM_Carga"
        Me.Text = "ABM_Carga"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_crear_carga As System.Windows.Forms.Button
    Friend WithEvents btn_guardar_carga As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbx_ABM_Cargas As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion_carga As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_carga As System.Windows.Forms.TextBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents lbl_carga As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbx_tipo_carga As System.Windows.Forms.ComboBox
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents chbx_confirma_tipo_carga As System.Windows.Forms.CheckBox
End Class
