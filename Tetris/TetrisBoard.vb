Public Class TetrisBoard
    Private intArray As Integer(,)
    Default Public Property Board(ByVal x, ByVal y) As Integer
        Get
            Return intArray(x, y)
        End Get
        Set(ByVal value As Integer)
            intArray(x, y) = value
        End Set
    End Property

    Public ReadOnly Property Size As Size
        Get
            Return New Size(intArray.GetUpperBound(0), intArray.GetUpperBound(1))
        End Get
    End Property
    Public ReadOnly Property Width As Integer
        Get
            Return intArray.GetUpperBound(0) + 1
        End Get
    End Property
    Public ReadOnly Property Height As Integer
        Get
            Return intArray.GetUpperBound(1) + 1
        End Get
    End Property

    Sub New()
        Dim result(9, 23) As Integer
        intArray = result
    End Sub
    Sub New(ByVal TetrisBoard As TetrisBoard)
        intArray = TetrisBoard.intArray.Clone
    End Sub
    Sub New(ByVal TetrisBoard As Integer(,))
        intArray = TetrisBoard.Clone
    End Sub
    Sub New(ByVal TetrisBoard As Integer(,), ByVal RotateArr As Boolean)
        If Not RotateArr Then
            intArray = TetrisBoard.Clone
        Else
            Dim result(TetrisBoard.GetUpperBound(1), TetrisBoard.GetUpperBound(0)) As Integer
            For x = 0 To TetrisBoard.GetUpperBound(0)
                For y = 0 To TetrisBoard.GetUpperBound(1)
                    result(y, x) = TetrisBoard(x, y)
                Next
            Next
            intArray = result
        End If
    End Sub

    Public Function getPos(ByVal x As Integer, ByVal y As Integer) As Integer
        Return Board(x, y)
    End Function
    Public Sub setPos(ByVal x As Integer, ByVal y As Integer, ByVal newValue As Integer)
        Board(x, y) = newValue
    End Sub

    Public Function clone() As TetrisBoard
        Return New TetrisBoard(Me)
    End Function
End Class
