Public Class Admin_Panel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim aaa As New Password_Reset_Admin_Panel    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        aaa.ShowDialog()
        End


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim aai As New Admin_Create_Account_Landing_Page    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        aai.ShowDialog()
        End


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim aaaa As New Admin_Correction_Form    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        aaaa.ShowDialog()
        End



    End Sub

    Private Sub Admin_Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class