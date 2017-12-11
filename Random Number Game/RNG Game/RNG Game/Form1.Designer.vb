<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuessNum
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
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.txtUG = New System.Windows.Forms.TextBox()
        Me.lblCanGuess = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(138, 187)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 23)
        Me.btnGuess.TabIndex = 0
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'txtUG
        '
        Me.txtUG.Location = New System.Drawing.Point(138, 143)
        Me.txtUG.Name = "txtUG"
        Me.txtUG.Size = New System.Drawing.Size(75, 20)
        Me.txtUG.TabIndex = 1
        '
        'lblCanGuess
        '
        Me.lblCanGuess.AutoSize = True
        Me.lblCanGuess.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanGuess.Location = New System.Drawing.Point(58, 104)
        Me.lblCanGuess.Name = "lblCanGuess"
        Me.lblCanGuess.Size = New System.Drawing.Size(245, 16)
        Me.lblCanGuess.TabIndex = 2
        Me.lblCanGuess.Text = "Can you guess my number? (0-100)"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(138, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GuessNum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 339)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCanGuess)
        Me.Controls.Add(Me.txtUG)
        Me.Controls.Add(Me.btnGuess)
        Me.Name = "GuessNum"
        Me.Text = "Guess my number!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents txtUG As System.Windows.Forms.TextBox
    Friend WithEvents lblCanGuess As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
