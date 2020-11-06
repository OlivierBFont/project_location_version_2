<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IAddPersonReserv
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBMatricule = New System.Windows.Forms.TextBox()
        Me.LaMatricule = New System.Windows.Forms.Label()
        Me.TBBureau = New System.Windows.Forms.MaskedTextBox()
        Me.TBPoste = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.TBTelephone = New System.Windows.Forms.MaskedTextBox()
        Me.LAPoste = New System.Windows.Forms.Label()
        Me.LABureau = New System.Windows.Forms.Label()
        Me.TBService = New System.Windows.Forms.TextBox()
        Me.LAService = New System.Windows.Forms.Label()
        Me.TBDepartement = New System.Windows.Forms.TextBox()
        Me.LADepartement = New System.Windows.Forms.Label()
        Me.LATelephone = New System.Windows.Forms.Label()
        Me.TBPrenom = New System.Windows.Forms.TextBox()
        Me.LAPrenom = New System.Windows.Forms.Label()
        Me.CBStatut = New System.Windows.Forms.ComboBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.LAStatut = New System.Windows.Forms.Label()
        Me.LANom = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(586, 58)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ajout de Personne"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TBMatricule
        '
        Me.TBMatricule.Location = New System.Drawing.Point(387, 97)
        Me.TBMatricule.Name = "TBMatricule"
        Me.TBMatricule.Size = New System.Drawing.Size(174, 20)
        Me.TBMatricule.TabIndex = 126
        '
        'LaMatricule
        '
        Me.LaMatricule.AutoSize = True
        Me.LaMatricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaMatricule.Location = New System.Drawing.Point(314, 100)
        Me.LaMatricule.Name = "LaMatricule"
        Me.LaMatricule.Size = New System.Drawing.Size(65, 17)
        Me.LaMatricule.TabIndex = 125
        Me.LaMatricule.Text = "Matricule"
        '
        'TBBureau
        '
        Me.TBBureau.Location = New System.Drawing.Point(387, 265)
        Me.TBBureau.Mask = "LL0000"
        Me.TBBureau.Name = "TBBureau"
        Me.TBBureau.Size = New System.Drawing.Size(72, 20)
        Me.TBBureau.TabIndex = 124
        '
        'TBPoste
        '
        Me.TBPoste.Location = New System.Drawing.Point(387, 323)
        Me.TBPoste.Margin = New System.Windows.Forms.Padding(2)
        Me.TBPoste.Mask = "999999"
        Me.TBPoste.Name = "TBPoste"
        Me.TBPoste.Size = New System.Drawing.Size(72, 20)
        Me.TBPoste.TabIndex = 123
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Email"
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(105, 265)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(174, 20)
        Me.Email.TabIndex = 121
        '
        'TBTelephone
        '
        Me.TBTelephone.Location = New System.Drawing.Point(104, 210)
        Me.TBTelephone.Margin = New System.Windows.Forms.Padding(2)
        Me.TBTelephone.Mask = "(000) 000-0000"
        Me.TBTelephone.Name = "TBTelephone"
        Me.TBTelephone.Size = New System.Drawing.Size(174, 20)
        Me.TBTelephone.TabIndex = 120
        '
        'LAPoste
        '
        Me.LAPoste.AutoSize = True
        Me.LAPoste.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAPoste.Location = New System.Drawing.Point(335, 321)
        Me.LAPoste.Name = "LAPoste"
        Me.LAPoste.Size = New System.Drawing.Size(44, 17)
        Me.LAPoste.TabIndex = 119
        Me.LAPoste.Text = "Poste"
        '
        'LABureau
        '
        Me.LABureau.AutoSize = True
        Me.LABureau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABureau.Location = New System.Drawing.Point(299, 266)
        Me.LABureau.Name = "LABureau"
        Me.LABureau.Size = New System.Drawing.Size(80, 17)
        Me.LABureau.TabIndex = 118
        Me.LABureau.Text = "No. Bureau"
        '
        'TBService
        '
        Me.TBService.Location = New System.Drawing.Point(387, 211)
        Me.TBService.Name = "TBService"
        Me.TBService.Size = New System.Drawing.Size(174, 20)
        Me.TBService.TabIndex = 117
        '
        'LAService
        '
        Me.LAService.AutoSize = True
        Me.LAService.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAService.Location = New System.Drawing.Point(324, 211)
        Me.LAService.Name = "LAService"
        Me.LAService.Size = New System.Drawing.Size(55, 17)
        Me.LAService.TabIndex = 116
        Me.LAService.Text = "Service"
        '
        'TBDepartement
        '
        Me.TBDepartement.Location = New System.Drawing.Point(387, 154)
        Me.TBDepartement.Name = "TBDepartement"
        Me.TBDepartement.Size = New System.Drawing.Size(174, 20)
        Me.TBDepartement.TabIndex = 115
        '
        'LADepartement
        '
        Me.LADepartement.AutoSize = True
        Me.LADepartement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LADepartement.Location = New System.Drawing.Point(294, 157)
        Me.LADepartement.Name = "LADepartement"
        Me.LADepartement.Size = New System.Drawing.Size(90, 17)
        Me.LADepartement.TabIndex = 114
        Me.LADepartement.Text = "Département"
        '
        'LATelephone
        '
        Me.LATelephone.AutoSize = True
        Me.LATelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LATelephone.Location = New System.Drawing.Point(26, 216)
        Me.LATelephone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LATelephone.Name = "LATelephone"
        Me.LATelephone.Size = New System.Drawing.Size(74, 16)
        Me.LATelephone.TabIndex = 113
        Me.LATelephone.Text = "Téléphone"
        '
        'TBPrenom
        '
        Me.TBPrenom.Location = New System.Drawing.Point(105, 154)
        Me.TBPrenom.Name = "TBPrenom"
        Me.TBPrenom.Size = New System.Drawing.Size(174, 20)
        Me.TBPrenom.TabIndex = 112
        '
        'LAPrenom
        '
        Me.LAPrenom.AutoSize = True
        Me.LAPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAPrenom.Location = New System.Drawing.Point(41, 157)
        Me.LAPrenom.Name = "LAPrenom"
        Me.LAPrenom.Size = New System.Drawing.Size(57, 17)
        Me.LAPrenom.TabIndex = 111
        Me.LAPrenom.Text = "Prénom"
        '
        'CBStatut
        '
        Me.CBStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBStatut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBStatut.FormattingEnabled = True
        Me.CBStatut.Items.AddRange(New Object() {"Étudiant", "Professeur", "Technicien", "Administration"})
        Me.CBStatut.Location = New System.Drawing.Point(104, 317)
        Me.CBStatut.Name = "CBStatut"
        Me.CBStatut.Size = New System.Drawing.Size(174, 21)
        Me.CBStatut.TabIndex = 110
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(105, 97)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(174, 20)
        Me.TBNom.TabIndex = 109
        '
        'LAStatut
        '
        Me.LAStatut.AutoSize = True
        Me.LAStatut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAStatut.Location = New System.Drawing.Point(50, 321)
        Me.LAStatut.Name = "LAStatut"
        Me.LAStatut.Size = New System.Drawing.Size(45, 17)
        Me.LAStatut.TabIndex = 108
        Me.LAStatut.Text = "Statut"
        '
        'LANom
        '
        Me.LANom.AutoSize = True
        Me.LANom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LANom.Location = New System.Drawing.Point(58, 100)
        Me.LANom.Name = "LANom"
        Me.LANom.Size = New System.Drawing.Size(37, 17)
        Me.LANom.TabIndex = 107
        Me.LANom.Text = "Nom"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AddButton)
        Me.Panel2.Controls.Add(Me.CancelButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 380)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 60)
        Me.Panel2.TabIndex = 127
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.AddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AddButton.Location = New System.Drawing.Point(326, 0)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(130, 60)
        Me.AddButton.TabIndex = 87
        Me.AddButton.Text = "Sauvegarder"
        Me.AddButton.UseVisualStyleBackColor = False
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
        Me.CancelButton.Size = New System.Drawing.Size(130, 60)
        Me.CancelButton.TabIndex = 86
        Me.CancelButton.Text = "Annuler"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.RentalProject.My.Resources.Resources.baseline_backward_black_18dp_4x
        Me.BackButton.Location = New System.Drawing.Point(0, 0)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(70, 58)
        Me.BackButton.TabIndex = 128
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'IAddPersonReserv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TBMatricule)
        Me.Controls.Add(Me.LaMatricule)
        Me.Controls.Add(Me.TBBureau)
        Me.Controls.Add(Me.TBPoste)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.TBTelephone)
        Me.Controls.Add(Me.LAPoste)
        Me.Controls.Add(Me.LABureau)
        Me.Controls.Add(Me.TBService)
        Me.Controls.Add(Me.LAService)
        Me.Controls.Add(Me.TBDepartement)
        Me.Controls.Add(Me.LADepartement)
        Me.Controls.Add(Me.LATelephone)
        Me.Controls.Add(Me.TBPrenom)
        Me.Controls.Add(Me.LAPrenom)
        Me.Controls.Add(Me.CBStatut)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.LAStatut)
        Me.Controls.Add(Me.LANom)
        Me.Controls.Add(Me.Label5)
        Me.Name = "IAddPersonReserv"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents TBMatricule As TextBox
    Friend WithEvents LaMatricule As Label
    Friend WithEvents TBBureau As MaskedTextBox
    Friend WithEvents TBPoste As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents TBTelephone As MaskedTextBox
    Friend WithEvents LAPoste As Label
    Friend WithEvents LABureau As Label
    Friend WithEvents TBService As TextBox
    Friend WithEvents LAService As Label
    Friend WithEvents TBDepartement As TextBox
    Friend WithEvents LADepartement As Label
    Friend WithEvents LATelephone As Label
    Friend WithEvents TBPrenom As TextBox
    Friend WithEvents LAPrenom As Label
    Friend WithEvents CBStatut As ComboBox
    Friend WithEvents TBNom As TextBox
    Friend WithEvents LAStatut As Label
    Friend WithEvents LANom As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AddButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents BackButton As Button
End Class
