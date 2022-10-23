Imports CapaDatos
Imports CapaEntidad
Public Class ClsNegocioCliente
    Private objDatosBuscarCliente As New ClsCliente
    Private objInsertarCliente As New ClsCliente
    Private objListarCliente As New ClsCliente
    Private objEliminarCliente As New ClsCliente
    Private objActualizarCliente As New ClsCliente
    Public Function N_BuscarCliente(Busqueda As String) As DataTable
        Return objDatosBuscarCliente.CD_BuscarCliente(Busqueda)
    End Function
    Public Function N_InsertarCliente(idcli As Integer, nom As String, apell As String, dir As String, telf As String)
        Return objInsertarCliente.CD_InsertarCliente(idcli, nom, apell, dir, telf)
    End Function
    Public Function CN_ListarCliente() As DataTable
        Return objListarCliente.CD_listarCliente
    End Function
    Public Function N_EliminarCliente(Eliminar As String)
        Return objEliminarCliente.CD_EliminarCliente(Eliminar)
    End Function
    Public Function N_ActualizarCliente(idcli As Integer, nom As String, apell As String, dir As String, telf As String)
        Return objActualizarCliente.CD_ActualizarCliente(idcli, nom, apell, dir, telf)
    End Function
End Class
