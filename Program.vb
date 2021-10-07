Imports System

Module Program
    Sub Main()
        Dim scelta As String = "Si"
        While scelta = "Si" Or scelta = "SI" Or scelta = "si"
            Console.Clear()
            Dim settimana(7) As String
        settimana(0) = "Lunedì"
        settimana(1) = "Martedì"
        settimana(2) = "Mercoledì"
        settimana(3) = "Giovedì"
        settimana(4) = "Venerdì"
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
