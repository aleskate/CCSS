<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txUser = New System.Windows.Forms.TextBox()
        Me.txContra = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Conn = New System.Data.SqlClient.SqlConnection()
        Me.DAExistUser = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsExistUser = New CCSS.dsExistUser()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DsExistUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'txUser
        '
        Me.txUser.Location = New System.Drawing.Point(149, 72)
        Me.txUser.Name = "txUser"
        Me.txUser.Size = New System.Drawing.Size(100, 20)
        Me.txUser.TabIndex = 2
        '
        'txContra
        '
        Me.txContra.Location = New System.Drawing.Point(149, 154)
        Me.txContra.Name = "txContra"
        Me.txContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txContra.Size = New System.Drawing.Size(100, 20)
        Me.txContra.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(131, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "dbo.existUser"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.Conn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@user", System.Data.SqlDbType.NVarChar, 255), New System.Data.SqlClient.SqlParameter("@contrasenia", System.Data.SqlDbType.NVarChar, 255)})
        '
        'Conn
        '
        Me.Conn.ConnectionString = "Data Source=fransysteml;Initial Catalog=CCSS;Integrated Security=True"
        Me.Conn.FireInfoMessageEventOnUserErrors = False
        '
        'DAExistUser
        '
        Me.DAExistUser.SelectCommand = Me.SqlSelectCommand1
        Me.DAExistUser.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "existUser", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nombreUsuario", "nombreUsuario"), New System.Data.Common.DataColumnMapping("centrosMedicos_codigo", "centrosMedicos_codigo"), New System.Data.Common.DataColumnMapping("contrasenia", "contrasenia"), New System.Data.Common.DataColumnMapping("estado", "estado"), New System.Data.Common.DataColumnMapping("identificacion", "identificacion"), New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("primerApellido", "primerApellido"), New System.Data.Common.DataColumnMapping("segundoApellido", "segundoApellido"), New System.Data.Common.DataColumnMapping("tipoIdentificacion", "tipoIdentificacion")})})
        '
        'DsExistUser
        '
        Me.DsExistUser.DataSetName = "dsExistUser"
        Me.DsExistUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(55, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 293)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txContra)
        Me.Controls.Add(Me.txUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Autentificación del Usuario"
        CType(Me.DsExistUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txUser As System.Windows.Forms.TextBox
    Friend WithEvents txContra As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAExistUser As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsExistUser As CCSS.dsExistUser
    Friend WithEvents Conn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
