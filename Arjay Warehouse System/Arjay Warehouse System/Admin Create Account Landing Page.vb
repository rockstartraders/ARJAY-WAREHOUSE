Public Class Admin_Create_Account_Landing_Page

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim aab As New Create_Admin_Account    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        'Me.Hide()
        aab.ShowDialog()
        'End


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    
        Dim aac As New Create_Receiving_Personnel_Account    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        'Me.Hide()
        aac.ShowDialog()
        'End



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim aad As New Create_A_Dispatch_Personnel_Account   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        ' Me.Hide()
        aad.ShowDialog()
        ' End



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click



        Me.Dispose()
        Me.Close()



    End Sub

    Private Sub Admin_Create_Account_Landing_Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class