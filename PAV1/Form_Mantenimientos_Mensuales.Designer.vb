<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Mantenimientos_Mensuales
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_año = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.rpv_estadistica = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MantenimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Mantenimientos_Mensuales = New PAV1.DS_Mantenimientos_Mensuales()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MantenimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Mantenimientos_Mensuales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(412, 448)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 5
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(615, 448)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 6
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_año)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_mes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 53)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Viajes"
        '
        'txt_año
        '
        Me.txt_año.Location = New System.Drawing.Point(292, 22)
        Me.txt_año.Name = "txt_año"
        Me.txt_año.Size = New System.Drawing.Size(100, 20)
        Me.txt_año.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Año"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mes"
        '
        'cmb_mes
        '
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(51, 22)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(121, 21)
        Me.cmb_mes.TabIndex = 0
        '
        'rpv_estadistica
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MantenimientosBindingSource
        Me.rpv_estadistica.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpv_estadistica.LocalReport.ReportEmbeddedResource = "PAV1.Estadistica_Mantenimientos_Mensuales.rdlc"
        Me.rpv_estadistica.Location = New System.Drawing.Point(12, 72)
        Me.rpv_estadistica.Name = "rpv_estadistica"
        Me.rpv_estadistica.Size = New System.Drawing.Size(676, 370)
        Me.rpv_estadistica.TabIndex = 7
        '
        'MantenimientosBindingSource
        '
        Me.MantenimientosBindingSource.DataMember = "Mantenimientos"
        Me.MantenimientosBindingSource.DataSource = Me.DS_Mantenimientos_Mensuales
        '
        'DS_Mantenimientos_Mensuales
        '
        Me.DS_Mantenimientos_Mensuales.DataSetName = "DS_Mantenimientos_Mensuales"
        Me.DS_Mantenimientos_Mensuales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form_Mantenimientos_Mensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 477)
        Me.Controls.Add(Me.rpv_estadistica)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Mantenimientos_Mensuales"
        Me.Text = "Form_Mantenimientos_Mensuales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MantenimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Mantenimientos_Mensuales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_año As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Friend WithEvents rpv_estadistica As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MantenimientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Mantenimientos_Mensuales As PAV1.DS_Mantenimientos_Mensuales
End Class
