Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Imports System.Security.Policy
Public Class ClsCliente

    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnRestaurantCerezo").ConnectionString)
    Public Function CD_BuscarCliente(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarClientes", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_listarCliente() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Cliente", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_InsertarCliente(idcli As Integer, nom As String, apell As String, dir As String, telf As Integer)

        Dim da As New SqlCommand("SP_Set_AgregarCliente", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@ID_CLIENTE", idcli)
        da.Parameters.AddWithValue("@NOM_CLIENTE", nom)
        da.Parameters.AddWithValue("@APELLIDO_CLIENTE", apell)
        da.Parameters.AddWithValue("@DIRECCION_CLIENTE", dir)
        da.Parameters.AddWithValue("@TELEFONO_CLIENTE", telf)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado Cliente correctamente")
        Catch ex As Exception
            MsgBox("Error al registrar el Cliente")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarCliente(idcli As Integer)
        Dim dart As New SqlCommand("SP_Set_EliminarCliente", cn)
        dart.CommandType = CommandType.StoredProcedure
        dart.Parameters.AddWithValue("@ID_CLIENTE", idcli)
        cn.Open()
        Dim dcate As Integer = dart.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado el Cliente")
        Catch ex As Exception
            MsgBox("Error al eliminar el Cliente")
        End Try
        Return dcate
    End Function

    Public Function CD_ActualizarCliente(idcli As Integer, nom As String, apell As String, dir As String, telf As Integer)
        Dim cli As New SqlCommand("SP_Set_ActualizarCliente", cn)
        cli.CommandType = CommandType.StoredProcedure
        cli.Parameters.AddWithValue("@ID_CLIENTE", idcli)
        cli.Parameters.AddWithValue("@NOM_CLIENTE", nom)
        cli.Parameters.AddWithValue("@APELLIDO_CLIENTE", apell)
        cli.Parameters.AddWithValue("@DIRECCION_CLIENTE", dir)
        cli.Parameters.AddWithValue("@TELEFONO_CLIENTE", telf)
        cn.Open()
        Dim cli1 As String = cli.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha Actualizado el Cliente")
        Catch ex As Exception
            MsgBox("Error al actualizar el Cliente")
        End Try
        Return cli1
    End Function

End Class
