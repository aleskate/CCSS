Public Class CambioContrasena

    Private Sub btnCamb_Click(sender As Object, e As EventArgs) Handles btnCamb.Click
        If (txContraActu.Text.Trim.Equals("") Or Not (txContraActu.Text.Trim.Equals(Login.DsExistUser.Tables("usuarios").Rows(0).Item(1)))) Then
            MsgBox("Contraseña Incorrecta")
        ElseIf (txContraNu.Text.Trim.Equals("")) Then
            MsgBox("Debe insertar su nueva contraseña")
        ElseIf (txContraNuRep.Text.Trim.Equals("") Or txContraNuRep.Text.Trim <> txContraNu.Text.Trim) Then
            MsgBox("Las contraseñas no coinciden")
        Else
            PaginaPrincipal.ModificarContra(txContraNu.Text)
            Login.getUser(Login.DsExistUser.Tables("usuarios").Rows(0).Item(0), txContraNu.Text.Trim)
            MsgBox("La contraseña fue cambiada exitosamente")
            txContraActu.Text = txContraNu.Text = txContraNuRep.Text = ""
            Me.Dispose()
        End If
    End Sub
End Class