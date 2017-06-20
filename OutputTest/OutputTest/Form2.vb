Imports System.IO
Public Class Form2


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sb As New System.Text.StringBuilder
        Dim sc As New System.Text.StringBuilder
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

        'creation of the config for reading settings:
        sc.AppendLine("XMRIGGED CONFIGURATION FILE --- DO NOT ADJUST IF YOU DON'T KNOW WHAT YOUR DOING")
        sc.AppendLine(txtpool.Text)
        sc.AppendLine(txtwallet.Text)

        If txtthreads.Text = "Safe Mode enabled" Then
            sc.AppendLine("1")
        Else
            sc.AppendLine(txtthreads.Text)
        End If


        If chkusr.Checked = True Then
            sc.AppendLine("pooluser-enabled")
            sc.AppendLine(userbox.Text)
            sc.AppendLine(passbox.Text)
        Else
            sc.AppendLine("pooluser-disabled")
        End If

        sc.AppendLine("----NICE HASH----")
        If chknice.Checked = True Then
            sc.AppendLine("nhash-enabled")
        Else
            sc.AppendLine("nhash-disabled")
        End If

        sc.AppendLine("----SAFE MODE----")
        If chksafe.Checked = True Then
            sc.AppendLine("smode-enabled")
        Else
            sc.AppendLine("smode-disabled")
        End If

        sc.AppendLine("----BACKGROUND MODE----")
        If chkbg.Checked = True Then
            sc.AppendLine("bgmd-enabled")
        ElseIf chkbg.Checked = False Then
            sc.AppendLine("bgmd-disabled")
        End If

        sc.AppendLine("----AV----")
        If txtav.Text = "--av=0" Or txtav.Text = "0" Then
            sc.AppendLine("--av=0")
        End If
        If txtav.Text = "--av=1" Or txtav.Text = "1" Then
            sc.AppendLine("--av=1")
        End If
        If txtav.Text = "--av=2" Or txtav.Text = "2" Then
            sc.AppendLine("--av=2")
        End If
        If txtav.Text = "--av=3" Or txtav.Text = "3" Then
            sc.AppendLine("--av=3")
        End If
        If txtav.Text = "--av=4" Or txtav.Text = "4" Then
            sc.AppendLine("--av=4")
        End If

        If rdogpu.Checked = True Then
            sc.AppendLine("--mn=cpu")
        End If

        sc.AppendLine("EOF")
        IO.File.WriteAllText("user.cfg", sc.ToString())

        'prepare the other form and change the checks/indicators
        My.Forms.Form1.Label7.Text = "Miner is ready!"
        My.Forms.Form1.lblconf.Visible = False
        'Background Mode Check

        'execute a friendly messagebox so that the user is aware setup is complete
        MsgBox("Setup is complete you can begin mining!")
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'actual configuration file
        Dim conf = "user.cfg"

        'check for the file, if it exists start to copy the lines back into their place
        If System.IO.File.Exists(conf) Then

            txtpool.Text = (ReadALine(conf, GetNumberOfLines(conf), 1))

            txtwallet.Text = (ReadALine(conf, GetNumberOfLines(conf), 2))

            txtthreads.Text = (ReadALine(conf, GetNumberOfLines(conf), 3))

            For Each k As String In IO.File.ReadLines(conf)
                If k.Contains("pooluser-enabled") Then
                    chkusr.Checked = True
                    userbox.Text = (ReadALine(conf, GetNumberOfLines(conf), 5))
                    passbox.Text = (ReadALine(conf, GetNumberOfLines(conf), 6))
                End If

                If k.Contains("nhash-enabled") Then
                    chknice.Checked = True
                End If

                If k.Contains("smode-enabled") Then
                    chksafe.Checked = True
                End If

                If k.Contains("bgmd-enabled") Then
                    chkbg.Checked = True
                End If

                If k.Contains("--av=0") Then
                    txtav.Text = "0"
                End If

                If k.Contains("--av=1") Then
                    txtav.Text = "1"
                End If

                If k.Contains("--av=2") Then
                    txtav.Text = "2"
                End If

                If k.Contains("--av=3") Then
                    txtav.Text = "3"
                End If

                If k.Contains("--av=4") Then
                    txtav.Text = "4"
                End If
                If k.Contains("--mn=cpu") Then
                    rdogpu.Checked = True
                End If

            Next

        End If

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

    Public Function ReadALine(ByVal File_Path As String, ByVal TotalLine As Integer, ByVal Line2Read As Integer) As String
        Dim Buffer As Array
        Dim Line As String
        If TotalLine <= Line2Read Then
            Return "No Such Line"
        End If
        Buffer = File.ReadAllLines(File_Path)
        Line = Buffer(Line2Read)
        Return Line
    End Function

    Public Function GetNumberOfLines(ByVal file_path As String) As Integer
        Dim sr As New StreamReader(file_path)
        Dim NumberOfLines As Integer
        Do While sr.Peek >= 0
            sr.ReadLine()
            NumberOfLines += 1
        Loop
        Return NumberOfLines
        sr.Close()
        sr.Dispose()
    End Function
End Class