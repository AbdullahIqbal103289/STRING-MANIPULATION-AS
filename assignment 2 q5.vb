Module Module1

    Sub Main()
        Dim vowelcount, c, N As Integer
        Dim mystr1, mystr2 As String
        Dim mychar As Char
        mychar = ""
        N = 0

        c = 0
        vowelcount = 0
        mystr1 = "AEIOU"
        mystr2 = ""
        Console.Write("please enter string: ")
        mystr2 = Console.ReadLine()
        For c = 1 To Len(mystr2)

            mychar = Mid(mystr2, c, 1)
            mychar = UCase(mychar)
            N = InStr(mystr1, mychar)
            If N > 0 Then
                vowelcount = vowelcount + 1


            End If
        Next

        Console.WriteLine("total vowels in entered string are:" & vowelcount)
        Console.ReadKey()




    End Sub

End Module
