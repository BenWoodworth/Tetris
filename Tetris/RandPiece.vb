Public Class RandPiece
    Private rand As Random
    Private chooseFrom As List(Of Integer)
    Sub New(seed As Integer)
        rand = New Random(seed)
        chooseFrom = New List(Of Integer)
        For x = 1 To 7
            chooseFrom.Add(x)
        Next
    End Sub
    Function nextInt() As Integer
        Dim index As Integer = rand.Next(0, chooseFrom.Count)
        Dim result As Integer = chooseFrom(index)

        Dim newList As New List(Of Integer)

        For Each i As Integer In chooseFrom
            If i <> result Then newList.Add(i)
        Next
        For x = 1 To 7
            If x <> result Then newList.Add(x)
        Next
        newList.Add(result)
        chooseFrom = newList

        Return result

        'Dim index As Integer = rand.Next(0, chooseFrom.Count)
        'Dim result As Integer = chooseFrom(index)

        'For x = 1 To 7
        '    If x <> result Then chooseFrom.Add(x)
        'Next
        Return result
    End Function
End Class
