Public Class Receiving_Panel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim bago As New Correction_Ticket    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        bago.Show()




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim agaa As New View_Correction_Request   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        agaa.Show()



    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim ahaaazz As New Receiving_Self_Help_Password_Resetvb   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        ahaaazz.Show()

    End Sub

    Private Sub Receiving_Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim no_more_brain As New Consignors_Address_Book   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        no_more_brain.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim no_more_brain_left As New Incoming   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        no_more_brain_left.Show()


    End Sub
End Class