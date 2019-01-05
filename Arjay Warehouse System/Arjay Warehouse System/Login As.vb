Imports System.IO

Public Class Login_As

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Login_As_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim ad As New Receiving_Login    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        ad.ShowDialog()
        End


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ab As New Admin_Login    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        ab.ShowDialog()
        Me.Dispose()
        End


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim ac As New Dispatch_Login   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        ac.ShowDialog()
        End


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Dim timeinandout As New Time_Keeping_System   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        timeinandout.ShowDialog()
        End

    End Sub
End Class