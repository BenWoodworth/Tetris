Imports System.Drawing
Public Class TetrisBoardControl
    Private prevShadowPiece As New TetrisPiece
    Dim shadowPiece As New TetrisPiece
    Private _piece As TetrisPiece = New TetrisPiece
    Public Property TetrisPiece As TetrisPiece
        Get
            Return _piece.clone
        End Get
        Set(ByVal value As TetrisPiece)
            Dim prevPiece As TetrisPiece = _piece.clone
            _piece = value.clone
            shadowPiece = value.withNewPos(TetrisFunctions.hardDrop(_board, value))
            updateChanges(prevPiece.onBoard(prevShadowPiece.onBoard(_board, -1)), value.onBoard(shadowPiece.onBoard(_board, -1)))
            prevShadowPiece = shadowPiece.clone
        End Set
    End Property
    Private _board As TetrisBoard = New TetrisBoard
    Public Property TetrisBoard As TetrisBoard
        Get
            Return _board.clone
        End Get
        Set(ByVal value As TetrisBoard)
            updateChanges(TetrisPiece.onBoard(_board), TetrisPiece.onBoard(value))
            _board = value.clone
        End Set
    End Property

    Private Sub updateChanges(ByVal oldBoard, ByVal newBoard)
        Dim changes As ArrayList = New ArrayList()
        For x = 0 To 9
            For y = 4 To 23
                If oldBoard(x, y) <> newBoard(x, y) Then ' Or oldBoard(x, y) = -1 Then
                    changes.Add(New Point(x, y))
                End If
            Next
        Next

        Dim box As SizeF = New SizeF(Me.Width / 10, Me.Height / 20)
        Dim rect As Rectangle
        For Each p As Point In changes
            rect = New Rectangle(Int(p.X * box.Width), Int((p.Y - 4) * box.Height), Int((p.X + 1) * box.Width) - Int(p.X * box.Width), Int((p.Y - 3) * box.Height) - Int((p.Y - 4) * box.Height))
            Me.Invalidate(rect)
        Next
    End Sub

    Private Sub TetrisBoard_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim curBoard As TetrisBoard = TetrisFunctions.pieceOnBoard(TetrisBoard, shadowPiece, -1)
        curBoard = TetrisFunctions.pieceOnBoard(curBoard.clone, TetrisPiece)
        Dim box As SizeF = New SizeF(Me.Width / 10, Me.Height / 20)
        Dim gfx As Graphics = e.Graphics
        'gfx.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor 'TODO DEBUG

        Dim rect As Rectangle
        For x = 0 To 9
            For y = 4 To 23
                If DesignMode Then
                    rect = New Rectangle(Int(x * box.Width), Int((y - 4) * box.Height), Int((x + 1) * box.Width) - Int(x * box.Width) - 1, Int((y - 3) * box.Height) - Int((y - 4) * box.Height) - 1)
                    If rectCollision(e.ClipRectangle, rect) Then
                        gfx.FillRectangle(New SolidBrush(TetrisFunctions.intToColor(curBoard.getPos(x, y))), rect)
                        gfx.DrawRectangle(Pens.DarkGray, rect)
                    End If
                Else
                    rect = New Rectangle(Int(x * box.Width), Int((y - 4) * box.Height), Int((x + 1) * box.Width) - Int(x * box.Width), Int((y - 3) * box.Height) - Int((y - 4) * box.Height))
                    If rectCollision(e.ClipRectangle, rect) Then
                        gfx.DrawImage(frmSettings.getTexture(curBoard.getPos(x, y)), rect)
                    End If
                End If
            Next
        Next
    End Sub

    Private Function rectCollision(ByVal r1 As Rectangle, ByVal r2 As Rectangle)
        Return r1.Contains(r2.Left, r2.Top) OrElse _
               r1.Contains(r2.Left, r2.Bottom) OrElse _
               r1.Contains(r2.Right, r2.Top) OrElse _
               r1.Contains(r2.Right, r2.Bottom) OrElse _
               r2.Contains(r1.Left, r1.Top) OrElse _
               r2.Contains(r1.Left, r1.Bottom) OrElse _
               r2.Contains(r1.Right, r1.Top) OrElse _
               r2.Contains(r1.Right, r1.Bottom)
    End Function

    'Private Sub TetrisBoard_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    '    Refresh()
    'End Sub

    Private Sub TetrisBoardControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw, True)
        Me.DoubleBuffered = True
        Me.UpdateStyles()
    End Sub
End Class
