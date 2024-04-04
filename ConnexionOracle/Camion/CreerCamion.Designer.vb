<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerCamion
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
        Me.IMMAT_input = New System.Windows.Forms.TextBox()
        Me.NOM_input = New System.Windows.Forms.TextBox()
        Me.TCID_input = New System.Windows.Forms.ComboBox()
        Me.CHAUFFID_input = New System.Windows.Forms.ComboBox()
        Me.COMDATE_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CreerCommandes_creer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(64, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 30)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Mesguen"
        '
        'IMMAT_input
        '
        Me.IMMAT_input.BackColor = System.Drawing.SystemColors.Window
        Me.IMMAT_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IMMAT_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.IMMAT_input.Location = New System.Drawing.Point(27, 127)
        Me.IMMAT_input.Name = "IMMAT_input"
        Me.IMMAT_input.Size = New System.Drawing.Size(300, 32)
        Me.IMMAT_input.TabIndex = 26
        '
        'NOM_input
        '
        Me.NOM_input.BackColor = System.Drawing.SystemColors.Window
        Me.NOM_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NOM_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.NOM_input.Location = New System.Drawing.Point(27, 213)
        Me.NOM_input.Name = "NOM_input"
        Me.NOM_input.Size = New System.Drawing.Size(300, 32)
        Me.NOM_input.TabIndex = 27
        '
        'TCID_input
        '
        Me.TCID_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TCID_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TCID_input.FormattingEnabled = True
        Me.TCID_input.Location = New System.Drawing.Point(376, 126)
        Me.TCID_input.Name = "TCID_input"
        Me.TCID_input.Size = New System.Drawing.Size(296, 33)
        Me.TCID_input.TabIndex = 32
        '
        'CHAUFFID_input
        '
        Me.CHAUFFID_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CHAUFFID_input.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.CHAUFFID_input.FormattingEnabled = True
        Me.CHAUFFID_input.Location = New System.Drawing.Point(376, 212)
        Me.CHAUFFID_input.Name = "CHAUFFID_input"
        Me.CHAUFFID_input.Size = New System.Drawing.Size(296, 33)
        Me.CHAUFFID_input.TabIndex = 33
        '
        'COMDATE_label
        '
        Me.COMDATE_label.AutoSize = True
        Me.COMDATE_label.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.COMDATE_label.Location = New System.Drawing.Point(23, 103)
        Me.COMDATE_label.Name = "COMDATE_label"
        Me.COMDATE_label.Size = New System.Drawing.Size(127, 21)
        Me.COMDATE_label.TabIndex = 34
        Me.COMDATE_label.Text = "Immatriculation :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(23, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 21)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Marque du camion :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(372, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Type du camion :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(372, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Chauffeur :"
        '
        'CreerCommandes_creer
        '
        Me.CreerCommandes_creer.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.CreerCommandes_creer.FlatAppearance.BorderSize = 0
        Me.CreerCommandes_creer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreerCommandes_creer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CreerCommandes_creer.Location = New System.Drawing.Point(599, 360)
        Me.CreerCommandes_creer.Name = "CreerCommandes_creer"
        Me.CreerCommandes_creer.Size = New System.Drawing.Size(73, 30)
        Me.CreerCommandes_creer.TabIndex = 38
        Me.CreerCommandes_creer.Text = "Créer"
        Me.CreerCommandes_creer.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConnexionOracle.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'CreerCamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 402)
        Me.Controls.Add(Me.CreerCommandes_creer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.COMDATE_label)
        Me.Controls.Add(Me.CHAUFFID_input)
        Me.Controls.Add(Me.TCID_input)
        Me.Controls.Add(Me.NOM_input)
        Me.Controls.Add(Me.IMMAT_input)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CreerCamion"
        Me.Text = "CreerCamion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents IMMAT_input As TextBox
    Friend WithEvents NOM_input As TextBox
    Friend WithEvents TCID_input As ComboBox
    Friend WithEvents CHAUFFID_input As ComboBox
    Friend WithEvents COMDATE_label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CreerCommandes_creer As Button
End Class
