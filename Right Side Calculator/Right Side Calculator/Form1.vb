Public Class RightTriangleCalculator
    Sub calcSideA(ByVal Bside As Double, ByVal Cside As Double)
        Dim Aside As Double
        Aside = Math.Sqrt(Bside * Cside + Cside * Cside)
        lblSideA.Text = Aside.ToString
    End Sub

    Sub calcSideB(ByVal Aside As Double, ByVal Cside As Double)
        Dim Bside As Double
        Bside = Math.Sqrt(Cside * Aside + Aside * Aside)
        lblSideB.Text = Bside.ToString
    End Sub

    Sub calcSideC(ByVal Aside As Double, ByVal Bside As Double)
        Dim Cside As Double
        Cside = Math.Sqrt(Aside * Bside + Bside * Bside)
        lblSideC.Text = Cside.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Dim result As Double
        If radioC.Checked = True Then
            calcSideC(CDbl(txtSideA.Text), CDbl(txtSideB.Text))
        End If

        If radioA.Checked = True Then
            calcSideA(CDbl(txtSideB.Text), CDbl(txtSideC.Text))
        End If

        If radioB.Checked = True Then
            calcSideB(CDbl(txtSideA.Text), CDbl(txtSideC.Text))
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblSideA.Text = " "
        lblSideB.Text = " "
        lblSideC.Text = " "

        txtSideA.Clear()
        txtSideB.Clear()
        txtSideC.Clear()
    End Sub
End Class
