<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerTournee
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TOURNDATE_label = New System.Windows.Forms.Label()
        Me.TOURNDATE_input = New System.Windows.Forms.DateTimePicker()
        Me.TOURNDEPART_input = New System.Windows.Forms.TextBox()
        Me.TOURNDEPART_label = New System.Windows.Forms.Label()
        Me.TOURNARRIVEE_label = New System.Windows.Forms.Label()
        Me.TOURNARRIVEE_input = New System.Windows.Forms.TextBox()
        Me.CAMIMMAT_label = New System.Windows.Forms.Label()
        Me.CreerTournee_creer = New System.Windows.Forms.Button()
        Me.CAMIMMAT_input = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(64, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 30)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mesguen"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'TOURNDATE_label
        '
        Me.TOURNDATE_label.AutoSize = True
        Me.TOURNDATE_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TOURNDATE_label.Location = New System.Drawing.Point(12, 91)
        Me.TOURNDATE_label.Name = "TOURNDATE_label"
        Me.TOURNDATE_label.Size = New System.Drawing.Size(49, 21)
        Me.TOURNDATE_label.TabIndex = 11
        Me.TOURNDATE_label.Text = "Date :"
        '
        'TOURNDATE_input
        '
        Me.TOURNDATE_input.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TOURNDATE_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TOURNDATE_input.Location = New System.Drawing.Point(12, 115)
        Me.TOURNDATE_input.Name = "TOURNDATE_input"
        Me.TOURNDATE_input.Size = New System.Drawing.Size(300, 32)
        Me.TOURNDATE_input.TabIndex = 12
        '
        'TOURNDEPART_input
        '
        Me.TOURNDEPART_input.BackColor = System.Drawing.SystemColors.Window
        Me.TOURNDEPART_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TOURNDEPART_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TOURNDEPART_input.Location = New System.Drawing.Point(390, 115)
        Me.TOURNDEPART_input.Name = "TOURNDEPART_input"
        Me.TOURNDEPART_input.Size = New System.Drawing.Size(300, 32)
        Me.TOURNDEPART_input.TabIndex = 13
        '
        'TOURNDEPART_label
        '
        Me.TOURNDEPART_label.AutoSize = True
        Me.TOURNDEPART_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TOURNDEPART_label.Location = New System.Drawing.Point(386, 91)
        Me.TOURNDEPART_label.Name = "TOURNDEPART_label"
        Me.TOURNDEPART_label.Size = New System.Drawing.Size(64, 21)
        Me.TOURNDEPART_label.TabIndex = 14
        Me.TOURNDEPART_label.Text = "Départ :"
        '
        'TOURNARRIVEE_label
        '
        Me.TOURNARRIVEE_label.AutoSize = True
        Me.TOURNARRIVEE_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TOURNARRIVEE_label.Location = New System.Drawing.Point(386, 157)
        Me.TOURNARRIVEE_label.Name = "TOURNARRIVEE_label"
        Me.TOURNARRIVEE_label.Size = New System.Drawing.Size(67, 21)
        Me.TOURNARRIVEE_label.TabIndex = 16
        Me.TOURNARRIVEE_label.Text = "Arrivée :"
        '
        'TOURNARRIVEE_input
        '
        Me.TOURNARRIVEE_input.BackColor = System.Drawing.SystemColors.Window
        Me.TOURNARRIVEE_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TOURNARRIVEE_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TOURNARRIVEE_input.Location = New System.Drawing.Point(390, 181)
        Me.TOURNARRIVEE_input.Name = "TOURNARRIVEE_input"
        Me.TOURNARRIVEE_input.Size = New System.Drawing.Size(300, 32)
        Me.TOURNARRIVEE_input.TabIndex = 15
        '
        'CAMIMMAT_label
        '
        Me.CAMIMMAT_label.AutoSize = True
        Me.CAMIMMAT_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CAMIMMAT_label.Location = New System.Drawing.Point(12, 157)
        Me.CAMIMMAT_label.Name = "CAMIMMAT_label"
        Me.CAMIMMAT_label.Size = New System.Drawing.Size(204, 21)
        Me.CAMIMMAT_label.TabIndex = 18
        Me.CAMIMMAT_label.Text = "Immatriculation du camion :"
        '
        'CreerTournee_creer
        '
        Me.CreerTournee_creer.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.CreerTournee_creer.FlatAppearance.BorderSize = 0
        Me.CreerTournee_creer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreerTournee_creer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CreerTournee_creer.Location = New System.Drawing.Point(617, 232)
        Me.CreerTournee_creer.Name = "CreerTournee_creer"
        Me.CreerTournee_creer.Size = New System.Drawing.Size(73, 30)
        Me.CreerTournee_creer.TabIndex = 19
        Me.CreerTournee_creer.Text = "Créer"
        Me.CreerTournee_creer.UseVisualStyleBackColor = False
        '
        'CAMIMMAT_input
        '
        Me.CAMIMMAT_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CAMIMMAT_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.CAMIMMAT_input.FormattingEnabled = True
        Me.CAMIMMAT_input.Location = New System.Drawing.Point(16, 181)
        Me.CAMIMMAT_input.Name = "CAMIMMAT_input"
        Me.CAMIMMAT_input.Size = New System.Drawing.Size(296, 33)
        Me.CAMIMMAT_input.TabIndex = 20
        '
        'CreerTournee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 278)
        Me.Controls.Add(Me.CAMIMMAT_input)
        Me.Controls.Add(Me.CreerTournee_creer)
        Me.Controls.Add(Me.CAMIMMAT_label)
        Me.Controls.Add(Me.TOURNARRIVEE_label)
        Me.Controls.Add(Me.TOURNARRIVEE_input)
        Me.Controls.Add(Me.TOURNDEPART_label)
        Me.Controls.Add(Me.TOURNDEPART_input)
        Me.Controls.Add(Me.TOURNDATE_input)
        Me.Controls.Add(Me.TOURNDATE_label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CreerTournee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreerTournee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TOURNDATE_label As Label
    Friend WithEvents TOURNDATE_input As DateTimePicker
    Friend WithEvents TOURNDEPART_input As TextBox
    Friend WithEvents TOURNDEPART_label As Label
    Friend WithEvents TOURNARRIVEE_label As Label
    Friend WithEvents TOURNARRIVEE_input As TextBox
    Friend WithEvents CAMIMMAT_label As Label
    Friend WithEvents CreerTournee_creer As Button
    Friend WithEvents CAMIMMAT_input As ComboBox
End Class
