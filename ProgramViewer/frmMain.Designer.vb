<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtMain = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbProjects = New System.Windows.Forms.ListBox()
        Me.fdOpenFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.lbFiles = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnVb = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnPopout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.tmrUpdateTools = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMain
        '
        Me.txtMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMain.BackColor = System.Drawing.SystemColors.Menu
        Me.txtMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMain.Location = New System.Drawing.Point(173, 75)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ReadOnly = True
        Me.txtMain.Size = New System.Drawing.Size(654, 524)
        Me.txtMain.TabIndex = 3
        Me.txtMain.Text = ""
        Me.txtMain.WordWrap = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(976, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFolderToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenFolderToolStripMenuItem
        '
        Me.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        Me.OpenFolderToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.OpenFolderToolStripMenuItem.Text = "Open Folder"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(304, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Program Grader v1.2"
        '
        'lbProjects
        '
        Me.lbProjects.BackColor = System.Drawing.SystemColors.Menu
        Me.lbProjects.FormattingEnabled = True
        Me.lbProjects.HorizontalScrollbar = True
        Me.lbProjects.Location = New System.Drawing.Point(12, 101)
        Me.lbProjects.Name = "lbProjects"
        Me.lbProjects.Size = New System.Drawing.Size(155, 329)
        Me.lbProjects.TabIndex = 1
        '
        'lbFiles
        '
        Me.lbFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbFiles.BackColor = System.Drawing.SystemColors.Menu
        Me.lbFiles.FormattingEnabled = True
        Me.lbFiles.HorizontalScrollbar = True
        Me.lbFiles.Location = New System.Drawing.Point(12, 465)
        Me.lbFiles.Name = "lbFiles"
        Me.lbFiles.Size = New System.Drawing.Size(155, 134)
        Me.lbFiles.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Projects"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(62, 438)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Files"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnView)
        Me.GroupBox1.Controls.Add(Me.btnRun)
        Me.GroupBox1.Controls.Add(Me.btnVb)
        Me.GroupBox1.Controls.Add(Me.btnOptions)
        Me.GroupBox1.Controls.Add(Me.btnPopout)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnOpen)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(833, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 520)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'btnView
        '
        Me.btnView.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnView.ForeColor = System.Drawing.Color.Black
        Me.btnView.Location = New System.Drawing.Point(3, 108)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(125, 23)
        Me.btnView.TabIndex = 103
        Me.btnView.Text = "&View Folder"
        Me.btnView.UseVisualStyleBackColor = True
        Me.btnView.Visible = False
        '
        'btnRun
        '
        Me.btnRun.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRun.ForeColor = System.Drawing.Color.Black
        Me.btnRun.Location = New System.Drawing.Point(3, 85)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(125, 23)
        Me.btnRun.TabIndex = 2
        Me.btnRun.Text = "&Run Program"
        Me.btnRun.UseVisualStyleBackColor = True
        Me.btnRun.Visible = False
        '
        'btnVb
        '
        Me.btnVb.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVb.ForeColor = System.Drawing.Color.Black
        Me.btnVb.Location = New System.Drawing.Point(3, 62)
        Me.btnVb.Name = "btnVb"
        Me.btnVb.Size = New System.Drawing.Size(125, 23)
        Me.btnVb.TabIndex = 102
        Me.btnVb.Text = "&Open Visual Studio"
        Me.btnVb.UseVisualStyleBackColor = True
        Me.btnVb.Visible = False
        '
        'btnOptions
        '
        Me.btnOptions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOptions.ForeColor = System.Drawing.Color.Black
        Me.btnOptions.Location = New System.Drawing.Point(3, 471)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(125, 23)
        Me.btnOptions.TabIndex = 101
        Me.btnOptions.Text = "&Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnPopout
        '
        Me.btnPopout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPopout.ForeColor = System.Drawing.Color.Black
        Me.btnPopout.Location = New System.Drawing.Point(3, 39)
        Me.btnPopout.Name = "btnPopout"
        Me.btnPopout.Size = New System.Drawing.Size(125, 23)
        Me.btnPopout.TabIndex = 3
        Me.btnPopout.Text = "&Code Popout"
        Me.btnPopout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(3, 494)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 23)
        Me.btnExit.TabIndex = 100
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOpen.ForeColor = System.Drawing.Color.Black
        Me.btnOpen.Location = New System.Drawing.Point(3, 16)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(125, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "&Open Folder"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'tmrUpdateTools
        '
        Me.tmrUpdateTools.Enabled = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(976, 607)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbFiles)
        Me.Controls.Add(Me.lbProjects)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Program Grader v1.2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMain As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lbProjects As ListBox
    Friend WithEvents fdOpenFolder As FolderBrowserDialog
    Friend WithEvents lbFiles As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnRun As Button
    Friend WithEvents tmrUpdateTools As Timer
    Friend WithEvents btnPopout As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnVb As Button
    Friend WithEvents btnView As Button
End Class
