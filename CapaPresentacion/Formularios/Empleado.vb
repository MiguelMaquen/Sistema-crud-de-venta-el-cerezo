Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports CapaNegocio

Public Class Empleado


    Dim conexion As clsConexion = New clsConexion()
    Dim ObjNegocio As New cls_CapaNegocio
    Dim ObjRegis As New cls_CapaNegocio
    Dim objElim As New cls_CapaNegocio
    Dim objAct As New cls_CapaNegocio
    Dim objList As New cls_CapaNegocio

    Private Sub FormUSS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion.conectar()
        Me.DGEmpleado.DataSource = objList.CN_ListarEmpleado()

    End Sub

    Private Sub DGCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEmpleado.CellContentClick
        txtCodigo.Text = DGEmpleado.Item(0, e.RowIndex).Value
        txtNombre.Text = DGEmpleado.Item(1, e.RowIndex).Value
        txtApellido.Text = DGEmpleado.Item(2, e.RowIndex).Value
        txtTelefono.Text = DGEmpleado.Item(3, e.RowIndex).Value
        txtDireccion.Text = DGEmpleado.Item(4, e.RowIndex).Value
        txtCargo.Text = DGEmpleado.Item(5, e.RowIndex).Value
        txtEstablecimiento.Text = DGEmpleado.Item(6, e.RowIndex).Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Buscar = txtBuscar.Text
        DGEmpleado.DataSource = ObjNegocio.N_BuscarEmpleado(txtBuscar.Text)
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjRegis.N_InsertarEmpleado(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, txtCargo.Text, txtEstablecimiento.Text)
        DGEmpleado.DataSource = ObjRegis.CN_ListarEmpleado
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtCargo.Text = ""
        txtEstablecimiento.Text = ""


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtCargo.Text = ""
        txtEstablecimiento.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        objElim.N_EliminarEmpleado(txtCodigo.Text)
        DGEmpleado.DataSource = objElim.CN_ListarEmpleado
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtCargo.Text = ""
        txtEstablecimiento.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        objAct.N_ActualizarEmpleado(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, txtCargo.Text, txtEstablecimiento.Text)
        DGEmpleado.DataSource = objAct.CN_ListarEmpleado
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtCargo.Text = ""
        txtEstablecimiento.Text = ""
    End Sub
End Class