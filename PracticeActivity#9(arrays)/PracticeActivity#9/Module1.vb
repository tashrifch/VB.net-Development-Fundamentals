Module Module1

    Sub Main()

        Dim names As String() = {"John Smith", "Jane Smith", "Phillip Burton", "Fred Bloggs"}

        For Each name As String In names
            Console.WriteLine(name)
        Next

        Dim namesArray(3, 1) As String

        namesArray(0, 0) = "John"
        namesArray(0, 1) = "Smith"
        namesArray(1, 0) = "Jane"
        namesArray(1, 1) = "Smith"
        namesArray(2, 0) = "Phillip"
        namesArray(2, 1) = "Burton"
        namesArray(3, 0) = "Fred"
        namesArray(3, 1) = "Bloggs"


        For Each name As String In namesArray
            Console.WriteLine(name)


        Next





    End Sub

End Module
