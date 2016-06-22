Public Class AccesoDatos

    Enum bases
        ale
        elias
        david
        alan
    End Enum

    Dim str_conexion As bases = bases.ale
    Dim cadena_conexion As String = ""
    Dim cmd As New SqlClient.SqlCommand
    Dim conexion As New SqlClient.SqlConnection

    Dim nombre_tabla As String

    Public Property _nombre_tabla As String
        Get
            Return Me.nombre_tabla
        End Get
        Set(ByVal value As String)
            Me.nombre_tabla = value
        End Set
    End Property

    'property de cmd.. por si se usa

    'Public Property _cmd As OleDb.OleDbCommand
    '    Get
    '        Return cmd
    '    End Get
    '    Set(ByVal value As OleDb.OleDbCommand)
    '        cmd = value
    '    End Set
    'End Property

    Private Sub elegir_base()
        Select Case str_conexion
            Case bases.ale
                Me.cadena_conexion = "Data Source=CORDOBA\SQLEXPRESS;Initial Catalog=BD_Transporte_Don-Lui;Integrated Security=True"
            Case bases.david
            Case bases.alan
            Case bases.elias
                Me.cadena_conexion = "Data Source=(local);Initial Catalog=BD_Transporte_Don_Luis;User ID=sa;Password=jinjo32"
        End Select
    End Sub

    Private Sub conectar()
        Me.elegir_base()
        Me.conexion.ConnectionString = cadena_conexion
        Me.conexion.Open()
        Me.cmd.Connection = conexion
        Me.cmd.CommandType = CommandType.Text
    End Sub

    Private Sub cerrar()
        Me.conexion.Close()
    End Sub

    Private Function ejecutar(ByVal cadena As String) As Data.DataTable
        Dim tabla As New DataTable
        Me.conectar()
        Me.cmd.CommandText = cadena
        tabla.Load(cmd.ExecuteReader())
        Me.cerrar()
        Return tabla

    End Function


    ' en las funciones leo_tabla, confirmar el atributo que es pasado como nombre_tabla
    Public Function leo_tabla() As Data.DataTable
        Return Me.ejecutar("SELECT * FROM " & Me.nombre_tabla)
    End Function

    Public Function leo_tabla(ByVal pk As String) As DataTable
        Return Me.ejecutar("SELECT " & pk & " FROM " & Me.nombre_tabla)
    End Function

    Public Function leo_Consulta(ByVal consulta As String) As DataTable
        Return Me.ejecutar(consulta)
    End Function

    Public Function leo_tabla(ByVal pk As String, ByVal restricciones As String) As DataTable
        Return Me.ejecutar("SELECT " & pk & " FROM " & Me.nombre_tabla & " WHERE " & restricciones)
    End Function


    Private Sub abm(ByVal cadena As String)
        Me.conectar()
        Me.cmd.CommandText = cadena
        Me.cmd.ExecuteNonQuery()
        Me.cerrar()
    End Sub

    Public Sub insertar(ByVal cadena As String)
        Me.abm(cadena)
    End Sub

    Public Sub modificar(ByVal cadena As String)
        Me.abm(cadena)
    End Sub

    Public Sub borrar(ByVal tabla As String, ByVal restricciones As String)
        If (restricciones IsNot "") Then
            Me.abm("DELETE FROM " & tabla & " WHERE " & restricciones)
        End If
    End Sub

    Public Sub insertar2(ByVal cadena As String)
        Me.abm("INSERT INTO " & nombre_tabla & " " & cadena)
    End Sub

    Public Sub modificar(ByVal cadena As String, ByVal restriccion As String)
        Me.abm("UPDATE " & nombre_tabla & " SET " & cadena & " WHERE " & restriccion)
    End Sub

    Public Sub borrar(ByVal restricciones As String)
        If (restricciones IsNot "") Then
            Me.abm("DELETE FROM " & nombre_tabla & " WHERE " & restricciones)
        End If
    End Sub

End Class
