Public Class Form1

    ' These have to be in Public Class, otherwise they will reset each time "Race" is clicked.
    Dim intBlueCarCount As Integer
    Dim intRedCarCount As Integer
    Dim intPurpleCarCount As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim randCar As Integer
        Dim rand As New Random
        Dim intCount1, intCount2, intCount3 As Integer
        Dim intScore As Integer = 1
        Dim intWinner As Integer = 5

        ' randCar = 3: There are 3 different variables to randomly choose, with the values starting at 0.
        ' This gives a total of three values: 0, 1, and 2, which is why randCar = 3.
        randCar = rand.Next(3)

        For intCount1 = 12 To rand.Next(200) + 780
            picBlueCar.Left = intCount1
        Next
        For intCount2 = 12 To rand.Next(200) + 780
            picRedCar.Left = intCount2
        Next
        For intCount3 = 12 To rand.Next(200) + 780
            picPurpleCar.Left = intCount3
        Next

        If intCount1 > intCount2 And intCount3 Then
            intBlueCarCount = intBlueCarCount + 1
            lblBlueWin.Text = intBlueCarCount
            MessageBox.Show("Blue wins!")
            If intBlueCarCount = intWinner Then
                MessageBox.Show("Blue takes home the trophy!")
                MessageBox.Show("You can keep playing if you'd like; but the game has finished. Click reset to restart.")
            End If

        ElseIf intCount2 > intCount1 And intCount3 Then
            intRedCarCount = intRedCarCount + 1
            lblRedWin.Text = intRedCarCount
            MessageBox.Show("Red wins!")
            If intRedCarCount = intWinner Then
                MessageBox.Show("Red wins it all!")
                MessageBox.Show("You can keep playing if you'd like; but the game has finished. Click reset to restart.")
            End If

        ElseIf intCount3 > intCount1 And intCount2 Then
            intPurpleCarCount = intPurpleCarCount + 1
            lblPurpleWin.Text = intPurpleCarCount
            MessageBox.Show("Purple wins!")
            If intPurpleCarCount = intWinner Then
                MessageBox.Show("Purple wins the grand prix!")
                MessageBox.Show("You can keep playing if you'd like; but the game has finished. Click reset to restart.")
            End If
        End If
        btnRace.Visible = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        picBlueCar.Left = 12
        picRedCar.Left = 12
        picPurpleCar.Left = 12

        btnRace.Visible = True
    End Sub

    Private Sub btnRestartGame_Click(sender As Object, e As EventArgs)
        picBlueCar.Left = 12
        picRedCar.Left = 12
        picPurpleCar.Left = 12

        btnRace.Visible = True

        lblBlueWin.Text = ToString()
        lblRedWin.Text = ToString()
        lblPurpleWin.Text = ToString()
    End Sub
End Class
