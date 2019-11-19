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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.costOfGoods = New System.Windows.Forms.TextBox()
        Me.nd = New System.Windows.Forms.TextBox()
        Me.Beg = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Turn = New System.Windows.Forms.TextBox()
        Me.Avg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BeginningTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.EndingTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CostTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CalculateTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClearTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExitTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.costOfGoods)
        Me.GroupBox1.Controls.Add(Me.nd)
        Me.GroupBox1.Controls.Add(Me.Beg)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 205)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cost of Goods Sold"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ending Inventory"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Beginning Inventory"
        '
        'costOfGoods
        '
        Me.costOfGoods.Location = New System.Drawing.Point(6, 158)
        Me.costOfGoods.Name = "costOfGoods"
        Me.costOfGoods.Size = New System.Drawing.Size(152, 22)
        Me.costOfGoods.TabIndex = 3
        '
        'nd
        '
        Me.nd.Location = New System.Drawing.Point(6, 93)
        Me.nd.Name = "nd"
        Me.nd.Size = New System.Drawing.Size(152, 22)
        Me.nd.TabIndex = 2
        '
        'Beg
        '
        Me.Beg.Location = New System.Drawing.Point(6, 39)
        Me.Beg.Name = "Beg"
        Me.Beg.Size = New System.Drawing.Size(152, 22)
        Me.Beg.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Turn)
        Me.GroupBox2.Controls.Add(Me.Avg)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(213, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 204)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Turn
        '
        Me.Turn.Location = New System.Drawing.Point(18, 101)
        Me.Turn.Name = "Turn"
        Me.Turn.Size = New System.Drawing.Size(196, 22)
        Me.Turn.TabIndex = 8
        '
        'Avg
        '
        Me.Avg.Location = New System.Drawing.Point(18, 47)
        Me.Avg.Name = "Avg"
        Me.Avg.Size = New System.Drawing.Size(196, 22)
        Me.Avg.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Turnover"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Average Inventory"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.CancelButton)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(35, 239)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(428, 175)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(184, 38)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 107)
        Me.CancelButton.TabIndex = 6
        Me.CancelButton.Text = "&Exit"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(97, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 107)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&Form Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 107)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(498, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Inventory Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents costOfGoods As TextBox
    Friend WithEvents nd As TextBox
    Friend WithEvents Beg As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Turn As TextBox
    Friend WithEvents Avg As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BeginningTip As ToolTip
    Friend WithEvents EndingTip As ToolTip
    Friend WithEvents CostTip As ToolTip
    Friend WithEvents CalculateTip As ToolTip
    Friend WithEvents ClearTip As ToolTip
    Friend WithEvents ExitTip As ToolTip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
