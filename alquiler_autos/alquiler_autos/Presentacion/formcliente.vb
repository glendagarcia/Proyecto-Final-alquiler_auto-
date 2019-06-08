Imports System.ComponentModel

Public Class formcliente

    Private dt As New DataTable


    Private Sub formcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtapellido.Text = ""
        txtdui.Text = ""
        txtcelular.Text = ""
        txtidcliente.Text = ""
    End Sub



    Private Sub mostrar()
        Try
            Dim funcion As New Cliente
            dt = funcion.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else

                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnnuevo.Visible = True
        btneditar.Visible = False
        buscar()

    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub

    Private Sub txtidcliente_TextChanged(sender As Object, e As EventArgs) Handles txtidcliente.TextChanged

    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Por favor ingrese el nombre del cliente")

        End If

    End Sub


    Private Sub txtapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Por favor ingrese el apellido del cliente")

        End If
    End Sub


    Private Sub txtdui_Validating(sender As Object, e As CancelEventArgs) Handles txtdui.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Por favor ingrese el DUI del cliente")

        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdui.Text <> "" And txtcelular.Text <> "" Then
            Try
                Dim dts As New vcliente 
                Dim funcion As New Cliente
                dts.gnombre = txtnombre.Text
                dts.gapellido = txtapellido.Text
                dts.gdui = txtdui.Text
                dts.gcelular = txtcelular.Text
                If funcion.insertar(dts) Then
                    MessageBox.Show("Cliente registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Cliente no fue registrado correctamente", "Intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidcliente.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre.Text = datalistado.SelectedCells.Item(2).Value
        txtapellido.Text = datalistado.SelectedCells.Item(3).Value
        txtdui.Text = datalistado.SelectedCells.Item(4).Value
        txtcelular.Text = datalistado.SelectedCells.Item(5).Value
        btneditar.Visible = True
        btnguardar.Visible = False

    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Quiere editar los registros de los clientes?", "Modificando...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdui.Text <> "" And txtcelular.Text <> "" And txtidcliente.Text <> "" Then
                Try
                    Dim dts As New vcliente
                    Dim funcion As New Cliente
                    dts.gidcliente = txtidcliente.Text
                    dts.gnombre = txtnombre.Text
                    dts.gapellido = txtapellido.Text
                    dts.gdui = txtdui.Text
                    dts.gcelular = txtcelular.Text
                    If funcion.editar(dts) Then
                        MessageBox.Show("Cliente modificado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Cliente no fue modificado correctamente", "Intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        End If
    End Sub

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True

        Else
            datalistado.Columns.Item("Eliminar").Visible = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro de querer borrar los registros seleccionados", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_cliente").Value)
                        Dim vdb As New vcliente
                        Dim funcion As New Cliente
                        vdb.gidcliente = onekey
                        If funcion.eliminar(vdb) Then
                            MessageBox.Show("Cliente  fue eliminado", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()

        End If
        Call limpiar()


    End Sub

    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        If txtflag.Text = "1" Then
            fomralquiler.txtidcliente1.Text = datalistado.SelectedCells.Item(1).Value
            fomralquiler.txtcnombre.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub
End Class