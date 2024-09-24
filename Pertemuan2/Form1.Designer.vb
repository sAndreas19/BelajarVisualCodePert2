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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CheckBox1 = New CheckBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        MenuStrip1 = New MenuStrip()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        MeToolStripMenuItem = New ToolStripMenuItem()
        OrtuToolStripMenuItem = New ToolStripMenuItem()
        ContacToolStripMenuItem = New ToolStripMenuItem()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.AllowDrop = True
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.DialogResult = DialogResult.OK
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(91, 502)
        Button1.Name = "Button1"
        Button1.Size = New Size(225, 45)
        Button1.TabIndex = 0
        Button1.Text = "Send"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(274, 25)
        Label1.TabIndex = 1
        Label1.Text = "Belajar Visual Studio Pertemuan 2"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.MenuHighlight
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(29, 133)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(177, 171)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(283, 455)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(394, 29)
        CheckBox1.TabIndex = 3
        CheckBox1.Text = "I have read and Accepted the Term of Service"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(283, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 25)
        Label2.TabIndex = 4
        Label2.Text = "Nama : Dion Ambarita"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(283, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(150, 25)
        Label3.TabIndex = 5
        Label3.Text = "NIM : 222406026"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(283, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 25)
        Label4.TabIndex = 6
        Label4.Text = "Kom : A"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(283, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(243, 25)
        Label5.TabIndex = 7
        Label5.Text = "Matkul : Pemrograman Visual"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, AboutToolStripMenuItem, ContacToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 8
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(77, 29)
        HomeToolStripMenuItem.Text = "Home"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MeToolStripMenuItem, OrtuToolStripMenuItem})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(78, 29)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' MeToolStripMenuItem
        ' 
        MeToolStripMenuItem.Name = "MeToolStripMenuItem"
        MeToolStripMenuItem.Size = New Size(270, 34)
        MeToolStripMenuItem.Text = "Me"
        ' 
        ' OrtuToolStripMenuItem
        ' 
        OrtuToolStripMenuItem.Name = "OrtuToolStripMenuItem"
        OrtuToolStripMenuItem.Size = New Size(270, 34)
        OrtuToolStripMenuItem.Text = "Ortu"
        ' 
        ' ContacToolStripMenuItem
        ' 
        ContacToolStripMenuItem.Name = "ContacToolStripMenuItem"
        ContacToolStripMenuItem.Size = New Size(89, 29)
        ContacToolStripMenuItem.Text = "Contact"
        ' 
        ' Button2
        ' 
        Button2.AllowDrop = True
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.DialogResult = DialogResult.OK
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(525, 502)
        Button2.Name = "Button2"
        Button2.Size = New Size(225, 45)
        Button2.TabIndex = 9
        Button2.Text = "Close"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        ClientSize = New Size(800, 573)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(CheckBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContacToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrtuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button

End Class
