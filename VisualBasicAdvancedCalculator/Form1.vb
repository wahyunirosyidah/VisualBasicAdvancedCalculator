Public Class Form1

    Public Value1 As Double
    Public Value2 As Double
    Public Value3 As Double

    Public Oper As Char
    Public Simbol As String
    Public Simbol2 As String


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
    Private Sub TombolPersen_Click(sender As Object, e As EventArgs) Handles TombolPersen.Click
        Value1 = Val(TextBox1.Text)
        TextBox1.Text = Value1 / 100
        Simbol = Value1 & "%"
        ShowHistory2()
    End Sub
    Private Sub TombolLog_Click(sender As Object, e As EventArgs) Handles TombolLog.Click
        TextBox1.Text = TextBox1.Text
        log(TombolLog)
        ShowHistory2()
    End Sub
    Private Sub TombolAkar_Click(sender As Object, e As EventArgs) Handles TombolAkar.Click
        Value1 = Math.Sqrt(TextBox1.Text)
        TextBox1.Text = Value1
        Value2 = Val(TextBox1.Text)
        ShowHistory2()
    End Sub
    Private Sub TombolEqual_Click(sender As Object, e As EventArgs) Handles TombolEqual.Click
        Value2 = Val(TextBox1.Text)
        Calculate()
        ShowHistory()
        Value2 = 0
        SayIt()
    End Sub
    Private Sub TombolKoma_Click(sender As Object, e As EventArgs) Handles TombolKoma.Click
        TextBox1.Text = TextBox1.Text & "."
    End Sub

    Private Sub HistoryOnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryOnToolStripMenuItem.Click
        Me.Width = 714
        ToolStripDropDownButton1.Text = "History On"

    End Sub
    Private Sub HistoryOfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryOfToolStripMenuItem.Click
        Me.Width = 440
        ToolStripDropDownButton1.Text = "History Off"
    End Sub



    Private Sub TombolClear_Click(sender As Object, e As EventArgs) Handles TombolClear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub TombolCE_Click(sender As Object, e As EventArgs) Handles TombolCE.Click
        TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
    End Sub
End Class
