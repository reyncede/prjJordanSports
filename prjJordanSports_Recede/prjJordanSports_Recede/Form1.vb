Public Class frmMain

    'Values for paychecks
    Private ReadOnly WEEKLY_PAYCHECK As Integer = 52
    Private ReadOnly BIWEEKLY_PAYCHECK As Integer = 26

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim annualSalary As Double = Val(txtAnnual.Text)
        'To get the weekly gross pay
        Dim weeklyGrossPay As Double = annualSalary / WEEKLY_PAYCHECK
        'To get the biweekly gross pay
        Dim biweeklyGrossPay As Double = annualSalary / BIWEEKLY_PAYCHECK
        txtWeekly.Text = formatPay(weeklyGrossPay)
        txtBiweekly.Text = formatPay(biweeklyGrossPay)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Hides the buttons in the form
        toggleUI(False)
        PrintForm1.Print()
        'Redisplays the button in the form
        toggleUI(True)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the textboxes
        txtAnnual.Clear()
        txtWeekly.Clear()
        txtBiweekly.Clear()
        txtAnnual.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Function formatPay(Expression As Double) As String
        'Formats expression to have dollar sign and end with decimals
        Return Format(Expression, "$#,##0.00")
    End Function

    Private Sub toggleUI(b As Boolean)
        'Sets the visibility of the buttons
        btnCalc.Visible = b
        btnPrint.Visible = b
        btnClear.Visible = b
        btnExit.Visible = b
    End Sub

End Class
