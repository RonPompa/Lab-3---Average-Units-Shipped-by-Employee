<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
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
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmployee1Output = New System.Windows.Forms.Label()
        Me.lblEmployee2Output = New System.Windows.Forms.Label()
        Me.lblEmployee3Output = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblAveragePerDay = New System.Windows.Forms.Label()
        Me.lblEmployee1Average = New System.Windows.Forms.Label()
        Me.lblEmployee2Average = New System.Windows.Forms.Label()
        Me.lblEmployee3Average = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtUnitsInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(12, 9)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(32, 13)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day: "
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(12, 43)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "Units:"
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Location = New System.Drawing.Point(61, 85)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee1.TabIndex = 4
        Me.lblEmployee1.Text = "Employee 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
        '
        'lblEmployee1Output
        '
        Me.lblEmployee1Output.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmployee1Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee1Output.Location = New System.Drawing.Point(12, 108)
        Me.lblEmployee1Output.Name = "lblEmployee1Output"
        Me.lblEmployee1Output.Size = New System.Drawing.Size(159, 205)
        Me.lblEmployee1Output.TabIndex = 2
        '
        'lblEmployee2Output
        '
        Me.lblEmployee2Output.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmployee2Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee2Output.Location = New System.Drawing.Point(187, 108)
        Me.lblEmployee2Output.Name = "lblEmployee2Output"
        Me.lblEmployee2Output.Size = New System.Drawing.Size(159, 205)
        Me.lblEmployee2Output.TabIndex = 3
        '
        'lblEmployee3Output
        '
        Me.lblEmployee3Output.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmployee3Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee3Output.Location = New System.Drawing.Point(363, 108)
        Me.lblEmployee3Output.Name = "lblEmployee3Output"
        Me.lblEmployee3Output.Size = New System.Drawing.Size(159, 205)
        Me.lblEmployee3Output.TabIndex = 4
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(237, 85)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee2.TabIndex = 9
        Me.lblEmployee2.Text = "Employee 2"
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(415, 85)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(62, 13)
        Me.lblEmployee3.TabIndex = 10
        Me.lblEmployee3.Text = "Employee 3"
        '
        'lblAveragePerDay
        '
        Me.lblAveragePerDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAveragePerDay.Location = New System.Drawing.Point(11, 349)
        Me.lblAveragePerDay.Name = "lblAveragePerDay"
        Me.lblAveragePerDay.Size = New System.Drawing.Size(510, 33)
        Me.lblAveragePerDay.TabIndex = 8
        Me.lblAveragePerDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee1Average
        '
        Me.lblEmployee1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee1Average.Location = New System.Drawing.Point(11, 317)
        Me.lblEmployee1Average.Name = "lblEmployee1Average"
        Me.lblEmployee1Average.Size = New System.Drawing.Size(160, 23)
        Me.lblEmployee1Average.TabIndex = 5
        '
        'lblEmployee2Average
        '
        Me.lblEmployee2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee2Average.Location = New System.Drawing.Point(186, 317)
        Me.lblEmployee2Average.Name = "lblEmployee2Average"
        Me.lblEmployee2Average.Size = New System.Drawing.Size(160, 23)
        Me.lblEmployee2Average.TabIndex = 6
        '
        'lblEmployee3Average
        '
        Me.lblEmployee3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee3Average.Location = New System.Drawing.Point(363, 317)
        Me.lblEmployee3Average.Name = "lblEmployee3Average"
        Me.lblEmployee3Average.Size = New System.Drawing.Size(160, 23)
        Me.lblEmployee3Average.TabIndex = 7
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(11, 385)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(160, 23)
        Me.btnEnter.TabIndex = 9
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(186, 385)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(160, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(363, 385)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(160, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtUnitsInput
        '
        Me.txtUnitsInput.Location = New System.Drawing.Point(52, 40)
        Me.txtUnitsInput.Name = "txtUnitsInput"
        Me.txtUnitsInput.Size = New System.Drawing.Size(100, 20)
        Me.txtUnitsInput.TabIndex = 1
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(536, 419)
        Me.Controls.Add(Me.txtUnitsInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblEmployee3Average)
        Me.Controls.Add(Me.lblEmployee2Average)
        Me.Controls.Add(Me.lblEmployee1Average)
        Me.Controls.Add(Me.lblAveragePerDay)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee3Output)
        Me.Controls.Add(Me.lblEmployee2Output)
        Me.Controls.Add(Me.lblEmployee1Output)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDay)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.Text = "Average Units Shipped by Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmployee1Output As Label
    Friend WithEvents lblEmployee2Output As Label
    Friend WithEvents lblEmployee3Output As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblAveragePerDay As Label
    Friend WithEvents lblEmployee1Average As Label
    Friend WithEvents lblEmployee2Average As Label
    Friend WithEvents lblEmployee3Average As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtUnitsInput As TextBox
End Class
