
Imports CapaNegocio
Public Class Establecimiento
    Dim conexion As clsConexion = New clsConexion()
    Dim ObjList As New ClsNegocioEstablecimiento
    Dim ObjRegis As New ClsNegocioEstablecimiento
    Dim ObjActua As New ClsNegocioEstablecimiento
    Dim ObjElim As New ClsNegocioEstablecimiento
    Dim ObjBuscar As New ClsNegocioEstablecimiento
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEstablecimiento.CellContentClick
        txtCodigo.Text = DGEstablecimiento.Item(0, e.RowIndex).Value
        txtEstablecimiento.Text = DGEstablecimiento.Item(1, e.RowIndex).Value
        txtTelefono.Text = DGEstablecimiento.Item(2, e.RowIndex).Value
        txtDireccion.Text = DGEstablecimiento.Item(3, e.RowIndex).Value
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGEstablecimiento.DataSource = ObjList.CN_ListarEstablecimiento()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjRegis.N_InsertarEstablecimiento(txtCodigo.Text, txtEstablecimiento.Text, txtTelefono.Text, txtDireccion.Text)
        DGEstablecimiento.DataSource = ObjRegis.CN_ListarEstablecimiento
        txtCodigo.Text = ""
        txtEstablecimiento.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ObjActua.N_ActualizarEstablecimiento(txtCodigo.Text, txtEstablecimiento.Text, txtTelefono.Text, txtDireccion.Text)
        DGEstablecimiento.DataSource = ObjActua.CN_ListarEstablecimiento
        txtCodigo.Text = ""
        txtEstablecimiento.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjElim.N_EliminarEstablecimiento(txtCodigo.Text)
        DGEstablecimiento.DataSource = ObjElim.CN_ListarEstablecimiento
        txtCodigo.Text = ""
        txtEstablecimiento.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Buscar = txtBuscar.Text
        DGEstablecimiento.DataSource = ObjBuscar.CN_ListarEstablecimiento(txtBuscar.Text)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Text = ""
        txtEstablecimiento.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
    End Sub
End Class