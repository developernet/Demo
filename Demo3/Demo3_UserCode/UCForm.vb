Imports System.Windows.Forms

Public Class UCForm

    Public Sub LimpiarFormulario(Container As Object)
        For Each Ctrl As Control In Container.Controls
            If TypeOf Ctrl Is TextBox Then Ctrl.Text = String.Empty
            If TypeOf Ctrl Is NumericUpDown Then CType(Ctrl, NumericUpDown).Value = 0
            If TypeOf Ctrl Is CheckBox Then CType(Ctrl, CheckBox).Checked = False
        Next
    End Sub

End Class
