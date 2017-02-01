Public Class GetPiece
    Public Shared Function getPiece(ByVal piece As TetrisPiece) As Integer(,)
        Dim result As Integer(,) = {{0}}
        piece.Rotation = piece.Rotation Mod 4

        Select Case piece.PieceID
            Case 1 'I
                Select Case piece.Rotation
                    Case 0
                        result = {{0, 0, 0, 0}, _
                                  {0, 0, 0, 0}, _
                                  {1, 1, 1, 1}, _
                                  {0, 0, 0, 0}}
                    Case 1
                        result = {{0, 1, 0, 0}, _
                                  {0, 1, 0, 0}, _
                                  {0, 1, 0, 0}, _
                                  {0, 1, 0, 0}}
                    Case 2
                        result = {{0, 0, 0, 0}, _
                                  {1, 1, 1, 1}, _
                                  {0, 0, 0, 0}, _
                                  {0, 0, 0, 0}}
                    Case 3
                        result = {{0, 0, 1, 0}, _
                                  {0, 0, 1, 0}, _
                                  {0, 0, 1, 0}, _
                                  {0, 0, 1, 0}}
                End Select
            Case 2 'Z
                Select Case piece.Rotation
                    Case 0
                        result = {{0, 0, 0}, _
                                  {2, 2, 0}, _
                                  {0, 2, 2}}
                    Case 1
                        result = {{0, 2, 0}, _
                                  {2, 2, 0}, _
                                  {2, 0, 0}}
                    Case 2
                        result = {{2, 2, 0}, _
                                  {0, 2, 2}, _
                                  {0, 0, 0}}
                    Case 3
                        result = {{0, 0, 2}, _
                                  {0, 2, 2}, _
                                  {0, 2, 0}}
                End Select
            Case 3 'S
                Select Case piece.Rotation
                    Case 0
                        result = {{0, 0, 0}, _
                                  {0, 3, 3}, _
                                  {3, 3, 0}}
                    Case 1
                        result = {{3, 0, 0}, _
                                  {3, 3, 0}, _
                                  {0, 3, 0}}
                    Case 2
                        result = {{0, 3, 3}, _
                                  {3, 3, 0}, _
                                  {0, 0, 0}}
                    Case 3
                        result = {{0, 3, 0}, _
                                  {0, 3, 3}, _
                                  {0, 0, 3}}
                End Select
            Case 4 'J
                Select Case piece.Rotation
                    Case 0
                        result = {{0, 4, 0}, _
                                  {0, 4, 0}, _
                                  {4, 4, 0}}
                    Case 1
                        result = {{4, 0, 0}, _
                                  {4, 4, 4}, _
                                  {0, 0, 0}}
                    Case 2
                        result = {{0, 4, 4}, _
                                  {0, 4, 0}, _
                                  {0, 4, 0}}
                    Case 3
                        result = {{0, 0, 0}, _
                                  {4, 4, 4}, _
                                  {0, 0, 4}}
                End Select
            Case 5 'L
                Select Case piece.Rotation
                    Case 0
                        result = {{0, 5, 0}, _
                                  {0, 5, 0}, _
                                  {0, 5, 5}}
                    Case 1
                        result = {{0, 0, 0}, _
                                  {5, 5, 5}, _
                                  {5, 0, 0}}
                    Case 2
                        result = {{5, 5, 0}, _
                                  {0, 5, 0}, _
                                  {0, 5, 0}}
                    Case 3
                        result = {{0, 0, 5}, _
                                  {5, 5, 5}, _
                                  {0, 0, 0}}
                End Select
            Case 6 'T
                Select Case piece.Rotation
                    Case 0
                        result = {{0, 6, 0}, _
                                  {6, 6, 6}, _
                                  {0, 0, 0}}
                    Case 1
                        result = {{0, 6, 0}, _
                                  {0, 6, 6}, _
                                  {0, 6, 0}}
                    Case 2
                        result = {{0, 0, 0}, _
                                  {6, 6, 6}, _
                                  {0, 6, 0}}
                    Case 3
                        result = {{0, 6, 0}, _
                                  {6, 6, 0}, _
                                  {0, 6, 0}}
                End Select
            Case 7 'O
                Return {{7, 7}, _
                        {7, 7}}
        End Select

        Dim final(result.GetUpperBound(1), result.GetUpperBound(0)) As Integer
        For x = 0 To result.GetUpperBound(0)
            For y = 0 To result.GetUpperBound(1)
                final(y, x) = result(x, y)
            Next
        Next
        Return final
    End Function

    Public Shared Function getPiece(pieceID As Integer) As Integer(,)
        Return getPiece(New TetrisPiece(pieceID, New Point(0, 0), 0))
    End Function

    Public Shared Function getDisplay(ByVal id As Integer) As Integer(,)
        Dim result As Integer(,) = {{0}}
        Select Case id
            Case 1 'I
                result = {{1, 1, 1, 1}}
            Case 2 'Z
                result = {{2, 2, 0}, _
                          {0, 2, 2}}
            Case 3 'S
                result = {{0, 3, 3}, _
                          {3, 3, 0}}
            Case 4 'J
                result = {{0, 4}, _
                          {0, 4}, _
                          {4, 4}}
            Case 5 'L
                result = {{5, 0}, _
                          {5, 0}, _
                          {5, 5}}
            Case 6 'T
                result = {{0, 6, 0}, _
                          {6, 6, 6}}
            Case 7 'O
                Return {{7, 7}, _
                        {7, 7}}
        End Select

        Dim final(result.GetUpperBound(1), result.GetUpperBound(0)) As Integer
        For x = 0 To result.GetUpperBound(0)
            For y = 0 To result.GetUpperBound(1)
                final(y, x) = result(x, y)
            Next
        Next
        Return final
    End Function
End Class