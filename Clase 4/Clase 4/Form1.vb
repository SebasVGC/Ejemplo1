Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim nombre As String

        nombre = txtNombre.Text
        If (nombre = "") Then
            MsgBox("No se admiten cadenas vacias")
        Else
            listaEmpleado.Items.Add(nombre)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cantidadTotal As Integer = 0

        For Each empleado In listaEmpleado.Items

            cantidadTotal = cantidadTotal + 1
        Next

        MsgBox("Cantidad total: " + cantidadTotal.ToString)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim cantidadTotalA As Integer = 0

        For Each empleado In listaEmpleado.Items
            Dim primeraLetra As String = Mid(empleado, 1, 1)

            If (primeraLetra = "A") Then
                cantidadTotalA = cantidadTotalA + 1
            End If
        Next
        MsgBox("Cantidad A: " + cantidadTotalA.ToString)
    End Sub
End Class
