Public Class HighScoreList
    Public Property HighScores() As List(Of HighScore)

    Sub New(ByVal file As String)
        load(file)
    End Sub

    Sub New()
        HighScores = New List(Of HighScore)
    End Sub

    Public Sub load(ByVal file As String)
        Dim emptyHighScore As New HighScore
        highScores = New List(Of HighScore)
        If IO.File.Exists(file) Then
            For Each l As String In Encryption.decrypt(IO.File.ReadAllText(file)).Replace(vbLf, "").Split(vbCrLf)
                If l <> "" Then
                    Dim toAdd As HighScore = HighScore.fromString(l)
                    If Not toAdd.equals(emptyHighScore) Then
                        HighScores.Add(HighScore.fromString(l))
                    End If
                End If
            Next
        End If
        reRank()
        compressGames()
    End Sub

    Public Sub save(ByVal file As String)
        reRank()
        If Not IO.File.Exists(file) Then IO.File.Create(file).Close()
        IO.File.SetAttributes(file, 0)
        Dim newFile As String = ""
        For Each hs As HighScore In highScores
            newFile &= hs.toString & vbCrLf
        Next
        IO.File.WriteAllText(file, Encryption.encrypt(newFile))
        IO.File.SetAttributes(file, IO.FileAttributes.Hidden Or IO.FileAttributes.ReadOnly)
    End Sub

    Public Sub reRank()
        If highScores.Count > 1 Then
            Dim changed As Integer = -1
            Do Until changed = 0
                changed = 0
                For x = 0 To highScores.Count - 2
                    If HighScores(x).Score.Score < HighScores(x + 1).Score.Score Then
                        Dim prevHS As HighScore = HighScores(x + 1).Clone
                        HighScores.RemoveAt(x + 1)
                        HighScores.Insert(x, prevHS)

                        changed += 1
                    End If
                Next
            Loop

            Dim curRank As Integer = 1
            highScores(0).Rank = 1
            For x = 1 To highScores.Count - 1
                If HighScores(x - 1).Score.Score = HighScores(x).Score.Score Then
                    HighScores(x).Rank = curRank
                Else
                    curRank = x + 1
                    HighScores(x).Rank = curRank
                End If
            Next
        ElseIf highScores.Count = 1 Then
            highScores(0).Rank = 1
        End If
    End Sub

    Public Function toListviewItems(ByVal columns As String) As ListViewItem()
        Dim result As New List(Of ListViewItem)
        Dim cols() As Char = columns.ToCharArray

        For Each hs As HighScore In highScores
            Dim toAdd As New List(Of String)
            For Each p As String In cols
                toAdd.Add(hs.getProperty(p))
            Next
            result.Add(New ListViewItem(toAdd.ToArray))
        Next
        Return result.ToArray
    End Function

    Public Sub compressGames()
        For Each hs As HighScore In highScores
            hs.Game = TetrisGame.compress(hs.Game)
        Next
    End Sub
End Class
