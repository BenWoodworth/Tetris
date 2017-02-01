<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScores
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
        Me.lvHighScores = New System.Windows.Forms.ListView()
        Me.rankColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.playerColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.scoreColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.levelColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.linesColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tetrisesColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tSpinColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tSpinDoubleColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tSpinTripleColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totalComboColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fullClearColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnViewGame = New System.Windows.Forms.Button()
        Me.btnVerifyScores = New System.Windows.Forms.Button()
        Me.pbVerify = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lvHighScores
        '
        Me.lvHighScores.AllowColumnReorder = True
        Me.lvHighScores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvHighScores.AutoArrange = False
        Me.lvHighScores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.rankColumn, Me.playerColumn, Me.scoreColumn, Me.levelColumn, Me.linesColumn, Me.tetrisesColumn, Me.tSpinColumn, Me.tSpinDoubleColumn, Me.tSpinTripleColumn, Me.totalComboColumn, Me.fullClearColumn})
        Me.lvHighScores.FullRowSelect = True
        Me.lvHighScores.Location = New System.Drawing.Point(0, 27)
        Me.lvHighScores.MultiSelect = False
        Me.lvHighScores.Name = "lvHighScores"
        Me.lvHighScores.Size = New System.Drawing.Size(666, 353)
        Me.lvHighScores.TabIndex = 0
        Me.lvHighScores.UseCompatibleStateImageBehavior = False
        Me.lvHighScores.View = System.Windows.Forms.View.Details
        '
        'rankColumn
        '
        Me.rankColumn.Text = "#"
        Me.rankColumn.Width = 35
        '
        'playerColumn
        '
        Me.playerColumn.Text = "Player"
        Me.playerColumn.Width = 101
        '
        'scoreColumn
        '
        Me.scoreColumn.Text = "Score"
        Me.scoreColumn.Width = 61
        '
        'levelColumn
        '
        Me.levelColumn.Text = "Levels"
        Me.levelColumn.Width = 47
        '
        'linesColumn
        '
        Me.linesColumn.Text = "Lines"
        Me.linesColumn.Width = 44
        '
        'tetrisesColumn
        '
        Me.tetrisesColumn.Text = "Tetrises"
        Me.tetrisesColumn.Width = 50
        '
        'tSpinColumn
        '
        Me.tSpinColumn.Text = "T-Spins"
        Me.tSpinColumn.Width = 48
        '
        'tSpinDoubleColumn
        '
        Me.tSpinDoubleColumn.Text = "T-S Double"
        Me.tSpinDoubleColumn.Width = 66
        '
        'tSpinTripleColumn
        '
        Me.tSpinTripleColumn.Text = "T-S Triple"
        Me.tSpinTripleColumn.Width = 59
        '
        'totalComboColumn
        '
        Me.totalComboColumn.Text = "Total Combo"
        Me.totalComboColumn.Width = 72
        '
        'fullClearColumn
        '
        Me.fullClearColumn.Text = "Full Clears"
        '
        'btnViewGame
        '
        Me.btnViewGame.Enabled = False
        Me.btnViewGame.Location = New System.Drawing.Point(87, 2)
        Me.btnViewGame.Name = "btnViewGame"
        Me.btnViewGame.Size = New System.Drawing.Size(84, 23)
        Me.btnViewGame.TabIndex = 1
        Me.btnViewGame.Text = "View Game"
        Me.btnViewGame.UseVisualStyleBackColor = True
        '
        'btnVerifyScores
        '
        Me.btnVerifyScores.Location = New System.Drawing.Point(2, 2)
        Me.btnVerifyScores.Name = "btnVerifyScores"
        Me.btnVerifyScores.Size = New System.Drawing.Size(84, 23)
        Me.btnVerifyScores.TabIndex = 3
        Me.btnVerifyScores.Text = "Verify Scores"
        Me.btnVerifyScores.UseVisualStyleBackColor = True
        '
        'pbVerify
        '
        Me.pbVerify.Location = New System.Drawing.Point(2, 2)
        Me.pbVerify.Name = "pbVerify"
        Me.pbVerify.Size = New System.Drawing.Size(84, 23)
        Me.pbVerify.TabIndex = 4
        '
        'frmHighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 380)
        Me.Controls.Add(Me.btnViewGame)
        Me.Controls.Add(Me.lvHighScores)
        Me.Controls.Add(Me.btnVerifyScores)
        Me.Controls.Add(Me.pbVerify)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHighScores"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "High Scores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvHighScores As System.Windows.Forms.ListView
    Friend WithEvents scoreColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents rankColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents levelColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents linesColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents tSpinColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents tetrisesColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents playerColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnViewGame As System.Windows.Forms.Button
    Friend WithEvents tSpinDoubleColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents tSpinTripleColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents fullClearColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnVerifyScores As System.Windows.Forms.Button
    Friend WithEvents pbVerify As System.Windows.Forms.ProgressBar
    Friend WithEvents totalComboColumn As System.Windows.Forms.ColumnHeader
End Class
