Public Class frmVentana

    Private Sub frmVentana_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblExit.Click
        Me.Close()

    End Sub
    'Programamos el boton para que nos lleve a la ventana de prestamos
    Private Sub btnPres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPres.Click
        frmPrestamos.ShowDialog()
    End Sub
    'Programamos el boton para que nos lleve a la ventana de devoluciones
    Private Sub btnDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDev.Click
        frmDevoluciones.ShowDialog()
    End Sub

    Private Sub btnSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocios.Click
        frmSocios.ShowDialog()

    End Sub

    Private Sub btnLibros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLibros.Click
        frmLibros.ShowDialog()
    End Sub
End Class
