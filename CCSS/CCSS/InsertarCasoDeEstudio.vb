Public Class InsertarCasoDeEstudio

    Private Sub InsertarCasoDeEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarComboTipoAc()
        llenarComboTipoID()
        llenarComboEstado()
        cbase.DataSource = getAseguradora.Tables("aseguradoras")
        cbase.DisplayMember = "razonSocial"
        cbase.ValueMember = "numeroPatronal"
        llenarCombofalle()
        llenarComboProvincia()
        llenarComboTel()
        cbmedi.DataSource = getmedi().Tables("medicos")
        cbmedi.DisplayMember = "nombre"
        cbmedi.ValueMember = "codigo"
        Panel2.Visible = False

    End Sub

    Private Sub llenarComboTipoAc()
        Dim dt As DataTable = New DataTable("tipoAc")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("id") = "0"
        dr("nombre") = "Riesgos de Trabajo"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "1"
        dr("nombre") = "Accidente Automotor"
        dt.Rows.Add(dr)

        cbTipoAc.DataSource = dt
        cbTipoAc.ValueMember = "id"
        cbTipoAc.DisplayMember = "nombre"
    End Sub

    Private Sub llenarComboTipoID()
        Dim dt As DataTable = New DataTable("tipoid")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("id") = "0"
        dr("nombre") = "Cédula Identidad"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "1"
        dr("nombre") = "Pasaporte"
        dt.Rows.Add(dr)

        cbtipoide.DataSource = dt
        cbtipoide.ValueMember = "id"
        cbtipoide.DisplayMember = "nombre"

        cbtipoidconduc.DataSource = dt
        cbtipoidconduc.ValueMember = "id"
        cbtipoidconduc.DisplayMember = "nombre"

        cbtipoidePropie.DataSource = dt
        cbtipoidePropie.ValueMember = "id"
        cbtipoidePropie.DisplayMember = "nombre"
    End Sub

    Private Sub llenarComboEstado()
        Dim dt As DataTable = New DataTable("estado")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("id") = "0"
        dr("nombre") = "Activo"
        dt.Rows.Add(dr)

        cbest.DataSource = dt
        cbest.ValueMember = "id"
        cbest.DisplayMember = "nombre"
    End Sub

    Private Function getAseguradora() As DataSet
        Dsaseguradora = New dsaseguradora
        DAaseguradora.Fill(Dsaseguradora, "aseguradoras")
        Return Dsaseguradora
    End Function

    Private Sub llenarCombofalle()
        Dim dt As DataTable = New DataTable("falle")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("id") = "0"
        dr("nombre") = "Si"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "1"
        dr("nombre") = "No"
        dt.Rows.Add(dr)

        cbfalle.DataSource = dt
        cbfalle.ValueMember = "id"
        cbfalle.DisplayMember = "nombre"
    End Sub

    Private Sub llenarComboProvincia()
        Dim dt As DataTable = New DataTable("provincia")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("id") = "Guanacaste"
        dr("nombre") = "Guanacaste"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "Limón"
        dr("nombre") = "Limón"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "San José"
        dr("nombre") = "San José"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("id") = "Alajuela"
        dr("nombre") = "Alajuela"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("id") = "Puntarenas"
        dr("nombre") = "Puntarenas"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("id") = "Cartago"
        dr("nombre") = "Cartago"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("id") = "Heredia"
        dr("nombre") = "Heredia"
        dt.Rows.Add(dr)

        cbprovi.DataSource = dt
        cbprovi.ValueMember = "id"
        cbprovi.DisplayMember = "nombre"
    End Sub

    Private Sub llenarComboTel()
        Dim dt As DataTable = New DataTable("tel")
        dt.Columns.Add("id")
        dt.Columns.Add("nombre")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("id") = "0"
        dr("nombre") = "Personal/Habitación"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "1"
        dr("nombre") = "Trabajo"
        dt.Rows.Add(dr)

        cbtel.DataSource = dt
        cbtel.ValueMember = "id"
        cbtel.DisplayMember = "nombre"
    End Sub

    Private Function getmedi() As DataSet
        Dsmedicos = New dsmedicos
        damedicos.Fill(Dsmedicos, "medicos")
        Return Dsmedicos
    End Function

    Private Sub cbTipoAc_SelectionChangeCommitted(ByVal sender _
As Object, ByVal e As EventArgs) _
Handles cbTipoAc.SelectionChangeCommitted
        If (cbTipoAc.SelectedValue = 0) Then
            Panel2.Visible = False
        Else
            Panel2.Visible = True
        End If
    End Sub

End Class