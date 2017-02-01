Public Class Score
    'http://tetris.wikia.com/wiki/Scoring

    Public Property Score As Integer
    Public ReadOnly Property Level As Integer
        Get
            Return Int(Lines / 10)
        End Get
    End Property

    Public Property Lines As Integer
    Public Property TSpins As Integer
    Public Property FullClears As Integer
    Public Property Tetrises As Integer
    Public Property HardDropDistance As Integer
    Public Property SoftDropDistance As Integer
    Public Property Combo As Integer
    Public Property TotalCombo As Integer
    Public Property TSpinSingle As Integer
    Public Property TSpinDouble As Integer
    Public Property TSpinTriple As Integer
    Public Property ScoreVersion As Integer

    Sub New()
        Lines = 0
        TSpins = 0
        FullClears = 0
        Tetrises = 0
        HardDropDistance = 0
        SoftDropDistance = 0
        Score = 0
        Combo = 0
        TotalCombo = 0
        TSpinSingle = 0
        TSpinDouble = 0
        TSpinTriple = 0
        ScoreVersion = -1
    End Sub

    Public Function compare(ByVal score As Score)
        If Not Lines = score.Lines Then Return False
        If Not TSpins = score.TSpins Then Return False
        If Not FullClears = score.FullClears Then Return False
        If Not Tetrises = score.Tetrises Then Return False
        If Not HardDropDistance = score.HardDropDistance Then Return False
        If Not SoftDropDistance = score.SoftDropDistance Then Return False
        If Not Me.Score = score.Score Then Return False
        If Not Combo = score.Combo Then Return False
        If Not TotalCombo = score.TotalCombo Then Return False
        If Not TSpinSingle = score.TSpinSingle Then Return False
        If Not TSpinDouble = score.TSpinDouble Then Return False
        If Not TSpinTriple = score.TSpinTriple Then Return False
        If Not ScoreVersion = score.ScoreVersion Then Return False
        Return True
    End Function

    Sub New(ByVal score As Score)
        Lines = score.Lines
        TSpins = score.TSpins
        FullClears = score.FullClears
        Tetrises = score.Tetrises
        HardDropDistance = score.HardDropDistance
        SoftDropDistance = score.SoftDropDistance
        Me.Score = score.Score
        Combo = score.Combo
        TotalCombo = score.TotalCombo
        TSpinSingle = score.TSpinSingle
        TSpinDouble = score.TSpinDouble
        TSpinTriple = score.TSpinTriple
        ScoreVersion = score.ScoreVersion
    End Sub

    Public Function clone() As Score
        Return New Score(Me)
    End Function
End Class
