Public Class TetrisPiece
    Public Property PieceID As Integer
    Public Property Location As Point
    Public Property Rotation As Integer
    Public ReadOnly Property StartPos As Point
        Get
            Select Case PieceID
                Case 0 'Nothing
                    Return New Point(4, 3)
                Case 1 'I
                    Return New Point(5, 4)
                Case 2 'Z
                    Return New Point(4, 3)
                Case 3 'S
                    Return New Point(5, 3)
                Case 4 'J
                    Return New Point(5, 3)
                Case 5 'L
                    Return New Point(4, 3)
                Case 6 'T
                    Return New Point(4, 4)
                Case 7 'O
                    Return New Point(4, 3)
            End Select
        End Get
    End Property

    Sub New(pieceID As Integer, location As Point, rotation As Integer)
        Me.PieceID = pieceID
        Me.Location = location
        Me.Rotation = rotation
    End Sub

    Sub New()
        Me.PieceID = 0
        Me.Location = New Point(0, 0)
        Me.Rotation = 0
    End Sub

    Sub New(ByVal piece As TetrisPiece)
        Me.PieceID = piece.PieceID
        Me.Location = piece.Location
        Me.Rotation = piece.Rotation
    End Sub

    Public Function onBoard(board As TetrisBoard, id As Integer) As TetrisBoard
        Return TetrisFunctions.pieceOnBoard(board, Me, id)
    End Function
    Public Function onBoard(board As TetrisBoard) As TetrisBoard
        Return TetrisFunctions.pieceOnBoard(board, Me)
    End Function
    Public Function onBoard() As TetrisBoard
        Return TetrisFunctions.pieceOnBoard(Me)
    End Function

    Public Function clone()
        Return New TetrisPiece(Me)
    End Function

    Public Function withNewPos(ByVal location As Point) As TetrisPiece
        Return New TetrisPiece(Me.PieceID, location, Me.Rotation)
    End Function
    Public Function withOffsetPos(ByVal offset As Point) As TetrisPiece
        Dim newPos As Point = Location
        newPos.Offset(offset)
        Return New TetrisPiece(Me.PieceID, newPos, Me.Rotation)
    End Function
    Public Function withOffsetPos(x As Integer, y As integer) As TetrisPiece
        Dim newPos As Point = Location
        newPos.Offset(x, y)
        Return New TetrisPiece(Me.PieceID, newPos, Me.Rotation)
    End Function
    Public Function withNewRotation(ByVal newRotation As Integer) As TetrisPiece
        Return New TetrisPiece(Me.PieceID, Me.Location, newRotation Mod 4)
    End Function
End Class
