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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Rolls = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 61)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Roll 20,0000 Dice at the Same Time"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Rolls
        '
        Me.Rolls.FormattingEnabled = True
        Me.Rolls.ItemHeight = 16
        Me.Rolls.Location = New System.Drawing.Point(174, 29)
        Me.Rolls.Name = "Rolls"
        Me.Rolls.Size = New System.Drawing.Size(149, 372)
        Me.Rolls.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Rolls)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Dice Rolling"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Rolls As ListBox
End Class
