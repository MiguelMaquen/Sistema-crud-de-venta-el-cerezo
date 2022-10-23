Imports CapaDatos
Public Class ClsNegocioFactura
	Private ObjListar As New ClsFactura
	Private ObjInsertar As New ClsFactura
	Private ObjBuscar As New ClsFactura
	Private ObjModificar As New ClsFactura
	Private ObjEliminar As New ClsFactura
	Public Function N_InsertarFactura(id_cli As Integer, fecha As Date)
		Return ObjInsertar.CD_InsertarFactura(id_cli, fecha)
	End Function

	Public Function CN_ListarFactura() As DataTable
		Return ObjListar.CD_listarFactura()
	End Function

	Public Function N_BuscarFactura(Busqueda As String) As DataTable
		Return ObjBuscar.CD_BuscarFactura(Busqueda)
	End Function
	Public Function N_EliminarFactura(Eliminar As String)
		Return ObjEliminar.CD_EliminarFactura(Eliminar)
	End Function
	Public Function N_ActualizarFactura(id_fac As Integer, id_cli As Integer, fecha As Date)
		Return ObjModificar.CD_ActualizarFactura(id_fac, id_cli, fecha)
	End Function

End Class
