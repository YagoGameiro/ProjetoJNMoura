Public Class frmFiltro
    Private Sub frmFiltro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFiltro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFiltro.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.Close()
        End If
    End Sub
End Class