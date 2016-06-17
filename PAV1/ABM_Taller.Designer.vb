<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Taller
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
        Me.error1 = New System.Windows.Forms.Label()
        Me.cboLocalidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreTaller = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoTaller = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grillaTaller = New System.Windows.Forms.DataGridView()
        Me.codigo_taller = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.error3 = New System.Windows.Forms.Label()
        Me.error2 = New System.Windows.Forms.Label()
        Me.error4 = New System.Windows.Forms.Label()
        Me.mjeError = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grillaTaller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mjeError)
        Me.GroupBox1.Controls.Add(Me.error4)
        Me.GroupBox1.Controls.Add(Me.error2)
        Me.GroupBox1.Controls.Add(Me.error3)
        Me.GroupBox1.Controls.Add(Me.error1)
        Me.GroupBox1.Controls.Add(Me.cboLocalidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboProvincia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombreTaller)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigoTaller)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'error1
        '
        Me.error1.AutoSize = True
        Me.error1.ForeColor = System.Drawing.Color.Red
        Me.error1.Location = New System.Drawing.Point(348, 53)
        Me.error1.Name = "error1"
        Me.error1.Size = New System.Drawing.Size(11, 13)
        Me.error1.TabIndex = 10
        Me.error1.Text = "*"
        Me.error1.Visible = False
        '
        'cboLocalidad
        '
        Me.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocalidad.FormattingEnabled = True
        Me.cboLocalidad.Location = New System.Drawing.Point(321, 106)
        Me.cboLocalidad.Name = "cboLocalidad"
        Me.cboLocalidad.Size = New System.Drawing.Size(121, 21)
        Me.cboLocalidad.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(256, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Localidad: "
        '
        'cboProvincia
        '
        Me.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(97, 106)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(121, 21)
        Me.cboProvincia.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Provincia:"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(97, 80)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(302, 20)
        Me.txtDomicilio.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Domicilio:"
        '
        'txtNombreTaller
        '
        Me.txtNombreTaller.Location = New System.Drawing.Point(97, 53)
        Me.txtNombreTaller.Name = "txtNombreTaller"
        Me.txtNombreTaller.Size = New System.Drawing.Size(245, 20)
        Me.txtNombreTaller.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'txtCodigoTaller
        '
        Me.txtCodigoTaller.Location = New System.Drawing.Point(97, 22)
        Me.txtCodigoTaller.Name = "txtCodigoTaller"
        Me.txtCodigoTaller.ReadOnly = True
        Me.txtCodigoTaller.Size = New System.Drawing.Size(108, 20)
        Me.txtCodigoTaller.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Taller:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grillaTaller)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(497, 120)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'grillaTaller
        '
        Me.grillaTaller.AllowUserToAddRows = False
        Me.grillaTaller.AllowUserToDeleteRows = False
        Me.grillaTaller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaTaller.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo_taller, Me.nombre, Me.domicilio, Me.localidad})
        Me.grillaTaller.Location = New System.Drawing.Point(12, 20)
        Me.grillaTaller.Name = "grillaTaller"
        Me.grillaTaller.ReadOnly = True
        Me.grillaTaller.Size = New System.Drawing.Size(479, 79)
        Me.grillaTaller.TabIndex = 0
        '
        'codigo_taller
        '
        Me.codigo_taller.HeaderText = "Codigo "
        Me.codigo_taller.Name = "codigo_taller"
        Me.codigo_taller.ReadOnly = True
        Me.codigo_taller.Width = 70
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'domicilio
        '
        Me.domicilio.HeaderText = "Domicilio"
        Me.domicilio.Name = "domicilio"
        Me.domicilio.ReadOnly = True
        Me.domicilio.Width = 200
        '
        'localidad
        '
        Me.localidad.HeaderText = "Localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(24, 350)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(125, 350)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar Carga"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(434, 350)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'error3
        '
        Me.error3.AutoSize = True
        Me.error3.ForeColor = System.Drawing.Color.Red
        Me.error3.Location = New System.Drawing.Point(224, 109)
        Me.error3.Name = "error3"
        Me.error3.Size = New System.Drawing.Size(11, 13)
        Me.error3.TabIndex = 11
        Me.error3.Text = "*"
        Me.error3.Visible = False
        '
        'error2
        '
        Me.error2.AutoSize = True
        Me.error2.ForeColor = System.Drawing.Color.Red
        Me.error2.Location = New System.Drawing.Point(405, 80)
        Me.error2.Name = "error2"
        Me.error2.Size = New System.Drawing.Size(11, 13)
        Me.error2.TabIndex = 12
        Me.error2.Text = "*"
        Me.error2.Visible = False
        '
        'error4
        '
        Me.error4.AutoSize = True
        Me.error4.ForeColor = System.Drawing.Color.Red
        Me.error4.Location = New System.Drawing.Point(448, 106)
        Me.error4.Name = "error4"
        Me.error4.Size = New System.Drawing.Size(11, 13)
        Me.error4.TabIndex = 13
        Me.error4.Text = "*"
        Me.error4.Visible = False
        '
        'mjeError
        '
        Me.mjeError.AutoSize = True
        Me.mjeError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mjeError.ForeColor = System.Drawing.Color.Red
        Me.mjeError.Location = New System.Drawing.Point(24, 145)
        Me.mjeError.Name = "mjeError"
        Me.mjeError.Size = New System.Drawing.Size(199, 13)
        Me.mjeError.TabIndex = 14
        Me.mjeError.Text = "Debe Completar todos los campos"
        Me.mjeError.Visible = False
        '
        'ABM_Taller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 385)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ABM_Taller"
        Me.Text = "ABM_Taller"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grillaTaller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombreTaller As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoTaller As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grillaTaller As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents codigo_taller As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents error1 As System.Windows.Forms.Label
    Friend WithEvents error4 As System.Windows.Forms.Label
    Friend WithEvents error2 As System.Windows.Forms.Label
    Friend WithEvents error3 As System.Windows.Forms.Label
    Friend WithEvents mjeError As System.Windows.Forms.Label
End Class
