Imports System

public Module module1
    
    Function gcd(ByVal a as Integer, ByVal b as Integer)
        Do while (a Mod b <> 0)
            Dim r as Integer = a Mod b
            a = b
            b = r
        Loop
        return b
    End Function

    public sub Main()
        Console.WriteLine(gcd(36, 12))

    End sub 

End Module