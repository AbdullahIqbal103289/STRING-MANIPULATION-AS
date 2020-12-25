Module Module1

    Sub Main()
        Dim c, alphabetcount, othercharactercount As Integer
        Dim mystring As String
        Dim char1 As Char
        mystring = ""
        alphabetcount = 0

        c = 0
        char1 = ""
        othercharactercount = 0

        Console.Write("please enter data: ")
        mystring = Console.ReadLine()
        For c = 1 To Len(mystring)
            char1 = Mid(mystring, c, 1)
            If (Asc(char1) >= 65 And Asc(char1) <= 90) Or (Asc(char1) >= 97 And Asc(char1) <= 122) Then
                alphabetcount = alphabetcount + 1
            ElseIf (Asc(char1) > 33 And Asc(char1) < 64) Or (Asc(char1) >= 91 And Asc(char1) <= 96) Then
                othercharactercount = othercharactercount + 1



            End If
        Next
        Console.WriteLine("total alphabet in entered data is: " & alphabetcount)
        Console.ReadKey()
        Console.WriteLine("othercharacters are: " & othercharactercount)
        Console.ReadKey()

    End Sub

End Module

