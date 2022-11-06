Public Class Form1
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        txtNama.Text = ""
        txtNPM.Text = ""
        txtTugas.Text = ""
        txtUTS.Text = ""
        txtUAS.Text = ""
        txtTotal.Text = ""
        txtIPS.Text = ""
        txtIPK.Text = ""
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim Nama = txtNama.Text()
        Dim NPM = txtNPM.Text()
        Dim Tugas = txtTugas.Text()
        Dim UTS = txtUTS.Text()
        Dim UAS = txtUAS.Text()
        Dim IPS = txtIPS.Text()
        Dim IPK = txtIPK.Text()
        Dim Totalnilai = txtTotal.Text()
        txtTotal.Text = txtTugas.Text * 20 / 100 + txtUTS.Text * 30 / 100 + txtUAS.Text * 50 / 100
        txtIPS.Text = txtTotal.Text * 4 / 100
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
