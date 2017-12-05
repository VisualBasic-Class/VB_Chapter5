Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        lblCountryDisplay.Text = String.Empty
        lblPlayDisplay.Text = String.Empty
        lblArtistDisplay.Text = String.Empty

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        lblArtistDisplay.Text = cboArtists.Text
        lblCountryDisplay.Text = cboCountries.Text
        lblPlayDisplay.Text = cboPlays.Text

    End Sub
End Class
