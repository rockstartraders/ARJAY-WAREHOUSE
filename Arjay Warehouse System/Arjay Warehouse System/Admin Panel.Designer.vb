<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Panel
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(558, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "PASSWORD RESET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(558, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 47)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CREATE ACCESS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(558, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 47)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "VIEW INCIDENT REQUEST"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(365, 33)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(187, 47)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "EMPLOYEE REGISTRATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (NEW HIRE)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(365, 101)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(187, 47)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "VIEW ACCESS LOG"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(365, 169)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(187, 47)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "EMPLOYEE LOOKUP"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "HELLO ADMIN"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(172, 33)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(187, 47)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "RESET MY PASSWORD"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(172, 101)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(187, 47)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "VIEW ACCESS MODIFICATION BY ADMIN"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Admin_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 322)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Admin_Panel"
        Me.Text = "ADMIN PANEL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
