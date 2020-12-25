Module Module1

    Sub Main()
        Dim a As Integer
        Dim c As Integer
        Dim mystr1, mystr2 As String
        Dim mychar As Char
        Dim allalphabets As Boolean
        allalphabets = True
        a = 0
        c = 0
        mystr1 = "abcdefghijklmnopqrstuvwxyz"
        mystr2 = ""
        mychar = ""
        Console.WriteLine("please enter string: ")

        mystr2 = Console.ReadLine
        For c = 1 To Len(mystr1)
            mychar = Mid(mystr1, c, 1)
            a = InStr(mystr2, mychar)
            If a = 0 Then
                allalphabets = False
            End If
        Next
        If allalphabets = True Then
            Console.WriteLine("all alphabets are present")
        Else

            Console.WriteLine("all alphabets are not present")
        End If

        Console.ReadKey()

    End Sub

End Module
