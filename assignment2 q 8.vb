Module Module1

    Sub Main()
        Dim mychar1, mychar2, B As Char
        Dim i As Integer
        Dim mystr1, MYSTR2 As String
        mystr1 = ""
        MYSTR2 = ""
        B = ""
        mychar2 = "*"
        i = 0
        mychar1 = ""
        Console.Write("Please enter string: ")
        mystr1 = Console.ReadLine

        mychar1 = Left(mystr1, 1)

        For i = 2 To Len(mystr1)
            B = Mid(mystr1, i, 1)
            If mychar1 = B Then
                MYSTR2 = MYSTR2 & mychar2
            Else
                MYSTR2 = MYSTR2 & B


            End If
        Next
        Console.WriteLine("your result is: " & mychar1 & MYSTR2)

        Console.ReadKey()

    End Sub

End Module
