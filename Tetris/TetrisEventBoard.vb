Public Class TetrisEventBoard
    Public Property Board As TetrisBoard
    Public Property Piece As TetrisPiece
    Public Property Score As Score
    Public Property Game As TetrisGame
    Private rand As RandPiece

    Private Function nextRandPiece() As Integer
        Dim result As Integer = 0
        Dim upperBound As Integer = _nextPiece.GetUpperBound(0)
        For x = 0 To upperBound
            If _nextPiece(x) = 0 Then
                If x = upperBound Then
                    _nextPiece(x) = rand.nextInt
                Else
                    If _nextPiece(x + 1) <> 0 Then
                        _nextPiece(x) = _nextPiece(x + 1)
                        _nextPiece(x + 1) = 0
                    Else
                        _nextPiece(x) = rand.nextInt
                    End If
                End If
            End If
        Next
        result = _nextPiece(0)
        For x = 0 To upperBound - 1
            _nextPiece(x) = _nextPiece(x + 1)
        Next
        _nextPiece(upperBound) = rand.nextInt

        Return result
    End Function

    Private _nextPiece(4) As Integer
    Public ReadOnly Property NextPiece As Integer()
        Get
            Return _nextPiece
        End Get
    End Property

    Private _holdPiece As Integer = 0
    Public Property HoldPiece As Integer
        Get
            Return _holdPiece
        End Get
        Set(value As Integer)
            _holdPiece = value
            RaiseEvent HoldPieceChange()
        End Set
    End Property
    Private changeHoldPiece As Boolean = True

    Public Event GameOver()
    Public Event NewPiece()
    Public Event HoldPieceChange()

    Sub New(ByVal board As TetrisBoard, ByVal piece As TetrisPiece, ByVal randSeed As Integer)
        TetrisFunctions.clone(board) : TetrisFunctions.clone(piece)

        rand = New RandPiece(randSeed)
        Me.board = board
        Me.Piece = piece
        HoldPiece = 0

        Game = New TetrisGame(randSeed)
    End Sub
    Sub New(ByVal randSeed As Integer)
        rand = New RandPiece(randSeed)
        Score = New Score
        Score.ScoreVersion = frmMain.ScoreVersion
        Me.board = New TetrisBoard
        Me.Piece = New TetrisPiece(nextRandPiece, New Point(4, 3), 0)
        Me.Piece.Location = Me.Piece.StartPos
        HoldPiece = 0

        Game = New TetrisGame(randSeed)
    End Sub

    Public Sub addEvent(ByVal eventId As Char)
        Game.Events.Add(eventId)
        Select Case eventId
            Case TetrisEvents.KeyDown
                eventKeyDown()
            Case TetrisEvents.KeyHardDrop
                eventKeyHardDrop()
            Case TetrisEvents.KeyHold
                eventKeyHold()
            Case TetrisEvents.KeyLeft
                eventKeyLeft()
            Case TetrisEvents.KeyRight
                eventKeyRight()
            Case TetrisEvents.KeyRotate
                eventKeyRotate()
            Case TetrisEvents.KeyRotateLeft
                eventKeyRotateLeft()
            Case TetrisEvents.TimerTick
                eventTimerTick()
        End Select
    End Sub
    Public Sub addEvents(ByVal eventIds As Char())
        For Each e As Char In eventIds
            addEvent(e)
            Application.DoEvents()
        Next
    End Sub
    Public Sub addEvents(ByVal eventIds As List(Of Char))
        For Each e As Char In eventIds
            addEvent(e)
            Application.DoEvents()
        Next
    End Sub

    Private Sub eventKeyRotate()
        rotate(1)
    End Sub
    Private Sub eventKeyRotateLeft()
        rotate(3)
    End Sub

    Private lastLR As Integer = 1
    Private Sub rotate(ByVal amount As Integer)
        Dim newPos As Point = Piece.Location
        Dim newRotation As Integer = (Piece.Rotation + amount) Mod 4

        Dim toCheck As Point() = {New Point(0, 0), _
                                  New Point(0, 1), _
                                  New Point(1, 1), _
                                  New Point(-1, 1), _
                                  New Point(0, 3), _
                                  New Point(1, 3), _
                                  New Point(-1, 3), _
                                  New Point(1, 0), _
                                  New Point(-1, 0), _
                                  New Point(0, -1), _
                                  New Point(1, -1), _
                                  New Point(-1, -1), _
                                  New Point(0, 2), _
                                  New Point(1, 2), _
                                  New Point(-1, 2), _
                                  New Point(2, 3), _
                                  New Point(-2, 3), _
                                  New Point(0, -2), _
                                  New Point(1, -2), _
                                  New Point(-1, -2), _
                                  New Point(2, 0), _
                                  New Point(-2, 0), _
                                  New Point(2, 1), _
                                  New Point(-2, 1), _
                                  New Point(2, -1), _
                                  New Point(-2, -1), _
                                  New Point(2, 2), _
                                  New Point(-2, 2), _
                                  New Point(2, -2), _
                                  New Point(-2, -2)}

        If lastLR = -1 Then
            For i = 0 To toCheck.Length - 1
                toCheck(i).X *= -1
            Next
        End If

        Dim x As Integer
        For x = 0 To toCheck.Length - 1
            If TetrisFunctions.isSafeLocation(Board, Piece.withOffsetPos(toCheck(x)).withNewRotation(newRotation)) Then
                Exit For
            End If
        Next
        If Not x = toCheck.Length Then
            If TetrisFunctions.isSafeLocation(Board, Piece.withOffsetPos(toCheck(x)).withNewRotation(newRotation)) Then
                Piece = Piece.withOffsetPos(toCheck(x)).withNewRotation(newRotation)
            End If
        End If
    End Sub
    Private Sub eventKeyDown()
        If TetrisFunctions.isSafeLocation(Board, Piece.withOffsetPos(New Point(0, 1))) Then
            Score.Score += 1
            Score.SoftDropDistance += 1
            eventTimerTick()
        End If
    End Sub
    Private Sub eventKeyLeft()
        Dim newPos As Point = Piece.Location
        newPos.X -= 1
        If TetrisFunctions.isSafeLocation(Board, New TetrisPiece(Piece.PieceID, newPos, Piece.Rotation)) Then
            Piece.Location = newPos
            Return
        End If
        lastLR = -1
    End Sub
    Private Sub eventKeyRight()
        Dim newPos As Point = Piece.Location
        newPos.X += 1
        If TetrisFunctions.isSafeLocation(Board, New TetrisPiece(Piece.PieceID, newPos, Piece.Rotation)) Then
            Piece.Location = newPos
            Return
        End If
        lastLR = 1
    End Sub
    Private Sub eventKeyHold()
        If changeHoldPiece Then
            Dim prevHold As Integer = HoldPiece
            HoldPiece = Piece.PieceID

            Dim id As Integer = prevHold
            If id = 0 Then
                id = nextRandPiece()
            End If
            createNewPiece(id)

            changeHoldPiece = False
        End If
    End Sub

    Private Sub createNewPiece(ByVal pieceId As Integer)
        Piece.PieceID = pieceId
        Piece.Location = Piece.StartPos
        Piece.Rotation = 0

        Dim toCheck As Point() = {New Point(0, 0), _
                                  New Point(-1, 0), _
                                  New Point(1, 0), _
                                  New Point(-2, 0), _
                                  New Point(2, 0)}

        Dim safe As Integer = -1
        For x = 0 To toCheck.Length - 1
            If TetrisFunctions.isSafeLocation(Board, Piece.withOffsetPos(toCheck(x))) Then
                safe = x
                Exit For
            End If
        Next

        If safe = -1 Then
            Piece.PieceID = 0
            RaiseEvent GameOver()
        Else
            Piece = Piece.withOffsetPos(toCheck(safe))
            If Score.Level > 25 Then Piece.Location = TetrisFunctions.hardDrop(Board, Piece)
            RaiseEvent NewPiece()
        End If
    End Sub


    Private Sub eventKeyHardDrop()
        Dim startY As Integer = Piece.Location.Y
        Piece.Location = TetrisFunctions.hardDrop(Board, Piece)
        Dim dist As Integer = Piece.Location.Y - startY
        Score.HardDropDistance += dist
        Score.Score += dist * 2
        eventTimerTick()
    End Sub

    Private Sub eventTimerTick()
        Dim newPos As Point = Piece.Location
        newPos.Y += 1
        If TetrisFunctions.isSafeLocation(Board, New TetrisPiece(Piece.PieceID, newPos, Piece.Rotation)) Then
            Piece.Location = newPos
        Else
            Dim newBoard As TetrisBoard = TetrisFunctions.pieceOnBoard(Board, Piece)
            Dim lines As Integer = TetrisFunctions.countCompleteLines(newBoard)
            If lines > 0 Then
                newBoard = TetrisFunctions.removeCompleteLines(newBoard)
                Score.Combo += 1
                If Score.Combo > 1 Then
                    Score.TotalCombo += 1
                End If
            Else
                Score.Combo = 0
            End If

            'http://tetris.wikia.com/wiki/Scoring
            Dim isTSpin As Boolean = TetrisFunctions.isTSpin(Board, Piece)
            Dim isPerfectClear As Integer = TetrisFunctions.isPerfectClear(newBoard)
            Dim level As Integer = Score.Level + 1

            Score.Lines += lines
            If isPerfectClear Then
                Score.Score += 50000
                Score.FullClears += 1
            End If
            Select Case lines
                Case 0
                    If isTSpin Then
                        Score.TSpins += 1
                        Score.Score += 100 * level
                    End If
                Case 1
                    Score.Score += 100 * level * Score.Combo
                    If isTSpin Then
                        Score.TSpins += 1
                        Score.TSpinSingle += 1
                        Score.Score += 200 * level
                    End If
                Case 2
                    Score.Score += 300 * level * Score.Combo
                    If isTSpin Then
                        Score.TSpins += 1
                        Score.TSpinDouble += 1
                        Score.Score += 1200 * level
                    End If
                Case 3
                    Score.Score += 500 * level * Score.Combo
                    If isTSpin Then
                        Score.TSpins += 1
                        Score.TSpinTriple += 1
                        Score.Score += 7500 * level
                    End If
                Case 4
                    Score.Score += 800 * level * Score.Combo
                    Score.Tetrises += 1
            End Select

            Board = newBoard

            createNewPiece(nextRandPiece())
            changeHoldPiece = True
        End If
    End Sub
End Class
