﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IReservation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.DetailsButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.ReservButton = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RentedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Authorisation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(586, 58)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Réservation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.WarningLabel)
        Me.Panel6.Controls.Add(Me.DetailsButton)
        Me.Panel6.Controls.Add(Me.SearchButton)
        Me.Panel6.Controls.Add(Me.ReturnButton)
        Me.Panel6.Controls.Add(Me.ReservButton)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 368)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(586, 72)
        Me.Panel6.TabIndex = 6
        '
        'WarningLabel
        '
        Me.WarningLabel.AutoSize = True
        Me.WarningLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.WarningLabel.Location = New System.Drawing.Point(94, 0)
        Me.WarningLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(146, 13)
        Me.WarningLabel.TabIndex = 9
        Me.WarningLabel.Text = "* Veuillez en choisir un avant."
        '
        'DetailsButton
        '
        Me.DetailsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DetailsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DetailsButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DetailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DetailsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsButton.ForeColor = System.Drawing.Color.White
        Me.DetailsButton.Location = New System.Drawing.Point(0, 0)
        Me.DetailsButton.Margin = New System.Windows.Forms.Padding(5)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(94, 72)
        Me.DetailsButton.TabIndex = 8
        Me.DetailsButton.Text = "Afficher les Détails"
        Me.DetailsButton.UseVisualStyleBackColor = False
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
        Me.SearchButton.Location = New System.Drawing.Point(261, 0)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(94, 72)
        Me.SearchButton.TabIndex = 7
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnButton.ForeColor = System.Drawing.Color.White
        Me.ReturnButton.Location = New System.Drawing.Point(355, 0)
        Me.ReturnButton.Margin = New System.Windows.Forms.Padding(5)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(121, 72)
        Me.ReturnButton.TabIndex = 6
        Me.ReturnButton.Text = "Annuler une réservation"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'ReservButton
        '
        Me.ReservButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ReservButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReservButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ReservButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ReservButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ReservButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReservButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservButton.ForeColor = System.Drawing.Color.White
        Me.ReservButton.Location = New System.Drawing.Point(476, 0)
        Me.ReservButton.Margin = New System.Windows.Forms.Padding(5)
        Me.ReservButton.Name = "ReservButton"
        Me.ReservButton.Size = New System.Drawing.Size(110, 72)
        Me.ReservButton.TabIndex = 5
        Me.ReservButton.Text = "Ajouter un Emprunt"
        Me.ReservButton.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.RentedBy, Me.Authorisation})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 63)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(5)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(586, 300)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'RentedBy
        '
        Me.RentedBy.Text = "Réservé par"
        Me.RentedBy.Width = 177
        '
        'Authorisation
        '
        Me.Authorisation.Text = "Autorisé par"
        Me.Authorisation.Width = 185
        '
        'IReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(586, 440)
        Me.Name = "IReservation"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents WarningLabel As Label
    Friend WithEvents DetailsButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents ReservButton As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents RentedBy As ColumnHeader
    Friend WithEvents Authorisation As ColumnHeader
End Class
