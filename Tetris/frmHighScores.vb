Imports System.Collections
Imports System.Windows.Forms

Public Class frmHighScores
    Dim hsList As HighScoreList = frmMain.hsList

    Private Sub frmHighScores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateControls()
    End Sub

    Public Sub updateControls()
        lvHighScores.Items.Clear()
        Dim format As String = (ScoreProperties.Rank & _
                                ScoreProperties.DisplayName & _
                                ScoreProperties.Score & _
                                ScoreProperties.Levels & _
                                ScoreProperties.Lines & _
                                ScoreProperties.Tetrises & _
                                ScoreProperties.TSpins & _
                                ScoreProperties.TSpinDouble & _
                                ScoreProperties.TSpinTriple & _
                                ScoreProperties.TotalCombo & _
                                ScoreProperties.FullClears)
        lvHighScores.Items.AddRange(hsList.toListviewItems(format))

        'TODO http://stackoverflow.com/questions/8405242/why-doesnt-listview-ensurevisible-work

        Dim selIndex As Integer = -1
        For Each i As ListViewItem In lvHighScores.Items
            If lvHighScores.SelectedItems.Count = 0 AndAlso hsList.HighScores(i.Index).Score.Equals(frmMain.sdGameStats.Score) Then
                selIndex = i.Index
                Exit For
            End If
        Next
        If selIndex > -1 Then
            'lvHighScores.Focus()
            lvHighScores.SelectedIndices.Add(selIndex)
            lvHighScores.Select()
            lvHighScores.EnsureVisible(selIndex)
        End If
    End Sub

    Private Sub btnViewGame_Click() Handles btnViewGame.Click, lvHighScores.MouseDoubleClick
        Dim count As Integer = lvHighScores.SelectedIndices.Count
        If count = 0 Then
            MsgBox("No high scores selected!", MsgBoxStyle.Critical)
        ElseIf count > 1 Then
            MsgBox("Too many high scores selected!", MsgBoxStyle.Critical)
        Else
            Me.Cursor = Cursors.AppStarting
            Dim game As String = hsList.HighScores(lvHighScores.SelectedIndices(0)).Game
            If game <> "" Then
                Dim pb As New frmPlayback(game)
                pb.ShowDialog()
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub lvHighScores_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvHighScores.SelectedIndexChanged
        If lvHighScores.SelectedItems.Count > 0 Then
            btnViewGame.Enabled = hsList.HighScores(lvHighScores.SelectedIndices(0)).Game <> ""
        Else
            btnViewGame.Enabled = False
        End If
    End Sub

    Private Sub btnVerifyScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifyScores.Click
        btnVerifyScores.Visible = False
        pbVerify.Value = 0
        pbVerify.Maximum = hsList.HighScores.Count '- 1

        hsList.load(frmMain.hsFile)
        For x = hsList.HighScores.Count - 1 To 0 Step -1
            If hsList.HighScores(x).Score.Score = 0 Or hsList.HighScores(x).Game = "" Then
                hsList.HighScores.RemoveAt(x)
            Else
                hsList.HighScores(x).Score = TetrisFunctions.scoreFromGame(hsList.HighScores(x).Game)
                hsList.HighScores(x).Score.ScoreVersion = frmMain.scoreVersion
            End If
            pbVerify.Value = hsList.HighScores.Count - x
        Next

        hsList.reRank()
        hsList.save(frmMain.hsFile)
        updateControls()
        Me.Cursor = Cursors.Default
        MsgBox("List successfully verified!")
        btnVerifyScores.Visible = True
    End Sub
End Class