Imports System.ComponentModel

Public Class formflota
    Private dt As New DataTable
    Private Sub formflota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim funcion As New Flota
            dt = funcion.mostrar


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar1.Enabled = True
                inexistente1.Visible = False
            Else

                datalistado.DataSource = Nothing
                txtbuscar1.Enabled = False
                inexistente1.Visible = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        buscar()
    End Sub
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbocampo1.Text & " like '" & txtbuscar1.Text & "%'"

            If dv.Count <> 0 Then
                inexistente1.Visible = False
                datalistado.DataSource = dv

            Else
                inexistente1.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        If txtflag1.Text = "1" Then
            fomralquiler.txtidflota.Text = datalistado.SelectedCells.Item(1).Value
            fomralquiler.txtauto.Text = datalistado.SelectedCells.Item(2).Value
        End If
        Me.Close()
    End Sub
End Class