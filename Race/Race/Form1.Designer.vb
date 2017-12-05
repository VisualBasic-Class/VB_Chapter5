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
        Me.btnRace = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblBlueWin = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPurpleWin = New System.Windows.Forms.Label()
        Me.lblRedWin = New System.Windows.Forms.Label()
        Me.picPurpleCar = New System.Windows.Forms.PictureBox()
        Me.picRedCar = New System.Windows.Forms.PictureBox()
        Me.picBlueCar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picPurpleCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRedCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlueCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRace
        '
        Me.btnRace.BackColor = System.Drawing.Color.Red
        Me.btnRace.Location = New System.Drawing.Point(12, 433)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(108, 23)
        Me.btnRace.TabIndex = 0
        Me.btnRace.Text = "Race!"
        Me.btnRace.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.LightGray
        Me.btnReset.Location = New System.Drawing.Point(12, 462)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(108, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnExit.Location = New System.Drawing.Point(12, 491)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblBlueWin
        '
        Me.lblBlueWin.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblBlueWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBlueWin.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlueWin.Location = New System.Drawing.Point(15, 36)
        Me.lblBlueWin.Name = "lblBlueWin"
        Me.lblBlueWin.Size = New System.Drawing.Size(62, 35)
        Me.lblBlueWin.TabIndex = 12
        Me.lblBlueWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.lblPurpleWin)
        Me.GroupBox1.Controls.Add(Me.lblRedWin)
        Me.GroupBox1.Controls.Add(Me.lblBlueWin)
        Me.GroupBox1.Location = New System.Drawing.Point(144, 426)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 100)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Car Points"
        '
        'lblPurpleWin
        '
        Me.lblPurpleWin.BackColor = System.Drawing.Color.BlueViolet
        Me.lblPurpleWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPurpleWin.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurpleWin.Location = New System.Drawing.Point(202, 36)
        Me.lblPurpleWin.Name = "lblPurpleWin"
        Me.lblPurpleWin.Size = New System.Drawing.Size(62, 35)
        Me.lblPurpleWin.TabIndex = 14
        Me.lblPurpleWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRedWin
        '
        Me.lblRedWin.BackColor = System.Drawing.Color.Red
        Me.lblRedWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRedWin.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRedWin.Location = New System.Drawing.Point(107, 36)
        Me.lblRedWin.Name = "lblRedWin"
        Me.lblRedWin.Size = New System.Drawing.Size(62, 35)
        Me.lblRedWin.TabIndex = 13
        Me.lblRedWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picPurpleCar
        '
        Me.picPurpleCar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.picPurpleCar.Image = Global.WindowsApplication1.My.Resources.Resources.Purple_Car
        Me.picPurpleCar.Location = New System.Drawing.Point(15, 318)
        Me.picPurpleCar.Name = "picPurpleCar"
        Me.picPurpleCar.Size = New System.Drawing.Size(138, 66)
        Me.picPurpleCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPurpleCar.TabIndex = 5
        Me.picPurpleCar.TabStop = False
        '
        'picRedCar
        '
        Me.picRedCar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.picRedCar.Image = Global.WindowsApplication1.My.Resources.Resources.Red_Car
        Me.picRedCar.Location = New System.Drawing.Point(12, 197)
        Me.picRedCar.Name = "picRedCar"
        Me.picRedCar.Size = New System.Drawing.Size(138, 70)
        Me.picRedCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRedCar.TabIndex = 4
        Me.picRedCar.TabStop = False
        '
        'picBlueCar
        '
        Me.picBlueCar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.picBlueCar.Image = Global.WindowsApplication1.My.Resources.Resources.Blue_Car
        Me.picBlueCar.Location = New System.Drawing.Point(9, 53)
        Me.picBlueCar.Name = "picBlueCar"
        Me.picBlueCar.Size = New System.Drawing.Size(141, 101)
        Me.picBlueCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBlueCar.TabIndex = 3
        Me.picBlueCar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._450x300_race_car_track_clip_art_race_car_border_clipart_clipart_panda_free_7821909
        Me.PictureBox1.Location = New System.Drawing.Point(-11, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1200, 582)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 577)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picPurpleCar)
        Me.Controls.Add(Me.picRedCar)
        Me.Controls.Add(Me.picBlueCar)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRace)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Race Program"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picPurpleCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRedCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlueCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picPurpleCar As System.Windows.Forms.PictureBox
    Friend WithEvents picRedCar As System.Windows.Forms.PictureBox
    Friend WithEvents picBlueCar As System.Windows.Forms.PictureBox
    Friend WithEvents lblBlueWin As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPurpleWin As System.Windows.Forms.Label
    Friend WithEvents lblRedWin As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
