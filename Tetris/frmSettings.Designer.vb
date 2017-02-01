<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.txtKeyLeft = New System.Windows.Forms.TextBox()
        Me.txtKeyRight = New System.Windows.Forms.TextBox()
        Me.txtKeyDown = New System.Windows.Forms.TextBox()
        Me.txtKeyHardDrop = New System.Windows.Forms.TextBox()
        Me.GamestatsGroup = New System.Windows.Forms.GroupBox()
        Me.txtKeyRotate = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtKeyPause = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtKeyHold = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnChangeName = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btnSaveDefault = New System.Windows.Forms.Button()
        Me.btnDefaultTexture = New System.Windows.Forms.Button()
        Me.btnOpenTexture = New System.Windows.Forms.Button()
        Me.TextureOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TextureSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.txtKeyRotateLeft = New System.Windows.Forms.TextBox()
        Me.pbTexture = New System.Windows.Forms.PictureBox()
        Me.GamestatsGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.pbTexture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKeyLeft
        '
        Me.txtKeyLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeyLeft.BackColor = System.Drawing.Color.White
        Me.txtKeyLeft.Location = New System.Drawing.Point(3, 14)
        Me.txtKeyLeft.Multiline = True
        Me.txtKeyLeft.Name = "txtKeyLeft"
        Me.txtKeyLeft.ReadOnly = True
        Me.txtKeyLeft.Size = New System.Drawing.Size(85, 20)
        Me.txtKeyLeft.TabIndex = 0
        '
        'txtKeyRight
        '
        Me.txtKeyRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeyRight.BackColor = System.Drawing.Color.White
        Me.txtKeyRight.Location = New System.Drawing.Point(4, 14)
        Me.txtKeyRight.Multiline = True
        Me.txtKeyRight.Name = "txtKeyRight"
        Me.txtKeyRight.ReadOnly = True
        Me.txtKeyRight.Size = New System.Drawing.Size(85, 20)
        Me.txtKeyRight.TabIndex = 0
        '
        'txtKeyDown
        '
        Me.txtKeyDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeyDown.BackColor = System.Drawing.Color.White
        Me.txtKeyDown.Location = New System.Drawing.Point(3, 14)
        Me.txtKeyDown.Multiline = True
        Me.txtKeyDown.Name = "txtKeyDown"
        Me.txtKeyDown.ReadOnly = True
        Me.txtKeyDown.Size = New System.Drawing.Size(85, 20)
        Me.txtKeyDown.TabIndex = 0
        '
        'txtKeyHardDrop
        '
        Me.txtKeyHardDrop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeyHardDrop.BackColor = System.Drawing.Color.White
        Me.txtKeyHardDrop.Location = New System.Drawing.Point(3, 14)
        Me.txtKeyHardDrop.Multiline = True
        Me.txtKeyHardDrop.Name = "txtKeyHardDrop"
        Me.txtKeyHardDrop.ReadOnly = True
        Me.txtKeyHardDrop.Size = New System.Drawing.Size(85, 20)
        Me.txtKeyHardDrop.TabIndex = 0
        '
        'GamestatsGroup
        '
        Me.GamestatsGroup.Controls.Add(Me.txtKeyRotate)
        Me.GamestatsGroup.Location = New System.Drawing.Point(104, 55)
        Me.GamestatsGroup.Name = "GamestatsGroup"
        Me.GamestatsGroup.Size = New System.Drawing.Size(92, 38)
        Me.GamestatsGroup.TabIndex = 3
        Me.GamestatsGroup.TabStop = False
        Me.GamestatsGroup.Text = "Rotate Right"
        '
        'txtKeyRotate
        '
        Me.txtKeyRotate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeyRotate.BackColor = System.Drawing.Color.White
        Me.txtKeyRotate.Location = New System.Drawing.Point(4, 14)
        Me.txtKeyRotate.Multiline = True
        Me.txtKeyRotate.Name = "txtKeyRotate"
        Me.txtKeyRotate.ReadOnly = True
        Me.txtKeyRotate.Size = New System.Drawing.Size(85, 20)
        Me.txtKeyRotate.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKeyLeft)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(92, 38)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Left"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtKeyRight)
        Me.GroupBox2.Location = New System.Drawing.Point(104, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(92, 38)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Right"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtKeyDown)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 95)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(92, 38)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Down"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtKeyHardDrop)
        Me.GroupBox4.Location = New System.Drawing.Point(104, 95)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(92, 38)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hard Drop"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtKeyPause)
        Me.GroupBox5.Location = New System.Drawing.Point(104, 135)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(92, 38)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pause"
        '
        'txtKeyPause
        '
        Me.txtKeyPause.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeyPause.BackColor = System.Drawing.Color.White
        Me.txtKeyPause.Location = New System.Drawing.Point(3, 12)
        Me.txtKeyPause.Multiline = True
        Me.txtKeyPause.Name = "txtKeyPause"
        Me.txtKeyPause.ReadOnly = True
        Me.txtKeyPause.Size = New System.Drawing.Size(85, 20)
        Me.txtKeyPause.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtKeyHold)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 135)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(92, 38)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Hold"
        '
        'txtKeyHold
        '
        Me.txtKeyHold.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeyHold.BackColor = System.Drawing.Color.White
        Me.txtKeyHold.Location = New System.Drawing.Point(3, 14)
        Me.txtKeyHold.Multiline = True
        Me.txtKeyHold.Name = "txtKeyHold"
        Me.txtKeyHold.ReadOnly = True
        Me.txtKeyHold.Size = New System.Drawing.Size(85, 20)
        Me.txtKeyHold.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(6, 175)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(190, 26)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GroupBox1)
        Me.GroupBox7.Controls.Add(Me.btnReset)
        Me.GroupBox7.Controls.Add(Me.GroupBox11)
        Me.GroupBox7.Controls.Add(Me.GamestatsGroup)
        Me.GroupBox7.Controls.Add(Me.GroupBox6)
        Me.GroupBox7.Controls.Add(Me.GroupBox2)
        Me.GroupBox7.Controls.Add(Me.GroupBox5)
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Controls.Add(Me.GroupBox4)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(202, 207)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Controls"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(6, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(190, 20)
        Me.txtName.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtName)
        Me.GroupBox8.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(202, 45)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Name"
        '
        'btnChangeName
        '
        Me.btnChangeName.BackColor = System.Drawing.Color.Transparent
        Me.btnChangeName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeName.ForeColor = System.Drawing.Color.Transparent
        Me.btnChangeName.Location = New System.Drawing.Point(0, 0)
        Me.btnChangeName.Name = "btnChangeName"
        Me.btnChangeName.Size = New System.Drawing.Size(1, 1)
        Me.btnChangeName.TabIndex = 0
        Me.btnChangeName.TabStop = False
        Me.btnChangeName.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Controls.Add(Me.btnSaveDefault)
        Me.GroupBox9.Controls.Add(Me.btnDefaultTexture)
        Me.GroupBox9.Controls.Add(Me.btnOpenTexture)
        Me.GroupBox9.Location = New System.Drawing.Point(220, 12)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(99, 203)
        Me.GroupBox9.TabIndex = 2
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Texture Pack"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.pbTexture)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(87, 100)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Preview"
        '
        'btnSaveDefault
        '
        Me.btnSaveDefault.Location = New System.Drawing.Point(6, 171)
        Me.btnSaveDefault.Name = "btnSaveDefault"
        Me.btnSaveDefault.Size = New System.Drawing.Size(87, 26)
        Me.btnSaveDefault.TabIndex = 3
        Me.btnSaveDefault.Text = "Save Default"
        Me.btnSaveDefault.UseVisualStyleBackColor = True
        '
        'btnDefaultTexture
        '
        Me.btnDefaultTexture.Location = New System.Drawing.Point(6, 144)
        Me.btnDefaultTexture.Name = "btnDefaultTexture"
        Me.btnDefaultTexture.Size = New System.Drawing.Size(87, 26)
        Me.btnDefaultTexture.TabIndex = 2
        Me.btnDefaultTexture.Text = "Load Default"
        Me.btnDefaultTexture.UseVisualStyleBackColor = True
        '
        'btnOpenTexture
        '
        Me.btnOpenTexture.Location = New System.Drawing.Point(6, 117)
        Me.btnOpenTexture.Name = "btnOpenTexture"
        Me.btnOpenTexture.Size = New System.Drawing.Size(87, 26)
        Me.btnOpenTexture.TabIndex = 1
        Me.btnOpenTexture.Text = "Open Texture"
        Me.btnOpenTexture.UseVisualStyleBackColor = True
        '
        'TextureOpenFileDialog
        '
        Me.TextureOpenFileDialog.Filter = "PNG (*.png)|*.png"
        Me.TextureOpenFileDialog.Title = "Open Texture File"
        '
        'TextureSaveFileDialog
        '
        Me.TextureSaveFileDialog.Filter = "PNG (*.png)|*.png"
        Me.TextureSaveFileDialog.Title = "Save Default Texture"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txtKeyRotateLeft)
        Me.GroupBox11.Location = New System.Drawing.Point(6, 55)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(92, 38)
        Me.GroupBox11.TabIndex = 2
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Rotate Left"
        '
        'txtKeyRotateLeft
        '
        Me.txtKeyRotateLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKeyRotateLeft.BackColor = System.Drawing.Color.White
        Me.txtKeyRotateLeft.Location = New System.Drawing.Point(4, 14)
        Me.txtKeyRotateLeft.Name = "txtKeyRotateLeft"
        Me.txtKeyRotateLeft.ReadOnly = True
        Me.txtKeyRotateLeft.Size = New System.Drawing.Size(85, 20)
        Me.txtKeyRotateLeft.TabIndex = 0
        '
        'pbTexture
        '
        Me.pbTexture.Image = Global.Tetris.My.Resources.Resources.DefaultTexture
        Me.pbTexture.Location = New System.Drawing.Point(6, 19)
        Me.pbTexture.Name = "pbTexture"
        Me.pbTexture.Size = New System.Drawing.Size(75, 75)
        Me.pbTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbTexture.TabIndex = 2
        Me.pbTexture.TabStop = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 282)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.btnChangeName)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.GamestatsGroup.ResumeLayout(False)
        Me.GamestatsGroup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.pbTexture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtKeyLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyRight As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyHardDrop As System.Windows.Forms.TextBox
    Friend WithEvents GamestatsGroup As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKeyDown As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKeyPause As System.Windows.Forms.TextBox
    Friend WithEvents txtKeyRotate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKeyHold As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents btnChangeName As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDefaultTexture As System.Windows.Forms.Button
    Friend WithEvents pbTexture As System.Windows.Forms.PictureBox
    Friend WithEvents btnOpenTexture As System.Windows.Forms.Button
    Friend WithEvents TextureOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveDefault As System.Windows.Forms.Button
    Friend WithEvents TextureSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKeyRotateLeft As System.Windows.Forms.TextBox
End Class
