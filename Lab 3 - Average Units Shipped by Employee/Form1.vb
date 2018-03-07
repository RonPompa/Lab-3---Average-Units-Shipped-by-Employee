Option Strict On

Public Class frmAverageUnitsShippedByEmployee


    'Variables
    'This is the minimum value integer for the range
    Private Const minValue As Integer = 0
    'This is the maximum value integer for the range
    Private Const maxValue As Integer = 1000
    'Number of days in a week
    Private Const daysInAWeek As Integer = 7
    'Units each day
    Private unitsEachDay(6) As Integer
    Private counter As Integer = 0
    'Calculates average
    Private average As Double
    Private total As Integer
    'Employee Averages and Total Averages

    Private avgUnits1Employee As Double
    Private avgUnits2Employee As Double
    Private avgUnits3Employee As Double
    Private avgTotalAverage As Double



    'At
    Private Const lastRowIndex As Integer = 2

    Private Const lastColumnIndex As Integer = 1

    Private numberArray(lastRowIndex, daysInAWeek - 1) As Integer

    Private currentRowIndex As Integer = 0

    Private currentColumnIndex As Integer = 0
    Private validated As String
    Private userinputValidated As Integer

    Private Function Validate(ByVal userInput1 As String, ByRef userinputValidated As Integer) As Boolean
        Dim userInput2 As Integer
        Dim returnValue As Boolean = True
        'Ranges
        If (Integer.TryParse(userInput1, userInput2)) Then
            If userInput2 >= 0 AndAlso userInput2 <= 1000 Then
                userinputValidated = userInput2
                returnValue = True

            Else
                returnValue = False


            End If
        Else
            returnValue = False

        End If
        Return returnValue



    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDay.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblEmployee1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        validated = txtUnitsInput.Text
        If Validate(validated, userinputValidated) = False Then
            MessageBox.Show("The value must be a whole number and between the ranges of 0 - 1000", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtUnitsInput.Text = ""
            txtUnitsInput.Focus()




        Else
            numberArray(currentRowIndex, currentColumnIndex) = userinputValidated
            If currentRowIndex = 0 Then
                lblEmployee1Output.Text += numberArray(currentRowIndex, currentColumnIndex) & vbCrLf
            ElseIf currentRowIndex = 1 Then
                lblEmployee2Output.Text += numberArray(currentRowIndex, currentColumnIndex) & vbCrLf
            ElseIf currentRowIndex = 2 Then
                lblEmployee3Output.Text += numberArray(currentRowIndex, currentColumnIndex) & vbCrLf


            End If
            'Day Counter
            lblDay.Text = "Days: " & counter + 1
            counter += 1
            currentColumnIndex += 1
            txtUnitsInput.Text = ""

            If currentRowIndex = 0 And currentColumnIndex > 6 Then
                For averageCtr As Integer = 0 To (daysInAWeek - 1)
                    avgUnits1Employee = avgUnits1Employee + numberArray(currentRowIndex, averageCtr)
                Next

                avgUnits1Employee = avgUnits1Employee / (daysInAWeek)

                lblEmployee1Average.Text = "Average: " & Math.Round(avgUnits1Employee, 2)
            End If

            If currentRowIndex = 1 And currentColumnIndex > 6 Then
                For averageCtr As Integer = 0 To (daysInAWeek - 1)
                    avgUnits2Employee = avgUnits2Employee + numberArray(currentRowIndex, averageCtr)
                Next

                avgUnits2Employee = avgUnits2Employee / (daysInAWeek)

                lblEmployee2Average.Text = "Average: " & Math.Round(avgUnits2Employee, 2)


            End If

            If currentRowIndex = 2 And currentColumnIndex > 6 Then
                For averageCtr As Integer = 0 To (daysInAWeek - 1)
                    avgUnits3Employee = avgUnits3Employee + numberArray(currentRowIndex, averageCtr)
                Next

                avgUnits3Employee = avgUnits3Employee / (daysInAWeek)

                lblEmployee3Average.Text = "Average: " & Math.Round(avgUnits3Employee, 2)



                avgTotalAverage = (avgUnits1Employee + avgUnits2Employee + avgUnits3Employee) / 3

                lblAveragePerDay.Text = "Average per day: " & Math.Round(avgTotalAverage, 2)




            End If

        End If







        If currentColumnIndex = daysInAWeek Then

            currentRowIndex += 1

            currentColumnIndex = 0


        End If

        If currentRowIndex > 2 Then
            btnEnter.Enabled = False
            txtUnitsInput.Enabled = False

        End If



        If counter > 6 Then counter = 0





    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        lblEmployee1.Text = ""
        lblEmployee1Average.Text = ""
        lblEmployee1Output.Text = ""

        lblEmployee2.Text = ""
        lblEmployee2Average.Text = ""
        lblEmployee2Output.Text = ""

        lblEmployee3.Text = ""
        lblEmployee3Average.Text = ""
        lblEmployee3Output.Text = ""

        txtUnitsInput.Text = ""

        btnEnter.Enabled = True
        txtUnitsInput.Enabled = True
        lblAveragePerDay.Text = ""
        ReDim numberArray(2, 6)

    End Sub
End Class
