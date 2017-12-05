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
        Me.lblChooseCountry = New System.Windows.Forms.Label()
        Me.lblChoosePlay = New System.Windows.Forms.Label()
        Me.lblChooseArtist = New System.Windows.Forms.Label()
        Me.cboCountries = New System.Windows.Forms.ComboBox()
        Me.cboPlays = New System.Windows.Forms.ComboBox()
        Me.cboArtists = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblArtistDisplay = New System.Windows.Forms.Label()
        Me.lblPlayDisplay = New System.Windows.Forms.Label()
        Me.lblCountryDisplay = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblChooseCountry
        '
        Me.lblChooseCountry.AutoSize = True
        Me.lblChooseCountry.Location = New System.Drawing.Point(42, 53)
        Me.lblChooseCountry.Name = "lblChooseCountry"
        Me.lblChooseCountry.Size = New System.Drawing.Size(93, 13)
        Me.lblChooseCountry.TabIndex = 0
        Me.lblChooseCountry.Text = "Choose a country:"
        '
        'lblChoosePlay
        '
        Me.lblChoosePlay.AutoSize = True
        Me.lblChoosePlay.Location = New System.Drawing.Point(42, 111)
        Me.lblChoosePlay.Name = "lblChoosePlay"
        Me.lblChoosePlay.Size = New System.Drawing.Size(77, 13)
        Me.lblChoosePlay.TabIndex = 1
        Me.lblChoosePlay.Text = "Choose a play:"
        '
        'lblChooseArtist
        '
        Me.lblChooseArtist.AutoSize = True
        Me.lblChooseArtist.Location = New System.Drawing.Point(42, 171)
        Me.lblChooseArtist.Name = "lblChooseArtist"
        Me.lblChooseArtist.Size = New System.Drawing.Size(86, 13)
        Me.lblChooseArtist.TabIndex = 2
        Me.lblChooseArtist.Text = "Choose an artist:"
        '
        'cboCountries
        '
        Me.cboCountries.FormattingEnabled = True
        Me.cboCountries.Items.AddRange(New Object() {"England", "Ireland", "Scotland", "Wales"})
        Me.cboCountries.Location = New System.Drawing.Point(141, 50)
        Me.cboCountries.Name = "cboCountries"
        Me.cboCountries.Size = New System.Drawing.Size(121, 21)
        Me.cboCountries.TabIndex = 3
        '
        'cboPlays
        '
        Me.cboPlays.FormattingEnabled = True
        Me.cboPlays.Items.AddRange(New Object() {"Hamlet", "Much Ado About Nothing", "Romeo and Juiet", "A Comedy of Errors", "The Merchant of Venice"})
        Me.cboPlays.Location = New System.Drawing.Point(141, 108)
        Me.cboPlays.Name = "cboPlays"
        Me.cboPlays.Size = New System.Drawing.Size(121, 21)
        Me.cboPlays.TabIndex = 4
        '
        'cboArtists
        '
        Me.cboArtists.FormattingEnabled = True
        Me.cboArtists.Items.AddRange(New Object() {"Michelangelo", "Raphael", "da Vinci"})
        Me.cboArtists.Location = New System.Drawing.Point(141, 168)
        Me.cboArtists.Name = "cboArtists"
        Me.cboArtists.Size = New System.Drawing.Size(121, 21)
        Me.cboArtists.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArtistDisplay)
        Me.GroupBox1.Controls.Add(Me.lblPlayDisplay)
        Me.GroupBox1.Controls.Add(Me.lblCountryDisplay)
        Me.GroupBox1.Location = New System.Drawing.Point(297, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 170)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Choices"
        '
        'lblArtistDisplay
        '
        Me.lblArtistDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArtistDisplay.Location = New System.Drawing.Point(18, 133)
        Me.lblArtistDisplay.Name = "lblArtistDisplay"
        Me.lblArtistDisplay.Size = New System.Drawing.Size(149, 23)
        Me.lblArtistDisplay.TabIndex = 2
        '
        'lblPlayDisplay
        '
        Me.lblPlayDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayDisplay.Location = New System.Drawing.Point(18, 76)
        Me.lblPlayDisplay.Name = "lblPlayDisplay"
        Me.lblPlayDisplay.Size = New System.Drawing.Size(149, 23)
        Me.lblPlayDisplay.TabIndex = 1
        '
        'lblCountryDisplay
        '
        Me.lblCountryDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountryDisplay.Location = New System.Drawing.Point(18, 18)
        Me.lblCountryDisplay.Name = "lblCountryDisplay"
        Me.lblCountryDisplay.Size = New System.Drawing.Size(149, 23)
        Me.lblCountryDisplay.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(30, 238)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(105, 23)
        Me.btnShow.TabIndex = 7
        Me.btnShow.Text = "Show Selections"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(206, 238)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(105, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(378, 238)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 280)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboArtists)
        Me.Controls.Add(Me.cboPlays)
        Me.Controls.Add(Me.cboCountries)
        Me.Controls.Add(Me.lblChooseArtist)
        Me.Controls.Add(Me.lblChoosePlay)
        Me.Controls.Add(Me.lblChooseCountry)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChooseCountry As System.Windows.Forms.Label
    Friend WithEvents lblChoosePlay As System.Windows.Forms.Label
    Friend WithEvents lblChooseArtist As System.Windows.Forms.Label
    Friend WithEvents cboCountries As System.Windows.Forms.ComboBox
    Friend WithEvents cboPlays As System.Windows.Forms.ComboBox
    Friend WithEvents cboArtists As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCountryDisplay As System.Windows.Forms.Label
    Friend WithEvents lblArtistDisplay As System.Windows.Forms.Label
    Friend WithEvents lblPlayDisplay As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
