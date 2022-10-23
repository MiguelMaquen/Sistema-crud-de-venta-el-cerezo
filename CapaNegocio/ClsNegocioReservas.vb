Imports CapaDatos
Public Class ClsNegocioReservas

    Private objBuscar As New ClsReservas
    Private objInsertar As New ClsReservas
    Private objListar As New ClsReservas
    Private objEliminar As New ClsReservas
    Private objActualizar As New ClsReservas
    Public Function N_BuscarReserva(Busqueda As String) As DataTable
        Return objBuscar.CD_BuscarReservas(Busqueda)
    End Function
    Public Function N_InsertarReserva(id_reser As Integer, id_cli As Integer, id_mesa As Integer, fech As Date, id_estab As Integer)
        Return objInsertar.CD_InsertarReservas(id_reser, id_cli, id_mesa, fech, id_estab)
    End Function
    Public Function CN_ListarReserva() As DataTable
        Return objListar.CD_listarReservas
    End Function
    Public Function N_EliminarReserva(Eliminar As String)
        Return objEliminar.CD_EliminarReservas(Eliminar)
    End Function
    Public Function N_ActualizarReserva(id_reser As Integer, id_cli As Integer, id_mesa As Integer, fech As Date, id_estab As Integer)
        Return objActualizar.CD_ActualizarReservas(id_reser, id_cli, id_mesa, fech, id_estab)
    End Function

End Class
