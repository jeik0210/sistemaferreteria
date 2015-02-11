Public Class Form2
    Dim producto(25) As String
    Dim precio(25), pre As Decimal
    Dim cantidad, subtotal, descuento, incremento, total, prec, totalf, comodin As Decimal


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        producto(0) = "aspiradora/soplador"
        producto(1) = "atornillador a bateria"
        producto(2) = "atornillador litium power"
        producto(3) = "bascula electronica"
        producto(4) = "bolsa carro portaherramienta"
        producto(5) = "cinta metrica"
        producto(6) = "cortavegetales electrico"
        producto(7) = "enrrollador"
        producto(8) = "hidrolimpiadora"
        producto(9) = "mandolina lux con 5 cuchillas"
        producto(10) = "pie de rey digital "
        producto(11) = "programador de riego"
        producto(12) = "rastreador de vehiculo /GPS"
        producto(13) = "sierra circular"
        producto(14) = "soldador de arco inverso"
        producto(15) = "taladro atornillador"
        producto(16) = "taladro electronico"
        producto(17) = "tijera de poda"
        producto(18) = "amoladora"
        producto(19) = "juego de alicates"
        producto(20) = "juego de martillos "
        producto(21) = "juego de llave"
        producto(22) = "gata hidraulica"
        producto(23) = "paleta de albañil"
        producto(24) = "cemento"
        producto(25) = "pintura"
        For i = 0 To 25
            cboproducto.Items.Add(producto(i))
        Next
        precio(0) = 80
        precio(1) = 60
        precio(2) = 57.29
        precio(3) = 81.84
        precio(4) = 14.79
        precio(5) = 15.5
        precio(6) = 42.52
        precio(7) = 88
        precio(8) = 190
        precio(9) = 67.08
        precio(10) = 34.95
        precio(11) = 78.02
        precio(12) = 1200
        precio(13) = 40.75
        precio(14) = 140
        precio(15) = 57.29
        precio(16) = 56.4
        precio(17) = 58.5
        precio(18) = 50.58
        precio(19) = 45.2
        precio(20) = 100
        precio(21) = 64.31
        precio(22) = 80
        precio(23) = 17
        precio(24) = 18
        precio(25) = 12

    End Sub

    Private Sub cboproducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboproducto.SelectedIndexChanged
        Dim s As Integer

        For j = 0 To 25
            s = cboproducto.SelectedIndex
            Select Case s
                Case j
                    txtprecio.Text = precio(j)
            End Select
        Next
    End Sub
    Sub factura()

        If txtcantidad.Text <> "" Then
            cantidad = Val(txtcantidad.Text)
            prec = txtprecio.Text
            subtotal = cantidad * prec
            If rdnefectivo.Checked = True Then
                descuento = prec * 0.1
            End If
            If rdntarjeta.Checked = True Then
                descuento = prec * 0.2
            End If
            If rdncheque.Checked = True Then
                descuento = prec * 0.05
            End If

            If chkenvio.Checked = True Then
                incremento = prec * 0.2

            End If
            total = subtotal + incremento - descuento

        Else
            cantidad = 1
            txtcantidad.Text = cantidad
            prec = txtprecio.Text
            subtotal = prec
            If rdnefectivo.Checked = True Then
                descuento = prec * 0.1
            End If
            If rdntarjeta.Checked = True Then
                descuento = prec * 0.2
            End If
            If rdncheque.Checked = True Then
                descuento = prec * 0.05
            End If

            If chkenvio.Checked = True Then
                incremento = prec * 0.2

            End If
            total = subtotal + incremento - descuento

        End If

    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        If txtnombre.Text <> "" Then
            If txttelefono.Text <> "" Then
                If txtdireccion.Text <> "" Then
                    If txtdni.Text <> "" Then
                        If cboproducto.SelectedIndex <> -1 Then
                            If rdnefectivo.Checked = True Or rdntarjeta.Checked = True Or rdncheque.Checked = True Then
                                lstcliente.Items.Add(txtnombre.Text)
                                lstproducto.Items.Add(cboproducto.SelectedItem)
                                factura()
                                lstcantidad.Items.Add(txtcantidad.Text)

                                lstprecio.Items.Add(total)
                                totalf = total + totalf
                                TxtTotal.Text = Val(totalf)


                            Else
                                MessageBox.Show("Seleccione tipo de pago", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                            End If

                        Else
                            MessageBox.Show("ingrese producto", "producto", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        End If
                    Else
                        MessageBox.Show("ingrese DNI", "DNI", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
                    End If
                Else
                    MessageBox.Show("Ingrese Direcion", "Verigicar", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
                End If
            Else
                MessageBox.Show("Ingrese Telefono", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        Else
            MessageBox.Show("Ingrese Nombre", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

   

    Private Sub lstcliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcliente.SelectedIndexChanged
        If lstcliente.SelectedIndex <> -1 Then
            lstcantidad.SelectedIndex = lstcliente.SelectedIndex
            lstprecio.SelectedIndex = lstcliente.SelectedIndex
            lstproducto.SelectedIndex = lstcliente.SelectedIndex
        End If
    End Sub

    Private Sub lstproducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstproducto.SelectedIndexChanged
        If lstproducto.SelectedIndex <> -1 Then
            lstcliente.SelectedIndex = lstproducto.SelectedIndex
            lstprecio.SelectedIndex = lstproducto.SelectedIndex
            lstproducto.SelectedIndex = lstproducto.SelectedIndex
        End If
    End Sub

    Private Sub lstcantidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcantidad.SelectedIndexChanged
        If lstcantidad.SelectedIndex <> -1 Then
            lstcliente.SelectedIndex = lstcantidad.SelectedIndex
            lstprecio.SelectedIndex = lstcantidad.SelectedIndex
            lstproducto.SelectedIndex = lstcantidad.SelectedIndex
        End If

    End Sub

    Private Sub lstprecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstprecio.SelectedIndexChanged
        If lstprecio.SelectedIndex <> -1 Then
            lstcliente.SelectedIndex = lstprecio.SelectedIndex
            lstproducto.SelectedIndex = lstprecio.SelectedIndex
            lstcantidad.SelectedIndex = lstprecio.SelectedIndex
        End If
    End Sub

    
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        If lstcliente.SelectedIndex <> -1 Then
            lstcliente.Items.RemoveAt(lstcliente.SelectedIndex)
            lstcantidad.Items.RemoveAt(lstcantidad.SelectedIndex)
            lstproducto.Items.RemoveAt(lstproducto.SelectedIndex)

            comodin = lstprecio.SelectedItem
            totalf = TxtTotal.Text - comodin
            lstprecio.Items.RemoveAt(lstprecio.SelectedIndex)
            TxtTotal.Text = totalf
        End If
    End Sub

    Private Sub rdnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdnsalir.Click
        If MessageBox.Show("¿Desea salir?", " salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub rdnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdnnuevo.Click
        txtnombre.Text = ""
        txtdni.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtprecio.Text = ""
        txtcantidad.Text = ""
        cboproducto.SelectedIndex = -1
        rdncheque.Checked = False
        rdnefectivo.Checked = False
        rdntarjeta.Checked = False
        chkenvio.Checked = False
        txtnombre.Focus()

    End Sub
End Class