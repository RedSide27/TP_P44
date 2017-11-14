Imports System.Data.SqlClient 'Pour utiliser SQL
Public Class frmEtudiants
    Dim cn As SqlConnection
    Dim comEtu As SqlCommand
    Dim comSup As SqlCommand
    Dim comAjout As SqlCommand
    Dim dr As SqlDataReader
    Dim Action As String
    Private Sub cmdNouveau_Click(sender As Object, e As EventArgs) Handles cmdNouveau.Click
        'Sur clique de nouveau barre et débarre les boutons voulu,vide l'ecran et donne le focus
        Barrer({cmdNouveau, cmdEnlever, cmdModifier, lvEtudiants})
        Debarrer({cmdAnnuler, cmdOK, grpEtudiants})
        Vider_Ecran()
        txtNo.Focus()
        Action = "AJOUT"
    End Sub

    Private Sub Barrer(ctrl() As Control)
        Dim i As Integer
        For i = 0 To ctrl.GetUpperBound(0)
            ctrl(i).Enabled = False
        Next
    End Sub
    Private Sub Debarrer(ctrl() As Control)
        Dim i As Integer
        For i = 0 To ctrl.GetUpperBound(0)
            ctrl(i).Enabled = True
        Next
    End Sub

    Private Sub frmEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Configuration de la connection
            cn = New SqlConnection
            cn.ConnectionString = My.Settings.cn
            cn.Open()

            Remplir_Etu()

            If lvEtudiants.Items.Count > 0 Then
                lvEtudiants.SelectedIndices.Add(0)
                'Regler la ligne bleu sur le selected item
            End If

        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Remplir_Etu()
        Try
            comEtu = New SqlCommand()
            With comEtu
                .CommandText = "SELECT * FROM T_etudiants"
                .CommandType = CommandType.Text
                .Connection = cn
            End With
            'Creation du DR
            dr = comEtu.ExecuteReader
            'Vider le contenue du lvEtudiants
            lvEtudiants.Items.Clear()
            'Boucle pour lire l'ensemble des étudiants
            Dim ligne As ListViewItem
            Do While dr.Read
                ligne = New ListViewItem(dr("etu_da").ToString)
                ligne.SubItems.Add(dr("pro_no").ToString)
                ligne.SubItems.Add(dr("etu_nom").ToString)
                ligne.SubItems.Add(dr("etu_prenom").ToString)
                ligne.SubItems.Add(dr("etu_sexe").ToString)
                ligne.SubItems.Add(dr("etu_adresse").ToString)
                ligne.SubItems.Add(dr("etu_ville").ToString)
                ligne.SubItems.Add(dr("etu_province").ToString)
                ligne.SubItems.Add(dr("etu_telephone").ToString)
                ligne.SubItems.Add(dr("etu_codepostal").ToString)
                'Ajouter le tag
                ligne.Tag = dr("etu_da")
                'Ajouter l'item
                lvEtudiants.Items.Add(ligne)
            Loop
            'Fermer le DR
            dr.Close()
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        'Mettre les erreur a 0
        err1.Clear()
        'Barrer/Debarrer
        Barrer({cmdAnnuler, cmdOK, grpEtudiants})
        Debarrer({cmdNouveau, lvEtudiants, cmdEnlever, cmdModifier})
        'Mettre l'action a rien
        Action = ""
        'Recharger la liste d'élèves pour annuler les changements
        Dim no As Integer
        If lvEtudiants.SelectedIndices.Count > 0 Then
            no = lvEtudiants.SelectedIndices(0)
            lvEtudiants.SelectedIndices.Clear()
            lvEtudiants.SelectedIndices.Add(no)
        End If
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        'Si les champ ne sont pas remplis, ne fait rien et affiche les erreurs
        If Verifier_Champs() = False Then Exit Sub
        'Si l'action est modifier modifi l'élève choisi
        If Action = "MODIFIER" Then
            Modifier_Eleve()
            Barrer({cmdAnnuler, cmdOK, grpEtudiants})
            Debarrer({lvEtudiants, cmdNouveau, cmdEnlever, cmdModifier})
        ElseIf Action = "AJOUT" Then
            Ajouter_Eleve()

        End If
        Action = ""

    End Sub

    Private Sub lvEtudiants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvEtudiants.SelectedIndexChanged

        If lvEtudiants.SelectedIndices.Count > 0 Then
            Recuperer_Eleve(lvEtudiants.SelectedItems(0).Tag)
        End If


    End Sub

    Private Sub Recuperer_Eleve(da As String)
        Try
            comEtu = New SqlCommand()
            With comEtu
                .CommandText = "SELECT * FROM T_etudiants WHERE etu_da = @da"
                .CommandType = CommandType.Text
                .Connection = cn
                .Parameters.Add("@da", SqlDbType.VarChar, 7)
            End With

            comEtu.Parameters("@da").Value = da
            'Creation du DR
            dr = comEtu.ExecuteReader

            'Boucle pour lire l'étudiants
            Do While dr.Read
                txtNo.Text = dr("etu_da").ToString
                txtProg.Text = dr("pro_no").ToString
                txtPrenom.Text = dr("etu_prenom").ToString
                txtNom.Text = dr("etu_nom").ToString
                txtAdresse.Text = dr("etu_adresse").ToString
                If dr("etu_sexe") = "M" Then
                    optMasculin.Checked = True
                    optFeminin.Checked = False
                Else
                    optFeminin.Checked = True
                    optMasculin.Checked = False
                End If
                txtVille.Text = dr("etu_ville").ToString
                cboProvince.Text = dr("etu_province").ToString
                mskTel.Text = dr("etu_telephone").ToString
                mskCp.Text = dr("etu_codepostal").ToString
            Loop
            'Fermer le DR
            dr.Close()
        Catch ex As SqlException
            If ex.Number = 2 Then
                MsgBox("Impossible de se connecter au serveur SQL")
                End
            ElseIf ex.Number = 4060 Then
                MsgBox("DB invalide")
                End
            ElseIf ex.Number = 18452 Then
                MsgBox("Login invalide")
                End
            ElseIf ex.Number = 2627 Then
                MsgBox("Clé primaire invalide car déjâ utilisé")
            ElseIf ex.Number = 150 Then
                MsgBox("Les deux termes d'une jointure externe doivent contenir des colonnes.")
            ElseIf ex.Number = 16929 Then
                MsgBox("Le curseur est READ ONLY.")
            Else
                MsgBox(ex.Number & " " & ex.Message)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click
        Action = "MODIFIER"
        Barrer({lvEtudiants, cmdNouveau, cmdEnlever, cmdModifier})
        Debarrer({cmdAnnuler, cmdOK, grpEtudiants})
        txtNom.Focus()
    End Sub

    Private Sub Vider_Ecran()
        txtNo.Text = ""
        txtNom.Text = ""
        txtPrenom.Text = ""
        txtProg.Text = ""
        mskCp.Text = ""
        txtVille.Text = ""
        mskTel.Text = ""
        txtAdresse.Text = ""
        optFeminin.Checked = False
        optMasculin.Checked = False
    End Sub

    Private Function Verifier_Champs() As Boolean
        'Effacer les ancien messages d'erreurs
        err1.Clear()
        Dim ok As Boolean = True
        If txtAdresse.Text.Trim = "" Then
            err1.SetError(txtAdresse, "Adresse invalide")
            ok = False
        End If
        If txtNo.Text.Trim = "" Then
            err1.SetError(txtNo, "DA Invalide")
            ok = False
        End If
        If txtNom.Text.Trim = "" Then
            err1.SetError(txtNom, "Nom invalide")
            ok = False
        End If
        If txtPrenom.Text.Trim = "" Then
            err1.SetError(txtPrenom, "Prenom invalide")
            ok = False
        End If
        If txtProg.Text.Trim = "" Then
            err1.SetError(txtProg, "Programme invalide")
            ok = False
        End If
        If txtVille.Text.Trim = "" Then
            err1.SetError(txtVille, "Ville invalide")
        End If
        If mskCp.Text.Trim = "" Then
            err1.SetError(mskCp, "Code Postale invalide")
            ok = False
        End If
        If mskTel.Text.Trim = "" Then
            err1.SetError(mskTel, "Telephone invalide")
            ok = False
        End If
        If optFeminin.Checked = False And optMasculin.Checked = False Then
            err1.SetError(grpSexe, "Veuillez choisir un sexe")
            ok = False
        End If

        Return ok
    End Function

    Private Sub Modifier_Eleve()
        Try
            Dim comModif As New SqlCommand
            With comModif
                .CommandText = "UPDATE T_Etudiants SET pro_no = @pro_no,etu_nom = @etu_nom,etu_prenom = @etu_prenom,etu_sexe = @etu_sexe,etu_adresse = @etu_adresse,etu_ville = @etu_ville,etu_province = @etu_province,etu_telephone = @etu_telephone,etu_codepostal = @etu_codepostal WHERE etu_da = @da"
                .CommandType = CommandType.Text
                .Connection = cn
                .Parameters.Add("@pro_no", SqlDbType.VarChar, 6).Value = txtProg.Text.Trim
                .Parameters.Add("@etu_nom", SqlDbType.VarChar, 20).Value = txtNom.Text.Trim
                .Parameters.Add("@etu_prenom", SqlDbType.VarChar, 20).Value = txtPrenom.Text.Trim
                If optFeminin.Checked = True Then
                    .Parameters.Add("@etu_sexe", SqlDbType.Char, 1).Value = "F"
                Else
                    .Parameters.Add("@etu_sexe", SqlDbType.Char, 1).Value = "M"
                End If
                .Parameters.Add("@etu_adresse", SqlDbType.VarChar, 100).Value = txtAdresse.Text.Trim
                .Parameters.Add("@etu_ville", SqlDbType.VarChar, 50).Value = txtVille.Text.Trim
                .Parameters.Add("@etu_province", SqlDbType.VarChar, 50).Value = cboProvince.SelectedItem.ToString
                .Parameters.Add("@etu_telephone", SqlDbType.VarChar, 14).Value = mskTel.Text.Trim
                .Parameters.Add("@etu_codepostal", SqlDbType.VarChar, 7).Value = mskCp.Text.Trim
                .Parameters.Add("@da", SqlDbType.VarChar, 7).Value = txtNo.Text.Trim
            End With
            'Executer la requete
            comModif.ExecuteNonQuery()
            MsgBox("Eleve modifier")
            Dim no As Integer
            no = lvEtudiants.SelectedIndices(0)
            'Remplir le listView
            Remplir_Etu()
            lvEtudiants.SelectedIndices.Add(no)

        Catch ex As SqlException
            If ex.Number = 2 Then
                MsgBox("Impossible de se connecter au serveur SQL")
                End
            ElseIf ex.Number = 4060 Then
                MsgBox("DB invalide")
                End
            ElseIf ex.Number = 18452 Then
                MsgBox("Login invalide")
                End
            ElseIf ex.Number = 2627 Then
                MsgBox("Clé primaire invalide car déjâ utilisé")
            ElseIf ex.Number = 150 Then
                MsgBox("Les deux termes d'une jointure externe doivent contenir des colonnes.")
            ElseIf ex.Number = 16929 Then
                MsgBox("Le curseur est READ ONLY.")
            Else
                MsgBox(ex.Number & " " & ex.Message)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdEnlever_Click(sender As Object, e As EventArgs) Handles cmdEnlever.Click
        If MsgBox("êtes-vous sur de vouloir supprimer le programme ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Supprimer_Eleve()
        End If
    End Sub
    ' Supprime le Programme Selectionner
    Public Sub Supprimer_Eleve()
        Try
            comSup = New SqlCommand()
            With comSup
                .CommandText = "DELETE FROM T_etudiants WHERE etu_da = @da"
                .CommandType = CommandType.Text
                .Connection = cn
                .Parameters.Add("@da", SqlDbType.VarChar, 7).Value = txtNo.Text.Trim
            End With

            If comSup.ExecuteNonQuery > 0 Then
                MsgBox("Élève Supprimer Avec Succès")
                Remplir_Etu()

                If lvEtudiants.SelectedIndices.Count > 0 Then
                    lvEtudiants.SelectedIndices.Add(0)
                End If
            Else
                MsgBox("Aucun Élève de supprimer")
            End If


        Catch ex As SqlException
            If ex.Number = 2 Then
                MsgBox("Impossible de se connecter au serveur SQL")
                End
            ElseIf ex.Number = 4060 Then
                MsgBox("DB invalide")
                End
            ElseIf ex.Number = 18452 Then
                MsgBox("Login invalide")
                End
            ElseIf ex.Number = 2627 Then
                MsgBox("Clé primaire invalide car déjâ utilisé")
            ElseIf ex.Number = 150 Then
                MsgBox("Les deux termes d'une jointure externe doivent contenir des colonnes.")
            ElseIf ex.Number = 16929 Then
                MsgBox("Le curseur est READ ONLY.")
            Else
                MsgBox(ex.Number & " " & ex.Message)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ajouter_Eleve()
        Try
            If txtNo.Text = "" Or txtNom.Text = "" Or txtProg.Text = "" Or txtPrenom.Text = "" Or txtAdresse.Text = "" Or txtVille.Text = "" Or mskCp.Text = "" Or mskTel.Text = "" Or (optFeminin.Checked = False And optMasculin.Checked = False) Then
                MsgBox("Champs Manquant")
                txtNo.Focus()
            End If

            comAjout = New SqlCommand()
            With comAjout
                .CommandText = "INSERT INTO T_etudiants (etu_da,pro_no,etu_nom,etu_prenom,etu_sexe,etu_adresse,etu_ville,etu_province,etu_telephone,etu_codepostal) values (@da,@prog,@nom,@prenom,@sexe,@adr,@ville,@prov,@tel,@cp)"
                .CommandType = CommandType.Text
                .Connection = cn
                .Parameters.Add("@da", SqlDbType.VarChar, 7).Value = txtNo.Text.Trim
                .Parameters.Add("@prog", SqlDbType.VarChar, 6).Value = txtProg.Text.Trim
                .Parameters.Add("@nom", SqlDbType.VarChar, 20).Value = txtNom.Text.Trim
                .Parameters.Add("@prenom", SqlDbType.VarChar, 20).Value = txtPrenom.Text.Trim
                If optFeminin.Checked = True Then
                    .Parameters.Add("@sexe", SqlDbType.Char).Value = "F"
                Else
                    .Parameters.Add("@sexe", SqlDbType.Char).Value = "M"
                End If
                .Parameters.Add("@adr", SqlDbType.VarChar, 100).Value = txtAdresse.Text.Trim
                .Parameters.Add("@ville", SqlDbType.VarChar, 50).Value = txtVille.Text.Trim
                .Parameters.Add("@prov", SqlDbType.VarChar, 50).Value = cboProvince.SelectedText
                .Parameters.Add("@tel", SqlDbType.VarChar, 14).Value = mskTel.Text
                .Parameters.Add("@cp", SqlDbType.VarChar, 7).Value = mskCp.Text.Trim

            End With

            ' Executer la requete
            comAjout.ExecuteNonQuery()
            MsgBox("Élève Ajouter Avec Succès")
            Remplir_Etu()
            lvEtudiants.SelectedIndices.Add(lvEtudiants.Items.Count - 1)

        Catch ex As SqlException
            If ex.Number = 2 Then
                MsgBox("Impossible de se connecter au serveur SQL")
                End
            ElseIf ex.Number = 4060 Then
                MsgBox("DB invalide")
                End
            ElseIf ex.Number = 18452 Then
                MsgBox("Login invalide")
                End
            ElseIf ex.Number = 2627 Then
                MsgBox("Clé primaire invalide car déjâ utilisé")
            ElseIf ex.Number = 150 Then
                MsgBox("Les deux termes d'une jointure externe doivent contenir des colonnes.")
            ElseIf ex.Number = 16929 Then
                MsgBox("Le curseur est READ ONLY.")
            Else
                MsgBox(ex.Number & " " & ex.Message)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPrenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVille.KeyPress, txtPrenom.KeyPress, txtNom.KeyPress, txtAdresse.KeyPress
        e.Handled = Char.IsDigit(e.KeyChar)
    End Sub

    Private Sub txtNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class