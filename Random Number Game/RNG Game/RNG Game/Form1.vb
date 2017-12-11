Public Class GuessNum

    Dim Counter As Integer
    Dim CompGen As Integer

    Private Sub GuessNum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Number As New Random
        CompGen = Number.Next(100) + 1
        Counter = 0
        txtUG.Text = ("")
    End Sub

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim userGuess As Integer
        userGuess = CInt(txtUG.Text)
        Counter = Counter + 1
        Try
            If userGuess = CompGen Then
                MessageBox.Show("Well done! You guessed my number.")
            ElseIf userGuess < CompGen Then
                MessageBox.Show("Not quite! Your number is too low. Try again!")
            ElseIf userGuess > CompGen Then
                MessageBox.Show("Nope! Your number is too high. Guess again!")
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a valid number and try again.")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim rQuit As DialogResult
        rQuit = MessageBox.Show("Are you sure you want to quit?", "Game Quit", MessageBoxButtons.YesNo)
        If rQuit = Windows.Forms.DialogResult.No Then
            MessageBox.Show("Yes, continue!")
        ElseIf rQuit = Windows.Forms.DialogResult.Yes Then
            Me.Close()

        End If
    End Sub
End Class
