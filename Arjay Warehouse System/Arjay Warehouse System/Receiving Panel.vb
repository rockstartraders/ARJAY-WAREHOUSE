Public Class Receiving_Panel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim bago As New Correction_Ticket    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        bago.ShowDialog()




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim agaa As New View_Correction_Request   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        agaa.ShowDialog()



    End Sub
End Class