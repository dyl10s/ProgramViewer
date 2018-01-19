Public Class frmOptions

    Public form As frmMain = Nothing

    Dim size As Point = New Point(Me.Width, Me.Height)

    Private Sub frmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FontDialog1.Font = form.txtMain.Font

        If (form.txtMain.Font.Bold) Then
            lblFont.Text = form.txtMain.Font.Name & ", Bold, " & form.txtMain.Font.Size
        Else
            lblFont.Text = form.txtMain.Font.Name & ", " & form.txtMain.Font.Size
        End If

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click

        If FontDialog1.ShowDialog() = DialogResult.OK Then
            form.txtMain.Font = FontDialog1.Font
            My.Settings.CodeFont = FontDialog1.Font

            If (form.txtMain.Font.Bold) Then
                lblFont.Text = form.txtMain.Font.Name & ", Bold, " & form.txtMain.Font.Size
            Else
                lblFont.Text = form.txtMain.Font.Name & ", " & form.txtMain.Font.Size
            End If

        End If


    End Sub
End Class