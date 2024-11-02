Imports System

' Define the Car class
Public Class Car
    Public brand As String
    Public model As String
    Public year As Integer

    ' Default constructor
    Public Sub New()
        Console.WriteLine("Default Constructor Called")
        brand = "Unknown"
        model = "Unknown"
        year = 0
    End Sub

    ' Parameterized constructor
    Public Sub New(ByVal brand As String, ByVal model As String, ByVal year As Integer)
        Console.WriteLine("Parameterized Constructor Called")
        Me.brand = brand
        Me.model = model
        Me.year = year
    End Sub

    ' Method to display car details
    Public Sub DisplayDetails()
        Console.WriteLine("Brand: " & brand & ", Model: " & model & ", Year: " & year)
    End Sub
End Class

Module Program
    Sub Main()
        ' Create an instance using the default constructor
        Dim defaultCar As New Car() ' Default constructor is invoked
        defaultCar.DisplayDetails() ' Displays details of defaultCar

        Console.WriteLine() ' Blank line for readability

        ' Create an instance using the parameterized constructor
        Dim myCar As New Car("Toyota", "Corolla", 2022) ' Parameterized constructor is invoked
        myCar.DisplayDetails() ' Displays details of myCar

        ' Keep the console window open
        Console.ReadLine() ' Waits for user input before closing
    End Sub
End Module
