Imports System.Data.SqlClient
Imports System.Configuration
Public Class ClsDetalleFactura

    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnRestaurantCerezo").ConnectionString)

    Public Function CD_BuscarDetalleFactura(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarDetalleFactura", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@detalle", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function
    Public Function listarDetalleFactura() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Detalle_Factura", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function

End Class
