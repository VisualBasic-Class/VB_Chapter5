<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RightTriangleCalculator
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
        Me.gboxSolvents = New System.Windows.Forms.GroupBox()
        Me.radioC = New System.Windows.Forms.RadioButton()
        Me.radioB = New System.Windows.Forms.RadioButton()
        Me.radioA = New System.Windows.Forms.RadioButton()
        Me.txtSideA = New System.Windows.Forms.TextBox()
        Me.txtSideB = New System.Windows.Forms.TextBox()
        Me.txtSideC = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSideA = New System.Windows.Forms.Label()
        Me.lblSideB = New System.Windows.Forms.Label()
        Me.lblSideC = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.gboxSolvents.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxSolvents
        '
        Me.gboxSolvents.Controls.Add(Me.lblSideC)
        Me.gboxSolvents.Controls.Add(Me.lblSideB)
        Me.gboxSolvents.Controls.Add(Me.lblSideA)
        Me.gboxSolvents.Controls.Add(Me.radioC)
        Me.gboxSolvents.Controls.Add(Me.radioB)
        Me.gboxSolvents.Controls.Add(Me.radioA)
        Me.gboxSolvents.Location = New System.Drawing.Point(12, 26)
        Me.gboxSolvents.Name = "gboxSolvents"
        Me.gboxSolvents.Size = New System.Drawing.Size(200, 263)
        Me.gboxSolvents.TabIndex = 0
        Me.gboxSolvents.TabStop = False
        '
        'radioC
        '
        Me.radioC.AutoSize = True
        Me.radioC.Location = New System.Drawing.Point(48, 195)
        Me.radioC.Name = "radioC"
        Me.radioC.Size = New System.Drawing.Size(95, 17)
        Me.radioC.TabIndex = 2
        Me.radioC.TabStop = True
        Me.radioC.Text = "Side for Side C"
        Me.radioC.UseVisualStyleBackColor = True
        '
        'radioB
        '
        Me.radioB.AutoSize = True
        Me.radioB.Location = New System.Drawing.Point(48, 112)
        Me.radioB.Name = "radioB"
        Me.radioB.Size = New System.Drawing.Size(101, 17)
        Me.radioB.TabIndex = 1
        Me.radioB.TabStop = True
        Me.radioB.Text = "Solve for Side B"
        Me.radioB.UseVisualStyleBackColor = True
        '
        'radioA
        '
        Me.radioA.AutoSize = True
        Me.radioA.Location = New System.Drawing.Point(48, 38)
        Me.radioA.Name = "radioA"
        Me.radioA.Size = New System.Drawing.Size(101, 17)
        Me.radioA.TabIndex = 0
        Me.radioA.TabStop = True
        Me.radioA.Text = "Solve for Side A"
        Me.radioA.UseVisualStyleBackColor = True
        '
        'txtSideA
        '
        Me.txtSideA.Location = New System.Drawing.Point(229, 82)
        Me.txtSideA.Name = "txtSideA"
        Me.txtSideA.Size = New System.Drawing.Size(100, 20)
        Me.txtSideA.TabIndex = 1
        '
        'txtSideB
        '
        Me.txtSideB.Location = New System.Drawing.Point(229, 161)
        Me.txtSideB.Name = "txtSideB"
        Me.txtSideB.Size = New System.Drawing.Size(100, 20)
        Me.txtSideB.TabIndex = 2
        '
        'txtSideC
        '
        Me.txtSideC.Location = New System.Drawing.Point(229, 244)
        Me.txtSideC.Name = "txtSideC"
        Me.txtSideC.Size = New System.Drawing.Size(100, 20)
        Me.txtSideC.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(269, 323)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSideA
        '
        Me.lblSideA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSideA.Location = New System.Drawing.Point(50, 58)
        Me.lblSideA.Name = "lblSideA"
        Me.lblSideA.Size = New System.Drawing.Size(100, 23)
        Me.lblSideA.TabIndex = 3
        '
        'lblSideB
        '
        Me.lblSideB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSideB.Location = New System.Drawing.Point(50, 132)
        Me.lblSideB.Name = "lblSideB"
        Me.lblSideB.Size = New System.Drawing.Size(100, 23)
        Me.lblSideB.TabIndex = 4
        '
        'lblSideC
        '
        Me.lblSideC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSideC.Location = New System.Drawing.Point(50, 215)
        Me.lblSideC.Name = "lblSideC"
        Me.lblSideC.Size = New System.Drawing.Size(100, 23)
        Me.lblSideC.TabIndex = 5
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(156, 323)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'RightTriangleCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 388)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSideC)
        Me.Controls.Add(Me.txtSideB)
        Me.Controls.Add(Me.txtSideA)
        Me.Controls.Add(Me.gboxSolvents)
        Me.Name = "RightTriangleCalculator"
        Me.Text = "Right Triangle Calculator"
        Me.gboxSolvents.ResumeLayout(False)
        Me.gboxSolvents.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gboxSolvents As System.Windows.Forms.GroupBox
    Friend WithEvents radioA As System.Windows.Forms.RadioButton
    Friend WithEvents radioC As System.Windows.Forms.RadioButton
    Friend WithEvents radioB As System.Windows.Forms.RadioButton
    Friend WithEvents txtSideA As System.Windows.Forms.TextBox
    Friend WithEvents txtSideB As System.Windows.Forms.TextBox
    Friend WithEvents txtSideC As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblSideC As System.Windows.Forms.Label
    Friend WithEvents lblSideB As System.Windows.Forms.Label
    Friend WithEvents lblSideA As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
