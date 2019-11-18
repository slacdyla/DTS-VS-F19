<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RandomNum
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
        Me.Numbers = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Numbers
        '
        Me.Numbers.FormattingEnabled = True
        Me.Numbers.ItemHeight = 16
        Me.Numbers.Location = New System.Drawing.Point(226, 55)
        Me.Numbers.Name = "Numbers"
        Me.Numbers.Size = New System.Drawing.Size(329, 164)
        Me.Numbers.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 59)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Get Values"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RandomNum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Numbers)
        Me.Name = "RandomNum"
        Me.Text = "Random Number Generator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Numbers As ListBox
    Friend WithEvents Button1 As Button
End Class
