Imports System.ComponentModel
Public Class formsucursal
    Private dt As New DataTable
    Private Sub formsucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim funcion As New Sucursal
            dt = funcion.mostrar


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar2.Enabled = True
                inexistente2.Visible = False
            Else

                datalistado.DataSource = Nothing
                txtbuscar2.Enabled = False
                inexistente2.Visible = True

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

            dv.RowFilter = cbocampo2.Text & " like '" & txtbuscar2.Text & "%'"

            If dv.Count <> 0 Then
                inexistente2.Visible = False
                datalistado.DataSource = dv

            Else
                inexistente2.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub

    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        If txtflag2.Text = "1" Then
            fomralquiler.txtidsucursal.Text = datalistado.SelectedCells.Item(1).Value
            fomralquiler.txtnsucursal.Text = datalistado.SelectedCells.Item(2).Value
        End If
        Me.Close()
    End Sub
End Class