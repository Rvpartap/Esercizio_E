Imports System

Module Program
    Sub Main()
        Dim scelta As String = "Si"
        While scelta = "Si" Or scelta = "SI" Or scelta = "si"
            Console.Clear()
            Dim settimana(7) As String
        settimana(0) = "Luned�"
        settimana(1) = "Marted�"
        settimana(2) = "Mercoled�"
        settimana(3) = "Gioved�"
        settimana(4) = "Venerd�"
        settimana(5) = "Sabato"
        settimana(6) = "Domenica"
        For i = 0 To 6
            Console.WriteLine(settimana(i))
        Next
            Console.ReadLine()
            Console.WriteLine("Vuoi Continuare? Si o No?")
            scelta = Console.ReadLine()
        End While
    End Sub
End Module
