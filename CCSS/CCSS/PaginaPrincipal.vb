Public Class PaginaPrincipal

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        CambioContrasena.ShowDialog()
    End Sub

    Public Function ModificarContra(ByVal contra As String) As String
        updateContra.Parameters("@user").Value = Form1.DsExistUser.Tables("usuarios").Rows(0).Item(0)
        updateContra.Parameters("@contra").Value = contra
        Try
            Conn.Open()
            updateContra.ExecuteNonQuery()
            Return "0"
        Catch exsql As SqlClient.SqlException
            Return exsql.ToString
        Catch ex As Exception
            Return ex.Message
        Finally
            Conn.Close()
        End Try
    End Function

End Class