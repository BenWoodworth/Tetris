Class TetrisAnimations
    Private Const s As Integer = -1 'Shadow
    Public Shared Function getAnimation(ByVal index As AnimationID) As List(Of TetrisBoard)
        Select Case index
            Case AnimationID.TSpin : Return TSpin
            Case AnimationID.Tetris : Return Tetris
            Case AnimationID.FullClear : Return FullClear
            Case Else : Return New List(Of TetrisBoard)
        End Select
    End Function

    Public Shared ReadOnly Property TSpin As List(Of TetrisBoard)
        Get
            Dim result As New List(Of TetrisBoard)
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 6, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 6, 6, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 6, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, s, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, 0, 0, 0, s, s, s}, _
                 {s, s, s, s, s, 0, s, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 6, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 6, 6, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 6, 0, 0, 0, 0}, _
                 {s, s, s, s, s, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, 0, 0, 0, s, s, s}, _
                 {s, s, s, s, s, 0, s, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 6, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 6, 6, 0, 0, 0}, _
                 {s, s, s, s, s, 6, 0, 0, 0, 0}, _
                 {s, s, s, s, 0, 0, 0, s, s, s}, _
                 {s, s, s, s, s, 0, s, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 6, 0, 0, 0, 0}, _
                 {s, s, s, s, s, 6, 6, 0, 0, 0}, _
                 {s, s, s, s, 0, 6, 0, s, s, s}, _
                 {s, s, s, s, s, 0, s, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, s, 6, 0, 0, 0, 0}, _
                 {s, s, s, s, 0, 6, 6, s, s, s}, _
                 {s, s, s, s, s, 6, s, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, s, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, 6, 6, 6, s, s, s}, _
                 {s, s, s, s, s, 6, s, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, s, 0, 0, 0, 0, 0}}, True))
            result.Add(result(result.Count - 1))
            Return result
        End Get
    End Property

    Public Shared ReadOnly Property Tetris As List(Of TetrisBoard)
        Get
            Dim result As New List(Of TetrisBoard)
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 1, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 1, 0, 0, 0, 0}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 0, s, s, s, s}, _
                 {s, s, s, s, s, 0, s, s, s, s}, _
                 {s, s, s, s, s, 0, s, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 1, 0, 0, 0, 0}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 0, s, s, s, s}, _
                 {s, s, s, s, s, 0, s, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 0, s, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, s, 0, s, s, s, s}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 1, s, s, s, s}, _
                 {s, s, s, s, s, 1, s, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, s, 0, s, s, s, s}}, True))
            result.Add(result(result.Count - 1))
            'result.Add(result(result.Count - 1))
            'result.Add(result(result.Count - 1))
            Return result
        End Get
    End Property

    Public Shared ReadOnly Property FullClear As List(Of TetrisBoard)
        Get
            Dim result As New List(Of TetrisBoard)
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 4, 4, 4, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 4, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, 0, 0, 0, s, s, s}, _
                 {s, s, s, s, s, s, 0, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 4, 4, 4, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 4, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, 0, 0, 0, s, s, s}, _
                 {s, s, s, s, s, s, 0, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 4, 4, 4, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 4, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, 0, 0, 0, s, s, s}, _
                 {s, s, s, s, s, s, 0, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 4, 4, 4, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 4, 0, 0, 0}, _
                 {s, s, s, s, 0, 0, 0, s, s, s}, _
                 {s, s, s, s, s, s, 0, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 4, 4, 4, 0, 0, 0}, _
                 {s, s, s, s, 0, 0, 4, s, s, s}, _
                 {s, s, s, s, s, s, 0, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {s, s, s, s, 4, 4, 4, s, s, s}, _
                 {s, s, s, s, s, s, 4, s, s, s}}, True))
            result.Add(New TetrisBoard( _
                {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, _
                 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}, True))
            result.Add(result(result.Count - 1))
            Return result
        End Get
    End Property
End Class
Public Enum AnimationID
    None
    TSpin
    Tetris
    FullClear
End Enum
