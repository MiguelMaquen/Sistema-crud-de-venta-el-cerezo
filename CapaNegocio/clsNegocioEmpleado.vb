Imports CapaDatos
Imports CapaEntidad
Public Class cls_CapaNegocio
	Private objDatos As New ClsEmpleado
	Private objDatosBuscarEmpleado As New ClsEmpleado
	Private dEmp As New ClsEmpleado
	Private Delim As New ClsEmpleado
	Private CAct As New ClsEmpleado

	Public Function N_InsertarEmpleado(ID_EMPLEADO As Integer, NOM_EMPLEADO As String, APELLIDO_EMPLEADO As String, TELEFONO As Integer, DIRECCION_EMPLEADO As String, CARGO As String, ID_ESTABLECIMIENTO As Integer)
		Return dEmp.CD_InsertarEmpleado(ID_EMPLEADO, NOM_EMPLEADO, APELLIDO_EMPLEADO, TELEFONO, DIRECCION_EMPLEADO, CARGO, ID_ESTABLECIMIENTO)
	End Function

	Public Function CN_ListarEmpleado() As DataTable
		Return objDatos.listarEmpleado()
	End Function

	Public Function N_BuscarEmpleado(Busqueda As String) As DataTable
		Return objDatosBuscarEmpleado.CD_BuscarEmpleado(Busqueda)
	End Function
	Public Function N_EliminarEmpleado(Eliminar As String)
		Return Delim.CD_EliminarEmpleado(Eliminar)
	End Function
	Public Function N_ActualizarEmpleado(ID_EMPLEADO As Integer, NOM_EMPLEADO As String, APELLIDO_EMPLEADO As String, TELEFONO As Integer, DIRECCION_EMPLEADO As String, CARGO As String, ID_ESTABLECIMIENTO As Integer)
		Return CAct.CD_ActualizarEmpleado(ID_EMPLEADO, NOM_EMPLEADO, APELLIDO_EMPLEADO, TELEFONO, DIRECCION_EMPLEADO, CARGO, ID_ESTABLECIMIENTO)
	End Function

End Class

