Public Class Delete_Access_Admin_Panel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim aaaakabb As New Delete_Access_for_an_ADMIN_admin   ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaakabb.ShowDialog()



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Me.Dispose()
        Me.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim aaaakabbb As New Delete_Access_for_Dispatch_Admin_function   ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaakabbb.ShowDialog()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim aaaakabbbd As New Delete_Access_for_Receiving_admin_function   ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaakabbbd.ShowDialog()


    End Sub
End Class