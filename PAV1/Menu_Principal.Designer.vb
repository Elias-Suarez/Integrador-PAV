<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Principal))
        Me.btn_viajes = New System.Windows.Forms.Button()
        Me.btn_cargas = New System.Windows.Forms.Button()
        Me.btn_choferes = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_camiones = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btnTaller = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_listados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_viajes
        '
        Me.btn_viajes.FlatAppearance.BorderSize = 0
        Me.btn_viajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_viajes.Image = CType(resources.GetObject("btn_viajes.Image"), System.Drawing.Image)
        Me.btn_viajes.Location = New System.Drawing.Point(12, 12)
        Me.btn_viajes.Name = "btn_viajes"
        Me.btn_viajes.Size = New System.Drawing.Size(240, 86)
        Me.btn_viajes.TabIndex = 0
        Me.btn_viajes.UseVisualStyleBackColor = True
        '
        'btn_cargas
        '
        Me.btn_cargas.FlatAppearance.BorderSize = 0
        Me.btn_cargas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cargas.Image = CType(resources.GetObject("btn_cargas.Image"), System.Drawing.Image)
        Me.btn_cargas.Location = New System.Drawing.Point(258, 104)
        Me.btn_cargas.Name = "btn_cargas"
        Me.btn_cargas.Size = New System.Drawing.Size(240, 86)
        Me.btn_cargas.TabIndex = 4
        Me.btn_cargas.UseVisualStyleBackColor = True
        '
        'btn_choferes
        '
        Me.btn_choferes.BackgroundImage = CType(resources.GetObject("btn_choferes.BackgroundImage"), System.Drawing.Image)
        Me.btn_choferes.FlatAppearance.BorderSize = 0
        Me.btn_choferes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_choferes.Image = CType(resources.GetObject("btn_choferes.Image"), System.Drawing.Image)
        Me.btn_choferes.Location = New System.Drawing.Point(504, 12)
        Me.btn_choferes.Name = "btn_choferes"
        Me.btn_choferes.Size = New System.Drawing.Size(240, 86)
        Me.btn_choferes.TabIndex = 2
        Me.btn_choferes.UseVisualStyleBackColor = False
        '
        'btn_clientes
        '
        Me.btn_clientes.FlatAppearance.BorderSize = 0
        Me.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clientes.Image = CType(resources.GetObject("btn_clientes.Image"), System.Drawing.Image)
        Me.btn_clientes.Location = New System.Drawing.Point(12, 104)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(240, 86)
        Me.btn_clientes.TabIndex = 3
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'btn_camiones
        '
        Me.btn_camiones.FlatAppearance.BorderSize = 0
        Me.btn_camiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_camiones.Image = CType(resources.GetObject("btn_camiones.Image"), System.Drawing.Image)
        Me.btn_camiones.Location = New System.Drawing.Point(258, 12)
        Me.btn_camiones.Name = "btn_camiones"
        Me.btn_camiones.Size = New System.Drawing.Size(240, 86)
        Me.btn_camiones.TabIndex = 1
        Me.btn_camiones.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.FlatAppearance.BorderSize = 0
        Me.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.Location = New System.Drawing.Point(623, 226)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(121, 42)
        Me.btn_cerrar.TabIndex = 6
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btnTaller
        '
        Me.btnTaller.FlatAppearance.BorderSize = 0
        Me.btnTaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTaller.Image = CType(resources.GetObject("btnTaller.Image"), System.Drawing.Image)
        Me.btnTaller.Location = New System.Drawing.Point(504, 104)
        Me.btnTaller.Name = "btnTaller"
        Me.btnTaller.Size = New System.Drawing.Size(240, 86)
        Me.btnTaller.TabIndex = 7
        Me.btnTaller.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(30, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 60)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Mantenimiento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_listados
        '
        Me.btn_listados.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listados.Location = New System.Drawing.Point(276, 196)
        Me.btn_listados.Name = "btn_listados"
        Me.btn_listados.Size = New System.Drawing.Size(222, 60)
        Me.btn_listados.TabIndex = 8
        Me.btn_listados.Text = "Listados"
        Me.btn_listados.UseVisualStyleBackColor = True
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(757, 268)
        Me.Controls.Add(Me.btn_listados)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTaller)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_camiones)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.btn_choferes)
        Me.Controls.Add(Me.btn_cargas)
        Me.Controls.Add(Me.btn_viajes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(773, 307)
        Me.Name = "Menu_Principal"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_viajes As System.Windows.Forms.Button
    Friend WithEvents btn_cargas As System.Windows.Forms.Button
    Friend WithEvents btn_choferes As System.Windows.Forms.Button
    Friend WithEvents btn_clientes As System.Windows.Forms.Button
    Friend WithEvents btn_camiones As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btnTaller As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_listados As System.Windows.Forms.Button
End Class
