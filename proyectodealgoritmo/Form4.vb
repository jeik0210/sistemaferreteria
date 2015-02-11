Public Class Form4

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        If MessageBox.Show("¿Desea salir?", " salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        txtcodigo.Text = ""
        txtcantidad.Text = ""
        txtnombre.Text = ""
        txtprecio.Text = ""
        txtcodigo.Focus()

    End Sub
End Class