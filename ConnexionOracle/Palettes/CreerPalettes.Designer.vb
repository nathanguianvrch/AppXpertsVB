<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerPalettes
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CreerTournee_creer = New System.Windows.Forms.Button()
        Me.PALTYPE_label = New System.Windows.Forms.Label()
        Me.PALTYPE_input = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.COMID_input = New System.Windows.Forms.ComboBox()
        Me.COMID_label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CreerTournee_creer
        '
        Me.CreerTournee_creer.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.CreerTournee_creer.FlatAppearance.BorderSize = 0
        Me.CreerTournee_creer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreerTournee_creer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CreerTournee_creer.Location = New System.Drawing.Point(617, 158)
        Me.CreerTournee_creer.Name = "CreerTournee_creer"
        Me.CreerTournee_creer.Size = New System.Drawing.Size(73, 30)
        Me.CreerTournee_creer.TabIndex = 30
        Me.CreerTournee_creer.Text = "Créer"
        Me.CreerTournee_creer.UseVisualStyleBackColor = False
        '
        'PALTYPE_label
        '
        Me.PALTYPE_label.AutoSize = True
        Me.PALTYPE_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PALTYPE_label.Location = New System.Drawing.Point(12, 90)
        Me.PALTYPE_label.Name = "PALTYPE_label"
        Me.PALTYPE_label.Size = New System.Drawing.Size(49, 21)
        Me.PALTYPE_label.TabIndex = 26
        Me.PALTYPE_label.Text = "Type :"
        '
        'PALTYPE_input
        '
        Me.PALTYPE_input.BackColor = System.Drawing.SystemColors.Window
        Me.PALTYPE_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PALTYPE_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.PALTYPE_input.Location = New System.Drawing.Point(16, 114)
        Me.PALTYPE_input.Name = "PALTYPE_input"
        Me.PALTYPE_input.Size = New System.Drawing.Size(300, 32)
        Me.PALTYPE_input.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(64, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 30)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Mesguen"
        '
        'COMID_input
        '
        Me.COMID_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMID_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.COMID_input.FormattingEnabled = True
        Me.COMID_input.Location = New System.Drawing.Point(394, 113)
        Me.COMID_input.Name = "COMID_input"
        Me.COMID_input.Size = New System.Drawing.Size(296, 33)
        Me.COMID_input.TabIndex = 31
        '
        'COMID_label
        '
        Me.COMID_label.AutoSize = True
        Me.COMID_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.COMID_label.Location = New System.Drawing.Point(390, 89)
        Me.COMID_label.Name = "COMID_label"
        Me.COMID_label.Size = New System.Drawing.Size(98, 21)
        Me.COMID_label.TabIndex = 29
        Me.COMID_label.Text = "Commande :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'CreerPalettes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 200)
        Me.Controls.Add(Me.COMID_input)
        Me.Controls.Add(Me.CreerTournee_creer)
        Me.Controls.Add(Me.COMID_label)
        Me.Controls.Add(Me.PALTYPE_label)
        Me.Controls.Add(Me.PALTYPE_input)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CreerPalettes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreerPalettes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CreerTournee_creer As Button
    Friend WithEvents PALTYPE_label As Label
    Friend WithEvents PALTYPE_input As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents COMID_input As ComboBox
    Friend WithEvents COMID_label As Label
End Class
