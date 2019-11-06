Imports System

public Module module1

    public sub reverseArray(ByRef arr() as Integer)
        Dim len as Integer = arr.Length
        Dim mid as Integer = (len / 2) - 1
        Dim temp as Integer
        len -= 1
        For i as Integer = 0 To mid
            temp = arr(i)
            arr(i) = arr(len - i)
            arr(len - i) = temp
        Next
    End sub

    ' test code
    public sub Main()
        Dim arr() as Integer = {1, 3, 7, 9}
        For i as Integer = 0 To arr.Length - 1
            Console.Write(arr(i) & " ")
        Next
        Console.WriteLine()

        reverseArray(arr)

        For i as Integer = 0 To arr.Length - 1
            Console.Write(arr(i) & " ")
        Next
        Console.WriteLine()
    End sub

End Module