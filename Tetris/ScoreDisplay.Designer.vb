<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreDisplay
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.gbScore = New System.Windows.Forms.GroupBox()
        Me.lblTetrisesB = New System.Windows.Forms.Label()
        Me.lblTetrises = New System.Windows.Forms.Label()
        Me.lblFullClearB = New System.Windows.Forms.Label()
        Me.lblTSpinB = New System.Windows.Forms.Label()
        Me.lblTSpin = New System.Windows.Forms.Label()
        Me.lblFullClear = New System.Windows.Forms.Label()
        Me.lblLevelB = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblLinesB = New System.Windows.Forms.Label()
        Me.lblLines = New System.Windows.Forms.Label()
        Me.lblScoreB = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblComboB = New System.Windows.Forms.Label()
        Me.lblCombo = New System.Windows.Forms.Label()
        Me.gbScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbScore
        '
        Me.gbScore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbScore.Controls.Add(Me.lblComboB)
        Me.gbScore.Controls.Add(Me.lblCombo)
        Me.gbScore.Controls.Add(Me.lblTetrisesB)
        Me.gbScore.Controls.Add(Me.lblTetrises)
        Me.gbScore.Controls.Add(Me.lblFullClearB)
        Me.gbScore.Controls.Add(Me.lblTSpinB)
        Me.gbScore.Controls.Add(Me.lblTSpin)
        Me.gbScore.Controls.Add(Me.lblFullClear)
        Me.gbScore.Controls.Add(Me.lblLevelB)
        Me.gbScore.Controls.Add(Me.lblLevel)
        Me.gbScore.Controls.Add(Me.lblLinesB)
        Me.gbScore.Controls.Add(Me.lblLines)
        Me.gbScore.Controls.Add(Me.lblScoreB)
        Me.gbScore.Controls.Add(Me.lblScore)
        Me.gbScore.Location = New System.Drawing.Point(0, -1)
        Me.gbScore.Name = "gbScore"
        Me.gbScore.Size = New System.Drawing.Size(91, 94)
        Me.gbScore.TabIndex = 10
        Me.gbScore.TabStop = False
        Me.gbScore.Text = "Score"
        '
        'lblTetrisesB
        '
        Me.lblTetrisesB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTetrisesB.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTetrisesB.Location = New System.Drawing.Point(51, 56)
        Me.lblTetrisesB.Name = "lblTetrisesB"
        Me.lblTetrisesB.Size = New System.Drawing.Size(38, 13)
        Me.lblTetrisesB.TabIndex = 10
        Me.lblTetrisesB.Text = "0"
        Me.lblTetrisesB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTetrises
        '
        Me.lblTetrises.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTetrises.Location = New System.Drawing.Point(3, 56)
        Me.lblTetrises.Name = "lblTetrises"
        Me.lblTetrises.Size = New System.Drawing.Size(52, 13)
        Me.lblTetrises.TabIndex = 4
        Me.lblTetrises.Text = "Tetrises:"
        Me.lblTetrises.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFullClearB
        '
        Me.lblFullClearB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFullClearB.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullClearB.Location = New System.Drawing.Point(51, 66)
        Me.lblFullClearB.Name = "lblFullClearB"
        Me.lblFullClearB.Size = New System.Drawing.Size(38, 13)
        Me.lblFullClearB.TabIndex = 11
        Me.lblFullClearB.Text = "0"
        Me.lblFullClearB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTSpinB
        '
        Me.lblTSpinB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTSpinB.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTSpinB.Location = New System.Drawing.Point(51, 46)
        Me.lblTSpinB.Name = "lblTSpinB"
        Me.lblTSpinB.Size = New System.Drawing.Size(38, 13)
        Me.lblTSpinB.TabIndex = 9
        Me.lblTSpinB.Text = "0"
        Me.lblTSpinB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTSpin
        '
        Me.lblTSpin.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTSpin.Location = New System.Drawing.Point(3, 46)
        Me.lblTSpin.Name = "lblTSpin"
        Me.lblTSpin.Size = New System.Drawing.Size(52, 13)
        Me.lblTSpin.TabIndex = 3
        Me.lblTSpin.Text = "TSpins:"
        Me.lblTSpin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFullClear
        '
        Me.lblFullClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullClear.Location = New System.Drawing.Point(3, 66)
        Me.lblFullClear.Name = "lblFullClear"
        Me.lblFullClear.Size = New System.Drawing.Size(52, 13)
        Me.lblFullClear.TabIndex = 5
        Me.lblFullClear.Text = "Full Clears:"
        Me.lblFullClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLevelB
        '
        Me.lblLevelB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLevelB.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelB.Location = New System.Drawing.Point(51, 26)
        Me.lblLevelB.Name = "lblLevelB"
        Me.lblLevelB.Size = New System.Drawing.Size(38, 13)
        Me.lblLevelB.TabIndex = 7
        Me.lblLevelB.Text = "0"
        Me.lblLevelB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLevel
        '
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(3, 26)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(52, 13)
        Me.lblLevel.TabIndex = 1
        Me.lblLevel.Text = "Level:"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLinesB
        '
        Me.lblLinesB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLinesB.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLinesB.Location = New System.Drawing.Point(51, 36)
        Me.lblLinesB.Name = "lblLinesB"
        Me.lblLinesB.Size = New System.Drawing.Size(38, 13)
        Me.lblLinesB.TabIndex = 8
        Me.lblLinesB.Text = "0"
        Me.lblLinesB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLines
        '
        Me.lblLines.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLines.Location = New System.Drawing.Point(3, 36)
        Me.lblLines.Name = "lblLines"
        Me.lblLines.Size = New System.Drawing.Size(52, 13)
        Me.lblLines.TabIndex = 2
        Me.lblLines.Text = "Lines:"
        Me.lblLines.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblScoreB
        '
        Me.lblScoreB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblScoreB.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreB.Location = New System.Drawing.Point(51, 16)
        Me.lblScoreB.Name = "lblScoreB"
        Me.lblScoreB.Size = New System.Drawing.Size(38, 13)
        Me.lblScoreB.TabIndex = 6
        Me.lblScoreB.Text = "0"
        Me.lblScoreB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(3, 16)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(52, 13)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "Score:"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblComboB
        '
        Me.lblComboB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComboB.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComboB.Location = New System.Drawing.Point(51, 76)
        Me.lblComboB.Name = "lblComboB"
        Me.lblComboB.Size = New System.Drawing.Size(38, 13)
        Me.lblComboB.TabIndex = 13
        Me.lblComboB.Text = "0"
        Me.lblComboB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCombo
        '
        Me.lblCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCombo.Location = New System.Drawing.Point(3, 76)
        Me.lblCombo.Name = "lblCombo"
        Me.lblCombo.Size = New System.Drawing.Size(52, 13)
        Me.lblCombo.TabIndex = 12
        Me.lblCombo.Text = "Combo:"
        Me.lblCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ScoreDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gbScore)
        Me.Name = "ScoreDisplay"
        Me.Size = New System.Drawing.Size(91, 93)
        Me.gbScore.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbScore As System.Windows.Forms.GroupBox
    Friend WithEvents lblTetrisesB As System.Windows.Forms.Label
    Friend WithEvents lblTetrises As System.Windows.Forms.Label
    Friend WithEvents lblFullClearB As System.Windows.Forms.Label
    Friend WithEvents lblTSpinB As System.Windows.Forms.Label
    Friend WithEvents lblTSpin As System.Windows.Forms.Label
    Friend WithEvents lblFullClear As System.Windows.Forms.Label
    Friend WithEvents lblLevelB As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblLinesB As System.Windows.Forms.Label
    Friend WithEvents lblLines As System.Windows.Forms.Label
    Friend WithEvents lblScoreB As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblComboB As System.Windows.Forms.Label
    Friend WithEvents lblCombo As System.Windows.Forms.Label

End Class
