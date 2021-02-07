Module Module1

    Sub Main()

        Dim mychar1, mychar2 As Char
        Dim mystr As String
        Dim count, A, B, C As Integer
        Dim i As Integer
        Dim isvalid As Boolean
        mystr = ""
        C = 0
        count = 0
        mychar2 = ""
        B = 0
        A = 0
        mychar1 = ""
        i = 0
        isvalid = True
        Console.Write("please enter string : ")
        mystr = Console.ReadLine
        For i = 1 To Len(mystr)
            mychar1 = Mid(mystr, i, 1)
            If mychar1 >= "a" And mychar1 <= "z" Then
                count = count + 1
            ElseIf mychar1 >= "A" And mychar1 <= "Z" Then
                    A = A + 1
                
            ElseIf mychar1 >= "0" And mychar1 <= "9" Then
                B = B + 1
            ElseIf (UCase(mychar1) >= "A" And UCase(mychar1) <= "Z") Or (mychar1 >= "0" And mychar1 <= "9") Then
                C = C + 1
            End If

        Next

        If count = 2 And A = 2 And B = 3 And (C <> Len(mystr)) Then
            isvalid = True
        Else
            isvalid = False

        End If

        Console.WriteLine("ENTERED STRING IS: " & isvalid)
        Console.ReadKey()
    End Sub

End Module
