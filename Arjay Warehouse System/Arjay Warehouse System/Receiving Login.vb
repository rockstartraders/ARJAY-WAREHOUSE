﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO

' Comments, Error and URL ' 
' Timeouts = https://www.grasshopper3d.com/group/slingshot/forum/topics/problem-with-connection '
' Out of range = https://stackoverflow.com/questions/14284494/mysql-error-1264-out-of-range-value-for-column '


Public Class Receiving_Login
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String
    Private Sub Receiving_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ' for entry log

        Dim D As Date = Now()  ' this is date and time 
        Me.TextBox3.Text = D

        Me.TextBox4.Text = My.Computer.Name


        Dim localIp As String

        For Each address As System.Net.IPAddress In System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList
            If address.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                TextBox5.Text = address.ToString()

                Exit For
            End If
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String


        username = TextBox1.Text
        password = TextBox2.Text


        con.Open()

        query = "SELECT * FROM `receiving access` WHERE `userid`='" & TextBox1.Text & "' and `password`= '" & TextBox2.Text & "'"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        If rd.HasRows Then

            rd.Read()

            ' <-- This is needed to show the username automatically inside VB form
            rd.Read()
            Receiving_Panel.Label1.Text = rd("userid")

            con.Close()

            ' <-- for logging purposes -->

            con.Open()
            query = "INSERT INTO `entry log`(`time_stamp`, `username`, `pcname`, `ipaddress`, `access type`, `outcome`) values ('" & TextBox3.Text & "','" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & Label4.Text & "','" & TextBox6.Text & "')"
            cmd = New MySqlCommand(query, con)
            cmd.CommandTimeout = 240  'for time out errors
            rd = cmd.ExecuteReader()


            Me.Hide()
            Receiving_Panel.ShowDialog()
            Me.Close()


        Else

            con.Close()
            rd.Close()

            MsgBox("Invalid User Name and Password !", 0 + 64)

            '<-- Logging for invalid Instance -->
            con.Open()
            query = "INSERT INTO `entry log`(`time_stamp`, `username`, `pcname`, `ipaddress`, `access type`, `outcome`) values ('" & TextBox3.Text & "','" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & Label4.Text & "','" & TextBox7.Text & "')"
            cmd = New MySqlCommand(query, con)
            cmd.CommandTimeout = 240  'for time out errors
            rd = cmd.ExecuteReader()




            TextBox1.Text = ""
            TextBox2.Text = ""

            con.Close()

        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim a As DialogResult = MsgBox("Are You Sure You Want to Exit ?", 4 + 32, )

        If a = DialogResult.Yes Then



            'Me.Dispose()
            'Me.Close()





            Dim ae As New Login_As    ' -- I need to create a new dim to avoid same instance and avoid instance error 

            Me.Hide()
            ae.ShowDialog()
            End


        End If

    End Sub
End Class