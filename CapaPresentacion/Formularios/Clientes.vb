Imports CapaNegocio

Public Class Clientes


    Dim ObjBuscar As New ClsNegocioCliente
    Dim ObjInsertar As New ClsNegocioCliente
    Dim ObjListar As New ClsNegocioCliente
    Dim ObjEliminar As New ClsNegocioCliente
    Dim ObjActualizar As New ClsNegocioCliente

    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGCliente.DataSource = ObjListar.CN_ListarCliente
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCliente.CellContentClick
        txtId_Cliente.Text = DGCliente.Item(0, e.RowIndex).Value
        txtNombre.Text = DGCliente.Item(1, e.RowIndex).Value
        txtApellido.Text = DGCliente.Item(2, e.RowIndex).Value
        txtDireccion.Text = DGCliente.Item(3, e.RowIndex).Value
        txtTelefono.Text = DGCliente.Item(4, e.RowIndex).Value
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Buscar = txtBuscarCliente.Text
        DGCliente.DataSource = ObjBuscar.N_BuscarCliente(txtBuscarCliente.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjInsertar.N_InsertarCliente(txtId_Cliente.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text)
        DGCliente.DataSource = ObjInsertar.CN_ListarCliente
        txtId_Cliente.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjEliminar.N_EliminarCliente(txtId_Cliente.Text)
        DGCliente.DataSource = ObjEliminar.CN_ListarCliente
        txtId_Cliente.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ObjActualizar.N_ActualizarCliente(txtId_Cliente.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text)
        DGCliente.DataSource = ObjActualizar.CN_ListarCliente
        txtId_Cliente.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtId_Cliente.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
    End Sub

    Private Sub txtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCliente.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class