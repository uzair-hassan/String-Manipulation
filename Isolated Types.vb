Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Letters, Specials, nextChar, Numbers As String
        Dim Counter As Integer

        Str1 = ""
        Letters = ""
        Specials = ""
        nextChar = ""
        Numbers = ""
        Counter = 0

        Console.Write("Enter a String: ")
        Str1 = Console.ReadLine()

        For Counter = 1 To Len(Str1)
            nextChar = Mid(Str1, Counter, 1)

            If (nextChar >= "A" And nextChar <= "Z") Or (nextChar >= "a" And nextChar <= "z") Then
                Letters = Letters & nextChar
            Else
                If nextChar >= "0" And nextChar <= "9" Then
                    Numbers = Numbers & nextChar
                Else
                    Specials = Specials & nextChar
                End If
            End If
            
        Next

        Console.WriteLine("Letters: " & Letters)
        Console.WriteLine("Specials: " & Specials)
        Console.WriteLine("Numbers: " & Numbers)

        Console.ReadKey()

    End Sub

End Module
