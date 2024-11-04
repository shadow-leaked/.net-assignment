Imports System

' Define the first interface
Public Interface IAnimal
    Sub Eat()
End Interface

' Define the second interface
Public Interface IPet
    Sub Play()
End Interface

' Implement multiple interfaces in a class
Public Class Dog
    Implements IAnimal, IPet

    Public Sub Eat() Implements IAnimal.Eat
        Console.WriteLine("Dog is eating.")
    End Sub

    Public Sub Play() Implements IPet.Play
        Console.WriteLine("Dog is playing.")
    End Sub
End Class

Module Program
    Sub Main()
        Dim myDog As New Dog()
        myDog.Eat()
        myDog.Play()

        ' Polymorphism: Using interface references
        Dim animal As IAnimal = myDog
        animal.Eat()

        Dim pet As IPet = myDog
        pet.Play()

        Console.ReadLine()
    End Sub
End Module
