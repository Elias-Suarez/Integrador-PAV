<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listados
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
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.btnCamiones = New System.Windows.Forms.Button()
        Me.btnChofer = New System.Windows.Forms.Button()
        Me.btnCargas = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnTaller = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnKMMensuales = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.Location = New System.Drawing.Point(45, 34)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Size = New System.Drawing.Size(167, 26)
        Me.btnMantenimiento.TabIndex = 0
        Me.btnMantenimiento.Text = "Mantenimientos mas realizados"
        Me.btnMantenimiento.UseVisualStyleBackColor = True
        '
        'btnCamiones
        '
        Me.btnCamiones.Location = New System.Drawing.Point(45, 77)
        Me.btnCamiones.Name = "btnCamiones"
        Me.btnCamiones.Size = New System.Drawing.Size(167, 23)
        Me.btnCamiones.TabIndex = 1
        Me.btnCamiones.Text = "Camiones mas reparados"
        Me.btnCamiones.UseVisualStyleBackColor = True
        '
        'btnChofer
        '
        Me.btnChofer.Location = New System.Drawing.Point(253, 37)
        Me.btnChofer.Name = "btnChofer"
        Me.btnChofer.Size = New System.Drawing.Size(160, 23)
        Me.btnChofer.TabIndex = 2
        Me.btnChofer.Text = "Choferes con más KM"
        Me.btnChofer.UseVisualStyleBackColor = True
        '
        'btnCargas
        '
        Me.btnCargas.Location = New System.Drawing.Point(253, 77)
        Me.btnCargas.Name = "btnCargas"
        Me.btnCargas.Size = New System.Drawing.Size(160, 23)
        Me.btnCargas.TabIndex = 3
        Me.btnCargas.Text = "Tipo Cargas más frecuentes"
        Me.btnCargas.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(444, 426)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnTaller
        '
        Me.btnTaller.Location = New System.Drawing.Point(45, 122)
        Me.btnTaller.Name = "btnTaller"
        Me.btnTaller.Size = New System.Drawing.Size(167, 23)
        Me.btnTaller.TabIndex = 5
        Me.btnTaller.Text = "Talleres mas usados"
        Me.btnTaller.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnKMMensuales)
        Me.GroupBox1.Controls.Add(Me.btnClientes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 222)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnKMMensuales
        '
        Me.btnKMMensuales.Location = New System.Drawing.Point(33, 34)
        Me.btnKMMensuales.Name = "btnKMMensuales"
        Me.btnKMMensuales.Size = New System.Drawing.Size(167, 26)
        Me.btnKMMensuales.TabIndex = 7
        Me.btnKMMensuales.Text = "KM Mensuales"
        Me.btnKMMensuales.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(33, 78)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(167, 26)
        Me.btnClientes.TabIndex = 8
        Me.btnClientes.Text = "Clientes con mas pedidos"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'Listados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 459)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTaller)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnCargas)
        Me.Controls.Add(Me.btnChofer)
        Me.Controls.Add(Me.btnCamiones)
        Me.Controls.Add(Me.btnMantenimiento)
        Me.Name = "Listados"
        Me.Text = "Listados"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMantenimiento As System.Windows.Forms.Button
    Friend WithEvents btnCamiones As System.Windows.Forms.Button
    Friend WithEvents btnChofer As System.Windows.Forms.Button
    Friend WithEvents btnCargas As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnTaller As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnKMMensuales As System.Windows.Forms.Button
    Friend WithEvents btnClientes As System.Windows.Forms.Button
End Class
