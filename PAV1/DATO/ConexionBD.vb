Public Class ConexionBD

    Enum CadenaConexion
        Ale
        Alan
        Elias
        David
    End Enum

    'Estableszo lo que sera la cadena de conexion y nombre de la tabla sobre la cual voy a trabajar
    Dim StringConexion As String = ""
    Dim nombreTabla As String = ""

    Dim str_conexion As CadenaConexion = CadenaConexion.Elias

    Private Sub elegir_base()
        Select Case str_conexion
            Case CadenaConexion.Ale
                Me.StringConexion = ""
            Case CadenaConexion.Alan
            Case CadenaConexion.Elias
                Me.StringConexion = "Data Source=(local);Initial Catalog=BD_Transporte_Don_Luis;User ID=sa;Password=jinjo32"
            Case CadenaConexion.David
        End Select
    End Sub
    

    'Creo las variables que me establecer una conexion y realizar consultas
    Dim conexion As Data.SqlClient.SqlConnection
    Dim comando As Data.SqlClient.SqlCommand

    'Propiedades SET y GET para acceder publicamente
    Public Property _cadenaConexion() As String
        Get
            Return Me.StringConexion
        End Get
        Set(ByVal value As String)
            Me.StringConexion = value
        End Set
    End Property
    Public Property _nombreTabla() As String
        Get
            Return Me.nombreTabla
        End Get
        Set(ByVal value As String)
            Me.nombreTabla = value
        End Set
    End Property

    'Creo el metodo que me permita conectar con la base de datos
    Private Sub conectar()
        Me.elegir_base()
        conexion = New SqlClient.SqlConnection
        comando = New Data.SqlClient.SqlCommand
        conexion.ConnectionString = StringConexion
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
    End Sub
    'Cierro la conexion
    Private Sub cerrarConexion()
        conexion.Close()
    End Sub
    'Ejectutara la consulta SQL pasada por parametro estableciendo la conexion a la BD. Es privada 
    Private Function ejecutarSQL(ByVal query As String) As Data.DataTable
        conectar()
        comando.CommandText = query
        Dim tabla As New Data.DataTable
        tabla.Load(comando.ExecuteReader())
        cerrarConexion()
        Return tabla
    End Function
    'Funcion que llamare desde otra clase para realizar una consulta
    Public Function ejecutarQuery(ByVal query As String) As Data.DataTable
        Return ejecutarSQL(query)
    End Function
    Public Function leoTabla(ByVal nombre As String) As Data.DataTable
        Return Me.ejecutarSQL("SELECT * FROM " & nombre)
    End Function
    Public Function leoTabla() As Data.DataTable
        Return Me.ejecutarSQL("SELECT * FROM " & Me.nombreTabla)
    End Function
    'Leo consulta con una condicion
    Public Function leoTabla(ByVal nombreTabla As String, ByVal condicion As String) As Data.DataTable
        Return Me.ejecutarSQL("SELECT * FROM " & nombreTabla & " WHERE " & condicion)
    End Function

    'Funcion para insertar, actualizar y dar de baja
    Private Sub abm(ByVal query As String)
        conectar()
        comando.CommandText = query
        comando.ExecuteNonQuery()
        cerrarConexion()
    End Sub

    Public Sub insertar(ByVal sql As String)
        Me.abm(sql)
    End Sub
    Public Sub actualizar(ByVal sql As String)
        Me.abm(sql)
    End Sub
    Public Sub eliminar(ByVal nombreTabla As String, ByVal condicion As String)
        Me.abm("DELETE FROM " & nombreTabla & " WHERE " & condicion)
    End Sub
End Class
