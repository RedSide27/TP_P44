Public Class frmMenu
    Private Sub ProgrammesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammesToolStripMenuItem.Click
        Dim Programme As New frmProgramme
        Programme.MdiParent = Me
        Programme.Show()
    End Sub

    Private Sub ÉtudiantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÉtudiantsToolStripMenuItem.Click
        Dim Etudiant As New frmEtudiants
        Etudiant.MdiParent = Me
        Etudiant.Show()
    End Sub
End Class
