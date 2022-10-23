Imports System.Configuration
Imports System.Data.SqlClient

Public Class ClsEstablecimiento
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnRestaurantCerezo").ConnectionString)
    Public Function CD_BuscarEstablecimiento(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarEstablecimiento", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_listarEstablecimiento() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Establecimiento", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_InsertarEstablecimiento(id_estable As Integer, nom_estable As String, telef As Integer, direc As String)
        Dim da As New SqlCommand("SP_Set_AgregarEstablecimiento", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@ID_ESTABLECIMIENTO", id_estable)
        da.Parameters.AddWithValue("@NOM_ESTABLECIMIENTO", nom_estable)
        da.Parameters.AddWithValue("@TELEFONO", telef)
        da.Parameters.AddWithValue("@DIRECCION", direc)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado el establecimiento correctamente")
        Catch ex As Exception
            MsgBox("Error al registrar el establecimiento")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarEstablecimiento(idestab As Integer)
        Dim estab As New SqlCommand("SP_Set_EliminarEstablecimiento", cn)
        estab.CommandType = CommandType.StoredProcedure
        estab.Parameters.AddWithValue("@ID_ESTABLECIMIENTO", idestab)
        cn.Open()
        Dim estab1 As Integer = estab.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado el establecimiento")
        Catch ex As Exception
            MsgBox("Error al eliminar el establecimiento")
        End Try
        Return estab1
    End Function

    Public Function CD_ActualizarEstablecimiento(id_estable As Integer, nom_estable As String, telef As Integer, direc As String)
        Dim actEst As New SqlCommand("SP_Set_ActualizarEstablecimiento", cn)
        actEst.CommandType = CommandType.StoredProcedure
        actEst.Parameters.AddWithValue("@ID_ESTABLECIMIENTO", id_estable)
        actEst.Parameters.AddWithValue("@NOM_ESTABLECIMIENTO", nom_estable)
        actEst.Parameters.AddWithValue("@TELEFONO", telef)
        actEst.Parameters.AddWithValue("@DIRECCION", direc)
        cn.Open()
        Dim actVent1 As String = actEst.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha actualizado el establecimiento")
        Catch ex As Exception
            MsgBox("Error al actualizar el establecimiento")
        End Try
        Return actVent1
    End Function
End Class
