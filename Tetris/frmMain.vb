
Public Class frmMain
    Public Const gameVersion As String = "beta-53"
    Public Const scoreVersion As Integer = 1

    Dim nextPieceDelay As Integer = 400
    Dim levelSpeedDecrease As Double = 0.25
    Dim levelStartSpeed As Integer = 800

    Public WithEvents eventBoard As New TetrisEventBoard(0)

    Dim curSeed As Integer

    Public hsFile As String = Application.StartupPath & "\tetris.dat"
    Public hsList As New HighScoreList(hsFile)

    Dim audioFileLocation As String = ""

    Private Sub setSpeed()
        Dim level As Integer = eventBoard.Score.Level
        Dim levelSpeed As Integer = getSpeed(level)

        If Not TetrisFunctions.isSafeLocation(eventBoard.board, eventBoard.Piece.withOffsetPos(0, 1)) Then
            Dim newSpeed As Integer = levelSpeed * 2
            If newSpeed < nextPieceDelay Then newSpeed = nextPieceDelay
            setTimerSpeed(newSpeed)
        Else
            setTimerSpeed(levelSpeed)
        End If
    End Sub

    Private Sub frmMain_Load() Handles MyBase.Load
        Me.Text = Me.Text.Replace("[GameVersion]", gameVersion)
        PlayerStartupMessage.show(Environment.UserName)

        Try
            Dim fileName As String = IO.Path.Combine(IO.Path.GetTempPath, "TetrisAudio")
            If IO.File.Exists(fileName & ".mid") Then
                Dim x As Integer = 0
                Do While IO.File.Exists(fileName & x & ".mid")
                    x += 1
                Loop
                fileName &= x
            End If
            audioFileLocation = fileName & ".mid"
            IO.File.WriteAllBytes(audioFileLocation, My.Resources.TetrisAudio)
        Catch
            btnVolume.Enabled = False
        End Try

        sdGameStats.Score.Score = 0
        sdGameStats.Refresh()

        frmSettings.txtName.Text = StrConv(Environment.UserName, VbStrConv.ProperCase)
        frmSettings.updateTextures()
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Sounds.StopMidi()
        IO.File.Delete(audioFileLocation)
    End Sub

    Private Sub setTimerSpeed(ByVal ms As Integer)
        If ms < 1 Then ms = 1
        tmrFall.Interval = ms
    End Sub

    Sub pauseUnpause()
        If btnPause.Text = "Pause" Then
            pause()
        Else
            unpause()
        End If
    End Sub
    Sub unpause()
        tmrFall.Enabled = True
        tBoard.TetrisBoard = eventBoard.board.clone
        tBoard.TetrisPiece = eventBoard.Piece.clone

        pdHold.TetrisPieceID = eventBoard.HoldPiece
        pdNext0.TetrisPieceID = eventBoard.NextPiece(0)
        pdNext1.TetrisPieceID = eventBoard.NextPiece(1)
        pdNext2.TetrisPieceID = eventBoard.NextPiece(2)
        pdNext3.TetrisPieceID = eventBoard.NextPiece(3)

        btnPause.Text = "Pause"
        updateBoard()
    End Sub
    Sub pause()
        tmrFall.Enabled = False
        tBoard.TetrisBoard = PauseBoard.getBoard
        tBoard.TetrisPiece = New TetrisPiece(0, New Point(0, 0), 0)

        pdHold.TetrisPieceID = 0
        pdNext0.TetrisPieceID = 0
        pdNext1.TetrisPieceID = 0
        pdNext2.TetrisPieceID = 0
        pdNext3.TetrisPieceID = 0

        btnPause.Text = "Unpause"
    End Sub

    Private Function getSpeed(ByVal level As Integer) As Integer
        Return levelStartSpeed * (1 - levelSpeedDecrease) ^ level
    End Function

    Private Sub updateBoard()
        tBoard.TetrisBoard = eventBoard.board.clone
        tBoard.TetrisPiece = eventBoard.Piece
    End Sub

    Dim timerResetCount As Integer = 0
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal key As Keys) As Boolean 'From decompiler
        If key = frmSettings.key_Pause Then
            Me.pauseUnpause()
            Return True
        Else
            If Not Me.tmrFall.Enabled Then
                Return False
            End If
            If key = (Keys.ShiftKey Or Keys.Shift) Then
                key = Keys.Shift
            End If
            Dim location As Point = Me.eventBoard.Piece.Location
            Dim canReset As Boolean = True
            Dim forceReset As Boolean = False
            If key = frmSettings.key_Rotate Then
                Me.eventBoard.addEvent(TetrisEvents.KeyRotate)
            ElseIf key = frmSettings.key_RotateLeft Then
                Me.eventBoard.addEvent(TetrisEvents.KeyRotateLeft)
            ElseIf key = frmSettings.key_Down Then
                Me.eventBoard.addEvent(TetrisEvents.KeyDown)
                canReset = False
                If Not location = Me.eventBoard.Piece.Location Then
                    Me.tmrFall.Enabled = False
                    Me.tmrFall.Enabled = True
                End If
            ElseIf key = frmSettings.key_Left Then
                Me.eventBoard.addEvent(TetrisEvents.KeyLeft)
            ElseIf key = frmSettings.key_Right Then
                Me.eventBoard.addEvent(TetrisEvents.KeyRight)
            ElseIf key = frmSettings.key_Hold Then
                Me.eventBoard.addEvent(TetrisEvents.KeyHold)
                canReset = False
            Else
                If key <> frmSettings.key_HardDrop Then
                    Return True
                End If
                Me.eventBoard.addEvent(TetrisEvents.KeyHardDrop)
                canReset = False
            End If
            Me.updateBoard()
            Me.updateScoreLabels()
            Me.setSpeed()
            If ((If(forceReset, 1, 0)) Or (If(Not canReset OrElse TetrisFunctions.isSafeLocation(Me.eventBoard.Board, Me.eventBoard.Piece.withOffsetPos(0, 1)), 0, 1))) <> 0 Then
                Me.timerResetCount = Me.timerResetCount + 1
                Me.tmrFall.Enabled = False
                Me.tmrFall.Enabled = True
            End If
            If Me.timerResetCount > 20 - CDbl(Me.eventBoard.Score.Level) / 2.0 Then
                Me.eventBoard.addEvent(TetrisEvents.TimerTick)
            End If
            Return True
            'TODO Rotating both directions at once freezes the game
        End If
    End Function

    Private Sub newPiece() Handles eventBoard.NewPiece
        timerResetCount = 0
        tmrFall.Enabled = False
        tmrFall.Enabled = True
        setSpeed()
        pdNext0.TetrisPieceID = eventBoard.NextPiece(0)
        pdNext1.TetrisPieceID = eventBoard.NextPiece(1)
        pdNext2.TetrisPieceID = eventBoard.NextPiece(2)
        pdNext3.TetrisPieceID = eventBoard.NextPiece(3)
    End Sub

    Private Sub tmrFall_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFall.Tick
        eventBoard.AddEvent(TetrisEvents.TimerTick)
        updateBoard()

        updateScoreLabels()

        setSpeed()
    End Sub

    Sub updateScoreLabels()
        sdGameStats.Score = eventBoard.Score
    End Sub

    Dim isGameOver As Boolean = True
    Private Sub GameOver() Handles eventBoard.GameOver
        updateScoreLabels()
        updateBoard()
        tmrFall.Enabled = False
        btnPause.Enabled = False
        isGameOver = True
        MsgBox("Game Over!")

        If Not TetrisFunctions.isValidScore(eventBoard.Game.Game, eventBoard.Score) Then
            MsgBox("Invalid Score!? D:" & vbCrLf & eventBoard.Game.Events.Count & vbCrLf)
        End If
        If eventBoard.Score.Score > 0 Then
            hsList.load(hsFile)
            hsList.HighScores.Add(New HighScore(eventBoard.Score, eventBoard.Game.Game))
            hsList.reRank()

            Dim players As List(Of String) = New List(Of String)
            Dim toRemove As List(Of Integer) = New List(Of Integer)
            For x = 0 To hsList.HighScores.Count - 1
                If players.Contains(hsList.HighScores(x).Username.ToLower) Then
                    toRemove.Add(x)
                Else
                    players.Add(hsList.HighScores(x).Username.ToLower)
                End If
            Next
            toRemove.Sort()
            toRemove.Reverse()
            For Each i As Integer In toRemove
                hsList.HighScores.RemoveAt(i)
            Next

            If hsList.HighScores.Count > 100 Then
                hsList.HighScores.RemoveRange(100, hsList.HighScores.Count - 100)
            End If
            hsList.save(hsFile)
            btnHighScores_Click()
        End If
    End Sub

    Private Sub HoldPieceChanged() Handles eventBoard.HoldPieceChange
        pdHold.TetrisPieceID = eventBoard.HoldPiece
    End Sub

    Private Sub frmMain_Deactivate() Handles Me.Deactivate
        If Not isGameOver Then pause()
    End Sub

    Private Sub btnHighScores_Click() Handles btnHighScores.Click
        If Not isGameOver Then pause()
        frmHighScores.ShowDialog()
    End Sub

    Private Sub btnSettings_Click() Handles btnSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub btnBugReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBugReport.Click
        frmBugReport.ShowDialog()
    End Sub

    Private Sub btnVolume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolume.Click
        If IO.File.Exists(audioFileLocation) Then
            btnVolume.Text = "Audio: " & IIf(btnVolume.Text.Contains("On"), "Off", "On")
            If btnVolume.Text.Contains("On") Then
                Me.Cursor = Cursors.WaitCursor
                Try
                    Sounds.PlayMidiFile(audioFileLocation)
                Catch ex As Exception
                    MsgBox("Error starting audio D:" & vbCrLf & "Here's an error message for you:" & vbCrLf & ex.Message)
                    btnVolume.Text = "Audio: Off"
                End Try
                Me.Cursor = Cursors.Arrow
            Else
                Sounds.StopMidi()
            End If
        Else
            MsgBox("The audio file could not be found, try restarting the program!")
        End If
    End Sub

    Private Sub btnScoring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScoring.Click
        frmHelp.ShowDialog()
    End Sub

    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        If Not isGameOver Then
            pause()
            If MsgBox("Start new game?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Randomize()
        curSeed = Rnd() * 25565

        eventBoard = New TetrisEventBoard(curSeed)
        setSpeed()
        updateBoard()
        pdHold.TetrisPieceID = 0
        tmrFall.Enabled = True
        newPiece()

        updateScoreLabels()
        btnPause.Enabled = True
        unpause()
        isGameOver = False
    End Sub

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        pauseUnpause()
    End Sub
End Class
