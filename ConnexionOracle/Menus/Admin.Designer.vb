<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.TextUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.VoirCommandes_btn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextUser
        '
        Me.TextUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextUser.AutoSize = True
        Me.TextUser.Location = New System.Drawing.Point(8, 209)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextUser.Size = New System.Drawing.Size(116, 13)
        Me.TextUser.TabIndex = 17
        Me.TextUser.Text = "Connecté en tant que :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(461, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Menu admin"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(18, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 30)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Voir les tournées"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(70, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Mesguen"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(18, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 30)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Créer une tournée"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'VoirCommandes_btn
        '
        Me.VoirCommandes_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.VoirCommandes_btn.FlatAppearance.BorderSize = 0
        Me.VoirCommandes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VoirCommandes_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.VoirCommandes_btn.Location = New System.Drawing.Point(179, 73)
        Me.VoirCommandes_btn.Name = "VoirCommandes_btn"
        Me.VoirCommandes_btn.Size = New System.Drawing.Size(180, 30)
        Me.VoirCommandes_btn.TabIndex = 20
        Me.VoirCommandes_btn.Text = "Voir les commandes"
        Me.VoirCommandes_btn.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button3.Location = New System.Drawing.Point(179, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 30)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Créer une commande"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button4.Location = New System.Drawing.Point(365, 73)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 30)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Voir les palettes"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button5.Location = New System.Drawing.Point(365, 145)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(180, 30)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Créer une palette"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button6.Location = New System.Drawing.Point(179, 181)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(180, 30)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Créer un camion"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(18, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button7.Location = New System.Drawing.Point(179, 109)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(180, 30)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = "Voir les camions"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 230)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.VoirCommandes_btn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents VoirCommandes_btn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
