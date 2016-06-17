<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Camion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtb_patente = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbx_marca = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_modelo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_kilometraje_inicial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_año = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.patente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mjeError = New System.Windows.Forms.Label()
        Me.error1 = New System.Windows.Forms.Label()
        Me.error2 = New System.Windows.Forms.Label()
        Me.error3 = New System.Windows.Forms.Label()
        Me.error4 = New System.Windows.Forms.Label()
        Me.error5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.error5)
        Me.GroupBox1.Controls.Add(Me.error4)
        Me.GroupBox1.Controls.Add(Me.error3)
        Me.GroupBox1.Controls.Add(Me.error2)
        Me.GroupBox1.Controls.Add(Me.error1)
        Me.GroupBox1.Controls.Add(Me.mjeError)
        Me.GroupBox1.Controls.Add(Me.mtb_patente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbx_marca)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbx_modelo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_kilometraje_inicial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_año)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 183)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Camion"
        '
        'mtb_patente
        '
        Me.mtb_patente.Location = New System.Drawing.Point(72, 36)
        Me.mtb_patente.Mask = "LLL-999"
        Me.mtb_patente.Name = "mtb_patente"
        Me.mtb_patente.Size = New System.Drawing.Size(150, 20)
        Me.mtb_patente.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Año: "
        '
        'cbx_marca
        '
        Me.cbx_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_marca.FormattingEnabled = True
        Me.cbx_marca.Location = New System.Drawing.Point(72, 69)
        Me.cbx_marca.Name = "cbx_marca"
        Me.cbx_marca.Size = New System.Drawing.Size(150, 21)
        Me.cbx_marca.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Marca: "
        '
        'cbx_modelo
        '
        Me.cbx_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_modelo.FormattingEnabled = True
        Me.cbx_modelo.Location = New System.Drawing.Point(295, 65)
        Me.cbx_modelo.Name = "cbx_modelo"
        Me.cbx_modelo.Size = New System.Drawing.Size(143, 21)
        Me.cbx_modelo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(241, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Modelo: "
        '
        'txt_kilometraje_inicial
        '
        Me.txt_kilometraje_inicial.Location = New System.Drawing.Point(103, 105)
        Me.txt_kilometraje_inicial.Name = "txt_kilometraje_inicial"
        Me.txt_kilometraje_inicial.Size = New System.Drawing.Size(150, 20)
        Me.txt_kilometraje_inicial.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kilometraje inicial:"
        '
        'txt_año
        '
        Me.txt_año.Location = New System.Drawing.Point(295, 36)
        Me.txt_año.Name = "txt_año"
        Me.txt_año.Size = New System.Drawing.Size(143, 20)
        Me.txt_año.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patente:"
        '
        'btn_insertar
        '
        Me.btn_insertar.Location = New System.Drawing.Point(27, 441)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(75, 23)
        Me.btn_insertar.TabIndex = 0
        Me.btn_insertar.Text = "Insertar"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(394, 441)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar.TabIndex = 1
        Me.btn_modificar.Text = "Volver"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.patente, Me.año, Me.marca, Me.modelo})
        Me.DataGridView1.Location = New System.Drawing.Point(27, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 206)
        Me.DataGridView1.TabIndex = 3
        '
        'patente
        '
        Me.patente.HeaderText = "Patente"
        Me.patente.Name = "patente"
        '
        'año
        '
        Me.año.HeaderText = "Año"
        Me.año.Name = "año"
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        '
        'mjeError
        '
        Me.mjeError.AutoSize = True
        Me.mjeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mjeError.ForeColor = System.Drawing.Color.Red
        Me.mjeError.Location = New System.Drawing.Point(10, 164)
        Me.mjeError.Name = "mjeError"
        Me.mjeError.Size = New System.Drawing.Size(167, 13)
        Me.mjeError.TabIndex = 11
        Me.mjeError.Text = "Debe completar los campos!"
        Me.mjeError.Visible = False
        '
        'error1
        '
        Me.error1.AutoSize = True
        Me.error1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error1.ForeColor = System.Drawing.Color.Red
        Me.error1.Location = New System.Drawing.Point(228, 36)
        Me.error1.Name = "error1"
        Me.error1.Size = New System.Drawing.Size(12, 13)
        Me.error1.TabIndex = 12
        Me.error1.Text = "*"
        Me.error1.Visible = False
        '
        'error2
        '
        Me.error2.AutoSize = True
        Me.error2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error2.ForeColor = System.Drawing.Color.Red
        Me.error2.Location = New System.Drawing.Point(438, 39)
        Me.error2.Name = "error2"
        Me.error2.Size = New System.Drawing.Size(12, 13)
        Me.error2.TabIndex = 13
        Me.error2.Text = "*"
        Me.error2.Visible = False
        '
        'error3
        '
        Me.error3.AutoSize = True
        Me.error3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error3.ForeColor = System.Drawing.Color.Red
        Me.error3.Location = New System.Drawing.Point(223, 77)
        Me.error3.Name = "error3"
        Me.error3.Size = New System.Drawing.Size(12, 13)
        Me.error3.TabIndex = 14
        Me.error3.Text = "*"
        Me.error3.Visible = False
        '
        'error4
        '
        Me.error4.AutoSize = True
        Me.error4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error4.ForeColor = System.Drawing.Color.Red
        Me.error4.Location = New System.Drawing.Point(438, 69)
        Me.error4.Name = "error4"
        Me.error4.Size = New System.Drawing.Size(12, 13)
        Me.error4.TabIndex = 15
        Me.error4.Text = "*"
        Me.error4.Visible = False
        '
        'error5
        '
        Me.error5.AutoSize = True
        Me.error5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error5.ForeColor = System.Drawing.Color.Red
        Me.error5.Location = New System.Drawing.Point(259, 108)
        Me.error5.Name = "error5"
        Me.error5.Size = New System.Drawing.Size(12, 13)
        Me.error5.TabIndex = 16
        Me.error5.Text = "*"
        Me.error5.Visible = False
        '
        'Camion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 476)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Camion"
        Me.Text = "Camion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_año As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbx_marca As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbx_modelo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_kilometraje_inicial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_insertar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents mtb_patente As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents patente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents año As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents error5 As System.Windows.Forms.Label
    Friend WithEvents error4 As System.Windows.Forms.Label
    Friend WithEvents error3 As System.Windows.Forms.Label
    Friend WithEvents error2 As System.Windows.Forms.Label
    Friend WithEvents error1 As System.Windows.Forms.Label
    Friend WithEvents mjeError As System.Windows.Forms.Label
End Class
