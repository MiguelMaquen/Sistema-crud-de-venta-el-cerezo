Imports CapaDatos

Public Class ClsNegocioEstablecimiento

    Private objBuscar As New ClsEstablecimiento
    Private objInsertar As New ClsEstablecimiento
    Private objListar As New ClsEstablecimiento
    Private objEliminar As New ClsEstablecimiento
    Private objActualizar As New ClsEstablecimiento
    Public Function N_BuscarEstablecimiento(Busqueda As String) As DataTable
        Return objBuscar.CD_BuscarEstablecimiento(Busqueda)
    End Function
    Public Function N_InsertarEstablecimiento(id_estable As Integer, nom_estable As String, telef As Integer, direc As String)
        Return objInsertar.CD_InsertarEstablecimiento(id_estable, nom_estable, telef, direc)
    End Function
    Public Function CN_ListarEstablecimiento() As DataTable
        Return objListar.CD_listarEstablecimiento
    End Function
    Public Function N_EliminarEstablecimiento(Eliminar As String)
        Return objEliminar.CD_EliminarEstablecimiento(Eliminar)
    End Function
    Public Function N_ActualizarEstablecimiento(id_estable As Integer, nom_estable As String, telef As Integer, direc As String)
        Return objActualizar.CD_ActualizarEstablecimiento(id_estable, nom_estable, telef, direc)
    End Function

End Class
