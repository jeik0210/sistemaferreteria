<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnfactura = New System.Windows.Forms.Button()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.btnstock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnfactura
        '
        Me.btnfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfactura.Location = New System.Drawing.Point(29, 36)
        Me.btnfactura.Name = "btnfactura"
        Me.btnfactura.Size = New System.Drawing.Size(180, 69)
        Me.btnfactura.TabIndex = 0
        Me.btnfactura.Text = "Factura"
        Me.btnfactura.UseVisualStyleBackColor = True
        '
        'btningresar
        '
        Me.btningresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.Location = New System.Drawing.Point(29, 148)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(180, 67)
        Me.btningresar.TabIndex = 1
        Me.btningresar.Text = "Ingresar Producto"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'btnstock
        '
        Me.btnstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstock.Location = New System.Drawing.Point(29, 267)
        Me.btnstock.Name = "btnstock"
        Me.btnstock.Size = New System.Drawing.Size(180, 61)
        Me.btnstock.TabIndex = 2
        Me.btnstock.Text = "Stock"
        Me.btnstock.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 395)
        Me.Controls.Add(Me.btnstock)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.btnfactura)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnfactura As System.Windows.Forms.Button
    Friend WithEvents btningresar As System.Windows.Forms.Button
    Friend WithEvents btnstock As System.Windows.Forms.Button

End Class
