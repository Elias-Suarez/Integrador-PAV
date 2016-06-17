Public Class Combo
    Public Sub cargar_combo(ByRef combo As ComboBox, ByVal dato As String)
        Dim acceso As New AccesoDatos With {._nombre_tabla = dato}

        Dim tabla As DataTable = acceso.leo_tabla()
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.DisplayMember = tabla.Columns(0).ColumnName
        combo.ValueMember = tabla.Columns(0).ColumnName

    End Sub

    Public Sub cargar_combo(ByRef combo As ComboBox, ByVal pk As String, ByVal value As String, ByVal nombre_tabla As String)
        Dim acceso As New AccesoDatos With {._nombre_tabla = nombre_tabla}
        Dim tabla As DataTable = acceso.leo_tabla()

        If Not tabla.Rows.Count = 0 Then
            combo.Items.Clear()
            combo.DataSource = tabla

            combo.DisplayMember = value
            combo.ValueMember = pk
        Else
            MsgBox("No se pudo cargar el combo " & nombre_tabla)
        End If
    End Sub

    Public Sub cargar_combo(ByRef combo As ComboBox, ByVal pk As String, ByVal nombre_tabla As String)
        Dim acceso As New AccesoDatos With {._nombre_tabla = nombre_tabla}
        Dim tabla As DataTable = acceso.leo_tabla(pk)
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.DisplayMember = tabla.Columns(0).ColumnName
        combo.ValueMember = tabla.Columns(0).ColumnName

    End Sub

    Public Sub cargar_combo(ByRef combo As ComboBox, ByVal pk As String, ByVal col As String, ByVal value As String, ByVal restriccion As String, ByVal nombre_tabla As String)
        Dim acceso As New AccesoDatos With {._nombre_tabla = nombre_tabla}
        Dim tabla As DataTable = acceso.leo_tabla(col, restriccion)

        combo.DataSource = tabla

        combo.DisplayMember = value
        combo.ValueMember = pk
    End Sub

    Public Sub carga_dgv(ByVal nombre_tabla As String, ByRef dgv As DataGridView, ByVal consulta As String, ByVal restricciones As String)
        Dim acceso As New AccesoDatos With {._nombre_tabla = nombre_tabla}
        Dim tabla As DataTable = acceso.leo_tabla(consulta, restricciones)

        dgv.DataSource = tabla

    End Sub

    Public Sub carga_dgv(ByVal nombre_tabla As String, ByRef grilla As DataGridView, ByVal columnas As String)
        Dim acceso As New AccesoDatos With {._nombre_tabla = nombre_tabla}
        Dim tabla As DataTable = acceso.leo_tabla(columnas)

        grilla.DataSource = tabla
    End Sub

End Class
