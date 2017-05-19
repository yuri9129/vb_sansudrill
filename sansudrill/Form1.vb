Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InBox.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Console.WriteLine(InBox.Text & "が入力されました。")
            OutBox.AppendText(InBox.Text & vbCrLf)
            InBox.Text = ""
        End If
    End Sub

End Class
