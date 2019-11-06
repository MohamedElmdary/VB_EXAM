Imports System
Imports System.Collections

public Module module1
    public sub Main()
        Dim names as New ArrayList()
        Dim n as Integer 
        n = Console.ReadLine()

        For i as Integer = 0 To 25
            names.Add(new ArrayList())
        Next
	
        Dim name as String
        Dim c as Integer
        For i as Integer = 0 To n - 1
            name = Console.ReadLine()
            c = char.ConvertToUtf32(name, 0) - 97
            names.Item(c).Add(name)
        Next

        For i as Integer = 0 To 25
            if Not names.Item(i).Count = 0
                Console.WriteLine("start with (" & names.Item(i).Item(0)(0) & ") is " & names.Item(i).Count & " times")
            End if
        Next
    End sub
End Module