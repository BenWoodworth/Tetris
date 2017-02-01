Public Module Sounds
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Long, ByVal hwndCallback As Long) As Long
    Public Sub PlayMidiFile(MidiFile As String)
        On Error Resume Next
        mciSendString("open sequencer!" & MidiFile & " alias midi", "", 0, 0)
        mciSendString("play midi from 0", 0&, 0, 0)
    End Sub
    Public Sub StopMidi()
        On Error Resume Next
        mciSendString("stop midi", "", 0, 0)
        mciSendString("close midi", "", 0, 0)
    End Sub
End Module