<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Camiones_Mas_Reparados
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
        Me.TrabajoXMantenimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grp_filtros = New System.Windows.Forms.GroupBox()
        Me.lbl_alerta_fecha_hasta = New System.Windows.Forms.Label()
        Me.lbl_alerta_fecha_desde = New System.Windows.Forms.Label()
        Me.mtb_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_trabajo = New System.Windows.Forms.ComboBox()
        Me.cmb_taller = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.crv_reporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.TrabajoXMantenimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrabajoXMantenimientoBindingSource
        '
        Me.TrabajoXMantenimientoBindingSource.DataMember = "TrabajoXMantenimiento"
        '
        'grp_filtros
        '
        Me.grp_filtros.Controls.Add(Me.lbl_alerta_fecha_hasta)
        Me.grp_filtros.Controls.Add(Me.lbl_alerta_fecha_desde)
        Me.grp_filtros.Controls.Add(Me.mtb_fecha_hasta)
        Me.grp_filtros.Controls.Add(Me.mtb_fecha_desde)
        Me.grp_filtros.Controls.Add(Me.Label3)
        Me.grp_filtros.Controls.Add(Me.Label2)
        Me.grp_filtros.Controls.Add(Me.Label4)
        Me.grp_filtros.Controls.Add(Me.Label1)
        Me.grp_filtros.Controls.Add(Me.cmb_trabajo)
        Me.grp_filtros.Controls.Add(Me.cmb_taller)
        Me.grp_filtros.Location = New System.Drawing.Point(12, 12)
        Me.grp_filtros.Name = "grp_filtros"
        Me.grp_filtros.Size = New System.Drawing.Size(818, 48)
        Me.grp_filtros.TabIndex = 0
        Me.grp_filtros.TabStop = False
        Me.grp_filtros.Text = "Filtros"
        '
        'lbl_alerta_fecha_hasta
        '
        Me.lbl_alerta_fecha_hasta.AutoSize = True
        Me.lbl_alerta_fecha_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta_fecha_hasta.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_fecha_hasta.Location = New System.Drawing.Point(792, 26)
        Me.lbl_alerta_fecha_hasta.Name = "lbl_alerta_fecha_hasta"
        Me.lbl_alerta_fecha_hasta.Size = New System.Drawing.Size(12, 13)
        Me.lbl_alerta_fecha_hasta.TabIndex = 4
        Me.lbl_alerta_fecha_hasta.Text = "*"
        '
        'lbl_alerta_fecha_desde
        '
        Me.lbl_alerta_fecha_desde.AutoSize = True
        Me.lbl_alerta_fecha_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta_fecha_desde.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_fecha_desde.Location = New System.Drawing.Point(619, 27)
        Me.lbl_alerta_fecha_desde.Name = "lbl_alerta_fecha_desde"
        Me.lbl_alerta_fecha_desde.Size = New System.Drawing.Size(12, 13)
        Me.lbl_alerta_fecha_desde.TabIndex = 4
        Me.lbl_alerta_fecha_desde.Text = "*"
        '
        'mtb_fecha_hasta
        '
        Me.mtb_fecha_hasta.Location = New System.Drawing.Point(711, 19)
        Me.mtb_fecha_hasta.Mask = "00/00/0000"
        Me.mtb_fecha_hasta.Name = "mtb_fecha_hasta"
        Me.mtb_fecha_hasta.Size = New System.Drawing.Size(75, 20)
        Me.mtb_fecha_hasta.TabIndex = 3
        Me.mtb_fecha_hasta.ValidatingType = GetType(Date)
        '
        'mtb_fecha_desde
        '
        Me.mtb_fecha_desde.Location = New System.Drawing.Point(538, 19)
        Me.mtb_fecha_desde.Mask = "00/00/0000"
        Me.mtb_fecha_desde.Name = "mtb_fecha_desde"
        Me.mtb_fecha_desde.Size = New System.Drawing.Size(75, 20)
        Me.mtb_fecha_desde.TabIndex = 2
        Me.mtb_fecha_desde.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(637, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(461, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Trabajo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Taller"
        '
        'cmb_trabajo
        '
        Me.cmb_trabajo.FormattingEnabled = True
        Me.cmb_trabajo.Location = New System.Drawing.Point(59, 19)
        Me.cmb_trabajo.Name = "cmb_trabajo"
        Me.cmb_trabajo.Size = New System.Drawing.Size(170, 21)
        Me.cmb_trabajo.TabIndex = 0
        '
        'cmb_taller
        '
        Me.cmb_taller.FormattingEnabled = True
        Me.cmb_taller.Location = New System.Drawing.Point(274, 19)
        Me.cmb_taller.Name = "cmb_taller"
        Me.cmb_taller.Size = New System.Drawing.Size(170, 21)
        Me.cmb_taller.TabIndex = 1
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(575, 477)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(755, 477)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 3
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'crv_reporte
        '
        Me.crv_reporte.ActiveViewIndex = -1
        Me.crv_reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv_reporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv_reporte.Location = New System.Drawing.Point(12, 91)
        Me.crv_reporte.Name = "crv_reporte"
        Me.crv_reporte.Size = New System.Drawing.Size(818, 380)
        Me.crv_reporte.TabIndex = 4
        '
        'Camiones_Mas_Reparados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 512)
        Me.Controls.Add(Me.crv_reporte)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.grp_filtros)
        Me.Name = "Camiones_Mas_Reparados"
        Me.Text = "Listado de Camiones más Reparados"
        CType(Me.TrabajoXMantenimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_filtros.ResumeLayout(False)
        Me.grp_filtros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents mtb_fecha_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtb_fecha_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_taller As System.Windows.Forms.ComboBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_trabajo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_alerta_fecha_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta_fecha_desde As System.Windows.Forms.Label

    Friend WithEvents TrabajoXMantenimientoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents crv_reporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
