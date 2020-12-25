Module Module1

    Sub Main()
        Dim mystr1, mystr2, mystr5 As String
        Dim a, b, c As Integer

        a = 0
        b = 0
        c = 0

        mystr1 = ""
        mystr2 = ""
        mystr5 = ""

        Console.Write("Please enter string: ")
        mystr1 = Console.ReadLine
        a = InStr(mystr1, "not")
        b = InStr(mystr1, "bad")
        c = Len(mystr1)
        

        If b > a Then
            mystr2 = Mid(mystr1, 1, a - 1)
            mystr5 = Mid(mystr1, b + 3, c)

        End If
        Console.WriteLine(mystr2 & " " & "good" & " " & mystr5)
        Console.ReadKey()

    End Sub

End Module
