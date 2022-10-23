<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetalleFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGDetalleFactura = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscarDetalleFactura = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DGDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGDetalleFactura
        '
        Me.DGDetalleFactura.AllowUserToAddRows = False
        Me.DGDetalleFactura.AllowUserToDeleteRows = False
        Me.DGDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDetalleFactura.Location = New System.Drawing.Point(12, 243)
        Me.DGDetalleFactura.Name = "DGDetalleFactura"
        Me.DGDetalleFactura.ReadOnly = True
        Me.DGDetalleFactura.Size = New System.Drawing.Size(837, 250)
        Me.DGDetalleFactura.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(537, 167)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 30)
        Me.btnBuscar.TabIndex = 28
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscarDetalleFactura
        '
        Me.txtBuscarDetalleFactura.Location = New System.Drawing.Point(209, 172)
        Me.txtBuscarDetalleFactura.Name = "txtBuscarDetalleFactura"
        Me.txtBuscarDetalleFactura.Size = New System.Drawing.Size(292, 20)
        Me.txtBuscarDetalleFactura.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(246, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(323, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Buscar Detalle Factura por ID"
        '
        'DetalleFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(861, 612)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscarDetalleFactura)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGDetalleFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DetalleFactura"
        Me.Text = "Reportes"
        CType(Me.DGDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGDetalleFactura As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscarDetalleFactura As TextBox
    Friend WithEvents Label9 As Label
End Class