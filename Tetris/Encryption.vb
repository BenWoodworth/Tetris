Module Encryption
    Public Function encrypt(ByVal str As String) As String
        If str = "" Then Return ""

        Dim arr As Char() = str.ToCharArray
        For x = 0 To arr.Length - 1
            arr(x) = ChrW(25565 - AscW(arr(x)))
        Next
        Array.Reverse(arr)
        Return New String(arr)
    End Function
    Public Function decrypt(ByVal str As String) As String
        Return encrypt(str)
    End Function
End Module
