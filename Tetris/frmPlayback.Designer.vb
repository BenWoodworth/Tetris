<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlayback
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TetrisBoard1 As Tetris.TetrisBoard = New Tetris.TetrisBoard()
        Dim TetrisPiece1 As Tetris.TetrisPiece = New Tetris.TetrisPiece()
        Dim Score1 As Tetris.Score = New Tetris.Score()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pdHold = New Tetris.PieceDisplay()
        Me.tBoard = New Tetris.TetrisBoardControl()
        Me.sdGameStats = New Tetris.ScoreDisplay()
        Me.GameScroll = New System.Windows.Forms.TrackBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pdNext3 = New Tetris.PieceDisplay()
        Me.pdNext2 = New Tetris.PieceDisplay()
        Me.pdNext1 = New Tetris.PieceDisplay()
        Me.pdNext0 = New Tetris.PieceDisplay()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GameScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.pdHold)
        Me.GroupBox1.Location = New System.Drawing.Point(268, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(92, 105)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hold"
        '
        'pdHold
        '
        Me.pdHold.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdHold.BackColor = System.Drawing.Color.Black
        Me.pdHold.Location = New System.Drawing.Point(6, 19)
        Me.pdHold.Name = "pdHold"
        Me.pdHold.Size = New System.Drawing.Size(80, 80)
        Me.pdHold.TabIndex = 0
        Me.pdHold.TetrisPieceID = 0
        Me.pdHold.TetrisPieceSize = 17
        '
        'tBoard
        '
        Me.tBoard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tBoard.BackColor = System.Drawing.Color.Black
        Me.tBoard.Location = New System.Drawing.Point(12, 12)
        Me.tBoard.Name = "tBoard"
        Me.tBoard.Size = New System.Drawing.Size(250, 500)
        Me.tBoard.TabIndex = 2
        Me.tBoard.TetrisBoard = TetrisBoard1
        TetrisPiece1.Location = New System.Drawing.Point(0, 0)
        TetrisPiece1.PieceID = 0
        TetrisPiece1.Rotation = 0
        Me.tBoard.TetrisPiece = TetrisPiece1
        '
        'sdGameStats
        '
        Me.sdGameStats.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sdGameStats.Location = New System.Drawing.Point(268, 440)
        Me.sdGameStats.Name = "sdGameStats"
        Score1.Combo = 0
        Score1.FullClears = 0
        Score1.HardDropDistance = 0
        Score1.Lines = 0
        Score1.TotalCombo = 0
        Score1.Score = 0
        Score1.SoftDropDistance = Nothing
        Score1.Tetrises = 0
        Score1.TSpinDouble = 0
        Score1.TSpins = 0
        Score1.TSpinSingle = 0
        Score1.TSpinTriple = 0
        Me.sdGameStats.Score = Score1
        Me.sdGameStats.Size = New System.Drawing.Size(92, 93)
        Me.sdGameStats.TabIndex = 12
        '
        'GameScroll
        '
        Me.GameScroll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameScroll.AutoSize = False
        Me.GameScroll.Location = New System.Drawing.Point(12, 514)
        Me.GameScroll.Name = "GameScroll"
        Me.GameScroll.Size = New System.Drawing.Size(250, 23)
        Me.GameScroll.TabIndex = 13
        Me.GameScroll.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.pdNext3)
        Me.GroupBox2.Controls.Add(Me.pdNext2)
        Me.GroupBox2.Controls.Add(Me.pdNext1)
        Me.GroupBox2.Controls.Add(Me.pdNext0)
        Me.GroupBox2.Location = New System.Drawing.Point(268, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(92, 321)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Next"
        '
        'pdNext3
        '
        Me.pdNext3.BackColor = System.Drawing.Color.Black
        Me.pdNext3.Location = New System.Drawing.Point(6, 245)
        Me.pdNext3.Name = "pdNext3"
        Me.pdNext3.Size = New System.Drawing.Size(70, 70)
        Me.pdNext3.TabIndex = 3
        Me.pdNext3.TetrisPieceID = 0
        Me.pdNext3.TetrisPieceSize = 14
        '
        'pdNext2
        '
        Me.pdNext2.BackColor = System.Drawing.Color.Black
        Me.pdNext2.Location = New System.Drawing.Point(6, 173)
        Me.pdNext2.Name = "pdNext2"
        Me.pdNext2.Size = New System.Drawing.Size(70, 70)
        Me.pdNext2.TabIndex = 2
        Me.pdNext2.TetrisPieceID = 0
        Me.pdNext2.TetrisPieceSize = 14
        '
        'pdNext1
        '
        Me.pdNext1.BackColor = System.Drawing.Color.Black
        Me.pdNext1.Location = New System.Drawing.Point(6, 101)
        Me.pdNext1.Name = "pdNext1"
        Me.pdNext1.Size = New System.Drawing.Size(70, 70)
        Me.pdNext1.TabIndex = 1
        Me.pdNext1.TetrisPieceID = 0
        Me.pdNext1.TetrisPieceSize = 14
        '
        'pdNext0
        '
        Me.pdNext0.BackColor = System.Drawing.Color.Black
        Me.pdNext0.Location = New System.Drawing.Point(6, 19)
        Me.pdNext0.Name = "pdNext0"
        Me.pdNext0.Size = New System.Drawing.Size(80, 80)
        Me.pdNext0.TabIndex = 0
        Me.pdNext0.TetrisPieceID = 0
        Me.pdNext0.TetrisPieceSize = 17
        '
        'frmPlayback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 546)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GameScroll)
        Me.Controls.Add(Me.sdGameStats)
        Me.Controls.Add(Me.tBoard)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(388, 584)
        Me.Name = "frmPlayback"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Game Playback"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GameScroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pdHold As Tetris.PieceDisplay
    Friend WithEvents tBoard As Tetris.TetrisBoardControl
    Friend WithEvents sdGameStats As Tetris.ScoreDisplay
    Friend WithEvents GameScroll As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pdNext3 As Tetris.PieceDisplay
    Friend WithEvents pdNext2 As Tetris.PieceDisplay
    Friend WithEvents pdNext1 As Tetris.PieceDisplay
    Friend WithEvents pdNext0 As Tetris.PieceDisplay
End Class
