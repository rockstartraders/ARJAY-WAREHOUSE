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

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim username As String
        Dim newpassword As String
        Dim confpassword As String

        username = TextBox1.Text
        newpassword = TextBox2.Text
        confpassword = TextBox3.Text


        con.Open()
        query = "select * from `dispatch access` where `userid`='" & TextBox1.Text & "'"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        If rd.HasRows Then
            con.Close()

           
                con.Open()
                query = "Update `dispatch access` set `password` = '" & TextBox3.Text & "' where `userid` ='" & TextBox1.Text & "'"
                cmd = New MySqlCommand(query, con)
            rd = cmd.ExecuteReader

            If TextBox2.Text <> TextBox3.Text Then
                MsgBox("Password didnt Match Please Ensure that you are Entering it Correctly", 0 + 64)

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""

                con.Close()

            Else

                MsgBox("Password Has Been Change", 0 + 64)

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""


                con.Close()
            End If


        Else
            MsgBox("Account does not exits, Please try again", 0 + 48)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""

        End If




    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
  

    End Sub
End Class