Module Module1

    Sub Main()
        Dim mychar1, mychar2 As Char
        Dim mystr As String
        Dim count, A, B As Integer
        Dim i As Integer
        Dim isvalid As Boolean
        mystr = ""
        count = 0
        mychar2 = ""
        B = 0
        A = 0
        mychar1 = ""
        i = 0
        isvalid = True
        Console.Write("PLEASE ENTER PASSWORD : ")
        mystr = Console.ReadLine

        For i = 1 To Len(mystr)
            mychar1 = Mid(mystr, i, 1)
            If Asc(mychar1) >= 97 And Asc(mychar1) <= 122 Then
                count = count + 1
            End If
        Next
        For i = 1 To Len(mystr)
            mychar1 = Mid(mystr, i, 1)
            If Asc(mychar1) >= 65 And Asc(mychar1) <= 90 Then
                A = A + 1
            End If
        Next
        For i = 1 To Len(mystr)
            mychar2 = Mid(mystr, i, 1)
            If Asc(mychar2) >= 48 And Asc(mychar2) <= 57 Then
                B = B + 1
            End If
        Next
        If count = 2 And A = 2 And B = 3 Then
            isvalid = True
        Else
            isvalid = False

        End If

        Console.WriteLine("ENTERED PASSWORD IS: " & isvalid)
        Console.ReadKey()

    End Sub

End Module
