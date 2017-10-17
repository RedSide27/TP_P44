<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtudiants
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtudiants))
        Me.cmdEnlever = New System.Windows.Forms.Button()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdNouveau = New System.Windows.Forms.Button()
        Me.grpEtudiants = New System.Windows.Forms.GroupBox()
        Me.txtProg = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblCodePostal = New System.Windows.Forms.Label()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.grpSexe = New System.Windows.Forms.GroupBox()
        Me.optMasculin = New System.Windows.Forms.RadioButton()
        Me.optFeminin = New System.Windows.Forms.RadioButton()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNoProg = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblDA = New System.Windows.Forms.Label()
        Me.lvEtudiants = New System.Windows.Forms.ListView()
        Me.colDA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNoProg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSexe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAdresse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVille = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCodePostal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTelephone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colProvince = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.err1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.mskCp = New System.Windows.Forms.MaskedTextBox()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.grpEtudiants.SuspendLayout()
        Me.grpSexe.SuspendLayout()
        CType(Me.err1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdEnlever
        '
        Me.cmdEnlever.Location = New System.Drawing.Point(1186, 163)
        Me.cmdEnlever.Name = "cmdEnlever"
        Me.cmdEnlever.Size = New System.Drawing.Size(134, 30)
        Me.cmdEnlever.TabIndex = 11
        Me.cmdEnlever.Text = "Enlever"
        Me.cmdEnlever.UseVisualStyleBackColor = True
        '
        'cmdModifier
        '
        Me.cmdModifier.Location = New System.Drawing.Point(1186, 127)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(134, 30)
        Me.cmdModifier.TabIndex = 10
        Me.cmdModifier.Text = "Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = True
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Enabled = False
        Me.cmdAnnuler.Location = New System.Drawing.Point(1186, 91)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(134, 30)
        Me.cmdAnnuler.TabIndex = 9
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Enabled = False
        Me.cmdOK.Location = New System.Drawing.Point(1186, 55)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(134, 30)
        Me.cmdOK.TabIndex = 8
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdNouveau
        '
        Me.cmdNouveau.Location = New System.Drawing.Point(1186, 19)
        Me.cmdNouveau.Name = "cmdNouveau"
        Me.cmdNouveau.Size = New System.Drawing.Size(134, 30)
        Me.cmdNouveau.TabIndex = 7
        Me.cmdNouveau.Text = "Nouveau"
        Me.cmdNouveau.UseVisualStyleBackColor = True
        '
        'grpEtudiants
        '
        Me.grpEtudiants.Controls.Add(Me.mskTel)
        Me.grpEtudiants.Controls.Add(Me.mskCp)
        Me.grpEtudiants.Controls.Add(Me.txtProg)
        Me.grpEtudiants.Controls.Add(Me.lblTelephone)
        Me.grpEtudiants.Controls.Add(Me.lblCodePostal)
        Me.grpEtudiants.Controls.Add(Me.cboProvince)
        Me.grpEtudiants.Controls.Add(Me.lblProvince)
        Me.grpEtudiants.Controls.Add(Me.txtAdresse)
        Me.grpEtudiants.Controls.Add(Me.lblAdresse)
        Me.grpEtudiants.Controls.Add(Me.txtVille)
        Me.grpEtudiants.Controls.Add(Me.lblVille)
        Me.grpEtudiants.Controls.Add(Me.grpSexe)
        Me.grpEtudiants.Controls.Add(Me.txtPrenom)
        Me.grpEtudiants.Controls.Add(Me.lblPrenom)
        Me.grpEtudiants.Controls.Add(Me.lblNoProg)
        Me.grpEtudiants.Controls.Add(Me.txtNom)
        Me.grpEtudiants.Controls.Add(Me.txtNo)
        Me.grpEtudiants.Controls.Add(Me.lblNom)
        Me.grpEtudiants.Controls.Add(Me.lblDA)
        Me.grpEtudiants.Enabled = False
        Me.grpEtudiants.Location = New System.Drawing.Point(12, 19)
        Me.grpEtudiants.Name = "grpEtudiants"
        Me.grpEtudiants.Size = New System.Drawing.Size(1051, 325)
        Me.grpEtudiants.TabIndex = 6
        Me.grpEtudiants.TabStop = False
        Me.grpEtudiants.Text = "Étudiants"
        '
        'txtProg
        '
        Me.txtProg.Location = New System.Drawing.Point(146, 86)
        Me.txtProg.Name = "txtProg"
        Me.txtProg.Size = New System.Drawing.Size(126, 29)
        Me.txtProg.TabIndex = 8
        '
        'lblTelephone
        '
        Me.lblTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelephone.Location = New System.Drawing.Point(411, 196)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(124, 29)
        Me.lblTelephone.TabIndex = 20
        Me.lblTelephone.Text = "Telephone:"
        '
        'lblCodePostal
        '
        Me.lblCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCodePostal.Location = New System.Drawing.Point(411, 159)
        Me.lblCodePostal.Name = "lblCodePostal"
        Me.lblCodePostal.Size = New System.Drawing.Size(124, 29)
        Me.lblCodePostal.TabIndex = 18
        Me.lblCodePostal.Text = "Code Postal"
        '
        'cboProvince
        '
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Items.AddRange(New Object() {"Alberta", "Colombie-Britanique", "Ontario", "Québec", "Nouvelle-Écosse", "Terre-Neuve-et-Labrador", "Manitoba", "Nouveau-Brunswick", "Île-du-Prince-Édouard", "Saskatchewan"})
        Me.cboProvince.Location = New System.Drawing.Point(541, 122)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(255, 30)
        Me.cboProvince.TabIndex = 17
        '
        'lblProvince
        '
        Me.lblProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProvince.Location = New System.Drawing.Point(411, 123)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(124, 29)
        Me.lblProvince.TabIndex = 16
        Me.lblProvince.Text = "Province"
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(541, 41)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(362, 29)
        Me.txtAdresse.TabIndex = 15
        '
        'lblAdresse
        '
        Me.lblAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdresse.Location = New System.Drawing.Point(411, 43)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(124, 29)
        Me.lblAdresse.TabIndex = 14
        Me.lblAdresse.Text = "Adresse:"
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(541, 82)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(300, 29)
        Me.txtVille.TabIndex = 13
        '
        'lblVille
        '
        Me.lblVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVille.Location = New System.Drawing.Point(411, 84)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(124, 29)
        Me.lblVille.TabIndex = 12
        Me.lblVille.Text = "Ville:"
        '
        'grpSexe
        '
        Me.grpSexe.Controls.Add(Me.optMasculin)
        Me.grpSexe.Controls.Add(Me.optFeminin)
        Me.grpSexe.Location = New System.Drawing.Point(146, 194)
        Me.grpSexe.Name = "grpSexe"
        Me.grpSexe.Size = New System.Drawing.Size(157, 117)
        Me.grpSexe.TabIndex = 11
        Me.grpSexe.TabStop = False
        Me.grpSexe.Text = "Sexe"
        '
        'optMasculin
        '
        Me.optMasculin.AutoSize = True
        Me.optMasculin.Location = New System.Drawing.Point(16, 71)
        Me.optMasculin.Name = "optMasculin"
        Me.optMasculin.Size = New System.Drawing.Size(108, 26)
        Me.optMasculin.TabIndex = 1
        Me.optMasculin.TabStop = True
        Me.optMasculin.Text = "Masculin"
        Me.optMasculin.UseVisualStyleBackColor = True
        '
        'optFeminin
        '
        Me.optFeminin.AutoSize = True
        Me.optFeminin.Location = New System.Drawing.Point(16, 28)
        Me.optFeminin.Name = "optFeminin"
        Me.optFeminin.Size = New System.Drawing.Size(99, 26)
        Me.optFeminin.TabIndex = 0
        Me.optFeminin.TabStop = True
        Me.optFeminin.Text = "Féminin"
        Me.optFeminin.UseVisualStyleBackColor = True
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(146, 121)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(255, 29)
        Me.txtPrenom.TabIndex = 10
        '
        'lblPrenom
        '
        Me.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrenom.Location = New System.Drawing.Point(16, 123)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(124, 29)
        Me.lblPrenom.TabIndex = 9
        Me.lblPrenom.Text = "Prénom:"
        '
        'lblNoProg
        '
        Me.lblNoProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoProg.Location = New System.Drawing.Point(16, 84)
        Me.lblNoProg.Name = "lblNoProg"
        Me.lblNoProg.Size = New System.Drawing.Size(124, 29)
        Me.lblNoProg.TabIndex = 7
        Me.lblNoProg.Text = "No. Prog:"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(146, 154)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(255, 29)
        Me.txtNom.TabIndex = 6
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(146, 43)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(126, 29)
        Me.txtNo.TabIndex = 5
        '
        'lblNom
        '
        Me.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNom.Location = New System.Drawing.Point(16, 156)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(124, 29)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "Nom:"
        '
        'lblDA
        '
        Me.lblDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDA.Location = New System.Drawing.Point(16, 43)
        Me.lblDA.Name = "lblDA"
        Me.lblDA.Size = New System.Drawing.Size(124, 29)
        Me.lblDA.TabIndex = 1
        Me.lblDA.Text = "DA:"
        '
        'lvEtudiants
        '
        Me.lvEtudiants.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDA, Me.colNoProg, Me.colPrenom, Me.colNom, Me.colSexe, Me.colAdresse, Me.colVille, Me.colCodePostal, Me.colTelephone, Me.colProvince})
        Me.lvEtudiants.FullRowSelect = True
        Me.lvEtudiants.GridLines = True
        Me.lvEtudiants.Location = New System.Drawing.Point(12, 367)
        Me.lvEtudiants.Name = "lvEtudiants"
        Me.lvEtudiants.Size = New System.Drawing.Size(1310, 486)
        Me.lvEtudiants.TabIndex = 12
        Me.lvEtudiants.UseCompatibleStateImageBehavior = False
        Me.lvEtudiants.View = System.Windows.Forms.View.Details
        '
        'colDA
        '
        Me.colDA.Text = "DA"
        Me.colDA.Width = 100
        '
        'colNoProg
        '
        Me.colNoProg.Text = "No Prog."
        Me.colNoProg.Width = 100
        '
        'colPrenom
        '
        Me.colPrenom.Text = "Prénom"
        Me.colPrenom.Width = 175
        '
        'colNom
        '
        Me.colNom.Text = "Nom"
        Me.colNom.Width = 175
        '
        'colSexe
        '
        Me.colSexe.Text = "Sexe"
        '
        'colAdresse
        '
        Me.colAdresse.Text = "Adresse"
        Me.colAdresse.Width = 200
        '
        'colVille
        '
        Me.colVille.Text = "Ville"
        Me.colVille.Width = 150
        '
        'colCodePostal
        '
        Me.colCodePostal.Text = "Code Postal"
        Me.colCodePostal.Width = 125
        '
        'colTelephone
        '
        Me.colTelephone.Text = "Téléphone"
        Me.colTelephone.Width = 120
        '
        'colProvince
        '
        Me.colProvince.Text = "Province"
        Me.colProvince.Width = 100
        '
        'err1
        '
        Me.err1.ContainerControl = Me
        '
        'mskCp
        '
        Me.mskCp.Location = New System.Drawing.Point(541, 161)
        Me.mskCp.Mask = "L0L-0L0"
        Me.mskCp.Name = "mskCp"
        Me.mskCp.Size = New System.Drawing.Size(91, 29)
        Me.mskCp.TabIndex = 21
        '
        'mskTel
        '
        Me.mskTel.Location = New System.Drawing.Point(541, 196)
        Me.mskTel.Mask = "(000) 000-0000"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(141, 29)
        Me.mskTel.TabIndex = 22
        '
        'frmEtudiants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1441, 898)
        Me.Controls.Add(Me.lvEtudiants)
        Me.Controls.Add(Me.cmdEnlever)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdNouveau)
        Me.Controls.Add(Me.grpEtudiants)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEtudiants"
        Me.Text = "frmEtudiants"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpEtudiants.ResumeLayout(False)
        Me.grpEtudiants.PerformLayout()
        Me.grpSexe.ResumeLayout(False)
        Me.grpSexe.PerformLayout()
        CType(Me.err1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdEnlever As Button
    Friend WithEvents cmdModifier As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdNouveau As Button
    Friend WithEvents grpEtudiants As GroupBox
    Friend WithEvents lblNoProg As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtNo As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents lblDA As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblCodePostal As Label
    Friend WithEvents cboProvince As ComboBox
    Friend WithEvents lblProvince As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents lblAdresse As Label
    Friend WithEvents txtVille As TextBox
    Friend WithEvents lblVille As Label
    Friend WithEvents grpSexe As GroupBox
    Friend WithEvents optMasculin As RadioButton
    Friend WithEvents optFeminin As RadioButton
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lvEtudiants As ListView
    Friend WithEvents colDA As ColumnHeader
    Friend WithEvents colNoProg As ColumnHeader
    Friend WithEvents colPrenom As ColumnHeader
    Friend WithEvents colNom As ColumnHeader
    Friend WithEvents colSexe As ColumnHeader
    Friend WithEvents colAdresse As ColumnHeader
    Friend WithEvents colVille As ColumnHeader
    Friend WithEvents colCodePostal As ColumnHeader
    Friend WithEvents colTelephone As ColumnHeader
    Friend WithEvents colProvince As ColumnHeader
    Friend WithEvents err1 As ErrorProvider
    Friend WithEvents txtProg As TextBox
    Friend WithEvents mskTel As MaskedTextBox
    Friend WithEvents mskCp As MaskedTextBox
End Class
