Module Module1

    Sub Main()
        Dim mystr1, mystr2, mystr3, mystr4, a, b As String
        Dim c, d As Integer
        d = 0
        mystr1 = ""
        mystr2 = ""
        mystr3 = ""
        mystr4 = ""
        a = ""
        b = ""
        c = 0
        Console.Write("please enter string: ")
        a = Console.ReadLine
        Console.Write("please enter string2: ")
        b = Console.ReadLine
        mystr1 = Left(a, 2)
        mystr2 = Left(b, 2)
        c = Len(a)
        d = Len(b)
        mystr3 = Mid(a, 3, c)

        mystr4 = Mid(b, 3, d)
        Console.WriteLine("result is: " & mystr2 & mystr3 & " " & mystr1 & mystr4)

        Console.ReadKey()





    End Sub

End Module
