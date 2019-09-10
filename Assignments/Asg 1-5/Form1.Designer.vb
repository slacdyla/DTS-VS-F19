<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SoupButt = New System.Windows.Forms.Button()
        Me.ChefButt = New System.Windows.Forms.Button()
        Me.FishButt = New System.Windows.Forms.Button()
        Me.Specials = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(242, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MAC Daniel's"
        '
        'SoupButt
        '
        Me.SoupButt.Location = New System.Drawing.Point(141, 343)
        Me.SoupButt.Name = "SoupButt"
        Me.SoupButt.Size = New System.Drawing.Size(88, 58)
        Me.SoupButt.TabIndex = 1
        Me.SoupButt.Text = "Soup of the Day"
        Me.SoupButt.UseVisualStyleBackColor = True
        '
        'ChefButt
        '
        Me.ChefButt.Location = New System.Drawing.Point(331, 343)
        Me.ChefButt.Name = "ChefButt"
        Me.ChefButt.Size = New System.Drawing.Size(91, 58)
        Me.ChefButt.TabIndex = 2
        Me.ChefButt.Text = "Chef's Special"
        Me.ChefButt.UseVisualStyleBackColor = True
        '
        'FishButt
        '
        Me.FishButt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.FishButt.Location = New System.Drawing.Point(564, 343)
        Me.FishButt.Name = "FishButt"
        Me.FishButt.Size = New System.Drawing.Size(91, 58)
        Me.FishButt.TabIndex = 3
        Me.FishButt.Text = "Daily Fish"
        Me.FishButt.UseVisualStyleBackColor = True
        '
        'Specials
        '
        Me.Specials.AutoSize = True
        Me.Specials.Font = New System.Drawing.Font("MV Boli", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials.ForeColor = System.Drawing.Color.Yellow
        Me.Specials.Location = New System.Drawing.Point(243, 165)
        Me.Specials.Name = "Specials"
        Me.Specials.Size = New System.Drawing.Size(277, 44)
        Me.Specials.TabIndex = 4
        Me.Specials.Text = "Today's Specials"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(744, 465)
        Me.Controls.Add(Me.Specials)
        Me.Controls.Add(Me.FishButt)
        Me.Controls.Add(Me.ChefButt)
        Me.Controls.Add(Me.SoupButt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SoupButt As Button
    Friend WithEvents ChefButt As Button
    Friend WithEvents FishButt As Button
    Friend WithEvents Specials As Label
End Class
