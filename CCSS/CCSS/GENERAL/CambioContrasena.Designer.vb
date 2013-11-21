<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioContrasena
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txContraActu = New System.Windows.Forms.TextBox()
        Me.txContraNu = New System.Windows.Forms.TextBox()
        Me.txContraNuRep = New System.Windows.Forms.TextBox()
        Me.btnCamb = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese su contraseña actual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese su nueva contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repita la nueva contraseña"
        '
        'txContraActu
        '
        Me.txContraActu.Location = New System.Drawing.Point(226, 26)
        Me.txContraActu.Name = "txContraActu"
        Me.txContraActu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txContraActu.Size = New System.Drawing.Size(120, 20)
        Me.txContraActu.TabIndex = 3
        '
        'txContraNu
        '
        Me.txContraNu.Location = New System.Drawing.Point(226, 85)
        Me.txContraNu.Name = "txContraNu"
        Me.txContraNu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txContraNu.Size = New System.Drawing.Size(120, 20)
        Me.txContraNu.TabIndex = 4
        '
        'txContraNuRep
        '
        Me.txContraNuRep.Location = New System.Drawing.Point(226, 145)
        Me.txContraNuRep.Name = "txContraNuRep"
        Me.txContraNuRep.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txContraNuRep.Size = New System.Drawing.Size(120, 20)
        Me.txContraNuRep.TabIndex = 5
        '
        'btnCamb
        '
        Me.btnCamb.Location = New System.Drawing.Point(141, 199)
        Me.btnCamb.Name = "btnCamb"
        Me.btnCamb.Size = New System.Drawing.Size(123, 35)
        Me.btnCamb.TabIndex = 6
        Me.btnCamb.Text = "Cambiar Contraseña"
        Me.btnCamb.UseVisualStyleBackColor = True
        '
        'CambioContrasena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 246)
        Me.Controls.Add(Me.btnCamb)
        Me.Controls.Add(Me.txContraNuRep)
        Me.Controls.Add(Me.txContraNu)
        Me.Controls.Add(Me.txContraActu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CambioContrasena"
        Me.Text = "CambioContrasena"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txContraActu As System.Windows.Forms.TextBox
    Friend WithEvents txContraNu As System.Windows.Forms.TextBox
    Friend WithEvents txContraNuRep As System.Windows.Forms.TextBox
    Friend WithEvents btnCamb As System.Windows.Forms.Button
End Class
