Public Class Form1
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim l1, l2, l3 As Integer
        Dim result As String

        l1 = Val(tbLado1.Text)
        l2 = Val(tbLado2.Text)
        l3 = Val(tbLado3.Text)

        If (l1 = 0 Or l2 = 0 Or l3 = 0 Or l1 < 0 Or l2 < 0 Or l3 < 0) Then
            MsgBox("Por favor verifique los datos ingresados")

        Else
            If (l1 > l2 And l1 > l3 Or l2 > l1 And l2 > l3 Or l3 > l1 And l3 > l2) Then
                result = "SI ES RECTANGULO"
            Else
                result = "NO ES RECTANGULO"
            End If
            lbResult.Text = result

        End If



    End Sub
End Class
