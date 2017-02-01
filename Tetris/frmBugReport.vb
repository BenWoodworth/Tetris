Public Class frmBugReport

    Private Sub frmBugReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtReport.SelectAll()
        txtReport.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        Dim file As String = Application.StartupPath & "\TetrisBugs.txt"
        If Not IO.File.Exists(file) Then IO.File.Create(file).Close()

        Dim curFileText As String = IO.File.ReadAllText(file)

        Dim newFileText As String = txtReport.Text
        newFileText = newFileText.Replace(vbCrLf & vbCrLf, vbCrLf)
        newFileText = newFileText.Replace("  ", " ")
        newFileText = newFileText.Replace(vbCrLf & " ", vbCrLf)

        If newFileText = "" Or newFileText = " " Then
            Me.Close()
            Return
        End If

        newFileText = newFileText.Replace(vbCrLf, vbCrLf & "#")
        newFileText = "#" & newFileText

        If curFileText.Contains(newFileText) Then
            Me.Close()
            Return
        End If

        newFileText = "##Version=" & frmMain.gameVersion & vbCrLf & "##User=" & frmSettings.txtName.Text & vbCrLf & "##Date=" & DateTime.Now.ToString & vbCrLf & "##Message=:" & vbCrLf & newFileText & vbCrLf
        If cbSubmitGame.Checked Then
            newFileText &= "#Game=:" & vbCrLf & frmMain.eventBoard.Game.Game & vbCrLf
        End If
        newFileText &= vbCrLf

        curFileText &= newFileText

        IO.File.SetAttributes(file, 0)
        IO.File.WriteAllText(file, curFileText)
        IO.File.SetAttributes(file, IO.FileAttributes.ReadOnly) ' Or IO.FileAttributes.Hidden)

        Me.Close()
    End Sub
End Class