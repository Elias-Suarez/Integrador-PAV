Public Class ABM_Trabajo

    Enum Guardar
        insertar
        modificar
    End Enum
    Dim accionGuardar = Guardar.insertar
    Dim indice As Integer

#Region "Carga datos"
    Private Sub ABM_Trabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.modo_inicio()
    End Sub

    Private Sub modo_inicio()
        txtx_nombre.Text = ""
        txtx_nombre.ReadOnly = True

        btn_eliminar.Enabled = False
        btn_crear.Enabled = True
        btn_guardar.Enabled = False

        chk_confirmar.Checked = False

        Me.actualizar_grilla()
    End Sub

    Private Sub modo_editar()
        txtx_nombre.ReadOnly = False

        btn_eliminar.Enabled = True
        btn_crear.Enabled = True
        btn_guardar.Enabled = True

        chk_confirmar.Checked = False
        accionGuardar = Guardar.modificar


    End Sub

    Private Sub modo_crear()
        txtx_nombre.Text = ""
        txtx_nombre.ReadOnly = False

        btn_eliminar.Enabled = False
        btn_crear.Enabled = False
        btn_guardar.Enabled = True

        chk_confirmar.Checked = False
        accionGuardar = Guardar.insertar

        Me.actualizar_grilla()
    End Sub

    Private Sub actualizar_grilla()
        Dim combo As New Combo
        combo.carga_dgv("Trabajo", dgv_trabajos, "id, nombre")
    End Sub
#End Region

#Region "Funcion Botones"
    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim acceso As New AccesoDatos With {._nombre_tabla = "Trabajo"}
        Dim t As DataTable = dgv_trabajos.DataSource

        If chk_confirmar.Checked Then
            If acceso.leo_tabla("id", " id = " & indice).Rows.Count = 1 Then
                acceso.borrar(" id = " & indice)
            Else
                MessageBox.Show("No se puede eliminar el trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            modo_inicio()
        Else
            chk_confirmar.Checked = False
            MessageBox.Show("Confirmar Operación", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        If chk_confirmar.Checked Then
            Dim acceso As New AccesoDatos With {._nombre_tabla = "Trabajo"}
            If Not txtx_nombre.Text = "" Then
                If accionGuardar = Guardar.insertar Then

                    acceso.insertar2(" (nombre) VALUES ('" & txtx_nombre.Text & "')")
                    indice = acceso.leo_tabla(" max(id) ").Rows.Item(0).Item(0)
                    accionGuardar = Guardar.modificar
                    Me.modo_editar()
                    Me.actualizar_grilla()
                Else

                    acceso.modificar(" nombre = '" & txtx_nombre.Text & "'", " id = " & indice)
                    actualizar_grilla()
                    accionGuardar = Guardar.modificar
                End If
            Else
                chk_confirmar.Checked = False
                MessageBox.Show("Nombre no puede ser un campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Confirmar Operación", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click
        Me.modo_crear()
    End Sub

    Private Sub dgv_trabajos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_trabajos.CellDoubleClick
        Dim t As DataTable = dgv_trabajos.DataSource

        txtx_nombre.Text = t.Rows.Item(dgv_trabajos.CurrentRow.Index).Item(1)
        indice = t.Rows.Item(dgv_trabajos.CurrentRow.Index).Item(0)

        modo_editar()
    End Sub

#End Region



End Class