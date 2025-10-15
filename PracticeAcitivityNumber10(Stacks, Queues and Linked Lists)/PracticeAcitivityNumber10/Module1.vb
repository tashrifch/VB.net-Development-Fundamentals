Module Module1

    Sub Main()
        Dim nameStack As New Stack
        Dim nameQueue As New Queue
        Dim nameLinkedList As New LinkedList(Of String)()

        ' Adding names to Stack
        nameStack.Push("John Smith")
        nameStack.Push("Jane Smith")
        nameStack.Push("Phillip Burton")
        nameStack.Push("Fred Bloggs")

        ' Adding names to Queue
        nameQueue.Enqueue("John Smith")
        nameQueue.Enqueue("Jane Smith")
        nameQueue.Enqueue("Phillip Burton")
        nameQueue.Enqueue("Fred Bloggs")

        ' Adding names to LinkedList
        nameLinkedList.AddFirst("John Smith")
        nameLinkedList.AddLast("Jane Smith")
        nameLinkedList.AddLast("Phillip Burton")
        nameLinkedList.AddLast("Fred Bloggs")

        Console.WriteLine(nameStack.Pop())
        Console.WriteLine(nameQueue.Dequeue())
        Console.WriteLine("")

        Console.WriteLine("Stack Content:")

        Dim johnFoundStack As Boolean = False
        Dim johnFoundQueue As Boolean = False

        ' Displaying Stack content

        For Each obj As Object In nameStack
            If obj.ToString() = "John Smith" Then
                johnFoundStack = True
            End If
            Console.WriteLine(obj)

        Next

        Console.WriteLine("")

        Console.WriteLine("Queue Content:")

        ' Displaying Queue content

        For Each obj As Object In nameQueue
            If obj.ToString() = "John Smith" Then
                johnFoundQueue = True
            End If
            Console.WriteLine(obj)
        Next

        Console.WriteLine("John Smith Found in Stack: " & johnFoundStack)
        Console.WriteLine("John Smith Found in Queue: " & johnFoundQueue)

        'Second Way
        Console.WriteLine("John Smith Found in Stack: " & nameStack.Contains("John Smith"))
        Console.WriteLine("John Smith Found in Queue: " & nameQueue.Contains("John Smith"))

        'Adding names to LinkedList

        Console.WriteLine("")
        nameLinkedList.AddBefore(nameLinkedList.Find("Phillip Burton"), "Paul Jones")
        nameLinkedList.AddAfter(nameLinkedList.Find("John Smith"), "Sarah Jane")

        'interating through LinkedList

        Console.WriteLine("LinkedList Content:")
        For Each name As String In nameLinkedList
            Console.WriteLine(name)
        Next
    End Sub

End Module
