<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Trabajo
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
        Me.dgv_trabajos = New System.Windows.Forms.DataGridView()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtx_nombre = New System.Windows.Forms.TextBox()
        Me.chk_confirmar = New System.Windows.Forms.CheckBox()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_trabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_trabajos
        '
        Me.dgv_trabajos.AllowUserToAddRows = False
        Me.dgv_trabajos.AllowUserToDeleteRows = False
        Me.dgv_trabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_trabajos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.id})
        Me.dgv_trabajos.Location = New System.Drawing.Point(12, 38)
        Me.dgv_trabajos.Name = "dgv_trabajos"
        Me.dgv_trabajos.ReadOnly = True
        Me.dgv_trabajos.Size = New System.Drawing.Size(201, 186)
        Me.dgv_trabajos.TabIndex = 0
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(12, 253)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(55, 23)
        Me.btn_eliminar.TabIndex = 1
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(85, 253)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(59, 23)
        Me.btn_guardar.TabIndex = 1
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_crear
        '
        Me.btn_crear.Location = New System.Drawing.Point(161, 253)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(52, 23)
        Me.btn_crear.TabIndex = 1
        Me.btn_crear.Text = "Crear"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'txtx_nombre
        '
        Me.txtx_nombre.Location = New System.Drawing.Point(65, 12)
        Me.txtx_nombre.Name = "txtx_nombre"
        Me.txtx_nombre.Size = New System.Drawing.Size(148, 20)
        Me.txtx_nombre.TabIndex = 3
        '
        'chk_confirmar
        '
        Me.chk_confirmar.AutoSize = True
        Me.chk_confirmar.Location = New System.Drawing.Point(12, 230)
        Me.chk_confirmar.Name = "chk_confirmar"
        Me.chk_confirmar.Size = New System.Drawing.Size(120, 17)
        Me.chk_confirmar.TabIndex = 4
        Me.chk_confirmar.Text = "Confirmar operación"
        Me.chk_confirmar.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'ABM_Trabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 285)
        Me.Controls.Add(Me.chk_confirmar)
        Me.Controls.Add(Me.txtx_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.dgv_trabajos)
        Me.Name = "ABM_Trabajo"
        Me.Text = "ABM_Trabajo"
        CType(Me.dgv_trabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_trabajos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_crear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtx_nombre As System.Windows.Forms.TextBox
    Friend WithEvents chk_confirmar As System.Windows.Forms.CheckBox
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
