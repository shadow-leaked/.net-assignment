Imports System
Imports System.Collections
Imports System.Collections.Generic

Module Program
    Sub Main()
        ' ArrayList Example
        Dim arrayList As New ArrayList()
        arrayList.Add(1)
        arrayList.Add(2)
        arrayList.Add(3)
        arrayList.Add("Four")
        arrayList.Add(5.5)

        Console.WriteLine("ArrayList contents:")
        For Each item In arrayList
            Console.WriteLine(item)
        Next

        Console.WriteLine() ' Blank line for readability

        ' Dictionary Example
        Dim dictionary As New Dictionary(Of String, Integer)()
        dictionary("Apple") = 1
        dictionary("Banana") = 2
        dictionary("Cherry") = 3

        Console.WriteLine("Dictionary contents:")
        For Each kvp In dictionary
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}")
        Next

        Console.ReadLine()
    End Sub
End Module
