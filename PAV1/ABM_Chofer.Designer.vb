<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_Chofer
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
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.dgvChofer = New System.Windows.Forms.DataGridView()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_nacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel_fijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAlertaTelFijo = New System.Windows.Forms.Label()
        Me.lblFecIng = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblAlertaNombre = New System.Windows.Forms.Label()
        Me.lblAlertaCel = New System.Windows.Forms.Label()
        Me.lblAlertaFecNac = New System.Windows.Forms.Label()
        Me.lblAlertaTD = New System.Windows.Forms.Label()
        Me.lblAlertaApellido = New System.Windows.Forms.Label()
        Me.lblAlerta = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.mskTelFijo = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.mskFechaIngreso = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskFechaNac = New System.Windows.Forms.MaskedTextBox()
        Me.cmbTipoDni = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskDni = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvChofer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(220, 598)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(118, 38)
        Me.btnInsertar.TabIndex = 0
        Me.btnInsertar.Text = "Crear Chofer"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'dgvChofer
        '
        Me.dgvChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChofer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apellido, Me.nombre, Me.tipo_doc, Me.nro_doc, Me.fecha_nacimiento, Me.fecha_ingreso, Me.celular, Me.tel_fijo})
        Me.dgvChofer.Location = New System.Drawing.Point(37, 400)
        Me.dgvChofer.Name = "dgvChofer"
        Me.dgvChofer.Size = New System.Drawing.Size(631, 185)
        Me.dgvChofer.TabIndex = 25
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'tipo_doc
        '
        Me.tipo_doc.HeaderText = "Tipo dni"
        Me.tipo_doc.Name = "tipo_doc"
        '
        'nro_doc
        '
        Me.nro_doc.HeaderText = "Nro Documento"
        Me.nro_doc.Name = "nro_doc"
        '
        'fecha_nacimiento
        '
        Me.fecha_nacimiento.HeaderText = "fecha nacimiento"
        Me.fecha_nacimiento.Name = "fecha_nacimiento"
        '
        'fecha_ingreso
        '
        Me.fecha_ingreso.HeaderText = "Fecha ingreso"
        Me.fecha_ingreso.Name = "fecha_ingreso"
        '
        'celular
        '
        Me.celular.HeaderText = "celular"
        Me.celular.Name = "celular"
        '
        'tel_fijo
        '
        Me.tel_fijo.HeaderText = "Tel Fijo"
        Me.tel_fijo.Name = "tel_fijo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAlertaTelFijo)
        Me.GroupBox1.Controls.Add(Me.lblFecIng)
        Me.GroupBox1.Controls.Add(Me.lblDni)
        Me.GroupBox1.Controls.Add(Me.lblAlertaNombre)
        Me.GroupBox1.Controls.Add(Me.lblAlertaCel)
        Me.GroupBox1.Controls.Add(Me.lblAlertaFecNac)
        Me.GroupBox1.Controls.Add(Me.lblAlertaTD)
        Me.GroupBox1.Controls.Add(Me.lblAlertaApellido)
        Me.GroupBox1.Controls.Add(Me.lblAlerta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.mskTelFijo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCelular)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.mskFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mskFechaNac)
        Me.GroupBox1.Controls.Add(Me.cmbTipoDni)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.mskDni)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 332)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Chofer"
        '
        'lblAlertaTelFijo
        '
        Me.lblAlertaTelFijo.AutoSize = True
        Me.lblAlertaTelFijo.ForeColor = System.Drawing.Color.Red
        Me.lblAlertaTelFijo.Location = New System.Drawing.Point(467, 261)
        Me.lblAlertaTelFijo.Name = "lblAlertaTelFijo"
        Me.lblAlertaTelFijo.Size = New System.Drawing.Size(11, 13)
        Me.lblAlertaTelFijo.TabIndex = 17
        Me.lblAlertaTelFijo.Text = "*"
        Me.lblAlertaTelFijo.Visible = False
        '
        'lblFecIng
        '
        Me.lblFecIng.AutoSize = True
        Me.lblFecIng.ForeColor = System.Drawing.Color.Red
        Me.lblFecIng.Location = New System.Drawing.Point(467, 197)
        Me.lblFecIng.Name = "lblFecIng"
        Me.lblFecIng.Size = New System.Drawing.Size(11, 13)
        Me.lblFecIng.TabIndex = 16
        Me.lblFecIng.Text = "*"
        Me.lblFecIng.Visible = False
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.ForeColor = System.Drawing.Color.Red
        Me.lblDni.Location = New System.Drawing.Point(257, 61)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(11, 13)
        Me.lblDni.TabIndex = 15
        Me.lblDni.Text = "*"
        Me.lblDni.Visible = False
        '
        'lblAlertaNombre
        '
        Me.lblAlertaNombre.AutoSize = True
        Me.lblAlertaNombre.ForeColor = System.Drawing.Color.Red
        Me.lblAlertaNombre.Location = New System.Drawing.Point(585, 130)
        Me.lblAlertaNombre.Name = "lblAlertaNombre"
        Me.lblAlertaNombre.Size = New System.Drawing.Size(11, 13)
        Me.lblAlertaNombre.TabIndex = 14
        Me.lblAlertaNombre.Text = "*"
        Me.lblAlertaNombre.Visible = False
        '
        'lblAlertaCel
        '
        Me.lblAlertaCel.AutoSize = True
        Me.lblAlertaCel.ForeColor = System.Drawing.Color.Red
        Me.lblAlertaCel.Location = New System.Drawing.Point(257, 264)
        Me.lblAlertaCel.Name = "lblAlertaCel"
        Me.lblAlertaCel.Size = New System.Drawing.Size(11, 13)
        Me.lblAlertaCel.TabIndex = 13
        Me.lblAlertaCel.Text = "*"
        Me.lblAlertaCel.Visible = False
        '
        'lblAlertaFecNac
        '
        Me.lblAlertaFecNac.AutoSize = True
        Me.lblAlertaFecNac.ForeColor = System.Drawing.Color.Red
        Me.lblAlertaFecNac.Location = New System.Drawing.Point(158, 193)
        Me.lblAlertaFecNac.Name = "lblAlertaFecNac"
        Me.lblAlertaFecNac.Size = New System.Drawing.Size(11, 13)
        Me.lblAlertaFecNac.TabIndex = 12
        Me.lblAlertaFecNac.Text = "*"
        Me.lblAlertaFecNac.Visible = False
        '
        'lblAlertaTD
        '
        Me.lblAlertaTD.AutoSize = True
        Me.lblAlertaTD.ForeColor = System.Drawing.Color.Red
        Me.lblAlertaTD.Location = New System.Drawing.Point(511, 69)
        Me.lblAlertaTD.Name = "lblAlertaTD"
        Me.lblAlertaTD.Size = New System.Drawing.Size(11, 13)
        Me.lblAlertaTD.TabIndex = 11
        Me.lblAlertaTD.Text = "*"
        Me.lblAlertaTD.Visible = False
        '
        'lblAlertaApellido
        '
        Me.lblAlertaApellido.AutoSize = True
        Me.lblAlertaApellido.ForeColor = System.Drawing.Color.Red
        Me.lblAlertaApellido.Location = New System.Drawing.Point(257, 126)
        Me.lblAlertaApellido.Name = "lblAlertaApellido"
        Me.lblAlertaApellido.Size = New System.Drawing.Size(11, 13)
        Me.lblAlertaApellido.TabIndex = 10
        Me.lblAlertaApellido.Text = "*"
        Me.lblAlertaApellido.Visible = False
        '
        'lblAlerta
        '
        Me.lblAlerta.AutoSize = True
        Me.lblAlerta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlerta.ForeColor = System.Drawing.Color.Red
        Me.lblAlerta.Location = New System.Drawing.Point(12, 304)
        Me.lblAlerta.Name = "lblAlerta"
        Me.lblAlerta.Size = New System.Drawing.Size(227, 16)
        Me.lblAlerta.TabIndex = 9
        Me.lblAlerta.Text = "Necesita completar los campos"
        Me.lblAlerta.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(0, 123)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(233, 20)
        Me.txtApellido.TabIndex = 2
        '
        'mskTelFijo
        '
        Me.mskTelFijo.Location = New System.Drawing.Point(328, 261)
        Me.mskTelFijo.Margin = New System.Windows.Forms.Padding(4)
        Me.mskTelFijo.Mask = "(999)000-0000"
        Me.mskTelFijo.Name = "mskTelFijo"
        Me.mskTelFijo.Size = New System.Drawing.Size(132, 20)
        Me.mskTelFijo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(325, 239)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Teléfono fijo:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(7, 261)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(233, 20)
        Me.txtCelular.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(328, 123)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(233, 20)
        Me.txtNombre.TabIndex = 3
        '
        'mskFechaIngreso
        '
        Me.mskFechaIngreso.Location = New System.Drawing.Point(328, 190)
        Me.mskFechaIngreso.Margin = New System.Windows.Forms.Padding(4)
        Me.mskFechaIngreso.Mask = "00/00/0000"
        Me.mskFechaIngreso.Name = "mskFechaIngreso"
        Me.mskFechaIngreso.Size = New System.Drawing.Size(132, 20)
        Me.mskFechaIngreso.TabIndex = 5
        Me.mskFechaIngreso.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 239)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Celular:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo DNI:"
        '
        'mskFechaNac
        '
        Me.mskFechaNac.Location = New System.Drawing.Point(7, 190)
        Me.mskFechaNac.Margin = New System.Windows.Forms.Padding(4)
        Me.mskFechaNac.Mask = "00/00/0000"
        Me.mskFechaNac.Name = "mskFechaNac"
        Me.mskFechaNac.Size = New System.Drawing.Size(132, 20)
        Me.mskFechaNac.TabIndex = 4
        Me.mskFechaNac.ValidatingType = GetType(Date)
        '
        'cmbTipoDni
        '
        Me.cmbTipoDni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDni.FormattingEnabled = True
        Me.cmbTipoDni.Location = New System.Drawing.Point(328, 61)
        Me.cmbTipoDni.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoDni.Name = "cmbTipoDni"
        Me.cmbTipoDni.Size = New System.Drawing.Size(160, 21)
        Me.cmbTipoDni.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(325, 158)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha de ingreso:"
        '
        'mskDni
        '
        Me.mskDni.Location = New System.Drawing.Point(10, 51)
        Me.mskDni.Margin = New System.Windows.Forms.Padding(4)
        Me.mskDni.Mask = "99999999"
        Me.mskDni.Name = "mskDni"
        Me.mskDni.Size = New System.Drawing.Size(233, 20)
        Me.mskDni.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 29)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DNI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 158)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha Nacimiento:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(84, 599)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(115, 37)
        Me.btnNuevo.TabIndex = 23
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(373, 599)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 37)
        Me.btnEliminar.TabIndex = 26
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ABM_Chofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 649)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.dgvChofer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "ABM_Chofer"
        Me.Text = "ABM_Chofer"
        CType(Me.dgvChofer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInsertar As System.Windows.Forms.Button
    Friend WithEvents dgvChofer As System.Windows.Forms.DataGridView
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_nacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_ingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel_fijo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAlertaApellido As System.Windows.Forms.Label
    Friend WithEvents lblAlerta As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents mskTelFijo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents mskFechaIngreso As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mskFechaNac As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbTipoDni As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mskDni As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblAlertaCel As System.Windows.Forms.Label
    Friend WithEvents lblAlertaFecNac As System.Windows.Forms.Label
    Friend WithEvents lblAlertaTD As System.Windows.Forms.Label
    Friend WithEvents lblAlertaTelFijo As System.Windows.Forms.Label
    Friend WithEvents lblFecIng As System.Windows.Forms.Label
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents lblAlertaNombre As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
