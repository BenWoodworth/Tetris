Public Class PieceDisplay
    Private pieceID As Integer = 0
    Public Property TetrisPieceID As Integer
        Get
            Return pieceID
        End Get
        Set(value As Integer)
            pieceID = value
            Refresh()
        End Set
    End Property
    Private pieceSize As Integer = 10
    Public Property TetrisPieceSize As Integer
        Get
            Return pieceSize
        End Get
        Set(value As Integer)
            pieceSize = value
            Refresh()
        End Set
    End Property

    Private Sub PieceDisplay_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.Bilinear
        If pieceID > 0 Then
            Dim arr As Integer(,) = GetPiece.getDisplay(pieceID)

            Dim size As Size = New Size(arr.GetUpperBound(0) + 1, arr.GetUpperBound(1) + 1)

            Dim bm As Bitmap = New Bitmap(TetrisPieceSize * size.Width, TetrisPieceSize * size.Height)
            Dim gfx As Graphics = Graphics.FromImage(bm)

            For x = 0 To size.Width - 1
                For y = 0 To size.Height - 1
                    If arr(x, y) > 0 Then
                        If DesignMode Then
                            gfx.FillRectangle(New SolidBrush(TetrisFunctions.intToColor(arr(x, y))), New Rectangle(x * TetrisPieceSize, y * TetrisPieceSize, TetrisPieceSize - 1, TetrisPieceSize - 1))
                            gfx.DrawRectangle(Pens.DarkGray, New Rectangle(x * TetrisPieceSize, y * TetrisPieceSize, TetrisPieceSize - 1, TetrisPieceSize - 1))
                        Else
                            gfx.DrawImage(frmSettings.getTexture(arr(x, y)), New Rectangle(x * TetrisPieceSize, y * TetrisPieceSize, TetrisPieceSize, TetrisPieceSize))
                        End If
                    End If
                Next
            Next

            e.Graphics.DrawImage(bm, CInt((Width - bm.Width) / 2), CInt((Height - bm.Height) / 2))
        End If
        e.Graphics.DrawRectangle(Pens.DarkGray, 0, 0, Size.Width - 1, Size.Height - 1)
    End Sub
End Class
