<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WisText = New System.Windows.Forms.Label()
        Me.WisBut = New System.Windows.Forms.Button()
        Me.ExitButt = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.WisText)
        Me.Panel1.Location = New System.Drawing.Point(65, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 55)
        Me.Panel1.TabIndex = 0
        '
        'WisText
        '
        Me.WisText.AutoSize = True
        Me.WisText.BackColor = System.Drawing.Color.Transparent
        Me.WisText.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WisText.Location = New System.Drawing.Point(18, 12)
        Me.WisText.Name = "WisText"
        Me.WisText.Size = New System.Drawing.Size(176, 26)
        Me.WisText.TabIndex = 0
        Me.WisText.Text = "Wisdoms Machine"
        '
        'WisBut
        '
        Me.WisBut.BackColor = System.Drawing.Color.Transparent
        Me.WisBut.Location = New System.Drawing.Point(134, 326)
        Me.WisBut.Name = "WisBut"
        Me.WisBut.Size = New System.Drawing.Size(93, 58)
        Me.WisBut.TabIndex = 1
        Me.WisBut.Text = "Press For Wisdom"
        Me.WisBut.UseVisualStyleBackColor = False
        '
        'ExitButt
        '
        Me.ExitButt.BackColor = System.Drawing.Color.Transparent
        Me.ExitButt.Location = New System.Drawing.Point(602, 326)
        Me.ExitButt.Name = "ExitButt"
        Me.ExitButt.Size = New System.Drawing.Size(93, 58)
        Me.ExitButt.TabIndex = 1
        Me.ExitButt.Text = "EXIT"
        Me.ExitButt.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButt)
        Me.Controls.Add(Me.WisBut)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents WisText As Label
    Friend WithEvents WisBut As Button
    Friend WithEvents ExitButt As Button
End Class
