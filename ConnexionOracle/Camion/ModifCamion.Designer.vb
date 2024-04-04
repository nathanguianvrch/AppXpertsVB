<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifCamion
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NOM_input = New System.Windows.Forms.TextBox()
        Me.TCID_input = New System.Windows.Forms.ComboBox()
        Me.CHAUFFID_input = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IMMAT_input = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(64, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 30)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Mesguen"
        '
        'NOM_input
        '
        Me.NOM_input.BackColor = System.Drawing.SystemColors.Window
        Me.NOM_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NOM_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.NOM_input.Location = New System.Drawing.Point(27, 212)
        Me.NOM_input.Name = "NOM_input"
        Me.NOM_input.Size = New System.Drawing.Size(300, 32)
        Me.NOM_input.TabIndex = 37
        '
        'TCID_input
        '
        Me.TCID_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TCID_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TCID_input.FormattingEnabled = True
        Me.TCID_input.Location = New System.Drawing.Point(376, 126)
        Me.TCID_input.Name = "TCID_input"
        Me.TCID_input.Size = New System.Drawing.Size(296, 33)
        Me.TCID_input.TabIndex = 38
        '
        'CHAUFFID_input
        '
        Me.CHAUFFID_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CHAUFFID_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.CHAUFFID_input.FormattingEnabled = True
        Me.CHAUFFID_input.Location = New System.Drawing.Point(376, 212)
        Me.CHAUFFID_input.Name = "CHAUFFID_input"
        Me.CHAUFFID_input.Size = New System.Drawing.Size(296, 33)
        Me.CHAUFFID_input.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(23, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 21)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Marque du camion :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(372, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Type du camion :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(372, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Chauffeur :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(492, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 30)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Modifier le camion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'IMMAT_input
        '
        Me.IMMAT_input.BackColor = System.Drawing.SystemColors.Window
        Me.IMMAT_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMMAT_input.Enabled = False
        Me.IMMAT_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.IMMAT_input.Location = New System.Drawing.Point(27, 126)
        Me.IMMAT_input.Name = "IMMAT_input"
        Me.IMMAT_input.Size = New System.Drawing.Size(300, 32)
        Me.IMMAT_input.TabIndex = 44
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label.Location = New System.Drawing.Point(23, 102)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(127, 21)
        Me.Label.TabIndex = 45
        Me.Label.Text = "Immatriculation :"
        '
        'ModifCamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 402)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.IMMAT_input)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CHAUFFID_input)
        Me.Controls.Add(Me.TCID_input)
        Me.Controls.Add(Me.NOM_input)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ModifCamion"
        Me.Text = "ModifCamion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NOM_input As TextBox
    Friend WithEvents TCID_input As ComboBox
    Friend WithEvents CHAUFFID_input As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents IMMAT_input As TextBox
    Friend WithEvents Label As Label
End Class
