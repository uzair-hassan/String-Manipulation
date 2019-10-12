Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim nextChar As String
        Dim Counter As Integer

        Str1 = ""
        Str2 = ""
        Counter = 0

        Console.Write("Enter a string: ")
        Str1 = Console.Read

        For Counter = Len(Str1) To 1 Step -1
            nextChar = Mid(Str1, Counter, 1)

            Str2 = Str2 + nextChar
        Next
        Console.WriteLine("Inverse String: " & Str2)
        Console.ReadKey()
    End Sub

End Module
