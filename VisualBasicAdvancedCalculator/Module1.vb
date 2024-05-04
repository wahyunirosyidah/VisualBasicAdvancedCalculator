Module Module1


    Sub ShowValue(ByVal Tombol As Button)
        Form1.TextBox1.Text = Val(Form1.TextBox1.Text & Tombol.Text)
    End Sub


    Sub log(ByVal Tombol As Button)
        Form1.TextBox1.Text = Form1.TextBox1.Text
        Form1.Value1 = Val(Form1.TextBox1.Text)
        Form1.Value2 = Math.Log(Form1.TextBox1.Text)
        Form1.TextBox1.Text = Form1.Value2 * 0.43429448190325182
        Form1.Simbol = "log(" & Form1.Value1 & ")"
    End Sub

    Sub arithematic(ByVal Tombol As Button)
        Form1.Value1 = Val(Form1.TextBox1.Text)
        Form1.Oper = Tombol.Text
        Form1.TextBox1.Text = ""

    End Sub

    Sub Calculate()
        Select Case Form1.Oper
            Case "+"
                Form1.TextBox1.Text = Form1.Value1 + Val(Form1.TextBox1.Text)
            Case "-"
                Form1.TextBox1.Text = Form1.Value1 - Val(Form1.TextBox1.Text)
            Case "x"
                Form1.TextBox1.Text = Form1.Value1 * Val(Form1.TextBox1.Text)
            Case "/"
                Form1.TextBox1.Text = Form1.Value1 / Val(Form1.TextBox1.Text)
        End Select
    End Sub

    Sub ShowHistory()

        Form1.TextBox2.Text =
         Form1.TextBox2.Text &
         Form1.Value1 & " " &
         Form1.Oper & " " &
         Form1.Value2 & vbCrLf &
         "Hasil: " & vbCrLf &
         Form1.TextBox1.Text & vbCrLf &
         "-----------------------------" & vbCrLf
    End Sub
    Sub ShowHistory2()
        Form1.TextBox2.Text =
         Form1.TextBox2.Text &
         Form1.Simbol & vbCrLf &
         "Hasil: " & vbCrLf &
         Form1.TextBox1.Text & vbCrLf &
         "-----------------------------" & vbCrLf
        SayIt()
    End Sub

    Sub Memorynya()
        Form1.TextBox2.Text =
         Form1.TextBox2.Text &
         "+" & Form1.TextBox1.Text & vbCrLf &
         "Memory: " & vbCrLf &
         Form1.Memory & vbCrLf &
         "-----------------------------" & vbCrLf
        Form1.TextBox1.Text = Form1.Memory
        SayIt()
    End Sub

    Sub MemoryCheck()
        Form1.TextBox2.Text =
         Form1.TextBox2.Text &
         "Cek Memory: " & vbCrLf &
         Form1.Memory & vbCrLf &
         "-----------------------------" & vbCrLf
        Form1.TextBox1.Text = Form1.Memory
        SayIt()
    End Sub

    Sub SayIt()
        Dim Say
        Say = CreateObject("sapi.spvoice")
        Say.speak(Form1.TextBox1.Text)
    End Sub

End Module
