<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodePopout
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodePopout))
        Me.txtMain = New System.Windows.Forms.RichTextBox()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtMain
        '
        Me.txtMain.BackColor = System.Drawing.SystemColors.Menu
        Me.txtMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMain.Location = New System.Drawing.Point(10, 10)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ReadOnly = True
        Me.txtMain.Size = New System.Drawing.Size(620, 470)
        Me.txtMain.TabIndex = 4
        Me.txtMain.Text = ""
        Me.txtMain.WordWrap = False
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Enabled = True
        Me.tmrUpdate.Interval = 1
        '
        'frmCodePopout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(640, 490)
        Me.Controls.Add(Me.txtMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCodePopout"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Code"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtMain As RichTextBox
    Friend WithEvents tmrUpdate As Timer
End Class
