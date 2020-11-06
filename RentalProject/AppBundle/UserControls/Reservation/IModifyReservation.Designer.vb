<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IModifyReservation
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Equipments = New System.Windows.Forms.DataGridView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericHours = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericDays = New System.Windows.Forms.NumericUpDown()
        Me.Comments = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReservID = New System.Windows.Forms.TextBox()
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.ReservDate = New System.Windows.Forms.DateTimePicker()
        Me.Authorisation = New System.Windows.Forms.TextBox()
        Me.RenterName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.Equipments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(586, 58)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Modification de la réservation"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Equipments
        '
        Me.Equipments.AllowUserToAddRows = False
        Me.Equipments.AllowUserToDeleteRows = False
        Me.Equipments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Equipments.BackgroundColor = System.Drawing.Color.White
        Me.Equipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Equipments.Enabled = False
        Me.Equipments.Location = New System.Drawing.Point(351, 93)
        Me.Equipments.Name = "Equipments"
        Me.Equipments.RowHeadersWidth = 51
        Me.Equipments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Equipments.Size = New System.Drawing.Size(215, 109)
        Me.Equipments.TabIndex = 128
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(204, 323)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 21)
        Me.CheckBox1.TabIndex = 127
        Me.CheckBox1.Text = "Date Fixe"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 34)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Durée de la réservation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en heures"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericHours
        '
        Me.NumericHours.Location = New System.Drawing.Point(213, 287)
        Me.NumericHours.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericHours.Name = "NumericHours"
        Me.NumericHours.Size = New System.Drawing.Size(61, 20)
        Me.NumericHours.TabIndex = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 34)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Durée de la résevation " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en jours"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericDays
        '
        Me.NumericDays.Location = New System.Drawing.Point(46, 287)
        Me.NumericDays.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericDays.Name = "NumericDays"
        Me.NumericDays.Size = New System.Drawing.Size(61, 20)
        Me.NumericDays.TabIndex = 123
        '
        'Comments
        '
        Me.Comments.Location = New System.Drawing.Point(350, 237)
        Me.Comments.Margin = New System.Windows.Forms.Padding(2)
        Me.Comments.MaxLength = 1000
        Me.Comments.Multiline = True
        Me.Comments.Name = "Comments"
        Me.Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Comments.Size = New System.Drawing.Size(216, 132)
        Me.Comments.TabIndex = 122
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 218)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Commentaires"
        '
        'ReservID
        '
        Me.ReservID.Enabled = False
        Me.ReservID.Location = New System.Drawing.Point(144, 72)
        Me.ReservID.Margin = New System.Windows.Forms.Padding(2)
        Me.ReservID.Multiline = True
        Me.ReservID.Name = "ReservID"
        Me.ReservID.ReadOnly = True
        Me.ReservID.Size = New System.Drawing.Size(73, 19)
        Me.ReservID.TabIndex = 120
        '
        'ReturnDate
        '
        Me.ReturnDate.Enabled = False
        Me.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReturnDate.Location = New System.Drawing.Point(75, 349)
        Me.ReturnDate.Margin = New System.Windows.Forms.Padding(2)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(216, 20)
        Me.ReturnDate.TabIndex = 119
        '
        'ReservDate
        '
        Me.ReservDate.Enabled = False
        Me.ReservDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReservDate.Location = New System.Drawing.Point(75, 219)
        Me.ReservDate.Margin = New System.Windows.Forms.Padding(2)
        Me.ReservDate.Name = "ReservDate"
        Me.ReservDate.Size = New System.Drawing.Size(216, 20)
        Me.ReservDate.TabIndex = 118
        '
        'Authorisation
        '
        Me.Authorisation.Enabled = False
        Me.Authorisation.Location = New System.Drawing.Point(144, 159)
        Me.Authorisation.Margin = New System.Windows.Forms.Padding(2)
        Me.Authorisation.Multiline = True
        Me.Authorisation.Name = "Authorisation"
        Me.Authorisation.ReadOnly = True
        Me.Authorisation.Size = New System.Drawing.Size(146, 19)
        Me.Authorisation.TabIndex = 117
        '
        'RenterName
        '
        Me.RenterName.Enabled = False
        Me.RenterName.Location = New System.Drawing.Point(144, 111)
        Me.RenterName.Margin = New System.Windows.Forms.Padding(2)
        Me.RenterName.Multiline = True
        Me.RenterName.Name = "RenterName"
        Me.RenterName.ReadOnly = True
        Me.RenterName.Size = New System.Drawing.Size(146, 19)
        Me.RenterName.TabIndex = 116
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(85, 324)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 17)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "Date de retour"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(117, 200)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 17)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "Date de réservation"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(61, 159)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Autorisé par"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(348, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Équipement"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 111)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Réservé par"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "ID"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Controls.Add(Me.ResetButton)
        Me.Panel1.Controls.Add(Me.CancelButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 382)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 58)
        Me.Panel1.TabIndex = 129
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SaveButton.Location = New System.Drawing.Point(196, 0)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(130, 58)
        Me.SaveButton.TabIndex = 84
        Me.SaveButton.Text = "Sauvegarder"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ResetButton.Location = New System.Drawing.Point(326, 0)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(130, 58)
        Me.ResetButton.TabIndex = 83
        Me.ResetButton.Text = "Réinitialiser"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CancelButton.Location = New System.Drawing.Point(456, 0)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(130, 58)
        Me.CancelButton.TabIndex = 82
        Me.CancelButton.Text = "Annuler"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'IModifyReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Equipments)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericHours)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericDays)
        Me.Controls.Add(Me.Comments)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReservID)
        Me.Controls.Add(Me.ReturnDate)
        Me.Controls.Add(Me.ReservDate)
        Me.Controls.Add(Me.Authorisation)
        Me.Controls.Add(Me.RenterName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Name = "IModifyReservation"
        Me.Size = New System.Drawing.Size(586, 440)
        CType(Me.Equipments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents Equipments As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericHours As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericDays As NumericUpDown
    Friend WithEvents Comments As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ReservID As TextBox
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents ReservDate As DateTimePicker
    Friend WithEvents Authorisation As TextBox
    Friend WithEvents RenterName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SaveButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents CancelButton As Button
End Class
