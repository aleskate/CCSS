Public Class SeleccionPerfiles

    Private Sub SeleccionPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ds = getPerfiles(Login.DsExistUser.Tables("usuarios").Rows(0).Item(0))
        If (ds.Tables("perfiles").Rows.Count = 0) Then
            cbPerfil.Enabled = False
            vacio.Text = "NO CUENTA CON NINGÚN PERFIL ASOCIADO"
            btnIng.Enabled = False
        Else
            cbPerfil.DataSource = ds.Tables("perfiles")
            cbPerfil.DisplayMember = "nombre"
            cbPerfil.ValueMember = "idPerfil"
        End If
    End Sub

    Private Function getPerfiles(ByVal user As String) As DataSet
        DsPerfiles = New DSPerfiles
        DAGetPerfiles.SelectCommand.Parameters("@user").Value = user
        DAGetPerfiles.Fill(DsPerfiles, "perfiles")
        Return DsPerfiles
    End Function

    Private Sub btnIng_Click(sender As Object, e As EventArgs) Handles btnIng.Click
        Me.Visible = False
        PaginaPrincipal.Show()
    End Sub
End Class