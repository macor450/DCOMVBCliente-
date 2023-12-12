Imports System

Namespace U4_DCOMCliente
    Module Program
        Sub Main()
            Try
                Dim servidorDCOM As New ServidorDCOM()
                Dim resultado As String = servidorDCOM.ObtenerSaludo("UsuarioDCOM")
                Console.WriteLine(resultado)
            Catch ex As Exception
                Console.WriteLine($"Error: {ex.Message}")
            End Try
            Console.ReadLine()
        End Sub
    End Module
End Namespace

