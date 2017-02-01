<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim Score1 As Tetris.Score = New Tetris.Score()
        Dim TetrisBoard1 As Tetris.TetrisBoard = New Tetris.TetrisBoard()
        Dim TetrisPiece1 As Tetris.TetrisPiece = New Tetris.TetrisPiece()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.tmrFall = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHighScores = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pdHold = New Tetris.PieceDisplay()
        Me.btnScoring = New System.Windows.Forms.Button()
        Me.btnBugReport = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pdNext3 = New Tetris.PieceDisplay()
        Me.pdNext2 = New Tetris.PieceDisplay()
        Me.pdNext1 = New Tetris.PieceDisplay()
        Me.pdNext0 = New Tetris.PieceDisplay()
        Me.btnVolume = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.sdGameStats = New Tetris.ScoreDisplay()
        Me.tBoard = New Tetris.TetrisBoardControl()
        Me.PieceDisplay1 = New Tetris.PieceDisplay()
        Me.PieceDisplay2 = New Tetris.PieceDisplay()
        Me.PieceDisplay3 = New Tetris.PieceDisplay()
        Me.PieceDisplay4 = New Tetris.PieceDisplay()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(12, 123)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(92, 34)
        Me.btnNewGame.TabIndex = 1
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'tmrFall
        '
        Me.tmrFall.Interval = 750
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(363, 471)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 41)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Project by" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ben Woodworth"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHighScores
        '
        Me.btnHighScores.Location = New System.Drawing.Point(12, 259)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(92, 34)
        Me.btnHighScores.TabIndex = 5
        Me.btnHighScores.Text = "High Scores"
        Me.btnHighScores.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(12, 191)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(92, 34)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pdHold)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(92, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hold"
        '
        'pdHold
        '
        Me.pdHold.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pdHold.BackColor = System.Drawing.Color.Black
        Me.pdHold.Location = New System.Drawing.Point(6, 19)
        Me.pdHold.Name = "pdHold"
        Me.pdHold.Size = New System.Drawing.Size(80, 80)
        Me.pdHold.TabIndex = 0
        Me.pdHold.TetrisPieceID = 0
        Me.pdHold.TetrisPieceSize = 17
        '
        'btnScoring
        '
        Me.btnScoring.Location = New System.Drawing.Point(12, 225)
        Me.btnScoring.Name = "btnScoring"
        Me.btnScoring.Size = New System.Drawing.Size(92, 34)
        Me.btnScoring.TabIndex = 4
        Me.btnScoring.Text = "Help" & Global.Microsoft.VisualBasic.ChrW(13)
        Me.btnScoring.UseVisualStyleBackColor = True
        '
        'btnBugReport
        '
        Me.btnBugReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBugReport.Location = New System.Drawing.Point(12, 478)
        Me.btnBugReport.Name = "btnBugReport"
        Me.btnBugReport.Size = New System.Drawing.Size(92, 34)
        Me.btnBugReport.TabIndex = 7
        Me.btnBugReport.Text = "Report Bug or Submit Idea..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnBugReport.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.pdNext3)
        Me.GroupBox2.Controls.Add(Me.pdNext2)
        Me.GroupBox2.Controls.Add(Me.pdNext1)
        Me.GroupBox2.Controls.Add(Me.pdNext0)
        Me.GroupBox2.Location = New System.Drawing.Point(366, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(92, 321)
        Me.GroupBox2.TabIndex = 8
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
        'btnVolume
        '
        Me.btnVolume.Location = New System.Drawing.Point(12, 293)
        Me.btnVolume.Name = "btnVolume"
        Me.btnVolume.Size = New System.Drawing.Size(92, 34)
        Me.btnVolume.TabIndex = 6
        Me.btnVolume.Text = "Audio: Off"
        Me.btnVolume.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Enabled = False
        Me.btnPause.Location = New System.Drawing.Point(12, 157)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(92, 34)
        Me.btnPause.TabIndex = 2
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'sdGameStats
        '
        Me.sdGameStats.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sdGameStats.Location = New System.Drawing.Point(366, 334)
        Me.sdGameStats.Name = "sdGameStats"
        Score1.Combo = 0
        Score1.FullClears = 0
        Score1.HardDropDistance = 0
        Score1.Lines = 0
        Score1.TotalCombo = 0
        Score1.Score = 0
        Score1.ScoreVersion = -1
        Score1.SoftDropDistance = 0
        Score1.Tetrises = 0
        Score1.TSpinDouble = 0
        Score1.TSpins = 0
        Score1.TSpinSingle = 0
        Score1.TSpinTriple = 0
        Me.sdGameStats.Score = Score1
        Me.sdGameStats.Size = New System.Drawing.Size(92, 93)
        Me.sdGameStats.TabIndex = 9
        '
        'tBoard
        '
        Me.tBoard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tBoard.BackColor = System.Drawing.Color.Black
        Me.tBoard.Location = New System.Drawing.Point(110, 12)
        Me.tBoard.Name = "tBoard"
        Me.tBoard.Size = New System.Drawing.Size(250, 500)
        Me.tBoard.TabIndex = 0
        Me.tBoard.TetrisBoard = TetrisBoard1
        TetrisPiece1.Location = New System.Drawing.Point(0, 0)
        TetrisPiece1.PieceID = 0
        TetrisPiece1.Rotation = 0
        Me.tBoard.TetrisPiece = TetrisPiece1
        '
        'PieceDisplay1
        '
        Me.PieceDisplay1.BackColor = System.Drawing.Color.Black
        Me.PieceDisplay1.Location = New System.Drawing.Point(6, 245)
        Me.PieceDisplay1.Name = "PieceDisplay1"
        Me.PieceDisplay1.Size = New System.Drawing.Size(70, 70)
        Me.PieceDisplay1.TabIndex = 3
        Me.PieceDisplay1.TetrisPieceID = 0
        Me.PieceDisplay1.TetrisPieceSize = 14
        '
        'PieceDisplay2
        '
        Me.PieceDisplay2.BackColor = System.Drawing.Color.Black
        Me.PieceDisplay2.Location = New System.Drawing.Point(6, 173)
        Me.PieceDisplay2.Name = "PieceDisplay2"
        Me.PieceDisplay2.Size = New System.Drawing.Size(70, 70)
        Me.PieceDisplay2.TabIndex = 2
        Me.PieceDisplay2.TetrisPieceID = 0
        Me.PieceDisplay2.TetrisPieceSize = 14
        '
        'PieceDisplay3
        '
        Me.PieceDisplay3.BackColor = System.Drawing.Color.Black
        Me.PieceDisplay3.Location = New System.Drawing.Point(6, 101)
        Me.PieceDisplay3.Name = "PieceDisplay3"
        Me.PieceDisplay3.Size = New System.Drawing.Size(70, 70)
        Me.PieceDisplay3.TabIndex = 1
        Me.PieceDisplay3.TetrisPieceID = 0
        Me.PieceDisplay3.TetrisPieceSize = 14
        '
        'PieceDisplay4
        '
        Me.PieceDisplay4.BackColor = System.Drawing.Color.Black
        Me.PieceDisplay4.Location = New System.Drawing.Point(6, 19)
        Me.PieceDisplay4.Name = "PieceDisplay4"
        Me.PieceDisplay4.Size = New System.Drawing.Size(80, 80)
        Me.PieceDisplay4.TabIndex = 0
        Me.PieceDisplay4.TetrisPieceID = 0
        Me.PieceDisplay4.TetrisPieceSize = 17
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 524)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnVolume)
        Me.Controls.Add(Me.sdGameStats)
        Me.Controls.Add(Me.btnBugReport)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnScoring)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.tBoard)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(266, 513)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tetris - [GameVersion]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tBoard As Tetris.TetrisBoardControl
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents tmrFall As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnHighScores As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents pdHold As Tetris.PieceDisplay
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnScoring As System.Windows.Forms.Button
    Friend WithEvents btnBugReport As System.Windows.Forms.Button
    Friend WithEvents sdGameStats As Tetris.ScoreDisplay
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pdNext3 As Tetris.PieceDisplay
    Friend WithEvents pdNext2 As Tetris.PieceDisplay
    Friend WithEvents pdNext1 As Tetris.PieceDisplay
    Friend WithEvents pdNext0 As Tetris.PieceDisplay
    Friend WithEvents PieceDisplay1 As Tetris.PieceDisplay
    Friend WithEvents PieceDisplay2 As Tetris.PieceDisplay
    Friend WithEvents PieceDisplay3 As Tetris.PieceDisplay
    Friend WithEvents PieceDisplay4 As Tetris.PieceDisplay
    Friend WithEvents btnVolume As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button

End Class
