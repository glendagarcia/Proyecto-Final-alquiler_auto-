Imports System.Data.SqlClient

Public Class Alquiler
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_alquiler")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function insertar(ByVal dts As valquiler) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_alquiler")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@id_cliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@id_flota", dts.gidflota)
            cmd.Parameters.AddWithValue("@id_sucursal", dts.gidsucursal)
            cmd.Parameters.AddWithValue("@fecha_salida", dts.gsalida)
            cmd.Parameters.AddWithValue("@fecha_entrada", dts.gentrada)

            If cmd.ExecuteNonQuery Then
                Return True
            Else

                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try
    End Function

End Class
