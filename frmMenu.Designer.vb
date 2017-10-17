<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉtudiantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesProgrammesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesÉtudiantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesÉtudinatsParProgrammeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionToolStripMenuItem, Me.RapportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1441, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgrammesToolStripMenuItem, Me.ÉtudiantsToolStripMenuItem, Me.ToolStripMenuItem1, Me.QuitterToolStripMenuItem})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'ProgrammesToolStripMenuItem
        '
        Me.ProgrammesToolStripMenuItem.Name = "ProgrammesToolStripMenuItem"
        Me.ProgrammesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProgrammesToolStripMenuItem.Text = "Programmes"
        '
        'ÉtudiantsToolStripMenuItem
        '
        Me.ÉtudiantsToolStripMenuItem.Name = "ÉtudiantsToolStripMenuItem"
        Me.ÉtudiantsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ÉtudiantsToolStripMenuItem.Text = "Étudiants"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'RapportToolStripMenuItem
        '
        Me.RapportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDesProgrammesToolStripMenuItem, Me.ListeDesÉtudiantsToolStripMenuItem, Me.ListeDesÉtudinatsParProgrammeToolStripMenuItem})
        Me.RapportToolStripMenuItem.Name = "RapportToolStripMenuItem"
        Me.RapportToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.RapportToolStripMenuItem.Text = "Rapport"
        '
        'ListeDesProgrammesToolStripMenuItem
        '
        Me.ListeDesProgrammesToolStripMenuItem.Name = "ListeDesProgrammesToolStripMenuItem"
        Me.ListeDesProgrammesToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ListeDesProgrammesToolStripMenuItem.Text = "Liste des Programmes"
        '
        'ListeDesÉtudiantsToolStripMenuItem
        '
        Me.ListeDesÉtudiantsToolStripMenuItem.Name = "ListeDesÉtudiantsToolStripMenuItem"
        Me.ListeDesÉtudiantsToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ListeDesÉtudiantsToolStripMenuItem.Text = "Liste des Étudiants"
        '
        'ListeDesÉtudinatsParProgrammeToolStripMenuItem
        '
        Me.ListeDesÉtudinatsParProgrammeToolStripMenuItem.Name = "ListeDesÉtudinatsParProgrammeToolStripMenuItem"
        Me.ListeDesÉtudinatsParProgrammeToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ListeDesÉtudinatsParProgrammeToolStripMenuItem.Text = "Liste des étudiants par programme"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1441, 898)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmMenu"
        Me.Text = "DuppApp"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgrammesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÉtudiantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RapportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesProgrammesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesÉtudiantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesÉtudinatsParProgrammeToolStripMenuItem As ToolStripMenuItem
End Class
