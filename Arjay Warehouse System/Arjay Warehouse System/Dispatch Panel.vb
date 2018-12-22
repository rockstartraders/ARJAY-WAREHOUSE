Public Class Dispatch_Panel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ah As New Correction_Ticket    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        ah.ShowDialog()
        End


    End Sub
End Class