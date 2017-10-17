<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProgramme
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
<<<<<<< HEAD
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramme))
        Me.grpProgramme = New System.Windows.Forms.GroupBox()
        Me.txtNbrHeure = New System.Windows.Forms.TextBox()
        Me.txtNbrUnites = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
=======
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramme))
        Me.grpProgramme = New System.Windows.Forms.GroupBox()
        Me.txtno = New System.Windows.Forms.MaskedTextBox()
        Me.txtNbrHeure = New System.Windows.Forms.TextBox()
        Me.txtNbrUnites = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
        Me.lblNbrHeure = New System.Windows.Forms.Label()
        Me.lblNbrUnite = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdNouveau = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdEnlever = New System.Windows.Forms.Button()
        Me.lvProgramme = New System.Windows.Forms.ListView()
        Me.colNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNbrUnite = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNbrHeure = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvEtudiant = New System.Windows.Forms.ListView()
        Me.colDA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNoProg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNomEtu = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
<<<<<<< HEAD
        Me.grpProgramme.SuspendLayout()
=======
        Me.Err1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpProgramme.SuspendLayout()
        CType(Me.Err1, System.ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
        Me.SuspendLayout()
        '
        'grpProgramme
        '
<<<<<<< HEAD
        Me.grpProgramme.Controls.Add(Me.txtNbrHeure)
        Me.grpProgramme.Controls.Add(Me.txtNbrUnites)
        Me.grpProgramme.Controls.Add(Me.txtNom)
        Me.grpProgramme.Controls.Add(Me.txtNo)
=======
        Me.grpProgramme.Controls.Add(Me.txtno)
        Me.grpProgramme.Controls.Add(Me.txtNbrHeure)
        Me.grpProgramme.Controls.Add(Me.txtNbrUnites)
        Me.grpProgramme.Controls.Add(Me.txtNom)
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
        Me.grpProgramme.Controls.Add(Me.lblNbrHeure)
        Me.grpProgramme.Controls.Add(Me.lblNbrUnite)
        Me.grpProgramme.Controls.Add(Me.lblNom)
        Me.grpProgramme.Controls.Add(Me.lblNo)
        Me.grpProgramme.Enabled = False
        Me.grpProgramme.Location = New System.Drawing.Point(12, 12)
        Me.grpProgramme.Name = "grpProgramme"
        Me.grpProgramme.Size = New System.Drawing.Size(442, 219)
        Me.grpProgramme.TabIndex = 0
        Me.grpProgramme.TabStop = False
        Me.grpProgramme.Text = "Programme"
        '
<<<<<<< HEAD
=======
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(146, 43)
        Me.txtno.Mask = "LLL.0L"
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(126, 29)
        Me.txtno.TabIndex = 0
        '
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
        'txtNbrHeure
        '
        Me.txtNbrHeure.Location = New System.Drawing.Point(146, 168)
        Me.txtNbrHeure.Name = "txtNbrHeure"
        Me.txtNbrHeure.Size = New System.Drawing.Size(126, 29)
        Me.txtNbrHeure.TabIndex = 8
        '
        'txtNbrUnites
        '
        Me.txtNbrUnites.Location = New System.Drawing.Point(146, 124)
        Me.txtNbrUnites.Name = "txtNbrUnites"
        Me.txtNbrUnites.Size = New System.Drawing.Size(126, 29)
        Me.txtNbrUnites.TabIndex = 7
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(146, 80)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(255, 29)
        Me.txtNom.TabIndex = 6
        '
<<<<<<< HEAD
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(146, 43)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(126, 29)
        Me.txtNo.TabIndex = 5
        '
=======
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
        'lblNbrHeure
        '
        Me.lblNbrHeure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNbrHeure.Location = New System.Drawing.Point(16, 168)
        Me.lblNbrHeure.Name = "lblNbrHeure"
        Me.lblNbrHeure.Size = New System.Drawing.Size(124, 29)
        Me.lblNbrHeure.TabIndex = 4
        Me.lblNbrHeure.Text = "Nbr Heure:"
        '
        'lblNbrUnite
        '
        Me.lblNbrUnite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNbrUnite.Location = New System.Drawing.Point(16, 124)
        Me.lblNbrUnite.Name = "lblNbrUnite"
        Me.lblNbrUnite.Size = New System.Drawing.Size(124, 29)
        Me.lblNbrUnite.TabIndex = 3
        Me.lblNbrUnite.Text = "Nbr Unites:"
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(16, 80)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(124, 29)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom:"
        '
        'lblNo
        '
        Me.lblNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNo.Location = New System.Drawing.Point(16, 43)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(124, 29)
        Me.lblNo.TabIndex = 1
        Me.lblNo.Text = "No:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, -87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(311, 405)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdNouveau
        '
        Me.cmdNouveau.Location = New System.Drawing.Point(510, 25)
        Me.cmdNouveau.Name = "cmdNouveau"
        Me.cmdNouveau.Size = New System.Drawing.Size(134, 30)
        Me.cmdNouveau.TabIndex = 1
        Me.cmdNouveau.Text = "Nouveau"
        Me.cmdNouveau.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Enabled = False
        Me.cmdOK.Location = New System.Drawing.Point(510, 61)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(134, 30)
        Me.cmdOK.TabIndex = 2
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Enabled = False
        Me.cmdAnnuler.Location = New System.Drawing.Point(510, 97)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(134, 30)
        Me.cmdAnnuler.TabIndex = 3
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'cmdModifier
        '
        Me.cmdModifier.Location = New System.Drawing.Point(510, 133)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(134, 30)
        Me.cmdModifier.TabIndex = 4
        Me.cmdModifier.Text = "Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = True
        '
        'cmdEnlever
        '
        Me.cmdEnlever.Location = New System.Drawing.Point(510, 169)
        Me.cmdEnlever.Name = "cmdEnlever"
        Me.cmdEnlever.Size = New System.Drawing.Size(134, 30)
        Me.cmdEnlever.TabIndex = 5
        Me.cmdEnlever.Text = "Enlever"
        Me.cmdEnlever.UseVisualStyleBackColor = True
        '
        'lvProgramme
        '
        Me.lvProgramme.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNo, Me.colNom, Me.colNbrUnite, Me.colNbrHeure})
        Me.lvProgramme.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProgramme.FullRowSelect = True
        Me.lvProgramme.GridLines = True
        Me.lvProgramme.Location = New System.Drawing.Point(12, 237)
        Me.lvProgramme.Name = "lvProgramme"
        Me.lvProgramme.Size = New System.Drawing.Size(672, 616)
        Me.lvProgramme.TabIndex = 6
        Me.lvProgramme.UseCompatibleStateImageBehavior = False
        Me.lvProgramme.View = System.Windows.Forms.View.Details
        '
        'colNo
        '
        Me.colNo.Text = "No"
        Me.colNo.Width = 100
        '
        'colNom
        '
        Me.colNom.Text = "Nom"
        Me.colNom.Width = 265
        '
        'colNbrUnite
        '
        Me.colNbrUnite.Text = "Nbr. Unités"
        Me.colNbrUnite.Width = 150
        '
        'colNbrHeure
        '
        Me.colNbrHeure.Text = "Nbr. Heures"
        Me.colNbrHeure.Width = 150
        '
        'lvEtudiant
        '
        Me.lvEtudiant.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDA, Me.colNoProg, Me.colPrenom, Me.colNomEtu})
        Me.lvEtudiant.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvEtudiant.FullRowSelect = True
        Me.lvEtudiant.GridLines = True
        Me.lvEtudiant.Location = New System.Drawing.Point(702, 25)
        Me.lvEtudiant.Name = "lvEtudiant"
        Me.lvEtudiant.Size = New System.Drawing.Size(684, 828)
        Me.lvEtudiant.TabIndex = 7
        Me.lvEtudiant.UseCompatibleStateImageBehavior = False
        Me.lvEtudiant.View = System.Windows.Forms.View.Details
        '
        'colDA
        '
        Me.colDA.Text = "DA"
        Me.colDA.Width = 125
        '
        'colNoProg
        '
        Me.colNoProg.Text = "No Prog."
        Me.colNoProg.Width = 125
        '
        'colPrenom
        '
        Me.colPrenom.Text = "Prénom"
        Me.colPrenom.Width = 220
        '
        'colNomEtu
        '
        Me.colNomEtu.Text = "Nom"
        Me.colNomEtu.Width = 200
        '
<<<<<<< HEAD
=======
        'Err1
        '
        Me.Err1.ContainerControl = Me
        '
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
        'frmProgramme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1441, 898)
        Me.Controls.Add(Me.lvEtudiant)
        Me.Controls.Add(Me.lvProgramme)
        Me.Controls.Add(Me.cmdEnlever)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdNouveau)
        Me.Controls.Add(Me.grpProgramme)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmProgramme"
        Me.Text = "frmProgramme"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpProgramme.ResumeLayout(False)
        Me.grpProgramme.PerformLayout()
<<<<<<< HEAD
=======
        CType(Me.Err1, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpProgramme As GroupBox
    Friend WithEvents txtNbrHeure As TextBox
    Friend WithEvents txtNbrUnites As TextBox
    Friend WithEvents txtNom As TextBox
<<<<<<< HEAD
    Friend WithEvents txtNo As TextBox
=======
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
    Friend WithEvents lblNbrHeure As Label
    Friend WithEvents lblNbrUnite As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblNo As Label
    Friend WithEvents cmdNouveau As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents cmdModifier As Button
    Friend WithEvents cmdEnlever As Button
    Friend WithEvents lvProgramme As ListView
    Friend WithEvents colNo As ColumnHeader
    Friend WithEvents colNom As ColumnHeader
    Friend WithEvents colNbrUnite As ColumnHeader
    Friend WithEvents colNbrHeure As ColumnHeader
    Friend WithEvents lvEtudiant As ListView
    Friend WithEvents colDA As ColumnHeader
    Friend WithEvents colNoProg As ColumnHeader
    Friend WithEvents colPrenom As ColumnHeader
    Friend WithEvents colNomEtu As ColumnHeader
    Friend WithEvents Button1 As Button
<<<<<<< HEAD
=======
    Friend WithEvents txtno As MaskedTextBox
    Friend WithEvents Err1 As ErrorProvider
>>>>>>> 97a0065b1def2a6a2b563d1e5e8bcedad5943856
End Class
