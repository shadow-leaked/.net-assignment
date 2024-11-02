Imports System

' Base class (parent)
Public Class Animal
    Public Sub Eat()
        Console.WriteLine("Eating...")
    End Sub
End Class

' Derived class (child)
Public Class Dog
    Inherits Animal
    Public Sub Bark()
        Console.WriteLine("Barking...")
    End Sub
End Class

Module Program
    Sub Main()
        Dim dog As New Dog()
        dog.Eat() ' Calling method from base class
        dog.Bark() ' Calling method from derived class
        Console.ReadLine()
    End Sub
End Module
