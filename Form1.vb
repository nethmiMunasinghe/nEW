Public Class Form1
    Dim Sub1, Sub2, Sub3, Total, Average As Double
    Dim Grade As String

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Sub1 = Convert.ToDouble(txtSub1.Text)
        Sub2 = Convert.ToDouble(txtSub2.Text)
        Sub3 = Convert.ToDouble(txtSub3.Text)

        ' Calculate total and average
        Total = Sub1 + Sub2 + Sub3
        txtTotal.Text = Total.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IndexNo As String
        Dim Name As String



        IndexNo = InputBox("Enter Index Number")
        txtIndex.Text = IndexNo
        Name = InputBox("Enter Your Name")
        txtName.Text = Name



    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtIndex.Text = ""
        txtName.Text = ""
        txtSub1.Text = ""
        txtSub2.Text = ""
        txtSub3.Text = ""
        txtTotal.Text = ""
        txtAverage.Text = ""
        txtGrade.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        ' Convert text box values to numbers
        Sub1 = Convert.ToDouble(txtSub1.Text)
        Sub2 = Convert.ToDouble(txtSub2.Text)
        Sub3 = Convert.ToDouble(txtSub3.Text)

        ' Calculate total and average
        Total = Sub1 + Sub2 + Sub3
        Average = Total / 3

        ' Update text boxes with calculated values
        'txtTotal.Text = Total.ToString()
        txtAverage.Text = Average.ToString()
    End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        ' Ensure average is calculated first
        Average = Convert.ToDouble(txtAverage.Text)

        ' Determine grade based on average
        If Average >= 75 And Average <= 100 Then
            Grade = "A"
        ElseIf Average >= 65 And Average < 75 Then
            Grade = "B"
        ElseIf Average >= 55 And Average < 65 Then
            Grade = "C"
        ElseIf Average >= 40 And Average < 55 Then
            Grade = "S"
        Else
            Grade = "F"
        End If

        ' Update grade text box
        txtGrade.Text = Grade
    End Sub
End Class