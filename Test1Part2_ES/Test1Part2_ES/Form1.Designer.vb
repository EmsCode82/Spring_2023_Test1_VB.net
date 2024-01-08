<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConcertTickets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.txtTicketPrice = New System.Windows.Forms.TextBox()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotalProfit = New System.Windows.Forms.Label()
        Me.lblTotalGrossSales = New System.Windows.Forms.Label()
        Me.lblTotalTickets = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTickets
        '
        Me.txtTickets.Location = New System.Drawing.Point(123, 22)
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(83, 20)
        Me.txtTickets.TabIndex = 0
        '
        'txtTicketPrice
        '
        Me.txtTicketPrice.Location = New System.Drawing.Point(123, 45)
        Me.txtTicketPrice.Name = "txtTicketPrice"
        Me.txtTicketPrice.Size = New System.Drawing.Size(83, 20)
        Me.txtTicketPrice.TabIndex = 1
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(123, 85)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(83, 27)
        Me.lblSubTotal.TabIndex = 2
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(123, 136)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(83, 27)
        Me.lblTax.TabIndex = 3
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Location = New System.Drawing.Point(123, 187)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(83, 27)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTicketPrice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTickets)
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.lblSubTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 236)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Order"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(17, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Price"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(17, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tax"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(17, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Sub-Total"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ticket Price"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Number of Tickets"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Profit"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Gross Sales"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Tickets Sold"
        '
        'lblTotalProfit
        '
        Me.lblTotalProfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalProfit.Location = New System.Drawing.Point(122, 126)
        Me.lblTotalProfit.Name = "lblTotalProfit"
        Me.lblTotalProfit.Size = New System.Drawing.Size(83, 27)
        Me.lblTotalProfit.TabIndex = 12
        Me.lblTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalGrossSales
        '
        Me.lblTotalGrossSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGrossSales.Location = New System.Drawing.Point(122, 75)
        Me.lblTotalGrossSales.Name = "lblTotalGrossSales"
        Me.lblTotalGrossSales.Size = New System.Drawing.Size(83, 27)
        Me.lblTotalGrossSales.TabIndex = 11
        Me.lblTotalGrossSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalTickets
        '
        Me.lblTotalTickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTickets.Location = New System.Drawing.Point(122, 24)
        Me.lblTotalTickets.Name = "lblTotalTickets"
        Me.lblTotalTickets.Size = New System.Drawing.Size(83, 27)
        Me.lblTotalTickets.TabIndex = 10
        Me.lblTotalTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalTickets)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblTotalGrossSales)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblTotalProfit)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 177)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daily Totals"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(26, 469)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(64, 23)
        Me.btnSubmit.TabIndex = 17
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClear.Location = New System.Drawing.Point(104, 469)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(64, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(182, 469)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmConcertTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 513)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConcertTickets"
        Me.Text = "Concert Tickets"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTickets As TextBox
    Friend WithEvents txtTicketPrice As TextBox
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotalProfit As Label
    Friend WithEvents lblTotalGrossSales As Label
    Friend WithEvents lblTotalTickets As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
