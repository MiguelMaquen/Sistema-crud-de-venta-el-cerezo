Imports CapaNegocio
Public Class Factura
    Dim ObjList As New ClsNegocioFactura
    Dim ObjRegis As New ClsNegocioFactura
    Dim ObjModi As New ClsNegocioFactura
    Dim ObjElim As New ClsNegocioFactura
    Dim ObjBus As New ClsNegocioFactura
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ObjRegis.N_InsertarFactura(txtCliente.Text, (CDate(DateFecha.Text)))
        DGFactura.DataSource = ObjRegis.CN_ListarFactura
        lblCodigo.Text = ""
        txtCliente.Text = ""
        DateFecha.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ObjModi.N_ActualizarFactura(lblCodigo.Text, txtCliente.Text, (CDate(DateFecha.Text)))
        DGFactura.DataSource = ObjRegis.CN_ListarFactura
        lblCodigo.Text = ""
        txtCliente.Text = ""
        DateFecha.Text = ""
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ObjElim.N_EliminarFactura(lblCodigo.Text)
        DGFactura.DataSource = ObjElim.CN_ListarFactura
        lblCodigo.Text = ""
        txtCliente.Text = ""
        DateFecha.Text = ""
    End Sub

    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGFactura.DataSource = ObjList.CN_ListarFactura
    End Sub

    Private Sub DGFactura_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGFactura.CellContentClick
        lblCodigo.Text = DGFactura.Item(0, e.RowIndex).Value
        txtCliente.Text = DGFactura.Item(1, e.RowIndex).Value
        DateFecha.Text = DGFactura.Item(2, e.RowIndex).Value
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Buscar = txtBuscar.Text
        DGFactura.DataSource = ObjBus.N_BuscarFactura(txtBuscar.Text)
    End Sub
End Class