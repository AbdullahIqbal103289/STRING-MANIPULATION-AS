Module Module1

    Sub Main()

        Dim S As String
        Dim mystr, D, F As String
        Dim mychar1 As Char
        Dim mychar2 As Char
        Dim c, B As Integer
        B = 0
        D = ""
        c = 0
        F = ""
        S = ""
        mychar1 = ""
        mychar2 = ""
        S = ""
        mystr = ""
        Console.Write("PLEASE ENTER S: ")
        S = Console.ReadLine
        B = Len(S)
        D = Left(S, 2)
        F = Right(S, 2)
        If Len(S) > 2 Then
            Console.WriteLine("your result is: " & D & F)
            Console.ReadKey()
        Else
            S = S
            Console.WriteLine("your result is: " & S)
            Console.ReadKey()

        End If

    End Sub

End Module
