Imports System.Configuration
Imports System.Data.SqlClient
Public Class ClsReservas
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnRestaurantCerezo").ConnectionString)

    Public Function CD_listarReservas() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Reservas", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_BuscarReservas(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarReservas", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@reserva", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_InsertarReservas(id_reser As Integer, id_cli As Integer, id_mesa As Integer, fech As Date, id_estab As Integer)

        Dim da As New SqlCommand("SP_Set_AgregarReservas", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@ID_RESERVA", id_reser)
        da.Parameters.AddWithValue("@ID_CLIENTE", id_cli)
        da.Parameters.AddWithValue("@ID_MESA", id_mesa)
        da.Parameters.AddWithValue("@FECHA_RESERVACION", fech)
        da.Parameters.AddWithValue("@ID_ESTABLECIMIENTO", id_estab)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado correctamente la reserva")
        Catch ex As Exception
            MsgBox("Error al registrar reserva")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarReservas(idreser As Integer)
        Dim da As New SqlCommand("SP_Set_EliminarReservas", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@ID_RESERVA", idreser)
        cn.Open()
        Dim daa As Integer = da.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado la reserva")
        Catch ex As Exception
            MsgBox("Error al eliminar la reserva")
        End Try
        Return daa
    End Function

    Public Function CD_ActualizarReservas(id_reser As Integer, id_cli As Integer, id_mesa As Integer, fech As Date, id_estab As Integer)
        Dim da As New SqlCommand("SP_Set_ActualizarReservas", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@ID_RESERVA", id_reser)
        da.Parameters.AddWithValue("@ID_CLIENTE", id_cli)
        da.Parameters.AddWithValue("@ID_MESA", id_mesa)
        da.Parameters.AddWithValue("@FECHA_RESERVACION", fech)
        da.Parameters.AddWithValue("@ID_ESTABLECIMIENTO", id_estab)
        cn.Open()
        Dim dad As String = da.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha Actualizado la reserva")
        Catch ex As Exception
            MsgBox("Error al actualizar la reserva")
        End Try
        Return dad
    End Function
End Class
