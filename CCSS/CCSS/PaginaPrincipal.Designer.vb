<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaginaPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.Conn = New System.Data.SqlClient.SqlConnection()
        Me.updateContra = New System.Data.SqlClient.SqlCommand()
        Me.SuspendLayout()
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(565, 12)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(128, 38)
        Me.btnInfo.TabIndex = 0
        Me.btnInfo.Text = "Información del Usuario"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'Conn
        '
        Me.Conn.ConnectionString = "Data Source=fransysteml;Initial Catalog=CCSS;Integrated Security=True"
        Me.Conn.FireInfoMessageEventOnUserErrors = False
        '
        'updateContra
        '
        Me.updateContra.CommandText = "UPDATE       usuarios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET                contrasenia = @contra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (no" & _
    "mbreUsuario = @user)"
        Me.updateContra.Connection = Me.Conn
        Me.updateContra.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@contra", System.Data.SqlDbType.VarChar, 255, "contrasenia"), New System.Data.SqlClient.SqlParameter("@user", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreUsuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'PaginaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 468)
        Me.Controls.Add(Me.btnInfo)
        Me.Name = "PaginaPrincipal"
        Me.Text = "Pagina Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents Conn As System.Data.SqlClient.SqlConnection
    Friend WithEvents updateContra As System.Data.SqlClient.SqlCommand
End Class
