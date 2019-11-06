Imports System
Imports System.Collections

public Module module1
    public class Stack
		private list as New ArrayList()

        Function count()
            return list.Count
        End Function

        Function isEmpty() as Boolean
            return count() = 0
        End Function

        public sub push(ByVal item as Integer)
            list.Add(item)
        End sub

        Function peek()
            if Not isEmpty()
                return list.Item(count() - 1)
            End if
            return Nothing
        End Function

        Function pop()
            if Not isEmpty()
                Dim temp as Integer = list.Item(count() - 1)
                list.RemoveAt(count() - 1)
                return temp
            End if
            return Nothing
        End Function

        public sub clear()
            list.Clear()
        End sub

    End class
    
    public sub Main()
        Dim stack as New Stack()
        stack.push(1)
        stack.push(3)
        stack.push(2)
        Console.WriteLine(stack.peek())
        Console.WriteLine(stack.pop())
        Console.WriteLine(stack.peek())
    End sub

End Module