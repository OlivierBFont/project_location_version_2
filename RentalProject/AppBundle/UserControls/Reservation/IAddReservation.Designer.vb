<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IAddReservation
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Person = New System.Windows.Forms.TextBox()
        Me.NewPersonButton = New System.Windows.Forms.Button()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.EquipmentCollection = New System.Windows.Forms.ListView()
        Me.EquipmentID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EquipmentName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Comments = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDownHeure = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownJour = New System.Windows.Forms.NumericUpDown()
        Me.CbEquipement = New System.Windows.Forms.ComboBox()
        Me.CbCategorie = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TbAutorise = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.NumericUpDownHeure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownJour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(586, 50)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Ajout d'une réservation"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(112, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "Nom, Prénom"
        '
        'Person
        '
        Me.Person.Location = New System.Drawing.Point(114, 91)
        Me.Person.MaxLength = 30
        Me.Person.Name = "Person"
        Me.Person.Size = New System.Drawing.Size(161, 20)
        Me.Person.TabIndex = 126
        '
        'NewPersonButton
        '
        Me.NewPersonButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.NewPersonButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewPersonButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.NewPersonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.NewPersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewPersonButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPersonButton.ForeColor = System.Drawing.Color.White
        Me.NewPersonButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NewPersonButton.Location = New System.Drawing.Point(281, 89)
        Me.NewPersonButton.Name = "NewPersonButton"
        Me.NewPersonButton.Size = New System.Drawing.Size(33, 21)
        Me.NewPersonButton.TabIndex = 125
        Me.NewPersonButton.Text = "+"
        Me.NewPersonButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NewPersonButton.UseVisualStyleBackColor = False
        '
        'SelectButton
        '
        Me.SelectButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SelectButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectButton.ForeColor = System.Drawing.Color.White
        Me.SelectButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SelectButton.Location = New System.Drawing.Point(281, 177)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(33, 21)
        Me.SelectButton.TabIndex = 124
        Me.SelectButton.Text = "->"
        Me.SelectButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SelectButton.UseVisualStyleBackColor = False
        '
        'EquipmentCollection
        '
        Me.EquipmentCollection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EquipmentID, Me.EquipmentName})
        Me.EquipmentCollection.FullRowSelect = True
        Me.EquipmentCollection.HideSelection = False
        Me.EquipmentCollection.Location = New System.Drawing.Point(331, 87)
        Me.EquipmentCollection.MultiSelect = False
        Me.EquipmentCollection.Name = "EquipmentCollection"
        Me.EquipmentCollection.Size = New System.Drawing.Size(246, 149)
        Me.EquipmentCollection.TabIndex = 123
        Me.EquipmentCollection.UseCompatibleStateImageBehavior = False
        Me.EquipmentCollection.View = System.Windows.Forms.View.Details
        '
        'EquipmentID
        '
        Me.EquipmentID.Text = "ID"
        Me.EquipmentID.Width = 38
        '
        'EquipmentName
        '
        Me.EquipmentName.Text = "Nom d'équipement"
        Me.EquipmentName.Width = 173
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(338, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 13)
        Me.Label8.TabIndex = 122
        Me.Label8.Text = "* Pour retirer, Double-clicker sur l'item."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(328, 67)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 17)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Équipements à réserver"
        '
        'Comments
        '
        Me.Comments.Location = New System.Drawing.Point(331, 284)
        Me.Comments.Margin = New System.Windows.Forms.Padding(2)
        Me.Comments.MaxLength = 1000
        Me.Comments.Multiline = True
        Me.Comments.Name = "Comments"
        Me.Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Comments.Size = New System.Drawing.Size(246, 87)
        Me.Comments.TabIndex = 120
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(328, 266)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 17)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "Commentaires"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 17)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Durée de la réservation (H)"
        '
        'NumericUpDownHeure
        '
        Me.NumericUpDownHeure.Location = New System.Drawing.Point(253, 285)
        Me.NumericUpDownHeure.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericUpDownHeure.Name = "NumericUpDownHeure"
        Me.NumericUpDownHeure.Size = New System.Drawing.Size(61, 20)
        Me.NumericUpDownHeure.TabIndex = 117
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(196, 316)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 21)
        Me.CheckBox1.TabIndex = 116
        Me.CheckBox1.Text = "Date Fixe"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Date de retour"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 17)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Durée de la réservation (J)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Autorisé par"
        '
        'NumericUpDownJour
        '
        Me.NumericUpDownJour.Location = New System.Drawing.Point(253, 251)
        Me.NumericUpDownJour.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericUpDownJour.Name = "NumericUpDownJour"
        Me.NumericUpDownJour.Size = New System.Drawing.Size(61, 20)
        Me.NumericUpDownJour.TabIndex = 112
        '
        'CbEquipement
        '
        Me.CbEquipement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEquipement.Enabled = False
        Me.CbEquipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbEquipement.FormattingEnabled = True
        Me.CbEquipement.Location = New System.Drawing.Point(114, 177)
        Me.CbEquipement.Name = "CbEquipement"
        Me.CbEquipement.Size = New System.Drawing.Size(161, 21)
        Me.CbEquipement.TabIndex = 111
        '
        'CbCategorie
        '
        Me.CbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbCategorie.FormattingEnabled = True
        Me.CbCategorie.Location = New System.Drawing.Point(114, 134)
        Me.CbCategorie.Name = "CbCategorie"
        Me.CbCategorie.Size = New System.Drawing.Size(200, 21)
        Me.CbCategorie.TabIndex = 110
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(48, 340)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(234, 20)
        Me.DateTimePicker1.TabIndex = 109
        '
        'TbAutorise
        '
        Me.TbAutorise.Location = New System.Drawing.Point(114, 216)
        Me.TbAutorise.MaxLength = 30
        Me.TbAutorise.Name = "TbAutorise"
        Me.TbAutorise.Size = New System.Drawing.Size(200, 20)
        Me.TbAutorise.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Équipement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Categorie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Réservé par"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SaveButton)
        Me.Panel2.Controls.Add(Me.ResetButton)
        Me.Panel2.Controls.Add(Me.CancelButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 382)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 58)
        Me.Panel2.TabIndex = 128
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
        Me.SaveButton.TabIndex = 87
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
        Me.ResetButton.TabIndex = 86
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
        Me.CancelButton.TabIndex = 85
        Me.CancelButton.Text = "Annuler"
        Me.CancelButton.UseVisualStyleBackColor = False
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
        Me.BackButton.Size = New System.Drawing.Size(52, 50)
        Me.BackButton.TabIndex = 129
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'IAddReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Person)
        Me.Controls.Add(Me.NewPersonButton)
        Me.Controls.Add(Me.SelectButton)
        Me.Controls.Add(Me.EquipmentCollection)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Comments)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDownHeure)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDownJour)
        Me.Controls.Add(Me.CbEquipement)
        Me.Controls.Add(Me.CbCategorie)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TbAutorise)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Name = "IAddReservation"
        Me.Size = New System.Drawing.Size(586, 440)
        CType(Me.NumericUpDownHeure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownJour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Person As TextBox
    Friend WithEvents NewPersonButton As Button
    Friend WithEvents SelectButton As Button
    Friend WithEvents EquipmentCollection As ListView
    Friend WithEvents EquipmentID As ColumnHeader
    Friend WithEvents EquipmentName As ColumnHeader
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Comments As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDownHeure As NumericUpDown
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDownJour As NumericUpDown
    Friend WithEvents CbEquipement As ComboBox
    Friend WithEvents CbCategorie As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TbAutorise As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SaveButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents BackButton As Button
End Class
