Imports System.IO
Imports System.Net
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Admin_Panel
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim aaa As New Password_Reset_Admin_Panel    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaa.Show()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim aai As New Admin_Create_Account_Landing_Page    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aai.Show()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim aaaa As New Admin_Correction_Form    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaa.Show()




    End Sub

    Private Sub Admin_Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


       


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim aaaab As New Employee_Registration_Form    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaab.Show()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim aaaad As New Entry_Log_Viewer    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaad.Show()



    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim aaaak As New Employee_database    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaak.Show()



    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Dim aaaaka As New Admin_Self_Help_Password_Reset    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaaka.Show()



    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click



    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Dim aaaakab As New View_ADMIN_Actions_for_Account_Modifications   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        
        aaaakab.Show()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Dim aaaakaba As New Delete_Access_Admin_Panel   ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaakaba.Show()


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Dim bakanaman As New Consignor_Registration_Form   ' -- I need to create a new dim to avoid same instance and avoid instance error 


        bakanaman.Show()


    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        Dim locker As New Locker_Registration_Form   ' -- I need to create a new dim to avoid same instance and avoid instance error 


        locker.Show()


    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click


        Dim consignorkagebunshin As New Caution_Error   ' -- I need to create a new dim to avoid same instance and avoid instance error 


        consignorkagebunshin.Show()


    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        Dim consignorkagebunshinreadonly As New View_Log_for_Consignor_Modification   ' -- I need to create a new dim to avoid same instance and avoid instance error 


        consignorkagebunshinreadonly.Show()


    End Sub
End Class