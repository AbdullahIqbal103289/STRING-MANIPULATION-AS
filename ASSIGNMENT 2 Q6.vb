Module Module1

    Sub Main()
        Dim count As Integer
        Dim mystr As String
        mystr = "many"
        count = 0
        Console.Write("Please enter number of donuts: ")
        count = Console.ReadLine
        If count < 10 Then
            count = count
            Console.WriteLine("Number of donuts: " & count)
            Console.ReadKey()
        Else
            Console.WriteLine("Number of donuts: " & mystr)
            Console.ReadKey()
        End If



    End Sub

End Module
