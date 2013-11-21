Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (txUser.Text.Trim.Equals("")) Then
            MsgBox("Debe insertar su nombre de usuario")
        ElseIf (txContra.Text.Trim.Equals("")) Then
            MsgBox("Debe insertar su contraseña")
        Else
            If (getUser(txUser.Text, txContra.Text).Tables("usuarios").Rows.Count = 0) Then
                MsgBox("Inserte un usuario y una contraseña correcta")
            Else
                'MsgBox(DsExistUser.Tables("usuarios").Rows(0).Item(0))
                Me.Visible = False
                SeleccionPerfiles.Show()
            End If
        End If

    End Sub

    Public Function getUser(ByVal user As String, ByVal contra As String) As DataSet
        DsExistUser = New dsExistUser
        DAExistUser.SelectCommand.Parameters("@user").Value = user
        DAExistUser.SelectCommand.Parameters("@contrasenia").Value = contra
        DAExistUser.Fill(DsExistUser, "usuarios")
        Return DsExistUser
    End Function

End Class
