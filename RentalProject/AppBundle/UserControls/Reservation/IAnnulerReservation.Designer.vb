<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IAnnulerReservation
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FullReturnButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGVEquipments = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.ReservID = New System.Windows.Forms.TextBox()
        Me.ReservDate = New System.Windows.Forms.DateTimePicker()
        Me.Authorisation = New System.Windows.Forms.TextBox()
        Me.RenterFirstName = New System.Windows.Forms.TextBox()
        Me.RenterLastName = New System.Windows.Forms.TextBox()
        Me.RenterStatus = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVEquipments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(586, 58)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "Annuler"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackButton
        '
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.RentalProject.My.Resources.Resources.baseline_backward_black_18dp_4x
        Me.BackButton.Location = New System.Drawing.Point(0, 0)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(52, 58)
        Me.BackButton.TabIndex = 113
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.FullReturnButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 58)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(166, 382)
        Me.Panel3.TabIndex = 114
        '
        'FullReturnButton
        '
        Me.FullReturnButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.FullReturnButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FullReturnButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.FullReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.FullReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FullReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FullReturnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullReturnButton.ForeColor = System.Drawing.Color.White
        Me.FullReturnButton.Location = New System.Drawing.Point(0, 0)
        Me.FullReturnButton.Margin = New System.Windows.Forms.Padding(2)
        Me.FullReturnButton.Name = "FullReturnButton"
        Me.FullReturnButton.Size = New System.Drawing.Size(166, 58)
        Me.FullReturnButton.TabIndex = 115
        Me.FullReturnButton.Text = "Annuler la réservation"
        Me.FullReturnButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DGVEquipments)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Email)
        Me.Panel2.Controls.Add(Me.ReservID)
        Me.Panel2.Controls.Add(Me.ReservDate)
        Me.Panel2.Controls.Add(Me.Authorisation)
        Me.Panel2.Controls.Add(Me.RenterFirstName)
        Me.Panel2.Controls.Add(Me.RenterLastName)
        Me.Panel2.Controls.Add(Me.RenterStatus)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(166, 58)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(420, 382)
        Me.Panel2.TabIndex = 115
        '
        'DGVEquipments
        '
        Me.DGVEquipments.AllowUserToAddRows = False
        Me.DGVEquipments.AllowUserToDeleteRows = False
        Me.DGVEquipments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVEquipments.BackgroundColor = System.Drawing.Color.White
        Me.DGVEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEquipments.Location = New System.Drawing.Point(27, 237)
        Me.DGVEquipments.Name = "DGVEquipments"
        Me.DGVEquipments.RowHeadersWidth = 51
        Me.DGVEquipments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVEquipments.Size = New System.Drawing.Size(367, 128)
        Me.DGVEquipments.TabIndex = 108
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(127, 205)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(8, 4, 0, 0)
        Me.Label14.Size = New System.Drawing.Size(171, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Équipements réservés"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(79, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Email"
        '
        'Email
        '
        Me.Email.Enabled = False
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(130, 131)
        Me.Email.Margin = New System.Windows.Forms.Padding(2)
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Size = New System.Drawing.Size(200, 21)
        Me.Email.TabIndex = 106
        '
        'ReservID
        '
        Me.ReservID.Enabled = False
        Me.ReservID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservID.Location = New System.Drawing.Point(66, 13)
        Me.ReservID.Margin = New System.Windows.Forms.Padding(2)
        Me.ReservID.Multiline = True
        Me.ReservID.Name = "ReservID"
        Me.ReservID.ReadOnly = True
        Me.ReservID.Size = New System.Drawing.Size(105, 19)
        Me.ReservID.TabIndex = 57
        '
        'ReservDate
        '
        Me.ReservDate.Enabled = False
        Me.ReservDate.Location = New System.Drawing.Point(129, 170)
        Me.ReservDate.Margin = New System.Windows.Forms.Padding(2)
        Me.ReservDate.Name = "ReservDate"
        Me.ReservDate.Size = New System.Drawing.Size(201, 20)
        Me.ReservDate.TabIndex = 55
        '
        'Authorisation
        '
        Me.Authorisation.Enabled = False
        Me.Authorisation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Authorisation.Location = New System.Drawing.Point(290, 13)
        Me.Authorisation.Margin = New System.Windows.Forms.Padding(2)
        Me.Authorisation.Multiline = True
        Me.Authorisation.Name = "Authorisation"
        Me.Authorisation.ReadOnly = True
        Me.Authorisation.Size = New System.Drawing.Size(105, 19)
        Me.Authorisation.TabIndex = 54
        '
        'RenterFirstName
        '
        Me.RenterFirstName.Enabled = False
        Me.RenterFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenterFirstName.Location = New System.Drawing.Point(66, 51)
        Me.RenterFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.RenterFirstName.Multiline = True
        Me.RenterFirstName.Name = "RenterFirstName"
        Me.RenterFirstName.ReadOnly = True
        Me.RenterFirstName.Size = New System.Drawing.Size(105, 19)
        Me.RenterFirstName.TabIndex = 49
        '
        'RenterLastName
        '
        Me.RenterLastName.Enabled = False
        Me.RenterLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenterLastName.Location = New System.Drawing.Point(290, 53)
        Me.RenterLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.RenterLastName.Multiline = True
        Me.RenterLastName.Name = "RenterLastName"
        Me.RenterLastName.ReadOnly = True
        Me.RenterLastName.Size = New System.Drawing.Size(105, 19)
        Me.RenterLastName.TabIndex = 48
        '
        'RenterStatus
        '
        Me.RenterStatus.Enabled = False
        Me.RenterStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenterStatus.Location = New System.Drawing.Point(66, 90)
        Me.RenterStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.RenterStatus.Multiline = True
        Me.RenterStatus.Name = "RenterStatus"
        Me.RenterStatus.ReadOnly = True
        Me.RenterStatus.Size = New System.Drawing.Size(105, 19)
        Me.RenterStatus.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 170)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 17)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Date de réservation"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(207, 13)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Autorisé par"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Statut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(249, 53)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Prénom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ID"
        '
        'IAnnulerReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label13)
        Me.Name = "IAnnulerReservation"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVEquipments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FullReturnButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGVEquipments As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents ReservID As TextBox
    Friend WithEvents ReservDate As DateTimePicker
    Friend WithEvents Authorisation As TextBox
    Friend WithEvents RenterFirstName As TextBox
    Friend WithEvents RenterLastName As TextBox
    Friend WithEvents RenterStatus As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
