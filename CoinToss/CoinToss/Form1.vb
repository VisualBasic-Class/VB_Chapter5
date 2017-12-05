Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnTossCoin_Click(sender As Object, e As EventArgs) Handles btnTossCoin.Click
        Dim intSideUp As Integer
        Dim rand As New Random

        ' Get a random number in the range of 0 to 1.
        ' 0 means tails up; 1 means heads up.
        intSideUp = rand.Next(2)

        ' Display the side that is up.
        If intSideUp = 0 Then
            picCoinHeads.Visible = True
            picCoinTails.Visible = False
        Else
            picCoinHeads.Visible = False
            picCoinHeads.Visible = True
        End If
    End Sub
End Class
