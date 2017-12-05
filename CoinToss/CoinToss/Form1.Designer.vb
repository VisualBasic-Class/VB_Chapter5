<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.picCoinTails = New System.Windows.Forms.Label()
        Me.picCoinHeads = New System.Windows.Forms.Label()
        Me.btnTossCoin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'picCoinTails
        '
        Me.picCoinTails.Image = Global.WindowsApplication1.My.Resources.Resources.coin_21
        Me.picCoinTails.Location = New System.Drawing.Point(181, 67)
        Me.picCoinTails.Name = "picCoinTails"
        Me.picCoinTails.Size = New System.Drawing.Size(136, 128)
        Me.picCoinTails.TabIndex = 1
        '
        'picCoinHeads
        '
        Me.picCoinHeads.Image = Global.WindowsApplication1.My.Resources.Resources.coin1
        Me.picCoinHeads.Location = New System.Drawing.Point(28, 73)
        Me.picCoinHeads.Name = "picCoinHeads"
        Me.picCoinHeads.Size = New System.Drawing.Size(121, 112)
        Me.picCoinHeads.TabIndex = 0
        '
        'btnTossCoin
        '
        Me.btnTossCoin.Location = New System.Drawing.Point(24, 223)
        Me.btnTossCoin.Name = "btnTossCoin"
        Me.btnTossCoin.Size = New System.Drawing.Size(125, 23)
        Me.btnTossCoin.TabIndex = 2
        Me.btnTossCoin.Text = "Toss the Coin"
        Me.btnTossCoin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(202, 223)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 267)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTossCoin)
        Me.Controls.Add(Me.picCoinTails)
        Me.Controls.Add(Me.picCoinHeads)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picCoinHeads As System.Windows.Forms.Label
    Friend WithEvents picCoinTails As System.Windows.Forms.Label
    Friend WithEvents btnTossCoin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
