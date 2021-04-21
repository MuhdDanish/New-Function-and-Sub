Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        PaparNama()
    End Sub

    Private Sub PaparNama()
        Result1.Text = "Nama"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Nama(strNama:=TextBox1.Text)
    End Sub

    Private Sub Nama(ByVal strNama As String)

        Result2.Text = strNama
    End Sub

    Function paparUmur()
        Result3.Text = "Umur"
        Return paparUmur
    End Function

    Private Function btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        paparUmur()
    End Function

    Function umur(ByVal intUmur As Integer) As Integer

        Result4.Text = intUmur
        Return umur
    End Function

    Private Function btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        umur(intUmur:=TextBox2.Text)
    End Function
End Class
