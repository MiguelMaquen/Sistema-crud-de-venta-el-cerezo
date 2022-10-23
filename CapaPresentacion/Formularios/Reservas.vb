Imports CapaNegocio

Public Class Reservas
    Dim ObjList As New ClsNegocioReservas
    Dim ObjRegis As New ClsNegocioReservas
    Dim ObjModi As New ClsNegocioReservas
    Dim ObjElim As New ClsNegocioReservas
    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGReserva.DataSource = ObjList.CN_ListarReserva
    End Sub

    Private Sub DGUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGReserva.CellContentClick
        txtCodigo.Text = DGReserva.Item(0, e.RowIndex).Value
        txtCliente.Text = DGReserva.Item(1, e.RowIndex).Value
        txtMesa.Text = DGReserva.Item(2, e.RowIndex).Value
        txtFecha.Text = DGReserva.Item(3, e.RowIndex).Value
        txtEstablecimiento.Text = DGReserva.Item(4, e.RowIndex).Value
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjRegis.N_InsertarReserva(txtCodigo.Text, txtCliente.Text, txtMesa.Text, (CDate(txtFecha.Text)), txtEstablecimiento.Text)
        DGReserva.DataSource = ObjRegis.CN_ListarReserva
        txtCodigo.Text = ""
        txtCliente.Text = ""
        txtMesa.Text = ""
        txtFecha.Text = ""
        txtEstablecimiento.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ObjRegis.N_ActualizarReserva(txtCodigo.Text, txtCliente.Text, txtMesa.Text, (CDate(txtFecha.Text)), txtEstablecimiento.Text)
        DGReserva.DataSource = ObjRegis.CN_ListarReserva
        txtCodigo.Text = ""
        txtCliente.Text = ""
        txtMesa.Text = ""
        txtFecha.Text = ""
        txtEstablecimiento.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjElim.N_EliminarReserva(txtCodigo.Text)
        DGReserva.DataSource = ObjElim.CN_ListarReserva
        txtCodigo.Text = ""
        txtCliente.Text = ""
        txtMesa.Text = ""
        txtFecha.Text = ""
        txtEstablecimiento.Text = ""
    End Sub
End Class