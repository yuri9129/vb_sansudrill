Public Class Form1
    Dim varA As Integer
    Dim varB As Integer
    Dim Hantei As String
    Dim Rand As New Random

    Sub MondaiSakusei()
        varA = Rand.Next(1, 10)
        varB = Rand.Next(1, 10)
        MondaiLbl.Text = varA & " + " & varB & " = "
    End Sub

    Sub check_answer()
        If varA + varB = InBox.Text Then
            Hantei = "○"
        Else
            Hantei = "×"
        End If

        OutBox.AppendText(Hantei & MondaiLbl.Text & InBox.Text & vbCrLf)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InBox.KeyPress
        '0より小さい文字コードを無効
        '9より大きい文字コードを無効
        'バックスペースを無効
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(Keys.Enter) And InBox.Text <> "" Then
            Console.WriteLine(InBox.Text & "が入力されました。")
            check_answer()
            InBox.Text = ""
            MondaiSakusei()
        End If
    End Sub

    Private Sub MondaiLbl_Click(sender As Object, e As EventArgs) Handles MondaiLbl.Click

    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        MondaiSakusei()
    End Sub

    Private Sub InBox_TextChanged(sender As Object, e As EventArgs) Handles InBox.TextChanged

    End Sub
End Class
