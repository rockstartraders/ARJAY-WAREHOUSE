Public Class Dispatch_Panel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ah As New Correction_Ticket    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        ah.ShowDialog()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim ahaa As New View_Correction_Request   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        ahaa.ShowDialog()


    End Sub
End Class