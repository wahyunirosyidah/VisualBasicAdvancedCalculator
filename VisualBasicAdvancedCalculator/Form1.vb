Public Class Form1

    Public Value1 As Double
    Public Value2 As Double
    Public Oper As Char


    Private Sub Tombol7_Click(sender As Object, e As EventArgs) Handles Tombol7.Click
        ShowValue(Tombol7)
    End Sub

    Private Sub Tombol8_Click(sender As Object, e As EventArgs) Handles Tombol8.Click
        ShowValue(Tombol8)
    End Sub

    Private Sub Tombol9_Click(sender As Object, e As EventArgs) Handles Tombol9.Click
        ShowValue(Tombol9)

    End Sub

    Private Sub Tombol4_Click(sender As Object, e As EventArgs) Handles Tombol4.Click
        ShowValue(Tombol4)
    End Sub

    Private Sub Tombol5_Click(sender As Object, e As EventArgs) Handles Tombol5.Click
        ShowValue(Tombol5)
    End Sub

    Private Sub Tombol6_Click(sender As Object, e As EventArgs) Handles Tombol6.Click
        ShowValue(Tombol6)
    End Sub

    Private Sub Tombol1_Click(sender As Object, e As EventArgs) Handles Tombol1.Click
        ShowValue(Tombol1)
    End Sub

    Private Sub Tombol2_Click(sender As Object, e As EventArgs) Handles Tombol2.Click
        ShowValue(Tombol2)
    End Sub

    Private Sub Tombol3_Click(sender As Object, e As EventArgs) Handles Tombol3.Click
        ShowValue(Tombol3)
    End Sub

    Private Sub Tombol0_Click(sender As Object, e As EventArgs) Handles Tombol0.Click
        ShowValue(Tombol0)
    End Sub

    Private Sub TombolBagi_Click(sender As Object, e As EventArgs) Handles TombolBagi.Click
        arithematic(TombolBagi)
    End Sub

    Private Sub TombolKali_Click(sender As Object, e As EventArgs) Handles TombolKali.Click
        arithematic(TombolKali)
    End Sub

    Private Sub TombolKurang_Click(sender As Object, e As EventArgs) Handles TombolKurang.Click
        arithematic(TombolKurang)
    End Sub

    Private Sub TombolTambah_Click(sender As Object, e As EventArgs) Handles TombolTambah.Click
        arithematic(TombolTambah)
    End Sub

    Private Sub TombolEqual_Click(sender As Object, e As EventArgs) Handles TombolEqual.Click
        Value2 = Val(TextBox1.Text)
        Calculate()
        ShowHistory()
        Value2 = 0
    End Sub
    Private Sub TombolKoma_Click(sender As Object, e As EventArgs) Handles TombolKoma.Click
        TextBox1.Text = TextBox1.Text & "."
    End Sub
End Class
