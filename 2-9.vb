Imports System

public Module module1
    public sub Main()
        Dim name as String = "MohamedRabieRabieElmdary"
        Dim count(26) as Integer
        Dim temp as Integer
        For i as Integer = 0 To name.Length - 1
		temp = char.ConvertToUtf32(name, i)
            if temp > 64 And temp < 91
                temp += 32
            End if
            temp -= 97
            count(temp) += 1 
        Next

        For i as Integer = 0 To 25
            if Not count(i) = 0
                Console.WriteLine("char (" & char.ConvertFromUtf32(i + 97) & "): " & count(i))
            End if
        Next
    End sub

End Module