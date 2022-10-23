Imports System.Data.SqlClient
Imports System.Configuration
Public Class ClsFactura
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnRestaurantCerezo").ConnectionString)
    Public Function CD_BuscarFactura(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarFactura", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@factura", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_listarFactura() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Factura", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_InsertarFactura(id_cli As Integer, fecha As Date)

        Dim da As New SqlCommand("SP_Set_AgregarFactura", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@ID_CLIENTE", id_cli)
        da.Parameters.AddWithValue("@FECHA", fecha)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado Factura correctamente")
        Catch ex As Exception
            MsgBox("Error al registrar la Factura")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarFactura(id_fac As Integer)
        Dim dart As New SqlCommand("SP_Set_EliminarFactura", cn)
        dart.CommandType = CommandType.StoredProcedure
        dart.Parameters.AddWithValue("@ID_FACTURA", id_fac)
        cn.Open()
        Dim dcate As Integer = dart.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado la Factura")
        Catch ex As Exception
            MsgBox("Error al eliminar la Factura")
        End Try
        Return dcate
    End Function

    Public Function CD_ActualizarFactura(id_fac As Integer, id_cli As Integer, fecha As Date)
        Dim cli As New SqlCommand("SP_Set_ActualizarFactura", cn)
        cli.CommandType = CommandType.StoredProcedure
        cli.Parameters.AddWithValue("@ID_FACTURA", id_fac)
        cli.Parameters.AddWithValue("@ID_CLIENTE", id_cli)
        cli.Parameters.AddWithValue("@FECHA", fecha)
        cn.Open()
        Dim cli1 As String = cli.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha Actualizado la Factura")
        Catch ex As Exception
            MsgBox("Error al actualizar la Factura")
        End Try
        Return cli1
    End Function
End Class
