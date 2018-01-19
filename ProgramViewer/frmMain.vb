Imports System.IO
Imports System.IO.Compression
Imports Ionic.Zip

Public Class frmMain

    Dim currentFolder As String = ""
    Dim projectZips As New List(Of String)
    Dim projectFiles As ObjectModel.ReadOnlyCollection(Of String)

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFolderToolStripMenuItem.Click

        newFolder()

    End Sub

    Private Sub newFolder()


        If fdOpenFolder.ShowDialog() = DialogResult.OK Then

            currentFolder = fdOpenFolder.SelectedPath
            lbProjects.Items.Clear()
            loadProjectNames(currentFolder)

        End If

    End Sub

    Private Sub loadProjectNames(folderPath As String)

        Dim tempProjZips = My.Computer.FileSystem.GetFiles(folderPath)



        For Each f As String In tempProjZips
            If (f.Contains(".zip")) Then
                lbProjects.Items.Add(f.Split("\").Last)

                projectZips.Add(f)
            End If
        Next

    End Sub

    Private Sub lbProjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProjects.SelectedIndexChanged


        Cursor.Current = Cursors.WaitCursor
        txtMain.Clear()
        lbFiles.Items.Clear()
        unZipFile()
        openProjectFiles()
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub unZipFile()

        Dim unzipPath As String = currentFolder + "\UnzippedFolder"

        If My.Computer.FileSystem.DirectoryExists(currentFolder + "\UnzippedFolder") Then
            My.Computer.FileSystem.DeleteDirectory(currentFolder + "\UnzippedFolder", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If

        For Each zip As ZipEntry In ZipFile.Read(projectZips.Item(lbProjects.SelectedIndex))
            zip.Extract(unzipPath, ExtractExistingFileAction.OverwriteSilently)
        Next

        projectFiles = My.Computer.FileSystem.GetFiles(unzipPath, FileIO.SearchOption.SearchAllSubDirectories)

    End Sub

    Private Sub openProjectFiles()

        lbFiles.Items.Clear()

        For Each f As String In projectFiles
            If f.Contains(".vb") AndAlso Not f.Contains(".vbproj") Then
                If f.Split(".").Length - 1 = 1 Then
                    lbFiles.Items.Add(f.Split("\").Last)
                End If
            End If
        Next

    End Sub

    Private Sub lbFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFiles.SelectedIndexChanged

        txtMain.Clear()

        Dim readFiles As New List(Of String)

        For Each f As String In projectFiles
            If f.Contains(".vb") Then
                If f.Split(".").Length - 1 = 1 Then
                    readFiles.add(f)
                End If
            End If
        Next

        Dim sr As New System.IO.StreamReader(readFiles(lbFiles.SelectedIndex))

        txtMain.Text = sr.ReadToEnd()
        sr.Close()

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Label1.Location = New Point(Me.Width / 2 - 200, Label1.Location.Y)
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        newFolder()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub tmrUpdateTools_Tick(sender As Object, e As EventArgs) Handles tmrUpdateTools.Tick

        If lbFiles.Items.Count > 0 Then
            btnRun.Show()
            btnVb.Show()
            btnView.Show()
        Else
            btnRun.Hide()
            btnVb.Hide()
            btnView.Hide()
        End If

    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        For Each file As String In My.Computer.FileSystem.GetFiles(currentFolder + "\UnzippedFolder", FileIO.SearchOption.SearchAllSubDirectories)

            If file.Contains(".exe") Then
                Process.Start(file)
                Exit Sub
            End If

        Next

    End Sub

    Private Sub btnPopout_Click(sender As Object, e As EventArgs) Handles btnPopout.Click

        Dim popForm As frmCodePopout = New frmCodePopout
        popForm.setForm(Me)
        popForm.Show()

    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        showOptions()
    End Sub

    Private Sub showOptions()

        Dim frm As New frmOptions
        frm.form = Me
        frm.ShowDialog()

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        showOptions()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If My.Settings.CodeFont.ToString <> Nothing Then
                txtMain.Font = My.Settings.CodeFont
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnVb_Click(sender As Object, e As EventArgs) Handles btnVb.Click

        For Each f In My.Computer.FileSystem.GetFiles(currentFolder + "\UnzippedFolder", FileIO.SearchOption.SearchAllSubDirectories)
            If f.Contains(".sln") Then
                Process.Start(f)
            End If
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnView.Click

        Process.Start(currentFolder + "\UnzippedFolder")

    End Sub

    Private Sub txtMain_TextChanged(sender As Object, e As EventArgs) Handles txtMain.TextChanged

        Me.CheckKeyword("Dim", Color.Blue, 1)

    End Sub


    Private Sub CheckKeyword(word As String, color__1 As Color, startIndex As Integer)
        If Me.txtMain.Text.Contains(word) Then
            Dim index As Integer = -1
            Dim selectStart As Integer = Me.txtMain.SelectionStart

            While ((index = Me.txtMain.Text.IndexOf(word, (index + 1))) <> -1)
                Me.txtMain.Select((index + startIndex), word.Length)
                Me.txtMain.SelectionColor = color__1
                Me.txtMain.Select(selectStart, 0)
                Me.txtMain.SelectionColor = Color.Black
            End While
        End If
    End Sub

End Class
