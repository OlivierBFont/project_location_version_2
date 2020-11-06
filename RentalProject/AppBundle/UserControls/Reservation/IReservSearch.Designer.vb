<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IReservSearch
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AuthorisationName = New System.Windows.Forms.TextBox()
        Me.ByAuthorisationName = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ReservLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReservFirstName = New System.Windows.Forms.TextBox()
        Me.ByReservName = New System.Windows.Forms.RadioButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RentedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Authorisation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.DetailsButton = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(586, 50)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Recherche - Réservation"
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
        Me.BackButton.Size = New System.Drawing.Size(70, 50)
        Me.BackButton.TabIndex = 28
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AuthorisationName)
        Me.Panel2.Controls.Add(Me.ByAuthorisationName)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ReservLastName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ReservFirstName)
        Me.Panel2.Controls.Add(Me.ByReservName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 390)
        Me.Panel2.TabIndex = 29
        '
        'AuthorisationName
        '
        Me.AuthorisationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorisationName.Location = New System.Drawing.Point(31, 240)
        Me.AuthorisationName.Name = "AuthorisationName"
        Me.AuthorisationName.Size = New System.Drawing.Size(164, 21)
        Me.AuthorisationName.TabIndex = 20
        '
        'ByAuthorisationName
        '
        Me.ByAuthorisationName.AutoSize = True
        Me.ByAuthorisationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByAuthorisationName.Location = New System.Drawing.Point(32, 210)
        Me.ByAuthorisationName.Name = "ByAuthorisationName"
        Me.ByAuthorisationName.Size = New System.Drawing.Size(144, 21)
        Me.ByAuthorisationName.TabIndex = 19
        Me.ByAuthorisationName.TabStop = True
        Me.ByAuthorisationName.Text = "Nom d'autorisation"
        Me.ByAuthorisationName.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nom"
        '
        'ReservLastName
        '
        Me.ReservLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservLastName.Location = New System.Drawing.Point(120, 137)
        Me.ReservLastName.Name = "ReservLastName"
        Me.ReservLastName.Size = New System.Drawing.Size(75, 21)
        Me.ReservLastName.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Prénom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Rechercher par..."
        '
        'ReservFirstName
        '
        Me.ReservFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservFirstName.Location = New System.Drawing.Point(31, 137)
        Me.ReservFirstName.Name = "ReservFirstName"
        Me.ReservFirstName.Size = New System.Drawing.Size(75, 21)
        Me.ReservFirstName.TabIndex = 12
        '
        'ByReservName
        '
        Me.ByReservName.AutoSize = True
        Me.ByReservName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByReservName.Location = New System.Drawing.Point(32, 93)
        Me.ByReservName.Name = "ByReservName"
        Me.ByReservName.Size = New System.Drawing.Size(152, 21)
        Me.ByReservName.TabIndex = 11
        Me.ByReservName.TabStop = True
        Me.ByReservName.Text = "Nom du réservateur"
        Me.ByReservName.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.RentedBy, Me.Authorisation})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(211, 50)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(375, 332)
        Me.ListView1.TabIndex = 30
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = "ID"
        Me.Id.Width = 31
        '
        'RentedBy
        '
        Me.RentedBy.Text = "Réservé par"
        Me.RentedBy.Width = 99
        '
        'Authorisation
        '
        Me.Authorisation.Text = "Autorisé par"
        Me.Authorisation.Width = 117
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SearchButton)
        Me.Panel3.Controls.Add(Me.DetailsButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(211, 382)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(375, 58)
        Me.Panel3.TabIndex = 31
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Image = Global.RentalProject.My.Resources.Resources.baseline_search_white_18dp
        Me.SearchButton.Location = New System.Drawing.Point(124, 0)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(94, 58)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'DetailsButton
        '
        Me.DetailsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DetailsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DetailsButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.DetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DetailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DetailsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsButton.ForeColor = System.Drawing.Color.White
        Me.DetailsButton.Location = New System.Drawing.Point(218, 0)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(157, 58)
        Me.DetailsButton.TabIndex = 1
        Me.DetailsButton.Text = "Afficher les Détails"
        Me.DetailsButton.UseVisualStyleBackColor = False
        '
        'IReservSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label13)
        Me.Name = "IReservSearch"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AuthorisationName As TextBox
    Friend WithEvents ByAuthorisationName As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ReservLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReservFirstName As TextBox
    Friend WithEvents ByReservName As RadioButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Id As ColumnHeader
    Friend WithEvents RentedBy As ColumnHeader
    Friend WithEvents Authorisation As ColumnHeader
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SearchButton As Button
    Friend WithEvents DetailsButton As Button
End Class
