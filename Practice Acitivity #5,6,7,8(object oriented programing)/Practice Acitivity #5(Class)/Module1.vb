
Imports System.Runtime.CompilerServices


'Activity 5,6,7,8
Class Mammals

    Public Event SoundOfMammal_Event()


    Public Sub New()

    End Sub
    Private _NameOfMammal As String
    Public Sub New(typeOfAnimal As String)
        _NameOfMammal = typeOfAnimal
    End Sub

    Public Property NameOfMammal As String
        Get
            Return _NameOfMammal
        End Get
        Set(value As String)
            If value = "Fish" Then
                _NameOfMammal = "Not a mammal"
            Else
                _NameOfMammal = value
            End If

        End Set
    End Property

    Function SoundOfMammal() As String
        RaiseEvent SoundOfMammal_Event()
        If NameOfMammal = "Lion" Then
            Return "Roar"
        ElseIf NameOfMammal = "Dog" Then
            Return "Bark"
        Else
            Return "Noise"
        End If
    End Function

    Overridable Function AmIWild() As String
        Return "I Don't know"
    End Function

End Class


Class WildAnimal
    Inherits Mammals





    Public Sub New()

    End Sub


    Public Sub New(typeOfAnimal As String)
        Me.NameOfMammal = typeOfAnimal
    End Sub
    Overrides Function AmIWild() As String
        Return "Yes, I am wild"
    End Function


End Class

Class TameAnimal
    Inherits Mammals

    Public Sub New()

    End Sub


    Public Sub New(typeOfAnimal As String)
        Me.NameOfMammal = typeOfAnimal
    End Sub

    Overrides Function AmIWild() As String
        Return "No, I am tame"
    End Function

End Class

Module Module1

    Sub Main()
        Dim FirstMammal As New WildAnimal("Lion")
        'FirstMammal.NameOfMammal = "Lion"
        AddHandler FirstMammal.SoundOfMammal_Event, AddressOf SoundOfMammal_EventHandler

        Console.WriteLine("First Animal are you wild? :" & FirstMammal.AmIWild())

        Dim SecondMammal As New TameAnimal("Kitten")
        'SecondMammal.NameOfMammal = "Kitten"

        Console.WriteLine("Second Animal are you wild? :" & SecondMammal.AmIWild())

        Console.WriteLine("The name of the second mammal is " & SecondMammal.NameOfMammal)

        Dim ThirdMammal As Mammals = FirstMammal

        Console.WriteLine("Third Mammal are you wild?: " & ThirdMammal.AmIWild())

        'ThirdMammal.NameOfMammal = "Dog"

        'Dim RandomMammal As New Mammals()
        'RandomMammal.NameOfMammal = "Elephant"

        'Dim fourthMammal As New Mammals("Cat")
        'Console.WriteLine("The name of the fourth mammal is " & fourthMammal.NameOfMammal)

        Console.WriteLine("The first mammal is a " & FirstMammal.NameOfMammal _
                          & " The Second mammal is a " & SecondMammal.NameOfMammal)
        Console.WriteLine("The sound of the first mammal is " & FirstMammal.SoundOfMammal())
        Console.WriteLine("The sound of the second mammal is " & SecondMammal.SoundOfMammal())
        'Console.WriteLine("The sound of the third mammal is " & ThirdMammal.SoundOfMammal())
        'Console.WriteLine("The sound of the random mammal is " & RandomMammal.SoundOfMammal())
    End Sub

    Sub SoundOfMammal_EventHandler()
        ' This subroutine is currently empty and can be implemented as needed.
        Console.WriteLine("I hear a sound")
    End Sub

End Module
