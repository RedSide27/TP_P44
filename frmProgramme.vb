Imports System.Data.SqlClient 'Import pour utiliser SQL
Public Class frmProgramme
    Dim cn As SqlConnection
    Dim comProg, comEtu, comAjout, comModif, comSup As SqlCommand
    Dim dr As SqlDataReader
    Dim ACTION As String = ""
    Private Sub cmdNouveau_Click(sender As Object, e As EventArgs) Handles cmdNouveau.Click
        Barrer_Debarrer(True)
        txtNo.Text = ""
        txtNom.Text = ""
        txtNbrUnites.Text = ""
        txtNbrHeure.Text = ""
        ACTION = "Ajouter"
    End Sub

    'Fonction pour barrer/debarrer les boutons
    Private Sub Barrer_Debarrer(Lock As Boolean)
        grpProgramme.Enabled = Lock
        cmdAnnuler.Enabled = Lock
        cmdEnlever.Enabled = Not Lock
        cmdModifier.Enabled = Not Lock
        cmdOK.Enabled = Lock
        cmdNouveau.Enabled = Not Lock
    End Sub

    Private Sub frmProgramme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Configuration de la connection
            cn = New SqlConnection
            cn.ConnectionString = My.Settings.cn
            cn.Open()

            'Configuration de la Commande pour selectionner les programmes
            comProg = New SqlCommand()
            With comProg
                .CommandText = "SELECT * FROM T_programme"
                .CommandType = CommandType.Text
                .Connection = cn
            End With

            'Remplir le LvProgramme
            Remplir_LvProgramme()


            'Configuration de la Commande pour selectionner les Programmes
            If lvProgramme.Items.Count > 0 Then
                lvProgramme.SelectedIndices.Add(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ' Remplie les textbox
    Private Sub Remplir_Prog(noProg As String)
        Try
            'Vide le Contenue des textbox
            'txtNo.Text = ""
            'txtNom.Text = ""
            'txtNbrUnites.Text = ""
            'txtNbrHeure.Text = ""
            'Ajout des Info
            Dim comRech As New SqlCommand
            With comRech
                .CommandText = "SELECT p.pro_no,p.pro_nom,p.pro_nbr_unites,p.pro_nbr_heures FROM T_programme p where p.pro_no = @da"
                .CommandType = CommandType.Text
                .Connection = cn
                .Parameters.Add("@da", SqlDbType.VarChar, 7)
            End With
            comRech.Parameters("@da").Value = noProg
            'Creation DR
            dr = comRech.ExecuteReader
            'Lecture des donnee
            Do While dr.Read()
                txtNo.Text = dr("pro_no").ToString
                txtNom.Text = dr("pro_nom").ToString
                txtNbrUnites.Text = dr("pro_nbr_unites").ToString
                txtNbrHeure.Text = dr("pro_nbr_heures").ToString
            Loop
            dr.Close()
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ' Remplie le listeview des Programmes
    Private Sub Remplir_LvProgramme()
        Try
            'Creation du DR
            dr = comProg.ExecuteReader
            'Vide le Contenue du LvProgramme
            lvProgramme.Items.Clear()

            'Boucle pour lire l'ensemble des programmes
            Dim ligne As ListViewItem
            Do While dr.Read
                ligne = New ListViewItem(dr("pro_no").ToString)
                ligne.SubItems.Add(dr("pro_nom").ToString)
                ligne.SubItems.Add(dr("pro_nbr_unites").ToString)
                ligne.SubItems.Add(dr("pro_nbr_heures").ToString)
                'ajout du tag
                ligne.Tag = dr("pro_no")
                'Ajout de l'item
                lvProgramme.Items.Add(ligne)
            Loop
            'Fermer le DR
            dr.Close()
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ' Obtient le programme selectionner
    Private Sub Changer_LvEtu(sender As Object, e As EventArgs) Handles lvProgramme.SelectedIndexChanged
        'Verifier si un item est selectionner
        If lvProgramme.SelectedIndices.Count > 0 Then
            Remplir_LvEtudiants(lvProgramme.SelectedItems(0).Tag)
            Remplir_Prog(lvProgramme.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        Barrer_Debarrer(False)
        Remplir_Prog("LEA.1A")
<<<<<<< HEAD
        txtNo.Enabled = True
=======
        txtno.Enabled = True
        Err1.Clear()
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
    End Sub

    Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click
        grpProgramme.Enabled = True
        Barrer_Debarrer(True)
        ACTION = "Modifier"
        txtNo.Enabled = False
    End Sub

    Private Sub cmdEnlever_Click(sender As Object, e As EventArgs) Handles cmdEnlever.Click
<<<<<<< HEAD

=======
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
        If MsgBox("êtes-vous sur de vouloir supprimer le programme ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Supprimer_Programme()
        End If
    End Sub
    ' Supprime le Programme Selectionner
    Public Sub Supprimer_Programme()
        Try
            comSup = New SqlCommand()
            With comSup
                .CommandText = "DELETE FROM T_programme WHERE pro_no = @no"
                .CommandType = CommandType.Text
                .Connection = cn
                .Parameters.Add("@no", SqlDbType.VarChar, 6).Value = txtNo.Text.Trim.ToString
            End With

            If comSup.ExecuteNonQuery > 0 Then
                MsgBox("Programme Supprimer Avec Succès")
                Remplir_LvProgramme()
                If lvProgramme.SelectedIndices.Count > 0 Then
                    lvProgramme.SelectedIndices.Add(0)
                End If
            Else
                MsgBox("Aucun Client de supprimer")
            End If

<<<<<<< HEAD

=======
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

<<<<<<< HEAD
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        If ACTION = "Ajouter" Then
            Ajouter_Programme()
        ElseIf ACTION = "Modifier" Then
            Modifier_Programme()
            txtNo.Enabled = True
        End If
    End Sub
    ' Modifie le Programme Selectionner
=======
    Private Sub txtNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom.KeyPress
        e.Handled = Char.IsDigit(e.KeyChar)
    End Sub

    Private Sub txtNbrUnites_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNbrUnites.KeyPress
        Dim Caractere As String = "0123456789,"
        If (e.KeyChar = Convert.ToChar(Keys.Back)) Then
            Exit Sub
        ElseIf Not Caractere.Contains(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtNbrHeure_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNbrHeure.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        If Verif_Champs() = True Then
            If ACTION = "Ajouter" Then
                Ajouter_Programme()
                Barrer_Debarrer(False)
            ElseIf ACTION = "Modifier" Then
                Modifier_Programme()
                txtno.Enabled = True
                Barrer_Debarrer(False)
            End If
            Err1.Clear()
        End If
    End Sub
    ' Modifie le Programme Selectionner

    Private Function Verif_Champs() As Boolean
        Err1.Clear()
        Dim x As Boolean = True
        If Mid(txtno.Text, 1) = " " Or Mid(txtno.Text, 2) = " " Or Mid(txtno.Text, 3) = " " Or Mid(txtno.Text, 5) = " " Or Mid(txtno.Text, 6) = Nothing Then
            Err1.SetError(txtno, "DA Invalide")
            x = False
        End If
        If txtNom.Text = "" Then
            Err1.SetError(txtNom, "Nom Invalide")
            x = False
        End If
        If txtNbrUnites.Text = "" Then
            Err1.SetError(txtNbrUnites, "Nombre D'Unité Invalide")
            x = False
        End If
        If txtNbrHeure.Text = "" Then
            Err1.SetError(txtNbrHeure, "Nombre D'Heure Invalide")
            x = False
        End If
        Return x
    End Function

>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
    Private Sub Modifier_Programme()
        Try
            If txtNo.Text = "" Or txtNom.Text = "" Or txtNbrUnites.Text = "" Or txtNbrHeure.Text = "" Then
                MsgBox("Champs Manquant")
                txtNo.Focus()
            End If

            comModif = New SqlCommand()
            With comModif
                .CommandText = "Update T_programme set pro_nom = @nom, pro_nbr_unites = @nbrUnit, pro_nbr_heures = @nbrHeure WHERE pro_no = @no"
                .CommandType = CommandType.Text
                .Connection = cn
                .Parameters.Add("@no", SqlDbType.VarChar, 6).Value = txtNo.Text.Trim.ToString
                .Parameters.Add("@nom", SqlDbType.VarChar, 50).Value = txtNom.Text.Trim.ToString
                .Parameters.Add("@nbrUnit", SqlDbType.Float).Value = Convert.ToDecimal(txtNbrUnites.Text.Trim) '<-- si l'utilisateur met un point sa plante
                .Parameters.Add("@nbrHeure", SqlDbType.Int).Value = CInt(txtNbrHeure.Text.Trim)
            End With

            ' Executer la requete
            comModif.ExecuteNonQuery()
            MsgBox("Programme Modifier Avec Succès")
            Remplir_LvProgramme()

        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ' Ajoute un Nouveau Programme
    Private Sub Ajouter_Programme()
        Try
            If txtNo.Text = "" Or txtNom.Text = "" Or txtNbrUnites.Text = "" Or txtNbrHeure.Text = "" Then
                MsgBox("Champs Manquant")
                txtNo.Focus()
            End If

            comAjout = New SqlCommand()
            With comAjout
                .CommandText = "INSERT INTO T_programme (pro_no,pro_nom,pro_nbr_heures,pro_nbr_unites) values (@no,@nom,@nbrHeure,@nbrUnit)"
                .CommandType = CommandType.Text
                .Connection = cn
                .Parameters.Add("@no", SqlDbType.VarChar, 6).Value = txtNo.Text.Trim.ToString
                .Parameters.Add("@nom", SqlDbType.VarChar, 50).Value = txtNom.Text.Trim.ToString
                .Parameters.Add("@nbrUnit", SqlDbType.Float).Value = Convert.ToDecimal(txtNbrUnites.Text.Trim) '<-- si l'utilisateur met un point sa plante
                .Parameters.Add("@nbrHeure", SqlDbType.Int).Value = CInt(txtNbrHeure.Text.Trim)
            End With

            ' Executer la requete
            comAjout.ExecuteNonQuery()
            MsgBox("Programme Ajouter Avec Succès")
            Remplir_LvProgramme()
            lvProgramme.SelectedIndices.Add(lvProgramme.Items.Count - 1)

        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ' Remplie le listview des Etudiants
    Private Sub Remplir_LvEtudiants(etu As String)
        Try
            comEtu = New SqlCommand()
            With comEtu
                .CommandText = "SELECT etu_da, pro_no,etu_nom,etu_prenom FROM T_etudiants WHERE pro_no = @pro_no ORDER BY pro_no"
                .CommandType = CommandType.Text
                .Connection = cn
                .Parameters.Add("@pro_no", SqlDbType.VarChar, 6)
            End With


            comEtu.Parameters("@pro_no").Value = etu
            'Creation du DR
            dr = comEtu.ExecuteReader
            'Cider le contenue du lvEtudiants
            lvEtudiant.Items.Clear()

            'Boucle pour lire l'ensemble des étudiants
            Dim ligne As ListViewItem
            Do While dr.Read
                ligne = New ListViewItem(dr("etu_da").ToString)
                ligne.SubItems.Add(dr("pro_no").ToString)
                ligne.SubItems.Add(dr("etu_nom").ToString)
                ligne.SubItems.Add(dr("etu_prenom").ToString)
                'Ajouter l'item
                lvEtudiant.Items.Add(ligne)
            Loop
            'Fermer le DR
            dr.Close()
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class