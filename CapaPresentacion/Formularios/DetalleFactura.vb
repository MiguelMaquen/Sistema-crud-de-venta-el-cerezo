Imports CapaNegocio

Public Class DetalleFactura
    Dim conexion As clsConexion = New clsConexion()
    Dim objList As New ClsNegocioDetalleFactura
    Dim ObjBuscar As New ClsNegocioDetalleFactura

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGDetalleFactura.DataSource = objList.CN_ListarDetalleFactura
    End Sub

    Private Sub DGReportes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDetalleFactura.CellContentClick

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Buscar = txtBuscarDetalleFactura.Text
        DGDetalleFactura.DataSource = ObjBuscar.N_BuscarDetalleFactura(txtBuscarDetalleFactura.Text)
    End Sub
End Class