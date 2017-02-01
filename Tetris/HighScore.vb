Public Class HighScore
    Public Property Rank As Integer
    Public Property DisplayName As String
    Public Property DateScored As Date
    Public Property Game As String
    Public Property GameVersion As String
    Public Property Username As String
    Public Property Score As Score

    Sub New(ByVal rank As Integer, ByVal displayName As String, ByVal score As Score, ByVal dateScored As Date, _
            ByVal game As String, ByVal gameVersion As String, ByVal username As String)
        Me.Rank = rank
        Me.DisplayName = displayName
        Me.Score = score
        Me.DateScored = dateScored
        Me.Game = game
        Me.GameVersion = gameVersion
        Me.Username = username
    End Sub
    Sub New()
        Me.Rank = -1
        Me.DisplayName = "N/A"
        Me.Score = New Score()
        Me.DateScored = New Date(0)
        Me.Game = ""
        Me.GameVersion = "N/A"
        Me.Username = "N/A"
    End Sub
    Sub New(ByVal score As Score, ByVal game As String)
        Me.Rank = -1
        Me.DisplayName = frmSettings.txtName.Text
        Me.Score = score
        Me.DateScored = DateTime.Now
        Me.Game = game
        Me.GameVersion = frmMain.gameVersion
        Me.Username = Environment.UserName
    End Sub

    Public Function Clone() As HighScore
        Return New HighScore(Rank, DisplayName, Score, DateScored, Game, GameVersion, Username)
    End Function

    Public Shared Function fromString(ByVal str As String) As HighScore
        Dim res As New HighScore
        Dim split As String() = {"", ""}
        For Each s As String In str.Split(",")
            split = s.Split("=")
            Select Case split(0)
                Case ScoreProperties.Rank
                    res.Rank = Val(split(1))
                Case ScoreProperties.DisplayName
                    res.DisplayName = split(1)
                Case ScoreProperties.Score
                    res.Score.Score = Val(split(1))
                Case ScoreProperties.Lines
                    res.Score.Lines = Val(split(1))
                Case ScoreProperties.TSpins
                    res.Score.TSpins = Val(split(1))
                Case ScoreProperties.Tetrises
                    res.Score.Tetrises = Val(split(1))
                Case ScoreProperties.FullClears
                    res.Score.FullClears = Val(split(1))
                Case ScoreProperties.TotalCombo
                    res.Score.TotalCombo = Val(split(1))
                Case ScoreProperties.SoftDropDist
                    res.Score.SoftDropDistance = Val(split(1))
                Case ScoreProperties.HardDropDist
                    res.Score.HardDropDistance = Val(split(1))
                Case ScoreProperties.DateScored
                    res.DateScored = Date.Parse(split(1))
                Case ScoreProperties.Game
                    res.Game = split(1)
                Case ScoreProperties.GameVersion
                    res.GameVersion = split(1)
                Case ScoreProperties.TSpinSingle
                    res.Score.TSpinSingle = Val(split(1))
                Case ScoreProperties.TSpinDouble
                    res.Score.TSpinDouble = Val(split(1))
                Case ScoreProperties.TSpinTriple
                    res.Score.TSpinTriple = Val(split(1))
                Case ScoreProperties.ScoreVersion
                    res.Score.ScoreVersion = Val(split(1))
                Case ScoreProperties.Username
                    res.Username = split(1)
            End Select
        Next
        Return res
    End Function

    Public Overrides Function toString() As String
        Dim result As String = _
            IIf(Rank = "-1", "", ScoreProperties.Rank & "=" & Rank & ",") & _
            IIf(DisplayName = "", "", ScoreProperties.DisplayName & "=" & DisplayName & ",") & _
            IIf(Score.Score = "-1", "", ScoreProperties.Score & "=" & Score.Score & ",") & _
            IIf(Score.Level = "-1", "", ScoreProperties.Levels & "=" & Score.Level & ",") & _
            IIf(Score.Lines = "-1", "", ScoreProperties.Lines & "=" & Score.Lines & ",") & _
            IIf(Score.TSpins = "-1", "", ScoreProperties.TSpins & "=" & Score.TSpins & ",") & _
            IIf(Score.Tetrises = "-1", "", ScoreProperties.Tetrises & "=" & Score.Tetrises & ",") & _
            IIf(Score.FullClears = "-1", "", ScoreProperties.FullClears & "=" & Score.FullClears & ",") & _
            IIf(Score.TotalCombo = "-1", "", ScoreProperties.TotalCombo & "=" & Score.TotalCombo & ",") & _
            IIf(Score.SoftDropDistance = "-1", "", ScoreProperties.SoftDropDist & "=" & Score.SoftDropDistance & ",") & _
            IIf(Score.HardDropDistance = "-1", "", ScoreProperties.HardDropDist & "=" & Score.HardDropDistance & ",") & _
            IIf(DateScored = New Date(0), "", ScoreProperties.DateScored & "=" & DateScored & ",") & _
            IIf(Game = "", "", ScoreProperties.Game & "=" & Game) & "," & _
            IIf(GameVersion = "", "", ScoreProperties.GameVersion & "=" & GameVersion & ",") & _
            IIf(Score.TSpinSingle = "-1", "", ScoreProperties.TSpinSingle & "=" & Score.TSpinSingle & ",") & _
            IIf(Score.TSpinDouble = "-1", "", ScoreProperties.TSpinDouble & "=" & Score.TSpinDouble & ",") & _
            IIf(Score.TSpinTriple = "-1", "", ScoreProperties.TSpinTriple & "=" & Score.TSpinTriple & ",") & _
            IIf(Score.ScoreVersion = "-1", "", ScoreProperties.ScoreVersion & "=" & Score.ScoreVersion & ",") & _
            IIf(Username = "", "", ScoreProperties.Username & "=" & Username)
        Do While result.Length > 0 AndAlso result(result.Length - 1) = ","
            result = result.Remove(result.Length - 1)
        Loop
        Return result
    End Function

    Public Function getProperty(ByVal p As Char) As String
        Select Case p
            Case ScoreProperties.Rank
                Return Rank
            Case ScoreProperties.DisplayName
                Return DisplayName
            Case ScoreProperties.Score
                Return Score.Score
            Case ScoreProperties.Levels
                Return Score.Level
            Case ScoreProperties.Lines
                Return Score.Lines
            Case ScoreProperties.TSpins
                Return Score.TSpins
            Case ScoreProperties.Tetrises
                Return Score.Tetrises
            Case ScoreProperties.FullClears
                Return Score.FullClears
            Case ScoreProperties.TotalCombo
                Return Score.TotalCombo
            Case ScoreProperties.SoftDropDist
                Return Score.SoftDropDistance
            Case ScoreProperties.HardDropDist
                Return Score.HardDropDistance
            Case ScoreProperties.DateScored
                Return DateScored
            Case ScoreProperties.Game
                Return Game
            Case ScoreProperties.GameVersion
                Return GameVersion
            Case ScoreProperties.TSpinSingle
                Return Score.TSpinSingle
            Case ScoreProperties.TSpinDouble
                Return Score.TSpinDouble
            Case ScoreProperties.TSpinTriple
                Return Score.TSpinTriple
            Case ScoreProperties.ScoreVersion
                Return Score.ScoreVersion
            Case ScoreProperties.Username
                Return Username
        End Select
        Return ""
    End Function

    Public Overloads Function equals(ByVal obj As HighScore) As Boolean
        If Not obj.Rank = Rank Then Return False
        If Not obj.DisplayName = DisplayName Then Return False
        If Not obj.Score.Score = Score.Score Then Return False
        If Not obj.Score.Level = Score.Level Then Return False
        If Not obj.Score.Lines = Score.Lines Then Return False
        If Not obj.Score.TSpins = Score.TSpins Then Return False
        If Not obj.Score.Tetrises = Score.Tetrises Then Return False
        If Not obj.Score.FullClears = Score.FullClears Then Return False
        If Not obj.Score.TotalCombo = Score.TotalCombo Then Return False
        If Not obj.Score.SoftDropDistance = Score.SoftDropDistance Then Return False
        If Not obj.Score.HardDropDistance = Score.HardDropDistance Then Return False
        If Not obj.DateScored = DateScored Then Return False
        If Not obj.Game = Game Then Return False
        If Not obj.GameVersion = GameVersion Then Return False
        If Not obj.Score.TSpinSingle = Score.TSpinSingle Then Return False
        If Not obj.Score.TSpinDouble = Score.TSpinDouble Then Return False
        If Not obj.Score.TSpinTriple = Score.TSpinTriple Then Return False
        If Not obj.Score.ScoreVersion = Score.ScoreVersion Then Return False
        If Not obj.Username = Username Then Return False
        Return True
    End Function
End Class

Public Class ScoreProperties
    Public Const Rank As Char = "A"
    Public Const DisplayName As Char = "B"
    Public Const Score As Char = "C"
    Public Const Levels As Char = "D"
    Public Const Lines As Char = "E"
    Public Const TSpins As Char = "F"
    Public Const Tetrises As Char = "G"
    Public Const FullClears As Char = "H"
    Public Const TotalCombo As Char = "I"
    Public Const SoftDropDist As Char = "J"
    Public Const HardDropDist As Char = "K"
    Public Const DateScored As Char = "L"
    Public Const Game As Char = "M"
    Public Const GameVersion As Char = "N"
    Public Const TSpinSingle As Char = "O"
    Public Const TSpinDouble As Char = "P"
    Public Const TSpinTriple As Char = "Q"
    Public Const ScoreVersion As Char = "R"
    Public Const Username As Char = "S"
End Class
