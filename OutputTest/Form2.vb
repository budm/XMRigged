Public Class Form2


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sb As New System.Text.StringBuilder
        'cpu miner setup initialization
        If rdocpu.Checked = True Then
            'create the batch file to execute
            txtbatchoutput.Text = "xmrig.exe" + " -o " + txtpool.Text + " -u " + txtwallet.Text + " -p x -k "
            If chkbg.Checked = True Then
                My.Forms.Form1.bgind.Text = "1"
                txtbatchoutput.Text = txtbatchoutput.Text + " -B "
            ElseIf chkbg.Checked = False Then
                My.Forms.Form1.bgind.Text = "0"
            End If

            'implement Algorithm variations changes
            If txtav.Text = "--av=0" Or txtav.Text = "0" Then
            End If
            If txtav.Text = "--av=1" Or txtav.Text = "1" Then
                txtbatchoutput.Text = txtbatchoutput.Text + " --av=1 "
            End If
            If txtav.Text = "--av=2" Or txtav.Text = "2" Then
                txtbatchoutput.Text = txtbatchoutput.Text + " --av=2 "
            End If
            If txtav.Text = "--av=3" Or txtav.Text = "3" Then
                txtbatchoutput.Text = txtbatchoutput.Text + " --av=3 "
            End If
            If txtav.Text = "--av=4" Or txtav.Text = "4" Then
                txtbatchoutput.Text = txtbatchoutput.Text + " --av=4 "
            End If

            'nicehash support
            If chknice.Checked = True Then
                txtbatchoutput.Text = txtbatchoutput.Text + " --nicehash "
            End If

            'safe mode
            If chksafe.Checked = False Then
                txtbatchoutput.Text = txtbatchoutput.Text + "-t " + txtthreads.Text
            End If
            If chksafe.Checked = True Then
                txtbatchoutput.Text = txtbatchoutput.Text + "--safe "
            End If

            'for pool login info
            If chkusr.Checked = True Then

                'check for info at least
                If userbox.Text = "" Then
                    MsgBox("please enter your username for the pool or uncheck the box.")
                    Exit Sub
                End If
                If passbox.Text = "" Then
                    MsgBox("please enter your password for the pool or uncheck the box.")
                    Exit Sub
                End If

                'add the info to the batch
                txtbatchoutput.Text = txtbatchoutput.Text + "--userpass=" + userbox.Text + passbox.Text
            End If

        End If
        'gpu miner setup initialization
        If rdogpu.Checked = True Then
            'checks the system out to confirm 64 bit
            If System.Environment.Is64BitOperatingSystem = True Then
                MsgBox("Downloading your appropriate GPU Miner")
                'gpu miner download code goes here

            ElseIf System.Environment.Is64BitOperatingSystem = False Then
                MsgBox("Sorry GPU Mining is not supported on a 32 Bit OS please consider cpu mining")
                'switch it back to cpu
                rdocpu.Checked = True
                Exit Sub
            End If

            'gpu setup code will go here
        End If

        'creation of the batch:
        sb.AppendLine("@echo off")
        sb.AppendLine(txtbatchoutput.Text)
        sb.AppendLine("pause")
        IO.File.WriteAllText("conf.bat", sb.ToString())

        'indicate the setup is complete in the miner
        My.Forms.Form1.Label7.Text = "Settings Loaded!"
        'Background Mode Check

        'execute a friendly messagebox so that the user is aware setup is complete
        MsgBox("Setup is complete you can begin mining!")
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create OS bit indicator
        If System.Environment.Is64BitOperatingSystem = True Then
            bitlabel.Text = "64 Bit Operating System mode"
        Else
            bitlabel.Text = "32 Bit Operating System mode"
        End If
    End Sub

    Private Sub chksafe_CheckedChanged(sender As Object, e As EventArgs) Handles chksafe.CheckedChanged
        If chksafe.Checked = True Then
            'greys out threads and Algorithm variations
            txtthreads.Enabled = False
            txtav.Enabled = False
            txtthreads.ReadOnly = True
            txtav.ReadOnly = True
            txtthreads.Text = "Safe Mode enabled"
            txtav.Text = "Safe Mode enabled"
        End If

        If chksafe.Checked = False Then
            'reables threads and av
            txtthreads.Enabled = True
            txtav.Enabled = True
            txtthreads.ReadOnly = False
            txtav.ReadOnly = False
            txtthreads.Text = "1"
            txtav.Text = "0"
        End If
    End Sub

    Private Sub rdogpu_CheckedChanged(sender As Object, e As EventArgs) Handles rdogpu.CheckedChanged
        'RADIO BUTTON FOR SWITCHING GPU AND CPU
        If rdogpu.Checked = True Then
            rdocpu.Checked = False
            gpubox.Visible = True
            budnvid.Visible = True
            butamd.Visible = True
        End If

    End Sub

    Private Sub rdocpu_CheckedChanged(sender As Object, e As EventArgs) Handles rdocpu.CheckedChanged
        'RADIO BUTTON FOR SWITCHING GPU AND CPU
        If rdocpu.Checked = True Then
            rdogpu.Checked = False
            gpubox.Visible = False
            budnvid.Visible = False
            butamd.Visible = False
        End If
    End Sub

    Private Sub butamd_CheckedChanged(sender As Object, e As EventArgs)
        'RADIO BUTTON FOR SWITCHING between amd and nvidia
        If butamd.Checked = True Then
            budnvid.Checked = False
        End If

    End Sub

    Private Sub budnvid_CheckedChanged(sender As Object, e As EventArgs)
        'RADIO BUTTON FOR SWITCHING between amd and nvidia
        If budnvid.Checked = True Then
            butamd.Checked = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkusr.CheckedChanged
        'make the user box visible
        If chkusr.Checked = True Then
            usrbox.Visible = True
        End If
        If chkusr.Checked = False Then
            usrbox.Visible = False
        End If
    End Sub
End Class