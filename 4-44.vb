Imports System
Imports System.Collections

public Module module1
    public class Queue
        private capacity as Integer
        private list() as Integer
        private numsElement as Integer

        public sub New(ByVal size as Integer)
            capacity = size
            ReDim list(size - 1)
            numsElement = 0
        End sub

        Function count()
            return numsElement
        End Function

        Function isEmpty() as Boolean
            return count() = 0
        End Function

        Function isFull() as Boolean
            return count() = capacity
        End Function

        public sub enQueue(ByVal item as Integer)
            if Not isFull()
                numsElement += 1
                list(count() - 1) = item
            End if
        End sub

        Function deQueue()
            if Not isEmpty()
                Dim temp as Integer = list(0)
                Dim q(capacity - 1) as Integer
                list.CopyTo(q, 0)
                ReDim list(capacity - 1)
                For i as Integer = 1 To capacity - 1
                    list(i - 1) = q(i)
                Next
                numsElement -= 1
                return temp
            End if
            return Nothing
        End Function

        Function peek()
            if Not isEmpty()
                return list(0)
            End if
            return Nothing
        End Function

        public sub printItems()
            For i as Integer = 0 To numsElement - 1
                Console.Write(list(i) & " ")
            Next
            Console.WriteLine()
        End sub
    
    End class

    public sub Main()
        Dim queue as New Queue(5)
        queue.enQueue(1)
        queue.enQueue(3)
        queue.enQueue(2)
        Console.WriteLine(queue.count())
        Console.WriteLine(queue.peek())
        queue.printItems()
        Console.WriteLine(queue.deQueue())
        Console.WriteLine(queue.peek())
        queue.printItems()

    End sub

End Module