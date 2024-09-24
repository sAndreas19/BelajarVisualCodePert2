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
        Label1 = New Label()
        Button1 = New Button()
        MenuStrip1 = New MenuStrip()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        MeToolStripMenuItem = New ToolStripMenuItem()
        OrtuToolStripMenuItem = New ToolStripMenuItem()
        ContacToolStripMenuItem = New ToolStripMenuItem()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Button2 = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(274, 25)
        Label1.TabIndex = 10
        Label1.Text = "Belajar Visual Studio Pertemuan 2"
        ' 
        ' Button1
        ' 
        Button1.AllowDrop = True
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.DialogResult = DialogResult.OK
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(504, 450)
        Button1.Name = "Button1"
        Button1.Size = New Size(225, 45)
        Button1.TabIndex = 9
        Button1.Text = "Keluar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, AboutToolStripMenuItem, ContacToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 17
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
        MeToolStripMenuItem.Size = New Size(150, 34)
        MeToolStripMenuItem.Text = "Me"
        ' 
        ' OrtuToolStripMenuItem
        ' 
        OrtuToolStripMenuItem.Name = "OrtuToolStripMenuItem"
        OrtuToolStripMenuItem.Size = New Size(150, 34)
        OrtuToolStripMenuItem.Text = "Ortu"
        ' 
        ' ContacToolStripMenuItem
        ' 
        ContacToolStripMenuItem.Name = "ContacToolStripMenuItem"
        ContacToolStripMenuItem.Size = New Size(89, 29)
        ContacToolStripMenuItem.Text = "Contact"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(283, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 25)
        Label3.TabIndex = 14
        Label3.Text = "Nama :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(357, 128)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(210, 31)
        TextBox1.TabIndex = 18
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(357, 326)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(210, 31)
        TextBox2.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(283, 326)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 25)
        Label2.TabIndex = 19
        Label2.Text = "KOM :"
        Label2.TextAlign = ContentAlignment.BottomRight
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(357, 226)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(210, 31)
        TextBox3.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(283, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 25)
        Label4.TabIndex = 21
        Label4.Text = "NIM :"
        ' 
        ' Button2
        ' 
        Button2.AllowDrop = True
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.DialogResult = DialogResult.OK
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(71, 450)
        Button2.Name = "Button2"
        Button2.Size = New Size(225, 45)
        Button2.TabIndex = 23
        Button2.Text = "Tampilkan"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 532)
        Controls.Add(Button2)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        Name = "Form2"
        Text = "Form2"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContacToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents MeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrtuToolStripMenuItem As ToolStripMenuItem
End Class
