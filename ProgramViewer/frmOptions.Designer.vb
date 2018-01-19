<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code Font:"
        '
        'lblFont
        '
        Me.lblFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFont.ForeColor = System.Drawing.Color.White
        Me.lblFont.Location = New System.Drawing.Point(95, 3)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(181, 33)
        Me.lblFont.TabIndex = 1
        Me.lblFont.Text = "Times New Roman 12 pt"
        Me.lblFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(86, 240)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(119, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnFont
        '
        Me.btnFont.Location = New System.Drawing.Point(14, 34)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(262, 23)
        Me.btnFont.TabIndex = 3
        Me.btnFont.Text = "Change Font"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(288, 275)
        Me.Controls.Add(Me.btnFont)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblFont)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOptions"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFont As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnFont As Button
End Class
