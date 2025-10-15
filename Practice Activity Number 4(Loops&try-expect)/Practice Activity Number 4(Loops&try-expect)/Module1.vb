Imports System.CodeDom
Imports System.IO

Module Module1

    Sub Main()

        ' Activity 4: Loops and Try-Expect
        'Part 1
        Dim firstCount As Boolean = True
        'For i = 1 To 5
        'Console.Write("Enter a number: ")
        'Dim userInput As Decimal = Console.ReadLine()
        'multCount = multCount * userInput
        'Next
        'Console.WriteLine("the total is: " & multCount)


        Dim multCount As Decimal

        Dim notZero As Boolean = True



        Do
            Try
                Console.Write("Enter a number (0 to stop): ")

                Dim userInput As Decimal = Console.ReadLine()

                If userInput = 0 And firstCount = True Then
                    Console.WriteLine("You have to enter at least one number that isn't 0")
                    Exit Do
                ElseIf userInput = 0 Then
                    Console.WriteLine("The total is: " & multCount)
                    Exit Do
                End If

                If firstCount = True Then
                    firstCount = False
                    multCount = userInput
                Else

                    multCount = multCount * userInput
                End If
            Catch ex As Exception
                Console.WriteLine("That is not a valid number, please try again")
            End Try

        Loop While notZero


        'In the solution video he use loop until userInput = 0 which is a better way to do it
        ' I will try to do it that way next time, I will keep this as it is my own work, however that is the better way to do it. 




    End Sub

End Module
