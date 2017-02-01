<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.tpScoring = New System.Windows.Forms.TabPage()
        Me.gbTetris = New System.Windows.Forms.GroupBox()
        Me.txtTetris = New System.Windows.Forms.TextBox()
        Me.gbTSpin = New System.Windows.Forms.GroupBox()
        Me.txtTSpin = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TetrisBoardAnimation2 = New Tetris.TetrisBoardAnimation()
        Me.aniTetris = New Tetris.TetrisBoardAnimation()
        Me.aniTSpin = New Tetris.TetrisBoardAnimation()
        Me.TetrisBoardAnimation1 = New Tetris.TetrisBoardAnimation()
        Me.MainTabControl.SuspendLayout()
        Me.tpScoring.SuspendLayout()
        Me.gbTetris.SuspendLayout()
        Me.gbTSpin.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTabControl
        '
        Me.MainTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainTabControl.Controls.Add(Me.tpScoring)
        Me.MainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(527, 614)
        Me.MainTabControl.TabIndex = 0
        '
        'tpScoring
        '
        Me.tpScoring.AutoScroll = True
        Me.tpScoring.Controls.Add(Me.GroupBox1)
        Me.tpScoring.Controls.Add(Me.gbTetris)
        Me.tpScoring.Controls.Add(Me.gbTSpin)
        Me.tpScoring.Location = New System.Drawing.Point(4, 22)
        Me.tpScoring.Name = "tpScoring"
        Me.tpScoring.Padding = New System.Windows.Forms.Padding(3)
        Me.tpScoring.Size = New System.Drawing.Size(519, 588)
        Me.tpScoring.TabIndex = 0
        Me.tpScoring.Text = "Scoring"
        Me.tpScoring.UseVisualStyleBackColor = True
        '
        'gbTetris
        '
        Me.gbTetris.Controls.Add(Me.txtTetris)
        Me.gbTetris.Controls.Add(Me.aniTetris)
        Me.gbTetris.Location = New System.Drawing.Point(6, 212)
        Me.gbTetris.Name = "gbTetris"
        Me.gbTetris.Size = New System.Drawing.Size(490, 200)
        Me.gbTetris.TabIndex = 2
        Me.gbTetris.TabStop = False
        Me.gbTetris.Text = "Tetris"
        '
        'txtTetris
        '
        Me.txtTetris.BackColor = System.Drawing.Color.White
        Me.txtTetris.Location = New System.Drawing.Point(6, 19)
        Me.txtTetris.Multiline = True
        Me.txtTetris.Name = "txtTetris"
        Me.txtTetris.ReadOnly = True
        Me.txtTetris.Size = New System.Drawing.Size(222, 175)
        Me.txtTetris.TabIndex = 1
        Me.txtTetris.Text = "A Tetris is where you get four lines at once. This is only possible with the I pi" & _
            "ece."
        '
        'gbTSpin
        '
        Me.gbTSpin.Controls.Add(Me.txtTSpin)
        Me.gbTSpin.Controls.Add(Me.aniTSpin)
        Me.gbTSpin.Location = New System.Drawing.Point(6, 6)
        Me.gbTSpin.Name = "gbTSpin"
        Me.gbTSpin.Size = New System.Drawing.Size(490, 200)
        Me.gbTSpin.TabIndex = 0
        Me.gbTSpin.TabStop = False
        Me.gbTSpin.Text = "T-Spin"
        '
        'txtTSpin
        '
        Me.txtTSpin.BackColor = System.Drawing.Color.White
        Me.txtTSpin.Location = New System.Drawing.Point(6, 19)
        Me.txtTSpin.Multiline = True
        Me.txtTSpin.Name = "txtTSpin"
        Me.txtTSpin.ReadOnly = True
        Me.txtTSpin.Size = New System.Drawing.Size(222, 175)
        Me.txtTSpin.TabIndex = 1
        Me.txtTSpin.Text = "A T-Spin is where you get a T piece into a position that is only possible by rota" & _
            "ting the piece. A T-Spin single is a T-Spin that clears a single line, a T-Spin " & _
            "double clears 2 lines, etc."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TetrisBoardAnimation2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 418)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 200)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Full Clear"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(222, 175)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "A Full Clear is where the board is completely cleared."
        '
        'TetrisBoardAnimation2
        '
        Me.TetrisBoardAnimation2.Animation = Tetris.AnimationID.FullClear
        Me.TetrisBoardAnimation2.AutoSize = True
        Me.TetrisBoardAnimation2.Delay = 750
        Me.TetrisBoardAnimation2.Index = 0
        Me.TetrisBoardAnimation2.Location = New System.Drawing.Point(234, 19)
        Me.TetrisBoardAnimation2.Name = "TetrisBoardAnimation2"
        Me.TetrisBoardAnimation2.Size = New System.Drawing.Size(250, 175)
        Me.TetrisBoardAnimation2.TabIndex = 0
        '
        'aniTetris
        '
        Me.aniTetris.Animation = Tetris.AnimationID.Tetris
        Me.aniTetris.AutoSize = True
        Me.aniTetris.Delay = 750
        Me.aniTetris.Index = 0
        Me.aniTetris.Location = New System.Drawing.Point(234, 19)
        Me.aniTetris.Name = "aniTetris"
        Me.aniTetris.Size = New System.Drawing.Size(250, 175)
        Me.aniTetris.TabIndex = 0
        '
        'aniTSpin
        '
        Me.aniTSpin.Animation = Tetris.AnimationID.TSpin
        Me.aniTSpin.AutoSize = True
        Me.aniTSpin.Delay = 750
        Me.aniTSpin.Index = 0
        Me.aniTSpin.Location = New System.Drawing.Point(234, 19)
        Me.aniTSpin.Name = "aniTSpin"
        Me.aniTSpin.Size = New System.Drawing.Size(250, 175)
        Me.aniTSpin.TabIndex = 0
        '
        'TetrisBoardAnimation1
        '
        Me.TetrisBoardAnimation1.Animation = Tetris.AnimationID.None
        Me.TetrisBoardAnimation1.AutoSize = True
        Me.TetrisBoardAnimation1.Delay = 750
        Me.TetrisBoardAnimation1.Index = 0
        Me.TetrisBoardAnimation1.Location = New System.Drawing.Point(0, 0)
        Me.TetrisBoardAnimation1.Name = "TetrisBoardAnimation1"
        Me.TetrisBoardAnimation1.Size = New System.Drawing.Size(150, 150)
        Me.TetrisBoardAnimation1.TabIndex = 0
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 613)
        Me.Controls.Add(Me.MainTabControl)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHelp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Tetris - Help"
        Me.MainTabControl.ResumeLayout(False)
        Me.tpScoring.ResumeLayout(False)
        Me.gbTetris.ResumeLayout(False)
        Me.gbTetris.PerformLayout()
        Me.gbTSpin.ResumeLayout(False)
        Me.gbTSpin.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainTabControl As System.Windows.Forms.TabControl
    Friend WithEvents tpScoring As System.Windows.Forms.TabPage
    Friend WithEvents gbTSpin As System.Windows.Forms.GroupBox
    Friend WithEvents TetrisBoardAnimation1 As Tetris.TetrisBoardAnimation
    Friend WithEvents aniTSpin As Tetris.TetrisBoardAnimation
    Friend WithEvents txtTSpin As System.Windows.Forms.TextBox
    Friend WithEvents gbTetris As System.Windows.Forms.GroupBox
    Friend WithEvents txtTetris As System.Windows.Forms.TextBox
    Friend WithEvents aniTetris As Tetris.TetrisBoardAnimation
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TetrisBoardAnimation2 As Tetris.TetrisBoardAnimation
End Class
