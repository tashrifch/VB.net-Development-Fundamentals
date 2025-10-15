Module Module1


    Sub Main()
        ' In this Practice Activity, in a New program, create two variables:

        'Mood can contain either the values Happy Or Sad
        Dim mood As String = "Sad"


        'TypeOfActivity can contain the values  Fun Or Serious.
        Dim TypeOfActivity As String = "Fun"
        '1. Create an IF statement, so that:
        'If you are Happy And the Activity Is Fun, Then you can say "I am Happy :-) and the Activity is Fun".

        If mood = "Happy" And TypeOfActivity = "Fun" Then
            Console.WriteLine("I am Happy :-) and the Activity is Fun")
        ElseIf mood = "Sad" And TypeOfActivity = "Serious" Then
            Console.WriteLine("I am Sad :-( and ready for Serious activities")
        Else
            Console.WriteLine("I am not in the mood for this activity")


        End If



        'If you are Sad And the Activity Is Serious, Then you can say "I am Sad :-( and ready for Serious activities".

        'Otherwise, say "I am not in the mood for this activity".

        '2. Create another IF statement, so that:


        If mood = "Happy" Or TypeOfActivity = "Fun" Then
            Console.WriteLine("Either I am happy, Or this activity Is fun - Or both!")
        End If

        'If you are Happy Or the Activity Is Fun, Then you can say "Either I am happy, or this activity is fun - or both!"

        '3. Create a Select Case statement based on Mood, a "/", And a TypeOfActivity combined.

        Select Case mood & "/" & TypeOfActivity
            Case "Happy/Fun"
                Console.WriteLine("Let's do it.")
            Case "Sad/Serious"
                Console.WriteLine("Let's do it.")
            Case "Happy/Serious"
                Console.WriteLine("Can we do something more fun?")
            Case "Sad/Fun"
                Console.WriteLine("Can we do it later?")
        End Select

        'If the result Is "Happy/Fun" Or "Sad/Serious", Then say "Let's do it."

        'If the result Is "Happy/Serious", Then say 'Can we do something more fun?"

        'If the result If "Sad/Fun", Then say "Can we do it later?"

        'Run it With the variables containing:

        'Happy And Fun,

        'Happy And Serious,

        'Sad And Fun, And

        'Sad And Serious.

        'Were the Outputs what you were expecting? If Not, have a look at your code And see If there Is anything you need To change.

    End Sub

End Module
