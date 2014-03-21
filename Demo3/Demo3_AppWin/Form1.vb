Imports Demo3_BusEntity
Imports Demo3_BusRules
Imports Demo3_DataAccess

Public Class Form1

    Private Sub Calcular(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oBETriangulo As New BETriangulo

        With oBETriangulo
            .Lado1 = 5
            .Lado2 = 7
            .Lado3 = 8
            .Autor = "RONALD NOE SAAVEDRA BANCES - DEVELOPER NET"
        End With

        Dim oBRTriangulo As New BRTriangulo

        If oBRTriangulo.EsTriangulo(oBETriangulo) Then
            oBETriangulo.SP = oBRTriangulo.CalcularSP(oBETriangulo)
            oBETriangulo.Area = oBRTriangulo.CalcularArea(oBETriangulo)

            Dim oDATriangulo As New DATriangulo
            oDATriangulo.GrabarDatos(oBETriangulo)
        End If

    End Sub

End Class
