Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        PaparNama()
    End Sub

    Private Sub PaparNama()
        Result1.Text = "Nama"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Dim strShowNama As String
        strShowNama = TextBox1.Text
        Result2.Text = strShowNama
        Nama(strNama:=TextBox1.Text)
    End Sub

    Private Sub Nama(strNama As String)
        Dim strInsert As String
    End Sub

    Function paparUmur()
        Result3.Text = "Umur"
    End Function

    Private Function btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        paparUmur()
    End Function

    Function umur(intUmur As Integer) As Integer
        Dim intInsert As Integer
    End Function

    Private Function btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Dim intShowUmur As Integer
        intShowUmur = TextBox2.Text
        Result4.Text = intShowUmur
        umur(intUmur:=TextBox2.Text)
    End Function
End Class
