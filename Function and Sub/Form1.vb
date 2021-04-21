Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        PaparNama()
    End Sub

    Private Sub PaparNama()
        Result1.Text = "Nama"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Nama(TextBox1.Text)
    End Sub

    Private Sub Nama(ByVal strNama As String)
        Dim strShowNama As String
        strShowNama = TextBox1.Text
        Result2.Text = strShowNama
    End Sub

    Function paparUmur()
        Result3.Text = "Umur"
        Return paparUmur
    End Function

    Private Function btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        paparUmur()
    End Function

    Function umur(ByVal intUmur As Integer) As Integer
        Dim intShowUmur As Integer
        intShowUmur = TextBox2.Text
        Result4.Text = intShowUmur
        Return umur
    End Function

    Private Function btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        umur(TextBox2.Text)
    End Function
End Class
