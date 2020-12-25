Module Module1

    Sub Main()
        Dim mychar1, mychar2, mychar3 As Char
        Dim mystr1, mystr2 As String
        Dim c As Integer
        mychar1 = ""
        mychar2 = ""
        mychar3 = ""
        mystr1 = ""
        mystr2 = ""
        c = 0
        Console.Write("PLEASE ENTER STRING: ")
        mystr1 = Console.ReadLine
        Console.Write("PLEASE ENTER CHARACTER TO REPLACE: ")
        mychar1 = Console.ReadLine
        Console.Write("PLEASE ENTER SUBSTITUTION CHARACTER: ")
        mychar2 = Console.ReadLine
        For c = 1 To Len(mystr1)
            mychar3 = Mid(mystr1, c, 1)
            If mychar3 = mychar1 Then
                mystr2 = mystr2 & mychar2
            Else
                mystr2 = mystr2 & mychar3


            End If
        Next
        Console.WriteLine("resulting string is: " & mystr2)
        Console.ReadKey()

    End Sub

End Module
