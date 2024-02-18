Public Class Formmenuutama
    Private Sub Formmenuutama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Close()
        Formmenulogin.Show()
    End Sub

    Private Sub PetugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PetugasToolStripMenuItem.Click
        Formpetugas.Show()

    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaryawanToolStripMenuItem.Click
        Formkaryawan.Show()

    End Sub




    Private Sub DataAPDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataAPDToolStripMenuItem.Click
        formdataapd.Show()

    End Sub

    Private Sub Bpengambilan_Click(sender As Object, e As EventArgs) Handles Bpengambilan.Click
        Formambilapd.Show()
    End Sub

    Private Sub Bpengembalian_Click(sender As Object, e As EventArgs) Handles Bpengembalian.Click
        Formkembaliapd.Show()
    End Sub
End Class