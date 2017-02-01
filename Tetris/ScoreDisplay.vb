Public Class ScoreDisplay
    Private _text As String = "Score"
    Public Overrides Property Text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
            gbScore.Text = value
        End Set
    End Property
    Private _score As Score = New Score
    Public Property Score As Score
        Get
            Return _score
        End Get
        Set(value As Score)
            _score = value
            lblScoreB.Text = shorten(Score.Score)
            lblLevelB.Text = shorten(Score.Level)
            lblLinesB.Text = shorten(Score.Lines)
            lblTSpinB.Text = shorten(Score.TSpins)
            lblTetrisesB.Text = shorten(Score.Tetrises)
            lblFullClearB.Text = shorten(Score.FullClears)
            lblComboB.Text = shorten(Score.Combo)
        End Set
    End Property
    Private Function shorten(ByVal str As String) As String
        If str.Length >= 10 Then
            Return str.Remove(str.Length - 6) & "M"
        ElseIf str.Length >= 7 Then
            Return str.Remove(str.Length - 3) & "K"
        End If
        Return str
    End Function
End Class
