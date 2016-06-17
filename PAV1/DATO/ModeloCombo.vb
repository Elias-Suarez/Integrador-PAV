Imports System.Text.RegularExpressions
Public Class ModeloCombo

    Public Sub cargar_combo(ByRef combo As ComboBox, ByVal dato As String)
        Dim acceso As New AccesoDatos With {._nombre_tabla = dato}

        Dim tabla As New DataTable
        tabla = acceso.leo_tabla()
        combo.Items.Clear()
        combo.DataSource = tabla
        combo.DisplayMember = tabla.Columns(1).ColumnName
        combo.ValueMember = tabla.Columns(0).ColumnName

    End Sub
    Public Sub cargar_combo(ByRef combo As ComboBox, ByVal nombreTabla As String, ByVal consulta As String)
        Dim acceso As New AccesoDatos With {._nombre_tabla = nombreTabla}

        Dim tabla As New DataTable
        tabla = acceso.leo_Consulta(consulta)
        combo.DataSource = Nothing
        combo.Items.Clear()

        combo.DataSource = tabla
        combo.DisplayMember = tabla.Columns(1).ColumnName
        combo.ValueMember = tabla.Columns(0).ColumnName

    End Sub

    Public Function validarEmail(ByVal email As String) As Boolean
        Dim res As Boolean = True
        Try
            res = Regex.IsMatch(email, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
        Catch ex As Exception
            MsgBox("No se pudo comprobar el Email " & ex.Message)
        End Try
        Return res
    End Function

    Public Sub limpiar(ByVal valor As Object)
        For Each obj As System.Windows.Forms.Control In valor
            Select Case obj.GetType.Name.ToString
                Case "TextBox"
                    obj.Text = ""
                Case "GroupBox"
                    Me.limpiar(obj.Controls)
                Case "DataGriedView"
                    Dim grilla As Windows.Forms.DataGridView = obj
                    grilla.Rows.Clear()
                Case "MaskedTextBox"
                    obj.Text = ""
            End Select
        Next
    End Sub
    Public Sub limpiarGrilla(ByRef grilla As DataGridView)
        grilla.Rows.Clear()
        grilla.DataSource = Nothing
    End Sub
    Public Sub cargarGrilla(ByRef grilla As Windows.Forms.DataGridView, ByVal consulta As String)
        Dim queryBD As New ConexionBD
        Dim tabla As Data.DataTable = queryBD.ejecutarQuery(consulta)
        grilla.DataSource = tabla
    End Sub
End Class
