<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtoutput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpool = New System.Windows.Forms.TextBox()
        Me.txtwallet = New System.Windows.Forms.TextBox()
        Me.txtthreads = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txthidden = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Buttonon = New System.Windows.Forms.PictureBox()
        Me.buttonoff = New System.Windows.Forms.PictureBox()
        Me.backup = New System.Windows.Forms.PictureBox()
        Me.controll = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bgind = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buttonon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonoff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtoutput
        '
        Me.txtoutput.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoutput.Location = New System.Drawing.Point(15, 332)
        Me.txtoutput.Multiline = True
        Me.txtoutput.Name = "txtoutput"
        Me.txtoutput.ReadOnly = True
        Me.txtoutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtoutput.Size = New System.Drawing.Size(795, 127)
        Me.txtoutput.TabIndex = 4
        Me.txtoutput.TabStop = False
        Me.txtoutput.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(15, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Miner Output:"
        Me.Label2.Visible = False
        '
        'txtpool
        '
        Me.txtpool.Location = New System.Drawing.Point(219, 575)
        Me.txtpool.Name = "txtpool"
        Me.txtpool.ReadOnly = True
        Me.txtpool.Size = New System.Drawing.Size(606, 23)
        Me.txtpool.TabIndex = 7
        Me.txtpool.Text = "proxy.xmrig.com:443"
        '
        'txtwallet
        '
        Me.txtwallet.Location = New System.Drawing.Point(80, 605)
        Me.txtwallet.Name = "txtwallet"
        Me.txtwallet.ReadOnly = True
        Me.txtwallet.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtwallet.Size = New System.Drawing.Size(745, 23)
        Me.txtwallet.TabIndex = 8
        Me.txtwallet.Text = "449TGay4WWJPwsXrWZfkMoPtDbJp8xoSzFuyjRt3iaM4bRHdzw4qoDu26FdcGx67BMDS1r2bnp7f5hF6x" &
    "dPWWrD3Q3Wf7G6"
        '
        'txtthreads
        '
        Me.txtthreads.Location = New System.Drawing.Point(673, 635)
        Me.txtthreads.Name = "txtthreads"
        Me.txtthreads.ReadOnly = True
        Me.txtthreads.Size = New System.Drawing.Size(152, 23)
        Me.txtthreads.TabIndex = 9
        Me.txtthreads.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(176, 578)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pool:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 608)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Wallet:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(609, 638)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Threads:"
        '
        'txthidden
        '
        Me.txthidden.Location = New System.Drawing.Point(840, 453)
        Me.txthidden.Name = "txthidden"
        Me.txthidden.Size = New System.Drawing.Size(174, 23)
        Me.txthidden.TabIndex = 13
        Me.txthidden.Visible = False
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(468, 647)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 28)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Save Settings"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "XMRigged"
        Me.NotifyIcon1.Visible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(645, 465)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "XMRigged version Alpha"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(822, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-103, -67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 320)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(205, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(576, 125)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(516, 465)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(123, 13)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Monero Resource Hub"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(12, 465)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Settings Not Loaded"
        '
        'Buttonon
        '
        Me.Buttonon.BackColor = System.Drawing.Color.Transparent
        Me.Buttonon.BackgroundImage = CType(resources.GetObject("Buttonon.BackgroundImage"), System.Drawing.Image)
        Me.Buttonon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Buttonon.Location = New System.Drawing.Point(306, 259)
        Me.Buttonon.Name = "Buttonon"
        Me.Buttonon.Size = New System.Drawing.Size(235, 67)
        Me.Buttonon.TabIndex = 21
        Me.Buttonon.TabStop = False
        '
        'buttonoff
        '
        Me.buttonoff.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.buttonoff.BackgroundImage = CType(resources.GetObject("buttonoff.BackgroundImage"), System.Drawing.Image)
        Me.buttonoff.Location = New System.Drawing.Point(800, 30)
        Me.buttonoff.Name = "buttonoff"
        Me.buttonoff.Size = New System.Drawing.Size(10, 10)
        Me.buttonoff.TabIndex = 22
        Me.buttonoff.TabStop = False
        Me.buttonoff.Visible = False
        '
        'backup
        '
        Me.backup.BackColor = System.Drawing.Color.Transparent
        Me.backup.BackgroundImage = CType(resources.GetObject("backup.BackgroundImage"), System.Drawing.Image)
        Me.backup.Location = New System.Drawing.Point(800, 46)
        Me.backup.Name = "backup"
        Me.backup.Size = New System.Drawing.Size(10, 10)
        Me.backup.TabIndex = 23
        Me.backup.TabStop = False
        Me.backup.Visible = False
        '
        'controll
        '
        Me.controll.AutoSize = True
        Me.controll.Location = New System.Drawing.Point(809, 475)
        Me.controll.Name = "controll"
        Me.controll.Size = New System.Drawing.Size(13, 15)
        Me.controll.TabIndex = 25
        Me.controll.Text = "0"
        Me.controll.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bgind
        '
        Me.bgind.AutoSize = True
        Me.bgind.Location = New System.Drawing.Point(809, 302)
        Me.bgind.Name = "bgind"
        Me.bgind.Size = New System.Drawing.Size(13, 15)
        Me.bgind.TabIndex = 26
        Me.bgind.Text = "0"
        Me.bgind.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(822, 487)
        Me.Controls.Add(Me.bgind)
        Me.Controls.Add(Me.controll)
        Me.Controls.Add(Me.backup)
        Me.Controls.Add(Me.buttonoff)
        Me.Controls.Add(Me.Buttonon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txthidden)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtthreads)
        Me.Controls.Add(Me.txtwallet)
        Me.Controls.Add(Me.txtpool)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtoutput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XMRigged"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buttonon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonoff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtoutput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpool As TextBox
    Friend WithEvents txtwallet As TextBox
    Friend WithEvents txtthreads As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txthidden As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Buttonon As PictureBox
    Friend WithEvents buttonoff As PictureBox
    Friend WithEvents backup As PictureBox
    Friend WithEvents controll As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bgind As Label
End Class
