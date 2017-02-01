Public Class frmSettings
    Public Property key_Rotate As Keys = Keys.Up
    Public Property key_RotateLeft As Keys = Keys.NumPad0
    Public Property key_Left As Keys = Keys.Left
    Public Property key_Right As Keys = Keys.Right
    Public Property key_Down As Keys = Keys.Down
    Public Property key_HardDrop As Keys = Keys.Space
    Public Property key_Hold As Keys = Keys.Shift
    Public Property key_Pause As Keys = Keys.Escape

    Private Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKeyLeft.GotFocus, txtKeyRight.GotFocus, txtKeyRotate.GotFocus, txtKeyDown.GotFocus, txtKeyHardDrop.GotFocus, txtKeyPause.GotFocus, txtKeyHold.GotFocus, txtKeyRotateLeft.GotFocus
        sender.selectAll()
    End Sub
    Private Sub txt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKeyLeft.Click, txtKeyRight.Click, txtKeyRotate.Click, txtKeyDown.Click, txtKeyHardDrop.Click, txtKeyPause.Click, txtKeyHold.Click, txtKeyRotateLeft.Click
        sender.selectAll()
    End Sub

    Private Sub txt_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyLeft.KeyUp, txtKeyRight.KeyUp, txtKeyRotate.KeyUp, txtKeyDown.KeyUp, txtKeyHardDrop.KeyUp, txtKeyPause.KeyUp, txtKeyHold.KeyUp, txtKeyRotateLeft.KeyUp
        Dim key As Integer = e.KeyCode

        Dim ignoreKeys() As Keys = {Keys.Tab, Keys.Menu, Keys.ControlKey}
        If ignoreKeys.Contains(key) Then Return

        If key = (Keys.ShiftKey Or Keys.Shift) Then
            key = Keys.Shift
        End If

        Select Case sender.Name
            Case "txtKeyRotate" : key_Rotate = key
            Case "txtKeyRotateLeft" : key_RotateLeft = key
            Case "txtKeyLeft" : key_Left = key
            Case "txtKeyRight" : key_Right = key
            Case "txtKeyDown" : key_Down = key
            Case "txtKeyHardDrop" : key_HardDrop = key
            Case "txtKeyHold" : key_Hold = key
            Case "txtKeyPause" : key_Pause = key
        End Select

        sender.Text = [Enum].GetName(GetType(Keys), key)
        sender.selectAll()
    End Sub

    Private Sub resetControls() Handles btnReset.Click
        key_Rotate = Keys.Up
        key_RotateLeft = Keys.NumPad0
        key_Left = Keys.Left
        key_Right = Keys.Right
        key_Down = Keys.Down
        key_HardDrop = Keys.Space
        key_Hold = Keys.Shift
        key_Pause = Keys.Escape

        txtKeyRotate.Text = [Enum].GetName(GetType(Keys), key_Rotate)
        txtKeyRotateLeft.Text = [Enum].GetName(GetType(Keys), key_RotateLeft)
        txtKeyLeft.Text = [Enum].GetName(GetType(Keys), key_Left)
        txtKeyRight.Text = [Enum].GetName(GetType(Keys), key_Right)
        txtKeyDown.Text = [Enum].GetName(GetType(Keys), key_Down)
        txtKeyHardDrop.Text = [Enum].GetName(GetType(Keys), key_HardDrop)
        txtKeyHold.Text = [Enum].GetName(GetType(Keys), key_Hold)
        txtKeyPause.Text = [Enum].GetName(GetType(Keys), key_Pause)
    End Sub

    Private Sub btnChangeName_Click(sender As System.Object, e As System.EventArgs) Handles btnChangeName.Click
        txtName.ReadOnly = False
        txtName.Focus()
        txtName.SelectAll()
        btnChangeName.Visible = False
    End Sub

    Public textures(8) As Image
    Public Function getTexture(id As Integer) As Image
        Return textures(id + 1)
    End Function
    Public Sub updateTextures()
        Dim id As Integer = -2
        Dim bm As Bitmap = New Bitmap(pbTexture.Image)
        For y = 0 To 2
            For x = 0 To 2
                id += 1
                textures(id + 1) = bm.Clone(New Rectangle(x * 25, y * 25, 25, 25), bm.PixelFormat)
            Next
        Next
        bm.Dispose()
    End Sub
    Private Sub btnOpenTexture_Click(sender As System.Object, e As System.EventArgs) Handles btnOpenTexture.Click
        TextureOpenFileDialog.FileName = ""
        If TextureOpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbTexture.Image = New Bitmap(TextureOpenFileDialog.FileName)
            updateTextures()
            frmMain.tBoard.Refresh()
        End If
    End Sub

    Private Sub TextureOpenFileDialog_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TextureOpenFileDialog.FileOk
        Dim bm As Bitmap = New Bitmap(1, 1)
        Try
            bm = New Bitmap(TextureOpenFileDialog.FileName)
        Catch ex As Exception
            e.Cancel = True
        End Try
        If (bm.Width Mod 3 = 0 AndAlso bm.Height Mod 3 = 0) Then 'bm.Size <> New Size(75, 75)) Then
            e.Cancel = True
        End If

        If e.Cancel Then
            MsgBox("Invalid texture file! The image size must be divisible by three!", MsgBoxStyle.Critical, "Invalid Texture!")
        End If
    End Sub

    Private Sub btnDefaultTexture_Click(sender As System.Object, e As System.EventArgs) Handles btnDefaultTexture.Click
        pbTexture.Image = My.Resources.DefaultTexture
        updateTextures()
        frmMain.tBoard.Refresh()
    End Sub

    Private Sub btnSaveDefault_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveDefault.Click
        If TextureSaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Resources.DefaultTexture.Save(TextureSaveFileDialog.FileName)
        End If
    End Sub

    Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        resetControls()
        TextureSaveFileDialog.InitialDirectory = Application.StartupPath
        TextureOpenFileDialog.InitialDirectory = Application.StartupPath
    End Sub
End Class