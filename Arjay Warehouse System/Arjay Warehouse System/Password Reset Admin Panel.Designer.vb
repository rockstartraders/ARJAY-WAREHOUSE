﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password_Reset_Admin_Panel
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(267, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESET PASSWORD FOR "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 92)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ADMIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(286, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 92)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "DISPATCH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(464, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(158, 92)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "RECEIVING"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(286, 231)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(158, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "BACK TO ADMIN PANEL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Password_Reset_Admin_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 313)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Password_Reset_Admin_Panel"
        Me.Text = "Password Reset Admin Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
