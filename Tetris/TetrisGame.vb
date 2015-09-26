Public Class TetrisGame
    Public Property Events As List(Of Char)
    Public Property GameSeed As Integer
    Public Property Game As String
        Get
            Return compress(GameSeed & ":" & New String(Events.ToArray))
        End Get
        Set(ByVal value As String)
            value = decompress(value)
            Dim split As String() = value.Split(":")
            If split.Length = 2 Then
                GameSeed = split(0)
                Events = New List(Of Char)
                Events.AddRange(split(1).ToCharArray)
            ElseIf split.Length = 1 Then
                GameSeed = 0
                Events = New List(Of Char)
                Events.AddRange(value.ToCharArray)
            Else
                GameSeed = 0
                Events = New List(Of Char)
            End If
        End Set
    End Property

    Sub New(ByVal game As String)
        Me.Game = game
    End Sub
    Sub New(ByVal gameSeed As Integer)
        Me.Game = ""
        Me.GameSeed = gameSeed
    End Sub
    Sub New()
        Me.Game = ""
    End Sub

    Public Shared Function compress(ByVal game As String) As String
        game = decompress(game)

        Dim split As String() = game.Split(":")
        Dim seed As Integer
        Dim events As String
        If split.Length = 2 Then
            seed = Int(split(0))
            events = split(1)
        ElseIf split.Length = 1 Then
            seed = 0
            events = split(0)
        Else
            seed = 0
            events = ""
        End If

        Dim result As String = ""
        If events.Length > 1 Then
            Dim prev As Char = events(0)
            Dim curCount As Integer = 0
            For x = 1 To events.Length - 1
                curCount += 1
                If events(x) <> prev Then
                    If curCount > 1 Then
                        result &= curCount
                    End If
                    result &= prev
                    curCount = 0
                    prev = events(x)
                End If
            Next
            If curCount = 0 Then
                result &= prev
            Else
                result &= curCount + 1 & prev
            End If
        Else
            result = events
        End If

        If seed <> 0 Then result = seed & ":" & result
        Return result
    End Function

    Public Shared Function decompress(ByVal game As String) As String
        Dim split As String() = game.Split(":")
        Dim seed As Integer
        Dim events As String
        If split.Length = 2 Then
            seed = Int(split(0))
            events = split(1)
        ElseIf split.Length = 1 Then
            seed = 0
            events = split(0)
        Else
            seed = 0
            events = ""
        End If

        Dim result As String = ""
        Dim curNumber As String = ""
        For Each c As Char In events.ToCharArray
            If IsNumeric(c) Then
                curNumber &= c
            Else
                If Val(curNumber) > 0 Then
                    For x = 1 To Val(curNumber)
                        result &= c
                    Next
                Else
                    result &= c
                End If
                curNumber = ""
            End If
        Next
        Return seed & ":" & result
    End Function
End Class

Public Class TetrisEvents
    Public Function getEvent(ByVal eventChar As Char) As Integer
        Select Case eventChar
            Case "A" : Return KeyRotate
            Case "B" : Return KeyLeft
            Case "C" : Return KeyRight
            Case "D" : Return KeyDown
            Case "E" : Return KeyHold
            Case "F" : Return KeyHardDrop
            Case "G" : Return TimerTick
            Case "H" : Return TimerTick
        End Select
        Return ""
    End Function
    Public Const KeyRotate = "A"
    Public Const KeyLeft = "B"
    Public Const KeyRight = "C"
    Public Const KeyDown = "D"
    Public Const KeyHold = "E"
    Public Const KeyHardDrop = "F"
    Public Const TimerTick = "G"
    Public Const KeyRotateLeft = "H"
End Class
