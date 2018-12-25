Public Class Password_Reset_Admin_Panel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim a As New Password_Reset_for_an_Admin    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        a.ShowDialog()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim b As New Password_Reset_for_Dispatch   ' -- I need to create a new dim to avoid same instance and avoid instance error 


        b.ShowDialog()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Dim c As New Password_Reset_for_Receiving_Personnel   ' -- I need to create a new dim to avoid same instance and avoid instance error 


        c.ShowDialog()



    End Sub

    Private Sub Password_Reset_Admin_Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'Dim f As New Admin_Panel   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Dispose()
        Me.Close()






    End Sub
End Class