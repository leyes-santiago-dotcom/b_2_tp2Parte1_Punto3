Public Class Form1
    '2. Escribir un algoritmo que muestre los números pares desde 2 hasta el 100 inclusive.
    Dim Pares As Integer
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        For Pares = 2 To 100 Step 2
            lblMuestra.Text = "los pares entre 2-100 son: " & Pares
        Next
    End Sub
End Class
