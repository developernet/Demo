Imports Demo3_BusEntity
Imports System.IO
Imports System.Text

Public Class DATriangulo

    Public Sub GrabarDatos(Triangulo As BETriangulo)

        Using sw As New StreamWriter("Triangulo.txt", True)
            With Triangulo
                Dim sb As New StringBuilder(.Lado1.ToString())
                sb.Append(",")
                sb.Append(.Lado2)
                sb.Append(",")
                sb.Append(.Lado3)
                sb.Append(",")
                sb.Append(.SP)
                sb.Append(",")
                sb.Append(.Area)

                sw.WriteLine(sb.ToString())
            End With
        End Using
    End Sub

End Class
