﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pantalla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pantalla))
        Me.pnPrincipal = New System.Windows.Forms.Panel()
        Me.btnSalir = New FontAwesome.Sharp.IconButton()
        Me.btnUsuario = New FontAwesome.Sharp.IconButton()
        Me.btnReportes = New FontAwesome.Sharp.IconButton()
        Me.btnVentas = New FontAwesome.Sharp.IconButton()
        Me.btnClientes = New FontAwesome.Sharp.IconButton()
        Me.btnCategorias = New FontAwesome.Sharp.IconButton()
        Me.btnFactura = New FontAwesome.Sharp.IconButton()
        Me.imgUSS = New System.Windows.Forms.PictureBox()
        Me.pnHome = New System.Windows.Forms.Panel()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.LabelFormActual = New System.Windows.Forms.Label()
        Me.IconFormActual = New FontAwesome.Sharp.IconPictureBox()
        Me.pnPrincipal.SuspendLayout()
        CType(Me.imgUSS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        CType(Me.IconFormActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnPrincipal
        '
        Me.pnPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnPrincipal.BackColor = System.Drawing.Color.IndianRed
        Me.pnPrincipal.Controls.Add(Me.btnSalir)
        Me.pnPrincipal.Controls.Add(Me.btnUsuario)
        Me.pnPrincipal.Controls.Add(Me.btnReportes)
        Me.pnPrincipal.Controls.Add(Me.btnVentas)
        Me.pnPrincipal.Controls.Add(Me.btnClientes)
        Me.pnPrincipal.Controls.Add(Me.btnCategorias)
        Me.pnPrincipal.Controls.Add(Me.btnFactura)
        Me.pnPrincipal.Controls.Add(Me.imgUSS)
        Me.pnPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.pnPrincipal.Name = "pnPrincipal"
        Me.pnPrincipal.Size = New System.Drawing.Size(287, 612)
        Me.pnPrincipal.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.btnSalir.IconColor = System.Drawing.Color.RoyalBlue
        Me.btnSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(3, 545)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(281, 60)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUsuario.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.UserCog
        Me.btnUsuario.IconColor = System.Drawing.Color.RoyalBlue
        Me.btnUsuario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuario.Location = New System.Drawing.Point(3, 479)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(281, 60)
        Me.btnUsuario.TabIndex = 13
        Me.btnUsuario.Text = "Reservaciones"
        Me.btnUsuario.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnReportes.IconChar = FontAwesome.Sharp.IconChar.Pager
        Me.btnReportes.IconColor = System.Drawing.Color.RoyalBlue
        Me.btnReportes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(3, 413)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(281, 60)
        Me.btnReportes.TabIndex = 11
        Me.btnReportes.Text = "Detalle Factura"
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnVentas.IconChar = FontAwesome.Sharp.IconChar.Shopify
        Me.btnVentas.IconColor = System.Drawing.Color.RoyalBlue
        Me.btnVentas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(3, 347)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(281, 60)
        Me.btnVentas.TabIndex = 10
        Me.btnVentas.Text = "Establecimiento"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnClientes.IconChar = FontAwesome.Sharp.IconChar.BoxOpen
        Me.btnClientes.IconColor = System.Drawing.Color.RoyalBlue
        Me.btnClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(3, 281)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(281, 60)
        Me.btnClientes.TabIndex = 9
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnCategorias
        '
        Me.btnCategorias.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCategorias.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnCategorias.FlatAppearance.BorderSize = 0
        Me.btnCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategorias.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnCategorias.IconChar = FontAwesome.Sharp.IconChar.ListCheck
        Me.btnCategorias.IconColor = System.Drawing.Color.RoyalBlue
        Me.btnCategorias.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategorias.Location = New System.Drawing.Point(3, 215)
        Me.btnCategorias.Name = "btnCategorias"
        Me.btnCategorias.Size = New System.Drawing.Size(281, 60)
        Me.btnCategorias.TabIndex = 8
        Me.btnCategorias.Text = "Empleados"
        Me.btnCategorias.UseVisualStyleBackColor = False
        '
        'btnFactura
        '
        Me.btnFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFactura.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnFactura.FlatAppearance.BorderSize = 0
        Me.btnFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnFactura.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnFactura.IconColor = System.Drawing.Color.RoyalBlue
        Me.btnFactura.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFactura.Location = New System.Drawing.Point(3, 149)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(281, 60)
        Me.btnFactura.TabIndex = 7
        Me.btnFactura.Text = "Factura"
        Me.btnFactura.UseVisualStyleBackColor = False
        '
        'imgUSS
        '
        Me.imgUSS.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.imgUSS.Cursor = System.Windows.Forms.Cursors.No
        Me.imgUSS.Image = CType(resources.GetObject("imgUSS.Image"), System.Drawing.Image)
        Me.imgUSS.Location = New System.Drawing.Point(3, 3)
        Me.imgUSS.Name = "imgUSS"
        Me.imgUSS.Size = New System.Drawing.Size(281, 140)
        Me.imgUSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgUSS.TabIndex = 0
        Me.imgUSS.TabStop = False
        '
        'pnHome
        '
        Me.pnHome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnHome.BackColor = System.Drawing.Color.DarkGray
        Me.pnHome.Location = New System.Drawing.Point(305, 95)
        Me.pnHome.Name = "pnHome"
        Me.pnHome.Size = New System.Drawing.Size(943, 529)
        Me.pnHome.TabIndex = 1
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelPrincipal.BackColor = System.Drawing.Color.DarkGray
        Me.PanelPrincipal.Controls.Add(Me.LabelFormActual)
        Me.PanelPrincipal.Controls.Add(Me.IconFormActual)
        Me.PanelPrincipal.Location = New System.Drawing.Point(305, 12)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(943, 77)
        Me.PanelPrincipal.TabIndex = 2
        '
        'LabelFormActual
        '
        Me.LabelFormActual.AutoSize = True
        Me.LabelFormActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFormActual.Location = New System.Drawing.Point(388, 32)
        Me.LabelFormActual.Name = "LabelFormActual"
        Me.LabelFormActual.Size = New System.Drawing.Size(0, 20)
        Me.LabelFormActual.TabIndex = 1
        '
        'IconFormActual
        '
        Me.IconFormActual.BackColor = System.Drawing.Color.DarkGray
        Me.IconFormActual.Cursor = System.Windows.Forms.Cursors.No
        Me.IconFormActual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconFormActual.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconFormActual.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconFormActual.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconFormActual.IconSize = 71
        Me.IconFormActual.Location = New System.Drawing.Point(3, 3)
        Me.IconFormActual.Name = "IconFormActual"
        Me.IconFormActual.Size = New System.Drawing.Size(93, 71)
        Me.IconFormActual.TabIndex = 0
        Me.IconFormActual.TabStop = False
        '
        'Pantalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 636)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.pnHome)
        Me.Controls.Add(Me.pnPrincipal)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "Pantalla"
        Me.Text = "Picanteria Cerezo"
        Me.pnPrincipal.ResumeLayout(False)
        CType(Me.imgUSS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        CType(Me.IconFormActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnPrincipal As Panel
    Friend WithEvents imgUSS As PictureBox
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsuario As FontAwesome.Sharp.IconButton
    Friend WithEvents btnReportes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVentas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCategorias As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFactura As FontAwesome.Sharp.IconButton
    Friend WithEvents pnHome As Panel
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents IconFormActual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents LabelFormActual As Label
End Class
