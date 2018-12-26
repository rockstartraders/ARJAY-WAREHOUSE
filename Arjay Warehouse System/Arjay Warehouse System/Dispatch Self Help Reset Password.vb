Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO

' Comments, Error and URL ' 
' Timeouts = https://www.grasshopper3d.com/group/slingshot/forum/topics/problem-with-connection '
' Out of range = https://stackoverflow.com/questions/14284494/mysql-error-1264-out-of-range-value-for-column '




Public Class Dispatch_Self_Help_Reset_Password
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Dispatch_Self_Help_Reset_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '< --- Use this to display text from previous from to this new instance 

        Me.TextBox1.Text = Dispatch_Panel.Label1.Text

       





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim a As DialogResult = MsgBox("Are You Sure You Want to Exit ?", 4 + 32, )

        If a = DialogResult.Yes Then



            Me.Dispose()
            Me.Close()



        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim username As String
        Dim newpassword As String


        username = TextBox1.Text
        newpassword = TextBox2.Text



        con.Open()
        query = "select * from `dispatch access` where `userid`='" & TextBox1.Text & "'"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        If rd.HasRows Then

            con.Close()
            con.Open()
            query = "Update `dispatch access` set `password` = '" & TextBox2.Text & "' where `userid` ='" & TextBox1.Text & "'"
            cmd = New MySqlCommand(query, con)
            rd = cmd.ExecuteReader
            ' MsgBox("Password Has Been Change", 0 + 64)



            Dim ahaaaa As New Dispatch_Login   ' -- I need to create a new dim to avoid same instance and avoid instance error 

            Dim a As DialogResult = MsgBox("Password Has Been Change But for Security Reason you Need to Logout and Log Back in Using your New Password ", 0 + 64)
            If a = DialogResult.OK Then

                TextBox2.Text = ""

                con.Close()


                Me.Dispose()
                Me.Close()
                Dispatch_Panel.Dispose()
                Dispatch_Panel.Close()
                ahaaaa.ShowDialog()



            End If




        End If


    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
  

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged



    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
