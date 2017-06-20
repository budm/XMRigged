<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblthr = New System.Windows.Forms.Label()
        Me.lblwal = New System.Windows.Forms.Label()
        Me.lblpol = New System.Windows.Forms.Label()
        Me.txtthreads = New System.Windows.Forms.TextBox()
        Me.txtwallet = New System.Windows.Forms.TextBox()
        Me.txtpool = New System.Windows.Forms.TextBox()
        Me.txtbatchoutput = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblsettings = New System.Windows.Forms.Label()
        Me.chkbg = New System.Windows.Forms.CheckBox()
        Me.bitlabel = New System.Windows.Forms.Label()
        Me.lblalg = New System.Windows.Forms.Label()
        Me.txtav = New System.Windows.Forms.TextBox()
        Me.lblao = New System.Windows.Forms.Label()
        Me.lblcha = New System.Windows.Forms.Label()
        Me.chksafe = New System.Windows.Forms.CheckBox()
        Me.chknice = New System.Windows.Forms.CheckBox()
        Me.rdocpu = New System.Windows.Forms.RadioButton()
        Me.rdogpu = New System.Windows.Forms.RadioButton()
        Me.gpubox = New System.Windows.Forms.GroupBox()
        Me.budnvid = New System.Windows.Forms.RadioButton()
        Me.butamd = New System.Windows.Forms.RadioButton()
        Me.chkusr = New System.Windows.Forms.CheckBox()
        Me.usrbox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userbox = New System.Windows.Forms.TextBox()
        Me.passbox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpubox.SuspendLayout()
        Me.usrbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(348, 557)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 24)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Save Settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblthr
        '
        Me.lblthr.AutoSize = True
        Me.lblthr.BackColor = System.Drawing.Color.Transparent
        Me.lblthr.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthr.Location = New System.Drawing.Point(7, 205)
        Me.lblthr.Name = "lblthr"
        Me.lblthr.Size = New System.Drawing.Size(50, 13)
        Me.lblthr.TabIndex = 20
        Me.lblthr.Text = "Threads:"
        '
        'lblwal
        '
        Me.lblwal.AutoSize = True
        Me.lblwal.BackColor = System.Drawing.Color.Transparent
        Me.lblwal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwal.Location = New System.Drawing.Point(17, 118)
        Me.lblwal.Name = "lblwal"
        Me.lblwal.Size = New System.Drawing.Size(43, 13)
        Me.lblwal.TabIndex = 19
        Me.lblwal.Text = "Wallet:"
        '
        'lblpol
        '
        Me.lblpol.AutoSize = True
        Me.lblpol.BackColor = System.Drawing.Color.Transparent
        Me.lblpol.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpol.Location = New System.Drawing.Point(25, 70)
        Me.lblpol.Name = "lblpol"
        Me.lblpol.Size = New System.Drawing.Size(33, 13)
        Me.lblpol.TabIndex = 18
        Me.lblpol.Text = "Pool:"
        '
        'txtthreads
        '
        Me.txtthreads.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtthreads.Location = New System.Drawing.Point(63, 220)
        Me.txtthreads.Name = "txtthreads"
        Me.txtthreads.Size = New System.Drawing.Size(131, 22)
        Me.txtthreads.TabIndex = 17
        Me.txtthreads.Text = "1"
        '
        'txtwallet
        '
        Me.txtwallet.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwallet.Location = New System.Drawing.Point(63, 132)
        Me.txtwallet.Multiline = True
        Me.txtwallet.Name = "txtwallet"
        Me.txtwallet.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtwallet.Size = New System.Drawing.Size(398, 70)
        Me.txtwallet.TabIndex = 16
        Me.txtwallet.Text = "4JUdGzvrMFDWrUUwY3toJATSeNwjn54LkCnKBPRzDuhzi5vSepHfUckJNxRL2gjkNrSqtCoRUrEDAgRws" &
    "QvVCjZbRyZxpNGaqHDJZ74p4J"
        '
        'txtpool
        '
        Me.txtpool.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpool.Location = New System.Drawing.Point(63, 89)
        Me.txtpool.Name = "txtpool"
        Me.txtpool.Size = New System.Drawing.Size(398, 22)
        Me.txtpool.TabIndex = 15
        Me.txtpool.Text = "proxy.xmrig.com:443"
        '
        'txtbatchoutput
        '
        Me.txtbatchoutput.Location = New System.Drawing.Point(445, 12)
        Me.txtbatchoutput.Name = "txtbatchoutput"
        Me.txtbatchoutput.Size = New System.Drawing.Size(100, 20)
        Me.txtbatchoutput.TabIndex = 22
        Me.txtbatchoutput.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(289, 416)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 222)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'lblsettings
        '
        Me.lblsettings.AutoSize = True
        Me.lblsettings.BackColor = System.Drawing.Color.Transparent
        Me.lblsettings.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsettings.Location = New System.Drawing.Point(166, 12)
        Me.lblsettings.Name = "lblsettings"
        Me.lblsettings.Size = New System.Drawing.Size(136, 20)
        Me.lblsettings.TabIndex = 25
        Me.lblsettings.Text = "XMRigged Settings"
        '
        'chkbg
        '
        Me.chkbg.AutoSize = True
        Me.chkbg.BackColor = System.Drawing.Color.Transparent
        Me.chkbg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbg.Location = New System.Drawing.Point(63, 459)
        Me.chkbg.Name = "chkbg"
        Me.chkbg.Size = New System.Drawing.Size(122, 17)
        Me.chkbg.TabIndex = 26
        Me.chkbg.Text = "Background Mode"
        Me.chkbg.UseVisualStyleBackColor = False
        '
        'bitlabel
        '
        Me.bitlabel.AutoSize = True
        Me.bitlabel.BackColor = System.Drawing.Color.Transparent
        Me.bitlabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bitlabel.Location = New System.Drawing.Point(6, 576)
        Me.bitlabel.Name = "bitlabel"
        Me.bitlabel.Size = New System.Drawing.Size(54, 13)
        Me.bitlabel.TabIndex = 31
        Me.bitlabel.Text = "32 bit OS"
        '
        'lblalg
        '
        Me.lblalg.AutoSize = True
        Me.lblalg.BackColor = System.Drawing.Color.Transparent
        Me.lblalg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalg.Location = New System.Drawing.Point(7, 510)
        Me.lblalg.Name = "lblalg"
        Me.lblalg.Size = New System.Drawing.Size(112, 13)
        Me.lblalg.TabIndex = 32
        Me.lblalg.Text = "Algorithm variation: "
        '
        'txtav
        '
        Me.txtav.Location = New System.Drawing.Point(63, 526)
        Me.txtav.Name = "txtav"
        Me.txtav.Size = New System.Drawing.Size(131, 20)
        Me.txtav.TabIndex = 33
        Me.txtav.Text = "0"
        '
        'lblao
        '
        Me.lblao.AutoSize = True
        Me.lblao.BackColor = System.Drawing.Color.Transparent
        Me.lblao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblao.Location = New System.Drawing.Point(6, 412)
        Me.lblao.Name = "lblao"
        Me.lblao.Size = New System.Drawing.Size(143, 21)
        Me.lblao.TabIndex = 34
        Me.lblao.Text = "Additional Options:"
        '
        'lblcha
        '
        Me.lblcha.AutoSize = True
        Me.lblcha.BackColor = System.Drawing.Color.Transparent
        Me.lblcha.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcha.Location = New System.Drawing.Point(15, 434)
        Me.lblcha.Name = "lblcha"
        Me.lblcha.Size = New System.Drawing.Size(94, 13)
        Me.lblcha.TabIndex = 35
        Me.lblcha.Text = "Change as needed"
        '
        'chksafe
        '
        Me.chksafe.AutoSize = True
        Me.chksafe.BackColor = System.Drawing.Color.Transparent
        Me.chksafe.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chksafe.Location = New System.Drawing.Point(63, 357)
        Me.chksafe.Name = "chksafe"
        Me.chksafe.Size = New System.Drawing.Size(389, 17)
        Me.chksafe.TabIndex = 36
        Me.chksafe.Text = "Safe Mode (safe adjustment of threads and av settings for current cpu)"
        Me.chksafe.UseVisualStyleBackColor = False
        '
        'chknice
        '
        Me.chknice.AutoSize = True
        Me.chknice.BackColor = System.Drawing.Color.Transparent
        Me.chknice.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chknice.Location = New System.Drawing.Point(63, 482)
        Me.chknice.Name = "chknice"
        Me.chknice.Size = New System.Drawing.Size(74, 17)
        Me.chknice.TabIndex = 37
        Me.chknice.Text = "NiceHash"
        Me.chknice.UseVisualStyleBackColor = False
        '
        'rdocpu
        '
        Me.rdocpu.AutoSize = True
        Me.rdocpu.BackColor = System.Drawing.Color.Transparent
        Me.rdocpu.Checked = True
        Me.rdocpu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdocpu.Location = New System.Drawing.Point(134, 45)
        Me.rdocpu.Name = "rdocpu"
        Me.rdocpu.Size = New System.Drawing.Size(86, 17)
        Me.rdocpu.TabIndex = 38
        Me.rdocpu.TabStop = True
        Me.rdocpu.Text = "CPU Mining"
        Me.rdocpu.UseVisualStyleBackColor = False
        '
        'rdogpu
        '
        Me.rdogpu.AutoSize = True
        Me.rdogpu.BackColor = System.Drawing.Color.Transparent
        Me.rdogpu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdogpu.Location = New System.Drawing.Point(230, 45)
        Me.rdogpu.Name = "rdogpu"
        Me.rdogpu.Size = New System.Drawing.Size(87, 17)
        Me.rdogpu.TabIndex = 39
        Me.rdogpu.Text = "GPU Mining"
        Me.rdogpu.UseVisualStyleBackColor = False
        Me.rdogpu.Visible = False
        '
        'gpubox
        '
        Me.gpubox.BackColor = System.Drawing.Color.Transparent
        Me.gpubox.Controls.Add(Me.budnvid)
        Me.gpubox.Controls.Add(Me.butamd)
        Me.gpubox.Location = New System.Drawing.Point(10, 380)
        Me.gpubox.Name = "gpubox"
        Me.gpubox.Size = New System.Drawing.Size(301, 29)
        Me.gpubox.TabIndex = 40
        Me.gpubox.TabStop = False
        Me.gpubox.Text = "GPU Selections"
        Me.gpubox.Visible = False
        '
        'budnvid
        '
        Me.budnvid.AutoSize = True
        Me.budnvid.BackColor = System.Drawing.Color.Transparent
        Me.budnvid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.budnvid.Location = New System.Drawing.Point(149, 11)
        Me.budnvid.Name = "budnvid"
        Me.budnvid.Size = New System.Drawing.Size(83, 17)
        Me.budnvid.TabIndex = 43
        Me.budnvid.TabStop = True
        Me.budnvid.Text = "nVidia GPU"
        Me.budnvid.UseVisualStyleBackColor = False
        Me.budnvid.Visible = False
        '
        'butamd
        '
        Me.butamd.AutoSize = True
        Me.butamd.BackColor = System.Drawing.Color.Transparent
        Me.butamd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butamd.Location = New System.Drawing.Point(68, 11)
        Me.butamd.Name = "butamd"
        Me.butamd.Size = New System.Drawing.Size(75, 17)
        Me.butamd.TabIndex = 42
        Me.butamd.TabStop = True
        Me.butamd.Text = "AMD GPU"
        Me.butamd.UseVisualStyleBackColor = False
        Me.butamd.Visible = False
        '
        'chkusr
        '
        Me.chkusr.AutoSize = True
        Me.chkusr.BackColor = System.Drawing.Color.Transparent
        Me.chkusr.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkusr.Location = New System.Drawing.Point(63, 248)
        Me.chkusr.Name = "chkusr"
        Me.chkusr.Size = New System.Drawing.Size(202, 17)
        Me.chkusr.TabIndex = 41
        Me.chkusr.Text = "Pool Worker Name and Password?"
        Me.chkusr.UseVisualStyleBackColor = False
        '
        'usrbox
        '
        Me.usrbox.BackColor = System.Drawing.Color.Transparent
        Me.usrbox.Controls.Add(Me.passbox)
        Me.usrbox.Controls.Add(Me.userbox)
        Me.usrbox.Controls.Add(Me.Label2)
        Me.usrbox.Controls.Add(Me.Label1)
        Me.usrbox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrbox.Location = New System.Drawing.Point(63, 271)
        Me.usrbox.Name = "usrbox"
        Me.usrbox.Size = New System.Drawing.Size(381, 80)
        Me.usrbox.TabIndex = 42
        Me.usrbox.TabStop = False
        Me.usrbox.Text = "Pool Worker Name and Password"
        Me.usrbox.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Worker Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'userbox
        '
        Me.userbox.Location = New System.Drawing.Point(96, 15)
        Me.userbox.Name = "userbox"
        Me.userbox.Size = New System.Drawing.Size(268, 22)
        Me.userbox.TabIndex = 2
        '
        'passbox
        '
        Me.passbox.Location = New System.Drawing.Point(96, 42)
        Me.passbox.Name = "passbox"
        Me.passbox.Size = New System.Drawing.Size(268, 22)
        Me.passbox.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(466, 590)
        Me.Controls.Add(Me.usrbox)
        Me.Controls.Add(Me.chkusr)
        Me.Controls.Add(Me.gpubox)
        Me.Controls.Add(Me.rdogpu)
        Me.Controls.Add(Me.rdocpu)
        Me.Controls.Add(Me.chknice)
        Me.Controls.Add(Me.chksafe)
        Me.Controls.Add(Me.lblcha)
        Me.Controls.Add(Me.lblao)
        Me.Controls.Add(Me.txtav)
        Me.Controls.Add(Me.lblalg)
        Me.Controls.Add(Me.bitlabel)
        Me.Controls.Add(Me.chkbg)
        Me.Controls.Add(Me.lblsettings)
        Me.Controls.Add(Me.txtbatchoutput)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblthr)
        Me.Controls.Add(Me.lblwal)
        Me.Controls.Add(Me.lblpol)
        Me.Controls.Add(Me.txtthreads)
        Me.Controls.Add(Me.txtwallet)
        Me.Controls.Add(Me.txtpool)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XMRigged Settings"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpubox.ResumeLayout(False)
        Me.gpubox.PerformLayout()
        Me.usrbox.ResumeLayout(False)
        Me.usrbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents lblthr As Label
    Friend WithEvents lblwal As Label
    Friend WithEvents lblpol As Label
    Friend WithEvents txtthreads As TextBox
    Friend WithEvents txtwallet As TextBox
    Friend WithEvents txtpool As TextBox
    Friend WithEvents txtbatchoutput As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblsettings As Label
    Friend WithEvents chkbg As CheckBox
    Friend WithEvents bitlabel As Label
    Friend WithEvents lblalg As Label
    Friend WithEvents txtav As TextBox
    Friend WithEvents lblao As Label
    Friend WithEvents lblcha As Label
    Friend WithEvents chksafe As CheckBox
    Friend WithEvents chknice As CheckBox
    Friend WithEvents rdocpu As RadioButton
    Friend WithEvents rdogpu As RadioButton
    Friend WithEvents gpubox As GroupBox
    Friend WithEvents budnvid As RadioButton
    Friend WithEvents butamd As RadioButton
    Friend WithEvents chkusr As CheckBox
    Friend WithEvents usrbox As GroupBox
    Friend WithEvents passbox As TextBox
    Friend WithEvents userbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
