Public Class Form2


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sb As New System.Text.StringBuilder
        'create the batch file to execute
        txtbatchoutput.Text = "xmrig.exe" + " -o " + txtpool.Text + " -u " + txtwallet.Text + " -p x -k " + "-t " + txtthreads.Text
        sb.AppendLine("@echo off")
        sb.AppendLine(txtbatchoutput.Text)
        sb.AppendLine("pause")
        IO.File.WriteAllText("conf.bat", sb.ToString())

        'indicate the setup is complete in the miner
        My.Forms.Form1.Label7.Text = "Settings Loaded!"

        'execute a friendly messagebox so that the user is aware setup is complete
        MsgBox("Setup is complete you can begin mining!")
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class