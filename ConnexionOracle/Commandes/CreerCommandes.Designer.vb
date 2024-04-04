<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerCommandes
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
        Me.CLIID_input = New System.Windows.Forms.ComboBox()
        Me.CreerCommandes_creer = New System.Windows.Forms.Button()
        Me.CLIID_label = New System.Windows.Forms.Label()
        Me.COMCHARG_label = New System.Windows.Forms.Label()
        Me.COMCHARG_input = New System.Windows.Forms.TextBox()
        Me.COMDEVISE_label = New System.Windows.Forms.Label()
        Me.COMDEVISE_input = New System.Windows.Forms.TextBox()
        Me.COMDATE_input = New System.Windows.Forms.DateTimePicker()
        Me.COMDATE_label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.COMLIVR_label = New System.Windows.Forms.Label()
        Me.COMLIVR_input = New System.Windows.Forms.TextBox()
        Me.EXPID_input = New System.Windows.Forms.ComboBox()
        Me.EXPID_label = New System.Windows.Forms.Label()
        Me.TOURNID_input = New System.Windows.Forms.ComboBox()
        Me.TOURNID_label = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLIID_input
        '
        Me.CLIID_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CLIID_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.CLIID_input.FormattingEnabled = True
        Me.CLIID_input.Location = New System.Drawing.Point(16, 183)
        Me.CLIID_input.Name = "CLIID_input"
        Me.CLIID_input.Size = New System.Drawing.Size(296, 33)
        Me.CLIID_input.TabIndex = 31
        '
        'CreerCommandes_creer
        '
        Me.CreerCommandes_creer.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.CreerCommandes_creer.FlatAppearance.BorderSize = 0
        Me.CreerCommandes_creer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreerCommandes_creer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CreerCommandes_creer.Location = New System.Drawing.Point(617, 360)
        Me.CreerCommandes_creer.Name = "CreerCommandes_creer"
        Me.CreerCommandes_creer.Size = New System.Drawing.Size(73, 30)
        Me.CreerCommandes_creer.TabIndex = 30
        Me.CreerCommandes_creer.Text = "Créer"
        Me.CreerCommandes_creer.UseVisualStyleBackColor = False
        '
        'CLIID_label
        '
        Me.CLIID_label.AutoSize = True
        Me.CLIID_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CLIID_label.Location = New System.Drawing.Point(12, 159)
        Me.CLIID_label.Name = "CLIID_label"
        Me.CLIID_label.Size = New System.Drawing.Size(57, 21)
        Me.CLIID_label.TabIndex = 29
        Me.CLIID_label.Text = "Client :"
        '
        'COMCHARG_label
        '
        Me.COMCHARG_label.AutoSize = True
        Me.COMCHARG_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.COMCHARG_label.Location = New System.Drawing.Point(386, 159)
        Me.COMCHARG_label.Name = "COMCHARG_label"
        Me.COMCHARG_label.Size = New System.Drawing.Size(154, 21)
        Me.COMCHARG_label.TabIndex = 28
        Me.COMCHARG_label.Text = "Lieu de chargement :"
        '
        'COMCHARG_input
        '
        Me.COMCHARG_input.BackColor = System.Drawing.SystemColors.Window
        Me.COMCHARG_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.COMCHARG_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.COMCHARG_input.Location = New System.Drawing.Point(390, 183)
        Me.COMCHARG_input.Name = "COMCHARG_input"
        Me.COMCHARG_input.Size = New System.Drawing.Size(300, 32)
        Me.COMCHARG_input.TabIndex = 27
        '
        'COMDEVISE_label
        '
        Me.COMDEVISE_label.AutoSize = True
        Me.COMDEVISE_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.COMDEVISE_label.Location = New System.Drawing.Point(386, 93)
        Me.COMDEVISE_label.Name = "COMDEVISE_label"
        Me.COMDEVISE_label.Size = New System.Drawing.Size(63, 21)
        Me.COMDEVISE_label.TabIndex = 26
        Me.COMDEVISE_label.Text = "Devise :"
        '
        'COMDEVISE_input
        '
        Me.COMDEVISE_input.BackColor = System.Drawing.SystemColors.Window
        Me.COMDEVISE_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.COMDEVISE_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.COMDEVISE_input.Location = New System.Drawing.Point(390, 117)
        Me.COMDEVISE_input.Name = "COMDEVISE_input"
        Me.COMDEVISE_input.Size = New System.Drawing.Size(300, 32)
        Me.COMDEVISE_input.TabIndex = 25
        '
        'COMDATE_input
        '
        Me.COMDATE_input.CalendarFont = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.COMDATE_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.COMDATE_input.Location = New System.Drawing.Point(12, 117)
        Me.COMDATE_input.Name = "COMDATE_input"
        Me.COMDATE_input.Size = New System.Drawing.Size(300, 32)
        Me.COMDATE_input.TabIndex = 24
        '
        'COMDATE_label
        '
        Me.COMDATE_label.AutoSize = True
        Me.COMDATE_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.COMDATE_label.Location = New System.Drawing.Point(12, 93)
        Me.COMDATE_label.Name = "COMDATE_label"
        Me.COMDATE_label.Size = New System.Drawing.Size(49, 21)
        Me.COMDATE_label.TabIndex = 23
        Me.COMDATE_label.Text = "Date :"
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
        'COMLIVR_label
        '
        Me.COMLIVR_label.AutoSize = True
        Me.COMLIVR_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.COMLIVR_label.Location = New System.Drawing.Point(386, 225)
        Me.COMLIVR_label.Name = "COMLIVR_label"
        Me.COMLIVR_label.Size = New System.Drawing.Size(130, 21)
        Me.COMLIVR_label.TabIndex = 33
        Me.COMLIVR_label.Text = "Lieu de livraison :"
        '
        'COMLIVR_input
        '
        Me.COMLIVR_input.BackColor = System.Drawing.SystemColors.Window
        Me.COMLIVR_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.COMLIVR_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.COMLIVR_input.Location = New System.Drawing.Point(390, 249)
        Me.COMLIVR_input.Name = "COMLIVR_input"
        Me.COMLIVR_input.Size = New System.Drawing.Size(300, 32)
        Me.COMLIVR_input.TabIndex = 32
        '
        'EXPID_input
        '
        Me.EXPID_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EXPID_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.EXPID_input.FormattingEnabled = True
        Me.EXPID_input.Location = New System.Drawing.Point(16, 248)
        Me.EXPID_input.Name = "EXPID_input"
        Me.EXPID_input.Size = New System.Drawing.Size(296, 33)
        Me.EXPID_input.TabIndex = 35
        '
        'EXPID_label
        '
        Me.EXPID_label.AutoSize = True
        Me.EXPID_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EXPID_label.Location = New System.Drawing.Point(12, 224)
        Me.EXPID_label.Name = "EXPID_label"
        Me.EXPID_label.Size = New System.Drawing.Size(90, 21)
        Me.EXPID_label.TabIndex = 34
        Me.EXPID_label.Text = "Expediteur :"
        '
        'TOURNID_input
        '
        Me.TOURNID_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TOURNID_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TOURNID_input.FormattingEnabled = True
        Me.TOURNID_input.Location = New System.Drawing.Point(16, 315)
        Me.TOURNID_input.Name = "TOURNID_input"
        Me.TOURNID_input.Size = New System.Drawing.Size(296, 33)
        Me.TOURNID_input.TabIndex = 37
        '
        'TOURNID_label
        '
        Me.TOURNID_label.AutoSize = True
        Me.TOURNID_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TOURNID_label.Location = New System.Drawing.Point(12, 291)
        Me.TOURNID_label.Name = "TOURNID_label"
        Me.TOURNID_label.Size = New System.Drawing.Size(72, 21)
        Me.TOURNID_label.TabIndex = 36
        Me.TOURNID_label.Text = "Tournée :"
        '
        'CreerCommandes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 402)
        Me.Controls.Add(Me.TOURNID_input)
        Me.Controls.Add(Me.TOURNID_label)
        Me.Controls.Add(Me.EXPID_input)
        Me.Controls.Add(Me.EXPID_label)
        Me.Controls.Add(Me.COMLIVR_label)
        Me.Controls.Add(Me.COMLIVR_input)
        Me.Controls.Add(Me.CLIID_input)
        Me.Controls.Add(Me.CreerCommandes_creer)
        Me.Controls.Add(Me.CLIID_label)
        Me.Controls.Add(Me.COMCHARG_label)
        Me.Controls.Add(Me.COMCHARG_input)
        Me.Controls.Add(Me.COMDEVISE_label)
        Me.Controls.Add(Me.COMDEVISE_input)
        Me.Controls.Add(Me.COMDATE_input)
        Me.Controls.Add(Me.COMDATE_label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CreerCommandes"
        Me.Text = "CreerCommandes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CLIID_input As ComboBox
    Friend WithEvents CreerCommandes_creer As Button
    Friend WithEvents CLIID_label As Label
    Friend WithEvents COMCHARG_label As Label
    Friend WithEvents COMCHARG_input As TextBox
    Friend WithEvents COMDEVISE_label As Label
    Friend WithEvents COMDEVISE_input As TextBox
    Friend WithEvents COMDATE_input As DateTimePicker
    Friend WithEvents COMDATE_label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents COMLIVR_label As Label
    Friend WithEvents COMLIVR_input As TextBox
    Friend WithEvents EXPID_input As ComboBox
    Friend WithEvents EXPID_label As Label
    Friend WithEvents TOURNID_input As ComboBox
    Friend WithEvents TOURNID_label As Label
End Class
