Public Class frmCodePopout

    Dim Mainform As frmMain = Nothing

    Private Sub tmrUpdate_Tick(sender As Object, e As EventArgs) Handles tmrUpdate.Tick



        If Mainform.txtMain.Text <> Nothing Then
            If txtMain.Text <> Mainform.txtMain.Text Then
                txtMain.Text = Mainform.txtMain.Text

            End If
        End If

        If txtMain.Font IsNot Mainform.txtMain.Font Then
            txtMain.Font = Mainform.txtMain.Font
        End If


    End Sub

    Public Sub setForm(form As frmMain)

        Mainform = form

    End Sub

End Class