Imports CapaDatos
Public Class ClsNegocioDetalleFactura
    Private objListarDetalleFactura As New ClsDetalleFactura
    Private objBuscarDetalleFactura As New ClsDetalleFactura

    Public Function N_BuscarDetalleFactura(Busqueda As String) As DataTable
        Return objBuscarDetalleFactura.CD_BuscarDetalleFactura(Busqueda)
    End Function
    Public Function CN_ListarDetalleFactura() As DataTable
        Return objListarDetalleFactura.listarDetalleFactura
    End Function

End Class
