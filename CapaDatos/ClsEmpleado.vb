Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Imports System.Security.Policy
Imports System.Security.Cryptography

Public Class ClsEmpleado

    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnRestaurantCerezo").ConnectionString)

    Public Function listarEmpleado() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("SP_Get_Listar_Empleado", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt
    End Function
    Public Function CD_BuscarEmpleado(objEnt As String) As DataTable
        Dim cmd As New SqlCommand("SP_Get_BuscarEmpleado", cn)
        cn.Open()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", objEnt)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cn.Close()
        Return dt

    End Function

    Public Function CD_InsertarEmpleado(ID_EMPLEADO As Integer, NOM_EMPLEADO As String, APELLIDO_EMPLEADO As String, TELEFONO As Integer, DIRECCION_EMPLEADO As String, CARGO As String, ID_ESTABLECIMIENTO As Integer)

        Dim da As New SqlCommand("SP_Set_AgregarEmpleado", cn)
        da.CommandType = CommandType.StoredProcedure
        da.Parameters.AddWithValue("@ID_EMPLEADO", ID_EMPLEADO)
        da.Parameters.AddWithValue("@NOM_EMPLEADO", NOM_EMPLEADO)
        da.Parameters.AddWithValue("@APELLIDO_EMPLEADO", APELLIDO_EMPLEADO)
        da.Parameters.AddWithValue("@TELEFONO", TELEFONO)
        da.Parameters.AddWithValue("@DIRECCION_EMPLEADO", DIRECCION_EMPLEADO)
        da.Parameters.AddWithValue("@CARGO", CARGO)
        da.Parameters.AddWithValue("@ID_ESTABLECIMIENTO", ID_ESTABLECIMIENTO)
        cn.Open()
        Dim resp As Integer
        Try
            resp = da.ExecuteNonQuery
            cn.Close()
            MsgBox("Se ha registrado correctamente")
        Catch ex As Exception
            MsgBox("Error al registrar al Empleado")
        End Try
        Return resp

    End Function

    Public Function CD_EliminarEmpleado(idemp As Integer)
        Dim demp As New SqlCommand("SP_Set_EliminarEmpleado", cn)
        demp.CommandType = CommandType.StoredProcedure
        demp.Parameters.AddWithValue("@ID_EMPLEADO", idemp)
        cn.Open()
        Dim demp1 As Integer = demp.ExecuteNonQuery

        Try
            cn.Close()
            MsgBox("Se ha eliminado al Empleado")
        Catch ex As Exception
            MsgBox("Error al eliminar al Empleado")
        End Try
        Return demp1
    End Function

    Public Function CD_ActualizarEmpleado(ID_EMPL As Integer, NOM_EMPLEADO As String, APELLIDO_EMPLEADO As String, TELEFONO As Integer, DIRECCION_EMPLEADO As String, CARGO As String, ID_ESTABLECIMIENTO As Integer)
        Dim actEmp As New SqlCommand("SP_Set_ActualizarEmpleado", cn)
        actEmp.CommandType = CommandType.StoredProcedure
        actEmp.Parameters.AddWithValue("@ID_EMPLEADO", ID_EMPL)
        actEmp.Parameters.AddWithValue("@NOM_EMPLEADO", NOM_EMPLEADO)
        actEmp.Parameters.AddWithValue("@APELLIDO_EMPLEADO", APELLIDO_EMPLEADO)
        actEmp.Parameters.AddWithValue("@TELEFONO", TELEFONO)
        actEmp.Parameters.AddWithValue("@DIRECCION_EMPLEADO", DIRECCION_EMPLEADO)
        actEmp.Parameters.AddWithValue("@CARGO", CARGO)
        actEmp.Parameters.AddWithValue("@ID_ESTABLECIMIENTO", ID_ESTABLECIMIENTO)
        cn.Open()
        Dim actEmp1 As String = actEmp.ExecuteNonQuery
        Try
            cn.Close()
            MsgBox("Se ha Actualizado Empleado")
        Catch ex As Exception
            MsgBox("Error al actualizar Empleado")
        End Try
        Return actEmp1
    End Function
End Class
