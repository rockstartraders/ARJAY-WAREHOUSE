﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO

' Comments, Error and URL ' 
' Timeouts = https://www.grasshopper3d.com/group/slingshot/forum/topics/problem-with-connection '
' Out of range = https://stackoverflow.com/questions/14284494/mysql-error-1264-out-of-range-value-for-column '



Public Class Correction_Ticket

    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Correction_Ticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim rn As New Random
        TextBox1.Text = (rn.Next(233, 334455) + 5)

        Dim D As Date = Now()  ' this is date and time 
        Me.Label3.Text = D


        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        Dim adapter As New MySqlDataAdapter("SELECT `emp_no`, `f_name`, `m_name`, `l_name`, `dept` FROM `employee record`", con)
        Dim table As New DataTable()



    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        Dim adapter As New MySqlDataAdapter("SELECT `emp_no`, `f_name`, `m_name`, `l_name`, `dept` FROM `employee record`", con)
        Dim table As New DataTable()
        Dim da As New SqlClient.SqlDataAdapter
        Dim rd As MySqlDataReader

        Try


            con.Open()
            Dim query As String
            query = "select * from  `employee record` where `emp_no` ='" + TextBox2.Text + "'"
            cmd = New MySqlCommand(query, con)
            rd = cmd.ExecuteReader
            While rd.Read
                TextBox3.Text = rd.Item("f_name")
                TextBox4.Text = rd.Item("m_name")
                TextBox5.Text = rd.Item("l_name")
                TextBox6.Text = rd.Item("dept")

            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")

        con.Open()
        Dim query As String
        query = "INSERT INTO `correction request`( `date_submitted`,`Incident_no`, `emp_no`, `f_name`, `m_name`, `l_name`, `dept`, `status`, `correction_type`, `prob_des`,`resolution`,`resolved_date`) VALUES ('" & Label3.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & Label13.Text & "')"
        cmd = New MySqlCommand(query, con)
        cmd.CommandTimeout = 240  'for time out errors
        rd = cmd.ExecuteReader()
        MsgBox(" New Correction Request Has been Submitted ")
        con.Close()


        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComboBox2.Text = ""




    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub
End Class