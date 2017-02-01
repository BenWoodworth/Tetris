Public Class frmPlayback
    Public Property Game As String
        Get
            Return tetGame.Game
        End Get
        Set(ByVal value As String)
            tetGame = New TetrisGame(value)
            GameScroll.Maximum = tetGame.Events.Count - 1
        End Set
    End Property
    Private eventBoard As TetrisEventBoard
    Dim tetGame As TetrisGame

    Dim boards As New List(Of SimpleBoardInfo)
    Sub New(ByVal game As String)
        InitializeComponent()
        Me.Game = game
        Me.Text = "Game Playback"
        boards.Clear()

        eventBoard = New TetrisEventBoard(tetGame.GameSeed)
        For Each e As Char In tetGame.Events
            eventBoard.AddEvent(e)
            boards.Add(New SimpleBoardInfo(eventBoard))
        Next
    End Sub

    Private Sub GameScroll_Scroll() Handles GameScroll.Scroll
        Dim boardInfo As SimpleBoardInfo = boards(GameScroll.Value)

        tBoard.TetrisBoard = boardInfo.Board
        tBoard.TetrisPiece = boardInfo.Piece

        pdHold.TetrisPieceID = boardInfo.HoldPiece

        sdGameStats.Score = boardInfo.Score

        pdNext0.TetrisPieceID = boardInfo.NextPiece(0)
        pdNext1.TetrisPieceID = boardInfo.NextPiece(1)
        pdNext2.TetrisPieceID = boardInfo.NextPiece(2)
        pdNext3.TetrisPieceID = boardInfo.NextPiece(3)
    End Sub
End Class
Public Class SimpleBoardInfo
    Public Property Board As TetrisBoard
    Public Property Piece As TetrisPiece
    Public Property HoldPiece As Integer
    Public Property Score As Score
    Public Property NextPiece As Integer()

    Sub New(ByVal eventBoard As TetrisEventBoard)
        Board = eventBoard.board.clone
        Piece = eventBoard.Piece.clone
        HoldPiece = eventBoard.HoldPiece
        Score = eventBoard.Score.clone
        NextPiece = eventBoard.NextPiece.Clone
    End Sub
End Class