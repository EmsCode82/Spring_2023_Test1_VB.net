Public Class frmConcertTickets

    'Declare Variables

    Dim intTotalTickets As Integer
    Dim dblTotalGrossSales As Double
    Dim dblTotalProfit As Double
    Const dblTaxRate = 0.07
    Const dblProfitRate = 0.2

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Declare variables

        Dim intTickets As Integer
        Dim dblTicketPrice As Double
        Dim dblSubTotal As Double
        Dim dblTax As Double
        Dim dblPrice As Double

        'Get Inputs

        intTickets = txtTickets.Text
        dblTicketPrice = txtTicketPrice.Text

        'Do Calculations

        intTotalTickets += intTickets
        dblSubTotal = dblTicketPrice * intTickets
        dblTotalGrossSales += dblSubTotal
        dblTotalProfit += dblSubTotal * dblProfitRate
        dblTax = dblSubTotal * dblTaxRate
        dblPrice = dblSubTotal + dblTax

        'Display Outputs

        lblSubTotal.Text = FormatCurrency(dblSubTotal)
        lblTax.Text = FormatCurrency(dblTax)
        lblPrice.Text = FormatCurrency(dblPrice)
        lblTotalTickets.Text = intTotalTickets
        lblTotalGrossSales.Text = FormatCurrency(dblTotalGrossSales)
        lblTotalProfit.Text = FormatCurrency(dblTotalProfit)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Reset Fields

        txtTickets.Clear()
        txtTicketPrice.Clear()
        lblSubTotal.ResetText()
        lblTax.ResetText()
        lblPrice.ResetText()
        txtTickets.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Exit Program

        Close()

    End Sub

End Class
