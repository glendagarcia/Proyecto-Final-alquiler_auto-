Imports System.ComponentModel

Public Class fomralquiler

    Private dt As New DataTable

    Private Sub fomralquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim funcion As New Cliente
            dt = funcion.mostrar


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar3.Enabled = True
                inexistente3.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnnuevo1.Visible = True
        buscar()
    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbocampo3.Text & " like '" & txtbuscar3.Text & "%'"

            If dv.Count <> 0 Then
                inexistente3.Visible = False
                datalistado.DataSource = dv

            Else
                inexistente3.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtidcliente1_TextChanged(sender As Object, e As EventArgs) Handles txtidcliente1.TextChanged

    End Sub

    Private Sub txtidcliente1_Validating(sender As Object, e As CancelEventArgs) Handles txtidcliente1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono1.SetError(sender, "")
        Else
            Me.ErrorIcono1.SetError(sender, "Por favor ingrese el ID del cliente")

        End If
    End Sub

    Private Sub txtidflota_TextChanged(sender As Object, e As EventArgs) Handles txtidflota.TextChanged

    End Sub

    Private Sub txtidflota_Validating(sender As Object, e As CancelEventArgs) Handles txtidflota.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono1.SetError(sender, "")
        Else
            Me.ErrorIcono1.SetError(sender, "Por favor ingrese el ID del auto")

        End If
    End Sub

    Private Sub txtidsucursal_TextChanged(sender As Object, e As EventArgs) Handles txtidsucursal.TextChanged

    End Sub

    Private Sub txtidsucursal_Validating(sender As Object, e As CancelEventArgs) Handles txtidsucursal.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono1.SetError(sender, "")
        Else
            Me.ErrorIcono1.SetError(sender, "Por favor ingrese el ID de la sucursal")

        End If

    End Sub

    Private Sub txtsalida_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsalida_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono1.SetError(sender, "")
        Else
            Me.ErrorIcono1.SetError(sender, "Por favor ingrese la fecha que se está rentando el auto, es un dato obligatorio")

        End If
    End Sub

    Private Sub txtentrada_TextChanged(sender As Object, e As EventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono1.SetError(sender, "")
        Else
            Me.ErrorIcono1.SetError(sender, "Por favor ingrese la fecha en se devolverá el auto,es un dato obligatorio")

        End If

    End Sub

    Private Sub btnnuevo1_Click(sender As Object, e As EventArgs) Handles btnnuevo1.Click
        mostrar()
    End Sub

    Private Sub btnguardar1_Click(sender As Object, e As EventArgs) Handles btnguardar1.Click
        If Me.ValidateChildren = True And txtidcliente1.Text <> "" And txtidflota.Text <> "" And txtidsucursal.Text <> "" And txtsalida.Text <> "" And txtentrada.Text <> "" Then
            Try
                Dim dts As valquiler = New valquiler(txtidalquiler.Text, txtidcliente1.Text, txtidflota.Text, txtidsucursal.Text, txtsalida.Text, txtentrada.Text)
                Dim funcion As New Alquiler
                dts.gidalquiler = txtidalquiler.Text
                dts.gidcliente = txtidcliente1.Text
                dts.gidflota = txtidflota.Text
                dts.gidsucursal = txtidsucursal.Text
                dts.gsalida = txtsalida.Text
                dts.gentrada = txtentrada.Text
                If funcion.insertar(dts) Then
                    MessageBox.Show("Alquiler registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                Else
                    MessageBox.Show("El alquiler no fue registrado correctamente", "Intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnbuscarcliente_Click(sender As Object, e As EventArgs) Handles btnbuscarcliente.Click
        formcliente.txtflag.Text = "1"
        formcliente.ShowDialog()


    End Sub

    Private Sub txtauto_TextChanged(sender As Object, e As EventArgs) Handles txtauto.TextChanged
        formflota.txtflag1.Text = "1"
        formflota.ShowDialog()
    End Sub

    Private Sub btnbuscarsucursal_Click(sender As Object, e As EventArgs) Handles btnbuscarsucursal.Click
        formsucursal.txtflag2.Text = "1"
        formsucursal.ShowDialog()
    End Sub
End Class