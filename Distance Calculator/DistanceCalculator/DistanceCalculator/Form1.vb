Public Class DistanceCalc

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblDistanceTraveled As Double
        Dim dblAnswer = 0

        Do While dblAnswer < CDbl(txtHours.Text)
            dblAnswer = dblAnswer + 1
            dblDistanceTraveled = (txtSpeed.Text) * dblAnswer
            listResults.Items.Add(dblAnswer.ToString + "       " + dblDistanceTraveled.ToString)
        Loop
        listResults.Items.Add("Total Distance: " + dblDistanceTraveled.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHours.Clear()
        txtSpeed.Clear()
        listResults.Items.Clear()
    End Sub
End Class
