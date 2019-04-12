Public Class LoginForm
    Private prstationFrm As PresentationForm

    Private Sub uxLogin_Click(sender As Object, e As EventArgs) Handles uxLogin.Click
        If (uxUserName.Text = "ADMIN" And uxPassword.Text = "CPRG254") Then
            'Me.Hide()
            If prstationFrm Is Nothing OrElse prstationFrm.IsDisposed Then
                prstationFrm = New PresentationForm()
            End If
            prstationFrm.Show()
            prstationFrm.BringToFront()


        Else

            MessageBox.Show("Wrong Password or User Name. Try Again")
            uxUserName.Clear()
            uxPassword.Clear()
            uxUserName.Focus()
        End If
    End Sub

    Private Sub uxCancel_Click(sender As Object, e As EventArgs) Handles uxCancel.Click
        uxUserName.Clear()
        uxPassword.Clear()
        uxUserName.Focus()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub uxClose_Click(sender As Object, e As EventArgs) Handles uxClose.Click
        Close()
    End Sub
End Class
