Public Class InputToPrompt
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Prompt out text from TextBox
        MessageBox.Show(txtInput.Text)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
