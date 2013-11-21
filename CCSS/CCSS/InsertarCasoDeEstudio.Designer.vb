<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertarCasoDeEstudio
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbTipoAc = New System.Windows.Forms.ComboBox()
        Me.cbtipoide = New System.Windows.Forms.ComboBox()
        Me.txcedu = New System.Windows.Forms.TextBox()
        Me.txnombre = New System.Windows.Forms.TextBox()
        Me.cbase = New System.Windows.Forms.ComboBox()
        Me.cbest = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtel = New System.Windows.Forms.MaskedTextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txocup = New System.Windows.Forms.TextBox()
        Me.cbtel = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.fechamue = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txsenas = New System.Windows.Forms.TextBox()
        Me.txdistrito = New System.Windows.Forms.TextBox()
        Me.txcanton = New System.Windows.Forms.TextBox()
        Me.cbprovi = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbfalle = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.chasegu = New System.Windows.Forms.CheckBox()
        Me.txatendes = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.dtfin = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dtinicio = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbmedi = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Conn = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.DAaseguradora = New System.Data.SqlClient.SqlDataAdapter()
        Me.Dsaseguradora = New CCSS.dsaseguradora()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.damedicos = New System.Data.SqlClient.SqlDataAdapter()
        Me.Dsmedicos = New CCSS.dsmedicos()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dtfechaacci = New System.Windows.Forms.DateTimePicker()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.desacci = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.direxataacci = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txdesauto = New System.Windows.Forms.TextBox()
        Me.txplaca = New System.Windows.Forms.TextBox()
        Me.txnompropie = New System.Windows.Forms.TextBox()
        Me.txidpropi = New System.Windows.Forms.TextBox()
        Me.txidconduc = New System.Windows.Forms.TextBox()
        Me.txnomcond = New System.Windows.Forms.TextBox()
        Me.txparte = New System.Windows.Forms.TextBox()
        Me.cbtipoidePropie = New System.Windows.Forms.ComboBox()
        Me.cbtipoidconduc = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Dsaseguradora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsmedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estudio de Accidentes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Datos del Caso de Estudio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo de Accidente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de Identificación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(489, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Aseguradora"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(113, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Número de Identificación"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(489, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Estado"
        '
        'cbTipoAc
        '
        Me.cbTipoAc.FormattingEnabled = True
        Me.cbTipoAc.Location = New System.Drawing.Point(247, 135)
        Me.cbTipoAc.Name = "cbTipoAc"
        Me.cbTipoAc.Size = New System.Drawing.Size(162, 21)
        Me.cbTipoAc.TabIndex = 8
        '
        'cbtipoide
        '
        Me.cbtipoide.FormattingEnabled = True
        Me.cbtipoide.Location = New System.Drawing.Point(247, 175)
        Me.cbtipoide.Name = "cbtipoide"
        Me.cbtipoide.Size = New System.Drawing.Size(162, 21)
        Me.cbtipoide.TabIndex = 9
        '
        'txcedu
        '
        Me.txcedu.Location = New System.Drawing.Point(247, 212)
        Me.txcedu.Name = "txcedu"
        Me.txcedu.Size = New System.Drawing.Size(162, 20)
        Me.txcedu.TabIndex = 10
        '
        'txnombre
        '
        Me.txnombre.Location = New System.Drawing.Point(247, 248)
        Me.txnombre.Name = "txnombre"
        Me.txnombre.Size = New System.Drawing.Size(162, 20)
        Me.txnombre.TabIndex = 11
        '
        'cbase
        '
        Me.cbase.FormattingEnabled = True
        Me.cbase.Location = New System.Drawing.Point(571, 127)
        Me.cbase.Name = "cbase"
        Me.cbase.Size = New System.Drawing.Size(162, 21)
        Me.cbase.TabIndex = 12
        '
        'cbest
        '
        Me.cbest.FormattingEnabled = True
        Me.cbest.Location = New System.Drawing.Point(571, 174)
        Me.cbest.Name = "cbest"
        Me.cbest.Size = New System.Drawing.Size(162, 21)
        Me.cbest.TabIndex = 13
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 290)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(766, 332)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtel)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.txocup)
        Me.TabPage1.Controls.Add(Me.cbtel)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.fechamue)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txsenas)
        Me.TabPage1.Controls.Add(Me.txdistrito)
        Me.TabPage1.Controls.Add(Me.txcanton)
        Me.TabPage1.Controls.Add(Me.cbprovi)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.cbfalle)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(758, 306)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Demográficos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtel
        '
        Me.txtel.Location = New System.Drawing.Point(513, 156)
        Me.txtel.Mask = "00000000"
        Me.txtel.Name = "txtel"
        Me.txtel.Size = New System.Drawing.Size(144, 20)
        Me.txtel.TabIndex = 24
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(23, 261)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(118, 13)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "* = Campos Requeridos"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(365, 208)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(11, 13)
        Me.Label23.TabIndex = 23
        Me.Label23.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(723, 194)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 13)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(287, 151)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(11, 13)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(287, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 13)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(287, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "*"
        '
        'txocup
        '
        Me.txocup.Location = New System.Drawing.Point(513, 191)
        Me.txocup.Multiline = True
        Me.txocup.Name = "txocup"
        Me.txocup.Size = New System.Drawing.Size(204, 61)
        Me.txocup.TabIndex = 18
        '
        'cbtel
        '
        Me.cbtel.FormattingEnabled = True
        Me.cbtel.Location = New System.Drawing.Point(513, 123)
        Me.cbtel.Name = "cbtel"
        Me.cbtel.Size = New System.Drawing.Size(144, 21)
        Me.cbtel.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(404, 191)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Ocupación"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(404, 156)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Teléfono"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(404, 123)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Tipo de Teléfono"
        '
        'fechamue
        '
        Me.fechamue.Location = New System.Drawing.Point(513, 48)
        Me.fechamue.Name = "fechamue"
        Me.fechamue.Size = New System.Drawing.Size(204, 20)
        Me.fechamue.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(404, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Fecha Defunción"
        '
        'txsenas
        '
        Me.txsenas.Location = New System.Drawing.Point(159, 191)
        Me.txsenas.Multiline = True
        Me.txsenas.Name = "txsenas"
        Me.txsenas.Size = New System.Drawing.Size(200, 61)
        Me.txsenas.TabIndex = 10
        '
        'txdistrito
        '
        Me.txdistrito.Location = New System.Drawing.Point(159, 148)
        Me.txdistrito.Name = "txdistrito"
        Me.txdistrito.Size = New System.Drawing.Size(121, 20)
        Me.txdistrito.TabIndex = 9
        '
        'txcanton
        '
        Me.txcanton.Location = New System.Drawing.Point(159, 116)
        Me.txcanton.Name = "txcanton"
        Me.txcanton.Size = New System.Drawing.Size(121, 20)
        Me.txcanton.TabIndex = 8
        '
        'cbprovi
        '
        Me.cbprovi.FormattingEnabled = True
        Me.cbprovi.Location = New System.Drawing.Point(159, 83)
        Me.cbprovi.Name = "cbprovi"
        Me.cbprovi.Size = New System.Drawing.Size(121, 21)
        Me.cbprovi.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 191)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Otras Señas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Distrito"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Cantón"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Provincia"
        '
        'cbfalle
        '
        Me.cbfalle.FormattingEnabled = True
        Me.cbfalle.Location = New System.Drawing.Point(159, 45)
        Me.cbfalle.Name = "cbfalle"
        Me.cbfalle.Size = New System.Drawing.Size(74, 21)
        Me.cbfalle.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Fallecido"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Información del Paciente"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label35)
        Me.TabPage2.Controls.Add(Me.Label34)
        Me.TabPage2.Controls.Add(Me.Label33)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.chasegu)
        Me.TabPage2.Controls.Add(Me.txatendes)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.dtfin)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.dtinicio)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.cbmedi)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(758, 306)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos Atención Medica"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Red
        Me.Label35.Location = New System.Drawing.Point(539, 214)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(14, 13)
        Me.Label35.TabIndex = 26
        Me.Label35.Text = "* "
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.Red
        Me.Label34.Location = New System.Drawing.Point(487, 151)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(14, 13)
        Me.Label34.TabIndex = 25
        Me.Label34.Text = "* "
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.Red
        Me.Label33.Location = New System.Drawing.Point(487, 97)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(14, 13)
        Me.Label33.TabIndex = 24
        Me.Label33.Text = "* "
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Red
        Me.Label31.Location = New System.Drawing.Point(487, 48)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(14, 13)
        Me.Label31.TabIndex = 22
        Me.Label31.Text = "* "
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(6, 255)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(118, 13)
        Me.Label30.TabIndex = 21
        Me.Label30.Text = "* = Campos Requeridos"
        '
        'chasegu
        '
        Me.chasegu.AutoSize = True
        Me.chasegu.Location = New System.Drawing.Point(542, 42)
        Me.chasegu.Name = "chasegu"
        Me.chasegu.Size = New System.Drawing.Size(77, 17)
        Me.chasegu.TabIndex = 10
        Me.chasegu.Text = "Asegurado"
        Me.chasegu.UseVisualStyleBackColor = True
        '
        'txatendes
        '
        Me.txatendes.Location = New System.Drawing.Point(269, 191)
        Me.txatendes.Multiline = True
        Me.txatendes.Name = "txatendes"
        Me.txatendes.Size = New System.Drawing.Size(255, 57)
        Me.txatendes.TabIndex = 9
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(39, 198)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(123, 13)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Descripción de Lesiones"
        '
        'dtfin
        '
        Me.dtfin.Location = New System.Drawing.Point(269, 144)
        Me.dtfin.Name = "dtfin"
        Me.dtfin.Size = New System.Drawing.Size(200, 20)
        Me.dtfin.TabIndex = 7
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(39, 151)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(168, 13)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "Fecha Fin Prestación de Servicios"
        '
        'dtinicio
        '
        Me.dtinicio.Location = New System.Drawing.Point(269, 90)
        Me.dtinicio.Name = "dtinicio"
        Me.dtinicio.Size = New System.Drawing.Size(200, 20)
        Me.dtinicio.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(39, 90)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(179, 13)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Fecha Inicio Prestación de Servicios"
        '
        'cbmedi
        '
        Me.cbmedi.FormattingEnabled = True
        Me.cbmedi.Location = New System.Drawing.Point(269, 40)
        Me.cbmedi.Name = "cbmedi"
        Me.cbmedi.Size = New System.Drawing.Size(200, 21)
        Me.cbmedi.TabIndex = 3
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(39, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Médico"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(758, 306)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Datos Accidente"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.Label40)
        Me.Panel1.Controls.Add(Me.Label39)
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.direxataacci)
        Me.Panel1.Controls.Add(Me.Label37)
        Me.Panel1.Controls.Add(Me.desacci)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.dtfechaacci)
        Me.Panel1.Controls.Add(Me.Label32)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Location = New System.Drawing.Point(3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 265)
        Me.Panel1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(758, 277)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Datos Patrono"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(758, 277)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Datos Resolución"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Conn
        '
        Me.Conn.ConnectionString = "Data Source=fransysteml;Initial Catalog=CCSS;Integrated Security=True"
        Me.Conn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "dbo.getAseguradora"
        Me.SqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand1.Connection = Me.Conn
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing)})
        '
        'DAaseguradora
        '
        Me.DAaseguradora.SelectCommand = Me.SqlSelectCommand1
        Me.DAaseguradora.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "getAseguradora", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("numeroPatronal", "numeroPatronal"), New System.Data.Common.DataColumnMapping("razonSocial", "razonSocial")})})
        '
        'Dsaseguradora
        '
        Me.Dsaseguradora.DataSetName = "dsaseguradora"
        Me.Dsaseguradora.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "dbo.getMedicos"
        Me.SqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand2.Connection = Me.Conn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing)})
        '
        'damedicos
        '
        Me.damedicos.SelectCommand = Me.SqlSelectCommand2
        Me.damedicos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "getMedicos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("nombre", "nombre"), New System.Data.Common.DataColumnMapping("codigo", "codigo")})})
        '
        'Dsmedicos
        '
        Me.Dsmedicos.DataSetName = "dsmedicos"
        Me.Dsmedicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(26, 13)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Datos Accidente"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(35, 42)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(103, 13)
        Me.Label32.TabIndex = 1
        Me.Label32.Text = "Fecha de Accidente"
        '
        'dtfechaacci
        '
        Me.dtfechaacci.Location = New System.Drawing.Point(260, 35)
        Me.dtfechaacci.Name = "dtfechaacci"
        Me.dtfechaacci.Size = New System.Drawing.Size(200, 20)
        Me.dtfechaacci.TabIndex = 2
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(35, 83)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(179, 13)
        Me.Label36.TabIndex = 3
        Me.Label36.Text = "Descripción Detallada del Accidente"
        '
        'desacci
        '
        Me.desacci.Location = New System.Drawing.Point(260, 75)
        Me.desacci.Multiline = True
        Me.desacci.Name = "desacci"
        Me.desacci.Size = New System.Drawing.Size(325, 90)
        Me.desacci.TabIndex = 4
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(40, 177)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(88, 13)
        Me.Label37.TabIndex = 5
        Me.Label37.Text = "Dirección Exacta"
        '
        'direxataacci
        '
        Me.direxataacci.Location = New System.Drawing.Point(260, 171)
        Me.direxataacci.Multiline = True
        Me.direxataacci.Name = "direxataacci"
        Me.direxataacci.Size = New System.Drawing.Size(325, 80)
        Me.direxataacci.TabIndex = 6
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.Red
        Me.Label38.Location = New System.Drawing.Point(3, 238)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(118, 13)
        Me.Label38.TabIndex = 22
        Me.Label38.Text = "* = Campos Requeridos"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(470, 41)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(14, 13)
        Me.Label39.TabIndex = 23
        Me.Label39.Text = "* "
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.Red
        Me.Label40.Location = New System.Drawing.Point(604, 117)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(14, 13)
        Me.Label40.TabIndex = 24
        Me.Label40.Text = "* "
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.Red
        Me.Label41.Location = New System.Drawing.Point(604, 212)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(14, 13)
        Me.Label41.TabIndex = 25
        Me.Label41.Text = "* "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label60)
        Me.Panel2.Controls.Add(Me.Label59)
        Me.Panel2.Controls.Add(Me.Label58)
        Me.Panel2.Controls.Add(Me.Label57)
        Me.Panel2.Controls.Add(Me.Label56)
        Me.Panel2.Controls.Add(Me.Label55)
        Me.Panel2.Controls.Add(Me.Label54)
        Me.Panel2.Controls.Add(Me.Label53)
        Me.Panel2.Controls.Add(Me.Label52)
        Me.Panel2.Controls.Add(Me.Label51)
        Me.Panel2.Controls.Add(Me.cbtipoidconduc)
        Me.Panel2.Controls.Add(Me.cbtipoidePropie)
        Me.Panel2.Controls.Add(Me.txidconduc)
        Me.Panel2.Controls.Add(Me.txnomcond)
        Me.Panel2.Controls.Add(Me.txparte)
        Me.Panel2.Controls.Add(Me.txidpropi)
        Me.Panel2.Controls.Add(Me.txnompropie)
        Me.Panel2.Controls.Add(Me.txplaca)
        Me.Panel2.Controls.Add(Me.txdesauto)
        Me.Panel2.Controls.Add(Me.Label50)
        Me.Panel2.Controls.Add(Me.Label49)
        Me.Panel2.Controls.Add(Me.Label48)
        Me.Panel2.Controls.Add(Me.Label47)
        Me.Panel2.Controls.Add(Me.Label46)
        Me.Panel2.Controls.Add(Me.Label45)
        Me.Panel2.Controls.Add(Me.Label44)
        Me.Panel2.Controls.Add(Me.Label43)
        Me.Panel2.Controls.Add(Me.Label42)
        Me.Panel2.Location = New System.Drawing.Point(3, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(743, 232)
        Me.Panel2.TabIndex = 26
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(34, 13)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(89, 13)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Número de Placa"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(34, 52)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(102, 13)
        Me.Label43.TabIndex = 1
        Me.Label43.Text = "Tipo Ide. Propietario"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(35, 87)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(97, 13)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Nombre Propietario"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(408, 52)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(101, 13)
        Me.Label45.TabIndex = 3
        Me.Label45.Text = "Tipo Ide. Conductor"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(408, 87)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(96, 13)
        Me.Label46.TabIndex = 4
        Me.Label46.Text = "Nombre Conductor"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(408, 18)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(87, 13)
        Me.Label47.TabIndex = 5
        Me.Label47.Text = "Número de Parte"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(35, 125)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(123, 13)
        Me.Label48.TabIndex = 6
        Me.Label48.Text = "Identificación Propietario"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(408, 125)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(122, 13)
        Me.Label49.TabIndex = 7
        Me.Label49.Text = "Identificación Conductor"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(35, 186)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(131, 13)
        Me.Label50.TabIndex = 8
        Me.Label50.Text = "Descripción del Accidente"
        '
        'txdesauto
        '
        Me.txdesauto.Location = New System.Drawing.Point(228, 147)
        Me.txdesauto.Multiline = True
        Me.txdesauto.Name = "txdesauto"
        Me.txdesauto.Size = New System.Drawing.Size(469, 82)
        Me.txdesauto.TabIndex = 9
        '
        'txplaca
        '
        Me.txplaca.Location = New System.Drawing.Point(179, 6)
        Me.txplaca.Name = "txplaca"
        Me.txplaca.Size = New System.Drawing.Size(121, 20)
        Me.txplaca.TabIndex = 10
        '
        'txnompropie
        '
        Me.txnompropie.Location = New System.Drawing.Point(179, 80)
        Me.txnompropie.Name = "txnompropie"
        Me.txnompropie.Size = New System.Drawing.Size(121, 20)
        Me.txnompropie.TabIndex = 12
        '
        'txidpropi
        '
        Me.txidpropi.Location = New System.Drawing.Point(179, 118)
        Me.txidpropi.Name = "txidpropi"
        Me.txidpropi.Size = New System.Drawing.Size(121, 20)
        Me.txidpropi.TabIndex = 13
        '
        'txidconduc
        '
        Me.txidconduc.Location = New System.Drawing.Point(532, 118)
        Me.txidconduc.Name = "txidconduc"
        Me.txidconduc.Size = New System.Drawing.Size(100, 20)
        Me.txidconduc.TabIndex = 17
        '
        'txnomcond
        '
        Me.txnomcond.Location = New System.Drawing.Point(532, 84)
        Me.txnomcond.Name = "txnomcond"
        Me.txnomcond.Size = New System.Drawing.Size(100, 20)
        Me.txnomcond.TabIndex = 16
        '
        'txparte
        '
        Me.txparte.Location = New System.Drawing.Point(532, 11)
        Me.txparte.Name = "txparte"
        Me.txparte.Size = New System.Drawing.Size(100, 20)
        Me.txparte.TabIndex = 14
        '
        'cbtipoidePropie
        '
        Me.cbtipoidePropie.FormattingEnabled = True
        Me.cbtipoidePropie.Location = New System.Drawing.Point(179, 44)
        Me.cbtipoidePropie.Name = "cbtipoidePropie"
        Me.cbtipoidePropie.Size = New System.Drawing.Size(121, 21)
        Me.cbtipoidePropie.TabIndex = 18
        '
        'cbtipoidconduc
        '
        Me.cbtipoidconduc.FormattingEnabled = True
        Me.cbtipoidconduc.Location = New System.Drawing.Point(532, 44)
        Me.cbtipoidconduc.Name = "cbtipoidconduc"
        Me.cbtipoidconduc.Size = New System.Drawing.Size(121, 21)
        Me.cbtipoidconduc.TabIndex = 19
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.ForeColor = System.Drawing.Color.Red
        Me.Label51.Location = New System.Drawing.Point(10, 216)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(118, 13)
        Me.Label51.TabIndex = 22
        Me.Label51.Text = "* = Campos Requeridos"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.ForeColor = System.Drawing.Color.Red
        Me.Label52.Location = New System.Drawing.Point(316, 13)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(14, 13)
        Me.Label52.TabIndex = 23
        Me.Label52.Text = "* "
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ForeColor = System.Drawing.Color.Red
        Me.Label53.Location = New System.Drawing.Point(316, 52)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(14, 13)
        Me.Label53.TabIndex = 24
        Me.Label53.Text = "* "
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.ForeColor = System.Drawing.Color.Red
        Me.Label54.Location = New System.Drawing.Point(316, 84)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(14, 13)
        Me.Label54.TabIndex = 25
        Me.Label54.Text = "* "
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.ForeColor = System.Drawing.Color.Red
        Me.Label55.Location = New System.Drawing.Point(316, 125)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(14, 13)
        Me.Label55.TabIndex = 26
        Me.Label55.Text = "* "
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.ForeColor = System.Drawing.Color.Red
        Me.Label56.Location = New System.Drawing.Point(654, 14)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(14, 13)
        Me.Label56.TabIndex = 27
        Me.Label56.Text = "* "
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.Color.Red
        Me.Label57.Location = New System.Drawing.Point(659, 47)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(14, 13)
        Me.Label57.TabIndex = 28
        Me.Label57.Text = "* "
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.ForeColor = System.Drawing.Color.Red
        Me.Label58.Location = New System.Drawing.Point(639, 87)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(14, 13)
        Me.Label58.TabIndex = 29
        Me.Label58.Text = "* "
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.ForeColor = System.Drawing.Color.Red
        Me.Label59.Location = New System.Drawing.Point(639, 125)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(14, 13)
        Me.Label59.TabIndex = 30
        Me.Label59.Text = "* "
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.Color.Red
        Me.Label60.Location = New System.Drawing.Point(703, 186)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(14, 13)
        Me.Label60.TabIndex = 31
        Me.Label60.Text = "* "
        '
        'InsertarCasoDeEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 657)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cbest)
        Me.Controls.Add(Me.cbase)
        Me.Controls.Add(Me.txnombre)
        Me.Controls.Add(Me.txcedu)
        Me.Controls.Add(Me.cbtipoide)
        Me.Controls.Add(Me.cbTipoAc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InsertarCasoDeEstudio"
        Me.Text = "Insertar Caso de Estudio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dsaseguradora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsmedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbTipoAc As System.Windows.Forms.ComboBox
    Friend WithEvents cbtipoide As System.Windows.Forms.ComboBox
    Friend WithEvents txcedu As System.Windows.Forms.TextBox
    Friend WithEvents txnombre As System.Windows.Forms.TextBox
    Friend WithEvents cbase As System.Windows.Forms.ComboBox
    Friend WithEvents cbest As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents txocup As System.Windows.Forms.TextBox
    Friend WithEvents cbtel As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents fechamue As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txsenas As System.Windows.Forms.TextBox
    Friend WithEvents txdistrito As System.Windows.Forms.TextBox
    Friend WithEvents txcanton As System.Windows.Forms.TextBox
    Friend WithEvents cbprovi As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbfalle As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Conn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAaseguradora As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Dsaseguradora As CCSS.dsaseguradora
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chasegu As System.Windows.Forms.CheckBox
    Friend WithEvents txatendes As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents dtfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents dtinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cbmedi As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents damedicos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Dsmedicos As CCSS.dsmedicos
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents direxataacci As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents desacci As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents dtfechaacci As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cbtipoidconduc As System.Windows.Forms.ComboBox
    Friend WithEvents cbtipoidePropie As System.Windows.Forms.ComboBox
    Friend WithEvents txidconduc As System.Windows.Forms.TextBox
    Friend WithEvents txnomcond As System.Windows.Forms.TextBox
    Friend WithEvents txparte As System.Windows.Forms.TextBox
    Friend WithEvents txidpropi As System.Windows.Forms.TextBox
    Friend WithEvents txnompropie As System.Windows.Forms.TextBox
    Friend WithEvents txplaca As System.Windows.Forms.TextBox
    Friend WithEvents txdesauto As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
End Class
