Public Class TetrisFunctions
    Public Shared Function checkCollision(ByVal bd1 As TetrisBoard, ByVal bd2 As TetrisBoard) As Boolean
        For x = 0 To 9
            For y = 0 To 23
                If bd1(x, y) <> 0 AndAlso bd2(x, y) <> 0 Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function

    Public Shared Function dropOverlay(ByVal Board As TetrisBoard, ByVal Overlay As TetrisBoard) As TetrisBoard
        clone(Board)

        Dim result As New TetrisBoard
        For x = 0 To 9
            For y = 0 To 23
                If Overlay(x, y) <> 0 Then
                    result(x, y) = Overlay(x, y)
                Else
                    result(x, y) = Board(x, y)
                End If
            Next
        Next
        Return result
    End Function

    Public Shared Function isPerfectClear(board As TetrisBoard) As Boolean
        For x = 0 To 9
            For y = 0 To 23
                If board(x, y) > 0 Then Return False
            Next
        Next
        Return True
    End Function

    Public Shared Function isValidScore(ByVal game As String, ByVal score As Score)
        Dim fromGame As Score = scoreFromGame(game)
        Return fromGame.compare(score)
    End Function

    Public Shared Function scoreFromGame(ByVal game As String) As Score
        Dim testGame As New TetrisGame(game)
        Dim eventBoard As New TetrisEventBoard(testGame.GameSeed)
        eventBoard.addEvents(testGame.Events)
        Return eventBoard.Score
    End Function

    Public Shared Function isTSpin(board As TetrisBoard, piece As TetrisPiece)
        If piece.PieceID <> 6 Then Return False
        If TetrisFunctions.isSafeLocation(board, piece.withOffsetPos(1, 0)) Then Return False
        If TetrisFunctions.isSafeLocation(board, piece.withOffsetPos(-1, 0)) Then Return False
        If TetrisFunctions.isSafeLocation(board, piece.withOffsetPos(0, 1)) Then Return False
        If TetrisFunctions.isSafeLocation(board, piece.withOffsetPos(0, -1)) Then Return False
        Return True
    End Function

    Public Shared Function hardDrop(ByVal board As TetrisBoard, ByVal piece As TetrisPiece) As Point
        If piece.PieceID = 0 Then Return New Point(0, 0)
        clone(board) : clone(piece)

        Do While isSafeLocation(board, piece)
            piece.Location = New Point(piece.Location.X, piece.Location.Y + 1)
        Loop
        piece.Location = New Point(piece.Location.X, piece.Location.Y - 1)
        Return piece.Location
    End Function

    Public Shared Function countCompleteLines(ByVal board As TetrisBoard) As Integer
        clone(board)

        Dim result As Integer = 0
        Dim fullLine As Boolean
        For y = 23 To 0 Step -1
            fullLine = True
            For x = 0 To 9
                If board(x, y) = 0 Then
                    fullLine = False
                    Exit For
                End If
            Next
            If fullLine Then result += 1
        Next
        Return result
    End Function

    Public Shared Function removeCompleteLines(ByVal board As TetrisBoard) As TetrisBoard
        clone(board)

        Dim toRemove As ArrayList = New ArrayList
        Dim fullLine As Boolean
        For y = 0 To 23
            fullLine = True
            For x = 0 To 9
                If board(x, y) = 0 Then
                    fullLine = False
                    Exit For
                End If
            Next
            If fullLine Then toRemove.Add(y)
        Next
        For Each i As Integer In toRemove
            For y = i To 1 Step -1
                For x = 0 To 9
                    board(x, y) = board(x, y - 1)
                Next
            Next
            For x = 0 To 9
                board(x, 0) = 0
            Next
        Next
        Return board
    End Function

    Public Shared Function intToColor(ByVal int As Integer) As Color
        Select Case int
            Case -1 : Return Color.FromArgb(64, 64, 64)
            Case 0 : Return Color.Black
            Case 1 : Return Color.Cyan
            Case 2 : Return Color.Red
            Case 3 : Return Color.Lime
            Case 4 : Return Color.Blue
            Case 5 : Return Color.Orange
            Case 6 : Return Color.Magenta
            Case 7 : Return Color.Yellow
        End Select
    End Function

    Public Shared Function isSafeLocation(ByVal board As TetrisBoard, piece As TetrisPiece) As Boolean
        If piece.PieceID = 0 Then Return True
        clone(board) : clone(piece)

        Dim tetPiece As Integer(,) = GetPiece.getPiece(piece)
        Dim pieceSize As Size = New Size(tetPiece.GetUpperBound(0), tetPiece.GetUpperBound(1))
        Dim offset As Point = New Point(pieceSize.Width / 2, pieceSize.Height / 2)

        If checkCollision(board, piece.onBoard()) Then Return False

        Dim rx As Integer
        Dim ry As Integer
        For x = 0 To pieceSize.Width
            For y = 0 To pieceSize.Height
                If tetPiece(x, y) <> 0 Then
                    rx = x + piece.Location.X - offset.X
                    ry = y + piece.Location.Y - offset.Y
                    If rx < 0 Or rx > 9 Then Return False
                    If ry < 0 Or ry > 23 Then Return False
                End If
            Next
        Next

        Return True
    End Function

    Public Shared Function pieceOnBoard(piece As TetrisPiece) As TetrisBoard
        Return pieceOnBoard(New TetrisBoard, piece)
    End Function

    Public Shared Function pieceOnBoard(board As TetrisBoard, piece As TetrisPiece, id As Integer) As TetrisBoard
        clone(board) : clone(piece)

        Dim tetPiece As Integer(,) = GetPiece.getPiece(piece).Clone
        For x = 0 To tetPiece.GetUpperBound(0)
            For y = 0 To tetPiece.GetUpperBound(1)
                If tetPiece(x, y) <> 0 Then tetPiece(x, y) = id
            Next
        Next

        Dim pieceSize As Size = New Size(tetPiece.GetUpperBound(0), tetPiece.GetUpperBound(1))
        Dim offset As Point = New Point(pieceSize.Width / 2, pieceSize.Height / 2)

        Dim startX As Integer = piece.Location.X - offset.X
        If startX < 0 Then startX = 0
        Dim startY As Integer = piece.Location.Y - offset.Y
        If startY < 0 Then startY = 0

        Dim endX As Integer = piece.Location.X + pieceSize.Width - offset.X
        If endX > 9 Then endX = 9
        Dim endY As Integer = piece.Location.Y + pieceSize.Height - offset.Y
        If endY > 23 Then endY = 23

        Dim newVal As Integer
        For x = startX To endX
            For y = startY To endY
                newVal = tetPiece(x - piece.Location.X + offset.X, y - piece.Location.Y + offset.Y)
                If newVal <> 0 Then board(x, y) = newVal
            Next
        Next
        Return board
    End Function

    Public Shared Function pieceOnBoard(board As TetrisBoard, piece As TetrisPiece) As TetrisBoard
        Return pieceOnBoard(board, piece, piece.PieceID)
    End Function

    Public Shared Sub clone(ByRef toClone As Object)
        toClone = toClone.clone()
    End Sub
End Class
