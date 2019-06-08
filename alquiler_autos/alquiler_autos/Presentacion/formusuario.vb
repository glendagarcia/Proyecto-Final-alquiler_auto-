Public Class formusuario
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbhora.Text = TimeOfDay
    End Sub

    Private Sub formusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbhora.Text = TimeOfDay
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End

    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Try
            Dim dts As vusuario = New vusuario()
            Dim funcion As New usuario
            dts.glogin = txtusuario.Text
            dts.gpassword = txtcontraseña.Text

            If funcion.validar_usuario(dts) = True Then
                forminicio.Show()
                Me.Hide()
            Else
                MessageBox.Show("Ingrese nuevamente los datos")
                txtcontraseña.Clear()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
End Class