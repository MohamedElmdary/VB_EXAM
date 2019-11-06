Imports System

public Module module1
    public sub Main()
        Dim ca, cb, ra, rb as Integer
        ca = 3 'Console.ReadLine()
        ra = 3 'Console.ReadLine()
        cb = 3 'Console.ReadLine()
        rb = 3 'Console.ReadLine()
	
        Dim ma(ra - 1, ca - 1), mb(rb - 1, cb - 1), res(ra - 1, cb - 1) as Integer
		ma(0, 0) = 1
		ma(0, 1) = 1
		ma(0, 2) = 1
		ma(1, 0) = 1
		ma(1, 1) = 1
		ma(1, 2) = 1
        ma(2, 0) = 1
		ma(2, 1) = 1
		ma(2, 2) = 1

		mb(0, 0) = 1
		mb(0, 1) = 1
		mb(0, 2) = 1
		mb(1, 0) = 1
		mb(1, 1) = 1
		mb(1, 2) = 1
        mb(2, 0) = 1
		mb(2, 1) = 1
		mb(2, 2) = 1
		
        if ra <> cb
            Console.WriteLine("invalid product")
            return
        End if

        For a as Integer = 0 To ra - 1
            For b as Integer = 0 To ca - 1
                Dim value as Integer = 0
                For c as Integer = 0 To cb - 1
                    value += ma(a, c) * mb(c, b)
                Next
                res(a, b) = value
            Next
        Next

        For a as Integer = 0 To ra - 1
            For b as Integer = 0 To cb - 1
                Console.Write(res(a, b) & " ")
            Next
            Console.WriteLine()
        Next

    End sub
End Module