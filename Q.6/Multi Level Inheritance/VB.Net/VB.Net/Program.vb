Imports System

' Base class (parent)
Public Class Animal
    Public Sub Eat()
        Console.WriteLine("Eating...")
    End Sub
End Class

' Intermediate class
Public Class Mammal
    Inherits Animal
    Public Sub Walk()
        Console.WriteLine("Walking...")
    End Sub
End Class

' Derived class (child)
Public Class Dog
    Inherits Mammal
    Public Sub Bark()
        Console.WriteLine("Barking...")
    End Sub
End Class

Module Program
    Sub Main()
        Dim dog As New Dog()
        dog.Eat() ' Calling method from base class
        dog.Walk() ' Calling method from intermediate class
        dog.Bark() ' Calling method from derived class
        Console.ReadLine()
    End Sub
End Module
