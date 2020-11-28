Imports System
Imports System.Linq
Imports System.Collections.Generic

Namespace MyApp
    Module Application
        Sub Print(result as IEnumerable(Of Integer), query as String)
            Console.WriteLine("[QUERY] {0}", query)
            For Each i as Integer in result
                Console.WriteLine("[OUTPUT] {0}", i)
            Next
        End Sub
        Sub GreaterThan(values as List(Of Integer))
            Dim result as IEnumerable(Of Integer) = from v in values
                         where v > 1
                         select v

            Print(result, "SELECT * FROM values AS v WHERE v > 1")
        End Sub
        Sub LessThan(values as List(Of Integer))
            Dim result as IEnumerable(Of Integer) = from v in values
                         where v < 2
                         select v

            Print(result, "SELECT * FROM values AS v WHERE v < 2")
        End Sub
        Sub EqualTo(values as List(Of Integer))
            Dim result as IEnumerable(Of Integer) = from v in values
                         where v = 1
                         select v

            Print(result, "SELECT * FROM values AS v WHERE v = 1")
        End Sub
    	Sub Main()
            Dim list as New List(Of Integer)
            list.Add(0)
            list.Add(1)
            list.Add(2)
    		Console.WriteLine("[INPUT] {0}", String.Join(", ", list.ToArray()))

            GreaterThan(list)
            LessThan(list)
            EqualTo(list)
    	End Sub
    End Module
End Namespace
