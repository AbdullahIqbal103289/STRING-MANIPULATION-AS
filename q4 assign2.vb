Module Module1

    Sub Main()
        Dim mystr As String
        Dim mychar1, mychar2, mychar3 As Char
        Dim highest, a, b, charcount As Integer
        mystr = ""
        mychar1 = ""
        mychar2 = ""
        mychar3 = ""
        highest = 0
        charcount = 0
        a = 0
        b = 0
        Console.Write("please enter string: ")
        mystr = Console.ReadLine
        mystr = UCase(mystr)
        For a = 1 To Len(mystr)
            mychar1 = Mid(mystr, a, 1)
            charcount = 0
            For b = 1 To Len(mystr)
                mychar2 = Mid(mystr, b, 1)
                If mychar2 = mychar1 Then
                    charcount = charcount + 1

                End If
            Next
            If charcount > highest Then
                highest = charcount
                mychar3 = mychar1

            End If
        Next
        Console.WriteLine("highest no. of times character appeared is: " & mychar3 & " " & "and no. of times appeared is : " & " " & highest)
        Console.ReadLine()
    End Sub

End Module
