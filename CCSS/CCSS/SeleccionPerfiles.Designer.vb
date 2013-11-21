<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionPerfiles
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPerfil = New System.Windows.Forms.ComboBox()
        Me.btnIng = New System.Windows.Forms.Button()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Conn = New System.Data.SqlClient.SqlConnection()
        Me.DAGetPerfiles = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsPerfiles = New CCSS.DSPerfiles()
        Me.vacio = New System.Windows.Forms.Label()
        Me.DsPerfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetPerfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DsPerfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPerfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetPerfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione el perfil que desea utilizar"
        '
        'cbPerfil
        '
        Me.cbPerfil.FormattingEnabled = True
        Me.cbPerfil.Location = New System.Drawing.Point(203, 112)
        Me.cbPerfil.Name = "cbPerfil"
        Me.cbPerfil.Size = New System.Drawing.Size(249, 21)
        Me.cbPerfil.TabIndex = 1
        '
        'btnIng
        '
        Me.btnIng.Location = New System.Drawing.Point(175, 225)
        Me.btnIng.Name = "btnIng"
        Me.btnIng.Size = New System.Drawing.Size(124, 23)
        Me.btnIng.TabIndex = 2
        Me.btnIng.Text = "Ingresar al Sistema"
        Me.btnIng.UseVisualStyleBackColor = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "dbo.getPerfiles"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.Conn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@user", System.Data.SqlDbType.NVarChar, 255)})
        '
        'Conn
        '
        Me.Conn.ConnectionString = "Data Source=fransysteml;Initial Catalog=CCSS;Integrated Security=True"
        Me.Conn.FireInfoMessageEventOnUserErrors = False
        '
        'DAGetPerfiles
        '
        Me.DAGetPerfiles.SelectCommand = Me.SqlSelectCommand1
        Me.DAGetPerfiles.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "getPerfiles", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("idPerfil", "idPerfil"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        '
        'DsPerfiles
        '
        Me.DsPerfiles.DataSetName = "DSPerfiles"
        Me.DsPerfiles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vacio
        '
        Me.vacio.AutoSize = True
        Me.vacio.ForeColor = System.Drawing.Color.OrangeRed
        Me.vacio.Location = New System.Drawing.Point(203, 159)
        Me.vacio.Name = "vacio"
        Me.vacio.Size = New System.Drawing.Size(0, 13)
        Me.vacio.TabIndex = 3
        '
        'DsPerfilesBindingSource
        '
        Me.DsPerfilesBindingSource.DataSource = Me.DsPerfiles
        Me.DsPerfilesBindingSource.Position = 0
        '
        'GetPerfilesBindingSource
        '
        Me.GetPerfilesBindingSource.DataMember = "getPerfiles"
        Me.GetPerfilesBindingSource.DataSource = Me.DsPerfilesBindingSource
        '
        'SeleccionPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 282)
        Me.Controls.Add(Me.vacio)
        Me.Controls.Add(Me.btnIng)
        Me.Controls.Add(Me.cbPerfil)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SeleccionPerfiles"
        Me.Text = "Seleccion Perfil"
        CType(Me.DsPerfiles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPerfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetPerfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents btnIng As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Conn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAGetPerfiles As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsPerfiles As CCSS.DSPerfiles
    Friend WithEvents vacio As System.Windows.Forms.Label
    Friend WithEvents DsPerfilesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GetPerfilesBindingSource As System.Windows.Forms.BindingSource
End Class
