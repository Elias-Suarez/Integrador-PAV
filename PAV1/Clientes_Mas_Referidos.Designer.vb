<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes_Mas_Referidos
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
        Me.rpv_reporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.grp_filtros = New System.Windows.Forms.GroupBox()
        Me.lbl_alerta_fecha_hasta = New System.Windows.Forms.Label()
        Me.lbl_alerta_fecha_desde = New System.Windows.Forms.Label()
        Me.mtb_fecha_hasta = New System.Windows.Forms.MaskedTextBox()
        Me.mtb_fecha_desde = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grp_filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'rpv_reporte
        '
        Me.rpv_reporte.ActiveViewIndex = -1
        Me.rpv_reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rpv_reporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.rpv_reporte.Location = New System.Drawing.Point(12, 84)
        Me.rpv_reporte.Name = "rpv_reporte"
        Me.rpv_reporte.Size = New System.Drawing.Size(807, 450)
        Me.rpv_reporte.TabIndex = 1
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(565, 540)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(745, 540)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 3
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'grp_filtros
        '
        Me.grp_filtros.Controls.Add(Me.lbl_alerta_fecha_hasta)
        Me.grp_filtros.Controls.Add(Me.lbl_alerta_fecha_desde)
        Me.grp_filtros.Controls.Add(Me.mtb_fecha_hasta)
        Me.grp_filtros.Controls.Add(Me.mtb_fecha_desde)
        Me.grp_filtros.Controls.Add(Me.Label3)
        Me.grp_filtros.Controls.Add(Me.Label2)
        Me.grp_filtros.Location = New System.Drawing.Point(12, 10)
        Me.grp_filtros.Name = "grp_filtros"
        Me.grp_filtros.Size = New System.Drawing.Size(807, 67)
        Me.grp_filtros.TabIndex = 0
        Me.grp_filtros.TabStop = False
        Me.grp_filtros.Text = "Filtros"
        '
        'lbl_alerta_fecha_hasta
        '
        Me.lbl_alerta_fecha_hasta.AutoSize = True
        Me.lbl_alerta_fecha_hasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta_fecha_hasta.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_fecha_hasta.Location = New System.Drawing.Point(383, 32)
        Me.lbl_alerta_fecha_hasta.Name = "lbl_alerta_fecha_hasta"
        Me.lbl_alerta_fecha_hasta.Size = New System.Drawing.Size(12, 13)
        Me.lbl_alerta_fecha_hasta.TabIndex = 5
        Me.lbl_alerta_fecha_hasta.Text = "*"
        '
        'lbl_alerta_fecha_desde
        '
        Me.lbl_alerta_fecha_desde.AutoSize = True
        Me.lbl_alerta_fecha_desde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alerta_fecha_desde.ForeColor = System.Drawing.Color.Red
        Me.lbl_alerta_fecha_desde.Location = New System.Drawing.Point(189, 32)
        Me.lbl_alerta_fecha_desde.Name = "lbl_alerta_fecha_desde"
        Me.lbl_alerta_fecha_desde.Size = New System.Drawing.Size(12, 13)
        Me.lbl_alerta_fecha_desde.TabIndex = 5
        Me.lbl_alerta_fecha_desde.Text = "*"
        '
        'mtb_fecha_hasta
        '
        Me.mtb_fecha_hasta.Location = New System.Drawing.Point(281, 25)
        Me.mtb_fecha_hasta.Mask = "00/00/0000"
        Me.mtb_fecha_hasta.Name = "mtb_fecha_hasta"
        Me.mtb_fecha_hasta.Size = New System.Drawing.Size(100, 20)
        Me.mtb_fecha_hasta.TabIndex = 1
        Me.mtb_fecha_hasta.ValidatingType = GetType(Date)
        '
        'mtb_fecha_desde
        '
        Me.mtb_fecha_desde.Location = New System.Drawing.Point(83, 25)
        Me.mtb_fecha_desde.Mask = "00/00/0000"
        Me.mtb_fecha_desde.Name = "mtb_fecha_desde"
        Me.mtb_fecha_desde.Size = New System.Drawing.Size(100, 20)
        Me.mtb_fecha_desde.TabIndex = 0
        Me.mtb_fecha_desde.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Desde"
        '
        'Clientes_Mas_Referidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 575)
        Me.Controls.Add(Me.rpv_reporte)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.grp_filtros)
        Me.Name = "Clientes_Mas_Referidos"
        Me.Text = "Listado de Clientes Frecuentes"
        Me.grp_filtros.ResumeLayout(False)
        Me.grp_filtros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rpv_reporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents grp_filtros As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_alerta_fecha_hasta As System.Windows.Forms.Label
    Friend WithEvents lbl_alerta_fecha_desde As System.Windows.Forms.Label
    Friend WithEvents mtb_fecha_hasta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtb_fecha_desde As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
