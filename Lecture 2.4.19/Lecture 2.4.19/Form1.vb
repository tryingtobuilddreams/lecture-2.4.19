Public Class Form1



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowGreeting_Click(sender As Object, e As EventArgs) Handles btnShowGreeting.Click
        ' variables to contain name
        Dim strName As String
        strName = txtInput.Text

        ' concatenates string and sends to label
        lblGreeting.Text = "Hello " & strName

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'declares variables
        Dim intFirst As Integer
        Dim intSecond As Integer
        Dim intSum As Integer

        'assigns variables
        intFirst = txtFirst.Text
        intSecond = txtSecond.Text

        ' calculation using the variables
        intSum = intFirst + intSecond

        'sends output to text box, anything in the textbox should be converted to a string
        txtSum.Text = intSum.ToString


    End Sub

    Private Sub btnClearAdd_Click(sender As Object, e As EventArgs) Handles btnClearAdd.Click
        ' clears labels and text boxes
        txtFirst.Text = ""
        txtSecond.Text = ""
        txtSum.Text = ""
        lblGreeting.Text = String.Empty
        txtInput.Text = String.Empty

        txtInput.Focus()
    End Sub
End Class
