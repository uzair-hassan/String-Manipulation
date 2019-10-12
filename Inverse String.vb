Module Module1

    Sub Main()
        Dim Str1, InvStr As String
        Dim nextChar As Char
        Dim Counter As Integer

        Str1 = ""
        InvStr = ""
        nextChar = ""
        Counter = 0

        Console.Write("Enter a String to inverse: ")
        Str1 = Console.ReadLine()

        For Counter = Len(Str1) To 1 Step -1
            nextChar = Mid(Str1, Counter, 1)

            InvStr = InvStr + nextChar
        Next

        Console.WriteLine("Inverse String is: " & InvStr)
        Console.ReadKey()

    End Sub

End Module
