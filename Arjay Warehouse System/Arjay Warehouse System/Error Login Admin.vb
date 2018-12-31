Imports System.IO
Imports System.Net
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Error_Login_Admin
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String


    Private Sub Error_Login_Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '<-- Form Load event -->

        Dim D As Date = Now()  ' this is date and time 
        Me.Label2.Text = D


        '< -- Parsing -->

        Me.TextBox3.Text = My.Computer.Name


        'Dim localIp As String

        For Each address As System.Net.IPAddress In System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList
            If address.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                TextBox4.Text = address.ToString()

                Exit For
            End If
        Next


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        con.Open()
        query = "INSERT INTO `entry log`(`time_stamp`, `username`, `pcname`, `ipaddress`, `access type`, `Instance`) values ('" & Label2.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & Label3.Text & "')"
        cmd = New MySqlCommand(query, con)
        cmd.CommandTimeout = 240  'for time out errors
        rd = cmd.ExecuteReader()

        con.Close()

        Admin_Login.TextBox1.Text = ""
        Admin_Login.TextBox2.Text = ""

        Me.Dispose()
        Me.Close()


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged



    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Label3.Text = Admin_Login.TextBox1.Text
    End Sub
End Class