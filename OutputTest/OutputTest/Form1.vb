Imports Microsoft.VisualBasic.CompilerServices

Public Class Form1
    Private pso As ProcessStartInfo
    Private miner As Process
    Dim arrProcess() As Process = System.Diagnostics.Process.GetProcessesByName("xmrig32")
    Dim start = "conf.bat"

    Private Delegate Sub InvokeWithString(ByVal text As String)

    Private Sub Bsync_Data_Received(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        Me.Invoke(New InvokeWithString(AddressOf Sync_OutputMiner), e.Data)
    End Sub

    Private Sub Sync_OutputMiner(ByVal text2 As String)
        txtoutput.AppendText(text2 & Environment.NewLine)
        txtoutput.ScrollToCaret()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "XMRigged " + "Version " + My.Application.Info.Version.ToString + " alpha"
        Dim pool = txtpool.Text()
        Dim wallet = txtwallet.Text()
        Dim conf2 = "user.cfg"
        Dim conf = "conf.bat"
        'updater code:
        'Me.CheckForUpdates()
        'check for the configuration
        If System.IO.File.Exists(conf2) Then
            lblconf.Visible = False
        End If
        'check for the batch file
        If System.IO.File.Exists(conf) Then
            Label7.Text = "Miner is Loaded!"
        End If
    End Sub

    Private Sub buttonon_Click(sender As Object, e As EventArgs) Handles Buttonon.Click

        'check for the batch file
        If Not System.IO.File.Exists(start) Then
            MsgBox("Please Setup the miner first, You can do that by going to settings!")
            Return
        End If

        'switch the button indicator and functions
        If controll.Text = "0" Then
            launchfunction()
        ElseIf controll.Text = "1" Then
            'switch the button to the inactive state
            Buttonon.BackgroundImage = backup.BackgroundImage
            controll.Text = "0"
            'ends the miner
            For Each p As Process In arrProcess
                p.Kill()
            Next
            'hide the output log
            txtoutput.Clear() 'clear previous outputs
            Label2.Visible = False
            txtoutput.Visible = False

        End If

    End Sub


    'CHECK FOR UPDATES
    Public Sub CheckForUpdates()
        Dim str As String = String.Concat(Application.StartupPath, "version")
        Dim str1 As String = My.Application.Info.Version.ToString()
        If (My.Computer.FileSystem.FileExists(str)) Then
            My.Computer.FileSystem.DeleteFile(str)
        End If
        My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/budm/XMRigged/master/version", str)
        Dim str2 As String = My.Computer.FileSystem.ReadAllText(str)
        If (Operators.CompareString(str1, str2, False) = 0) Then
            'maybe do something here but probably not
        Else
            Update.Visible = True
            Label1.Text = "Theres A Update! Please Update!"
        End If
    End Sub

    'launch the miner
    Private Sub launchfunction()
        'switch the button to the active state
        Buttonon.BackgroundImage = buttonoff.BackgroundImage
        controll.Text = "1"

        'show the output log
        Label2.Visible = True
        txtoutput.Visible = True

        'Kill previous instances of the miner
        For Each p As Process In arrProcess
            p.Kill()
        Next

        'setup:
        txtoutput.Clear() 'clear previous outputs
        pso = New ProcessStartInfo(start) 'txthidden.Text

        'Background Mode Check
        If bgind.Text = "1" Then
            txtoutput.Text = "Background Mode is Currently Enabled, No Output Displayed."
        End If

        'miner initialization:
        Dim minerencoding As System.Text.Encoding = Nothing
        System.Text.Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)
        With pso
            .UseShellExecute = False
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = True
            .StandardOutputEncoding = minerencoding
            .StandardErrorEncoding = minerencoding
        End With
        miner = New Process With {.StartInfo = pso, .EnableRaisingEvents = True}
        AddHandler miner.ErrorDataReceived, AddressOf Bsync_Data_Received
        AddHandler miner.OutputDataReceived, AddressOf Bsync_Data_Received

        'launching of the miner
        miner.Start()
        miner.BeginOutputReadLine()
        miner.BeginErrorReadLine()

    End Sub


    'stuff below here isn't important to daily adjustment mainly just interface settings and simple functions
    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Kill any instance of xmrig first then end the program
        Dim arrProcess() As Process = System.Diagnostics.Process.GetProcessesByName("xmrig32")
        For Each p As Process In arrProcess
            p.Kill()
        Next
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'watchs for the form to be minimized so the notification tray icon can appear
        If Me.WindowState = System.Windows.Forms.FormWindowState.Minimized Then
            Me.Visible = False
            NotifyIcon1.Visible = True
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object,
    ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        'make the form appear when clicked
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        My.Forms.AboutBox1.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        My.Forms.Form2.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Update.Click
        Process.Start("UpdateHandler.exe")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://sites.google.com/view/moneroresourcehub")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Kill any instance of xmrig first then end the program
        Dim arrProcess() As Process = System.Diagnostics.Process.GetProcessesByName("xmrig32")
        For Each p As Process In arrProcess
            p.Kill()
        Next
        End
    End Sub

End Class
