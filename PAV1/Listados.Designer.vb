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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_mantenimientos_menusales = New System.Windows.Forms.Button()
        Me.btn_viajes_por_localidad = New System.Windows.Forms.Button()
        Me.btnKMMensuales = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_clientes_frecuentes = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.Location = New System.Drawing.Point(35, 28)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Size = New System.Drawing.Size(167, 26)
        Me.btnMantenimiento.TabIndex = 0
        Me.btnMantenimiento.Text = "Mantenimientos mas realizados"
        Me.btnMantenimiento.UseVisualStyleBackColor = True
        '
        'btnCamiones
        '
        Me.btnCamiones.Location = New System.Drawing.Point(35, 71)
        Me.btnCamiones.Name = "btnCamiones"
        Me.btnCamiones.Size = New System.Drawing.Size(167, 23)
        Me.btnCamiones.TabIndex = 1
        Me.btnCamiones.Text = "Camiones mas reparados"
        Me.btnCamiones.UseVisualStyleBackColor = True
        '
        'btnChofer
        '
        Me.btnChofer.Location = New System.Drawing.Point(214, 31)
        Me.btnChofer.Name = "btnChofer"
        Me.btnChofer.Size = New System.Drawing.Size(167, 23)
        Me.btnChofer.TabIndex = 2
        Me.btnChofer.Text = "Choferes con más KM"
        Me.btnChofer.UseVisualStyleBackColor = True
        '
        'btnCargas
        '
        Me.btnCargas.Location = New System.Drawing.Point(214, 71)
        Me.btnCargas.Name = "btnCargas"
        Me.btnCargas.Size = New System.Drawing.Size(167, 23)
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
        Me.btnTaller.Location = New System.Drawing.Point(35, 116)
        Me.btnTaller.Name = "btnTaller"
        Me.btnTaller.Size = New System.Drawing.Size(167, 23)
        Me.btnTaller.TabIndex = 5
        Me.btnTaller.Text = "Talleres mas usados"
        Me.btnTaller.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btn_mantenimientos_menusales)
        Me.GroupBox1.Controls.Add(Me.btn_viajes_por_localidad)
        Me.GroupBox1.Controls.Add(Me.btnKMMensuales)
        Me.GroupBox1.Controls.Add(Me.btnClientes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 222)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estadisticas"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(214, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(167, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Button1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(33, 123)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Button1"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_mantenimientos_menusales
        '
        Me.btn_mantenimientos_menusales.Location = New System.Drawing.Point(214, 81)
        Me.btn_mantenimientos_menusales.Name = "btn_mantenimientos_menusales"
        Me.btn_mantenimientos_menusales.Size = New System.Drawing.Size(167, 23)
        Me.btn_mantenimientos_menusales.TabIndex = 9
        Me.btn_mantenimientos_menusales.Text = "Mantenimientos Mensuales"
        Me.btn_mantenimientos_menusales.UseVisualStyleBackColor = True
        '
        'btn_viajes_por_localidad
        '
        Me.btn_viajes_por_localidad.Location = New System.Drawing.Point(214, 37)
        Me.btn_viajes_por_localidad.Name = "btn_viajes_por_localidad"
        Me.btn_viajes_por_localidad.Size = New System.Drawing.Size(167, 23)
        Me.btn_viajes_por_localidad.TabIndex = 9
        Me.btn_viajes_por_localidad.Text = "Viajes por Localidad"
        Me.btn_viajes_por_localidad.UseVisualStyleBackColor = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_clientes_frecuentes)
        Me.GroupBox2.Controls.Add(Me.btnMantenimiento)
        Me.GroupBox2.Controls.Add(Me.btnCamiones)
        Me.GroupBox2.Controls.Add(Me.btnTaller)
        Me.GroupBox2.Controls.Add(Me.btnCargas)
        Me.GroupBox2.Controls.Add(Me.btnChofer)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(507, 170)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listados"
        '
        'btn_clientes_frecuentes
        '
        Me.btn_clientes_frecuentes.Location = New System.Drawing.Point(214, 116)
        Me.btn_clientes_frecuentes.Name = "btn_clientes_frecuentes"
        Me.btn_clientes_frecuentes.Size = New System.Drawing.Size(167, 23)
        Me.btn_clientes_frecuentes.TabIndex = 6
        Me.btn_clientes_frecuentes.Text = "Clientes más Frecuentes"
        Me.btn_clientes_frecuentes.UseVisualStyleBackColor = True
        '
        'Listados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 459)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "Listados"
        Me.Text = "Listados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_mantenimientos_menusales As System.Windows.Forms.Button
    Friend WithEvents btn_viajes_por_localidad As System.Windows.Forms.Button
    Friend WithEvents btn_clientes_frecuentes As System.Windows.Forms.Button
End Class
