Public Class TetrisBoardAnimation
    Private autoSize_ = True
    Public Shadows Property AutoSize As Boolean
        Get
            Return autoSize_
        End Get
        Set(ByVal value As Boolean)
            autoSize_ = value
            autoResize()
        End Set
    End Property

    Private boards_ As List(Of TetrisBoard) = New List(Of TetrisBoard)({}) 'TODO
    Public ReadOnly Property Boards As List(Of TetrisBoard)
        Get
            Return boards_
        End Get
    End Property

    Private animation_ As AnimationID = AnimationID.None
    Public Property Animation As AnimationID
        Get
            Return animation_
        End Get
        Set(ByVal value As AnimationID)
            animation_ = value
            boards_ = TetrisAnimations.getAnimation(value)
            autoResize()
            Refresh()
        End Set
    End Property

    Private index_ = 0
    Public Property Index As Integer
        Get
            Return index_
        End Get
        Set(ByVal value As Integer)
            index_ = value
            Refresh()
        End Set
    End Property

    Public Property Delay As Integer
        Get
            Return tmrMain.Interval
        End Get
        Set(ByVal value As Integer)
            tmrMain.Interval = value
        End Set
    End Property

    Private enabled_ As Boolean = True
    Public Shadows Property Enabled As Boolean
        Get
            Return enabled_
        End Get
        Set(ByVal value As Boolean)
            enabled_ = value
            tmrMain.Enabled = Not DesignMode And value
            If Not DesignMode And value Then
                Index = 0
            End If
        End Set
    End Property

    Private Sub BoardAnimation_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If Boards.Count = 0 Then
            If DesignMode Then
                e.Graphics.DrawString("No animation selected!", DefaultFont, Brushes.Red, 10, 10)
            End If
        Else
            Dim board As TetrisBoard = Boards(Index)
            Dim box As SizeF = New SizeF(Width / board.Width, Height / board.Height)
            Dim gfx As Graphics = e.Graphics

            Dim rect As Rectangle
            For x = 0 To board.Width - 1
                For y = 0 To board.Height - 1
                    If DesignMode Then
                        rect = New Rectangle(Int(x * box.Width), Int((y) * box.Height), Int((x + 1) * box.Width) - Int(x * box.Width) - 1, Int((y + 1) * box.Height) - Int((y) * box.Height) - 1)
                        gfx.FillRectangle(New SolidBrush(TetrisFunctions.intToColor(board.getPos(x, y))), rect)
                        gfx.DrawRectangle(Pens.DarkGray, rect)
                    Else
                        rect = New Rectangle(Int(x * box.Width), Int((y) * box.Height), Int((x + 1) * box.Width) - Int(x * box.Width), Int((y + 1) * box.Height) - Int((y) * box.Height))
                        gfx.DrawImage(frmSettings.getTexture(board.getPos(x, y)), rect)
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick
        Dim ind As Integer = Index + 1
        If ind > Boards.Count - 1 Then ind = 0
        Index = ind
    End Sub

    Private Sub TetrisBoardAnimation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.DoubleBuffered = True
        Me.UpdateStyles()
        Enabled = True
        tmrMain.Enabled = Not DesignMode
    End Sub

    Public Sub autoResize()
        If AutoSize And Boards.Count > 0 Then
            Width = Boards(0).Width * 25
            Height = Boards(0).Height * 25
        End If
    End Sub

    Private Sub TetrisBoardAnimation_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        autoResize()
    End Sub
End Class
