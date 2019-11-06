Imports System

public Module module1
    public class CArray
        private arr() as Integer
        private numElements as Integer

        public sub New(size as Integer)
            ReDim arr(size)
            numElements = 0
        End sub

        public sub insert(item as Integer)
            if arr.GetUpperBound(0) <= numElements
                ReDim Preserve arr(numElements * 1.25)
            End if
            arr(numElements) = item
            numElements += 1
        End sub

        public sub showArray()
            For i as Integer = 0 To numElements - 1
                Console.Write(arr(i) & " ")
            Next
            Console.WriteLine()
        End sub
    
        public sub bubbleSort()
            Dim temp as Integer
            For a as Integer = 0 To numElements - 1
                For b as Integer = 0 To numElements - 2
                    if arr(b) > arr(b + 1)
                        temp = arr(b)
                        arr(b) = arr(b + 1)
                        arr(b + 1) = temp
                    End if
                Next
            Next
        End sub

        public sub selectionSort()
            Dim temp as Integer
            For a as Integer = 0 To numElements - 2
                Dim min as Integer = a
                For b as Integer = a + 1 To numElements - 1
                    if arr(b) < arr(min)
                        min = b
                    End if
                Next
                temp = arr(min)
                arr(min) = arr(a)
                arr(a) = temp
            Next
        End sub

        Function binarySearch(ByVal n as Integer)
            Dim lower as Integer = 0
            Dim upper as Integer = numElements - 1
            Dim mid as Integer
            Do while lower <= upper
                mid = (lower + upper) \ 2
                if arr(mid) = n
                    return mid
                elseif arr(mid) > n
                    upper = mid - 1
                else
                    lower = mid + 1            
                End if
            Loop
            return -1
        End Function

    End class

    public sub Main()
        Dim arr as New CArray(2)
        arr.showArray()
        arr.insert(1)
        arr.insert(8)
        arr.insert(5)
        arr.insert(4)
        arr.showArray()

        ' arr.bubbleSort()
        arr.selectionSort()
        arr.showArray()

        Console.WriteLine(arr.binarySearch(5))
        Console.WriteLine(arr.binarySearch(3))


    End sub

End Module