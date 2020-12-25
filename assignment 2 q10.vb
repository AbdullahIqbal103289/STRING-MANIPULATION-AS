Module Module1

    Sub Main()
        Dim mystr1, mystr2, B, mystr3 As String
        Dim mychar1 As Char
        Dim i, a As Integer
        B = ""
        a = 0
        mystr3 = "ly"
        mystr1 = ""
        mychar1 = ""
        mystr2 = "ing"
        i = 0
        Console.Write("Please enter string: ")
        mystr1 = Console.ReadLine()
        a = Len(mystr1)
        B = Right(mystr1, 3)

        If a >= 3 And B <> mystr2 Then
            Console.WriteLine("result is: " & mystr1 & mystr2)
            Console.ReadKey()

        ElseIf a >= 3 And B = mystr2 Then
            Console.WriteLine("result is: " & mystr1 & mystr3)
            Console.ReadKey()

        Else
            mystr1 = mystr1

            Console.WriteLine("result is:" & mystr1)
            Console.ReadKey()
        End If

    End Sub

End Module
