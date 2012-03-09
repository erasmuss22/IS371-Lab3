Public Class frmATM

    Private Sub frmATM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.ATMTable' table. You can move, or remove it, as needed.
        Me.ATMTableTableAdapter.Fill(Me.NorthwindDataSet.ATMTable)
        AccountNumCombo.SelectedIndex = -1
    End Sub

    Private Sub AccountNumCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles AccountNumCombo.SelectedIndexChanged
        If AccountNumCombo.SelectedIndex <> -1 Then
            OneButton.Enabled = True
            TwoButton.Enabled = True
            ThreeButton.Enabled = True
            FourButton.Enabled = True
            FiveButton.Enabled = True
            SixButton.Enabled = True
            SevenButton.Enabled = True
            EightButton.Enabled = True
            NineButton.Enabled = True
            ZeroButton.Enabled = True
            DoneButton.Enabled = True
            HeadsUpLabel.Text = "Enter your pin number on the pad."
            PinText.Clear()
        End If
    End Sub

    Private Sub OneButton_Click(sender As System.Object, e As System.EventArgs) Handles OneButton.Click
        PinText.AppendText("1")
    End Sub

    Private Sub TwoButton_Click(sender As System.Object, e As System.EventArgs) Handles TwoButton.Click
        PinText.AppendText("2")
    End Sub

    Private Sub ThreeButton_Click(sender As System.Object, e As System.EventArgs) Handles ThreeButton.Click
        PinText.AppendText("3")
    End Sub

    Private Sub FourButton_Click(sender As System.Object, e As System.EventArgs) Handles FourButton.Click
        PinText.AppendText("4")
    End Sub

    Private Sub FiveButton_Click(sender As System.Object, e As System.EventArgs) Handles FiveButton.Click
        PinText.AppendText("5")
    End Sub

    Private Sub SixButton_Click(sender As System.Object, e As System.EventArgs) Handles SixButton.Click
        PinText.AppendText("6")
    End Sub

    Private Sub SevenButton_Click(sender As System.Object, e As System.EventArgs) Handles SevenButton.Click
        PinText.AppendText("7")
    End Sub

    Private Sub EightButton_Click(sender As System.Object, e As System.EventArgs) Handles EightButton.Click
        PinText.AppendText("8")
    End Sub

    Private Sub NineButton_Click(sender As System.Object, e As System.EventArgs) Handles NineButton.Click
        PinText.AppendText("9")
    End Sub

    Private Sub ZeroButton_Click(sender As System.Object, e As System.EventArgs) Handles ZeroButton.Click
        PinText.AppendText("0")
    End Sub

    Private Sub DoneButton_Click(sender As System.Object, e As System.EventArgs) Handles DoneButton.Click
        OneButton.Enabled = False
        TwoButton.Enabled = False
        ThreeButton.Enabled = False
        FourButton.Enabled = False
        FiveButton.Enabled = False
        SixButton.Enabled = False
        SevenButton.Enabled = False
        EightButton.Enabled = False
        NineButton.Enabled = False
        ZeroButton.Enabled = False
        DoneButton.Enabled = False
        DoneButton.Enabled = False
        OkayButton.Enabled = False
        BalanceButton.Enabled = False
        WithdrawButton.Enabled = False
        PinText.Enabled = False
        HeadsUpLabel.Text = "Please select your account number."
        PinText.Clear()
        AccountNumCombo.Enabled = False
        AccountNumCombo.SelectedIndex = -1
    End Sub

    Private Sub PinText_TextChanged(sender As System.Object, e As System.EventArgs) Handles PinText.TextChanged
        OkayButton.Enabled = True
    End Sub

    Private Sub OkayButton_Click(sender As System.Object, e As System.EventArgs) Handles OkayButton.Click
        Dim custPin = PinText.Text
        Dim custAccout = AccountNumCombo.SelectedValue.ToString
        Dim actualCust =
            From customer In NorthwindDataSet.ATMTable
            Where customer.acctNum = custAccout
            Select customer
        If custPin = actualCust(0).pin Then
            PinText.Clear()
            PinText.Enabled = True
            WithdrawButton.Enabled = True
            BalanceButton.Enabled = True
            HeadsUpLabel.Text = "Your balance is: $" + actualCust(0).balance.ToString
            AccountNumCombo.Enabled = False
        Else

        End If
    End Sub
End Class
