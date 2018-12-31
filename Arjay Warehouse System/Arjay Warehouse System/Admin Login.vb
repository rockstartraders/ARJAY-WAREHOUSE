Imports System.IO
Imports System.Net
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Admin_Login
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    ' for entry log 

    Private Sub Admin_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim D As Date = Now()  ' this is date and time 
        Me.TextBox3.Text = D

        Me.TextBox4.Text = My.Computer.Name


        'Dim localIp As String

        For Each address As System.Net.IPAddress In System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList
            If address.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                TextBox5.Text = address.ToString()

                Exit For
            End If
        Next

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim username As String
        Dim password As String

        username = TextBox1.Text
        password = TextBox2.Text


        

        con.Open()
        query = "INSERT INTO `entry log`(`time_stamp`, `username`, `pcname`, `ipaddress`, `access type`, `Instance`) values ('" & TextBox3.Text & "','" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & Label4.Text & "','" & Label5.Text & "')"
        cmd = New MySqlCommand(query, con)
        cmd.CommandTimeout = 240  'for time out errors
        rd = cmd.ExecuteReader()

        con.Close()

        con.Open()

        query = "SELECT * FROM `admin access` WHERE `userid`='" & TextBox1.Text & "' and `password`= '" & TextBox2.Text & "'"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        If rd.HasRows Then

            rd.Read()
            ' <-- This is needed to show the username automatically inside VB form
            rd.Read()
            Admin_Panel.Label1.Text = rd("userid")


            Me.Hide()
            Admin_Panel.Show()
            Me.Close()


        Else
            'MsgBox("Invalid User Name and Password !", 0 + 64)
            'TextBox1.Text = ""
            'TextBox2.Text = ""


            Dim erroruna As New Error_Login_Admin    ' -- I need to create a new dim to avoid same instance and avoid instance error 

            erroruna.Show()

            


        End If

        con.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim a As DialogResult = MsgBox("Are You Sure You Want to Exit ?", 4 + 32, )

        If a = DialogResult.Yes Then



            'Me.Dispose()
            'Me.Close()





            Dim ae As New Login_As    ' -- I need to create a new dim to avoid same instance and avoid instance error 

            Me.Hide()
            ae.Show()
            End


        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class