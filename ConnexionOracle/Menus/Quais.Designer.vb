<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quais
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
        Me.VoirCommandes_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextUser
        '
        Me.TextUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextUser.AutoSize = True
        Me.TextUser.Location = New System.Drawing.Point(7, 209)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextUser.Size = New System.Drawing.Size(116, 13)
        Me.TextUser.TabIndex = 18
        Me.TextUser.Text = "Connecté en tant que :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(376, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Menu quais"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(17, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 30)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Voir les tournées"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(69, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Mesguen"
        '
        'VoirCommandes_btn
        '
        Me.VoirCommandes_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.VoirCommandes_btn.FlatAppearance.BorderSize = 0
        Me.VoirCommandes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VoirCommandes_btn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.VoirCommandes_btn.Location = New System.Drawing.Point(17, 124)
        Me.VoirCommandes_btn.Name = "VoirCommandes_btn"
        Me.VoirCommandes_btn.Size = New System.Drawing.Size(166, 30)
        Me.VoirCommandes_btn.TabIndex = 19
        Me.VoirCommandes_btn.Text = "Voir les commandes"
        Me.VoirCommandes_btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(17, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Quais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 230)
        Me.Controls.Add(Me.VoirCommandes_btn)
        Me.Controls.Add(Me.TextUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Quais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quais"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VoirCommandes_btn As Button
End Class
