Module PlayerStartupMessage
    Sub show(ByVal username As String)
        username = username.ToLower

        Select Case username
            Case "ronald.mitchell"
                MsgBox("The computer has come alive and is eating" & vbCrLf & "you due to an unidentified internal error! :D", MsgBoxStyle.OkOnly, "Tetris Error!?")
            Case "peter.hehl"
                If MsgBox("Don't you have work to do?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                    MsgBox("GET TO WORK PETER!!", MsgBoxStyle.Exclamation)
                    End
                Else
                    MsgBox("OK, you are free to pass.")
                End If
        End Select
    End Sub
End Module
