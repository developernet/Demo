Imports Demo3_BusEntity

Public Class BRTriangulo

    Public Function EsTriangulo(ByVal Triangulo As BETriangulo) As Boolean
        With Triangulo
            Return .Lado1 + .Lado2 > .Lado3 _
                AndAlso .Lado2 + .Lado3 > .Lado1 _
                AndAlso .Lado1 + .Lado3 > .Lado2
        End With
    End Function

    Public Function CalcularSP(Triangulo As BETriangulo) As Integer
        With Triangulo
            Return (.Lado1 + .Lado2 + .Lado3) / 2
        End With
    End Function

    Public Function CalcularArea(Triangulo As BETriangulo) As Integer
        With Triangulo
            Return Math.Sqrt(.SP * (.SP - .Lado1) * (.SP - .Lado2) * (.SP - .Lado3))
        End With
    End Function

End Class
