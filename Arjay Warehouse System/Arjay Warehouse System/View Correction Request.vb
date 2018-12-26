Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO

' Comments, Error and URL ' 
' Timeouts = https://www.grasshopper3d.com/group/slingshot/forum/topics/problem-with-connection '
' Out of range = https://stackoverflow.com/questions/14284494/mysql-error-1264-out-of-range-value-for-column '

Public Class View_Correction_Request
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub View_Correction_Request_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        Dim table As New DataTable()
        Dim da As New SqlClient.SqlDataAdapter
        Dim rd As MySqlDataReader

        Try


            con.Open()
            Dim query As String
            query = "SELECT * FROM `correction request` where `emp_no` ='" + TextBox2.Text + "'"
            cmd = New MySqlCommand(query, con)
            rd = cmd.ExecuteReader
            While rd.Read

                TextBox1.Text = rd.Item("Incident_no")
                TextBox9.Text = rd.Item("date_submitted")
                TextBox3.Text = rd.Item("f_name")
                TextBox4.Text = rd.Item("m_name")
                TextBox5.Text = rd.Item("l_name")
                TextBox6.Text = rd.Item("dept")
                ComboBox1.Text = rd.Item("status")
                ComboBox2.Text = rd.Item("correction_type")
                TextBox7.Text = rd.Item("prob_des")
                TextBox8.Text = rd.Item("resolution")

            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        Dim table As New DataTable()
        Dim da As New SqlClient.SqlDataAdapter
        Dim rd As MySqlDataReader

        Try


            con.Open()
            Dim query As String
            query = "SELECT * FROM `correction request` where `Incident_no` ='" + TextBox1.Text + "'"
            cmd = New MySqlCommand(query, con)
            rd = cmd.ExecuteReader
            While rd.Read

                TextBox2.Text = rd.Item("emp_no")
                TextBox9.Text = rd.Item("date_submitted")
                TextBox3.Text = rd.Item("f_name")
                TextBox4.Text = rd.Item("m_name")
                TextBox5.Text = rd.Item("l_name")
                TextBox6.Text = rd.Item("dept")
                ComboBox1.Text = rd.Item("status")
                ComboBox2.Text = rd.Item("correction_type")
                TextBox7.Text = rd.Item("prob_des")
                TextBox8.Text = rd.Item("resolution")

            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        Dim table As New DataTable()
        Dim da As New SqlClient.SqlDataAdapter
        Dim rd As MySqlDataReader

        Try


            con.Open()
            Dim query As String
            query = "SELECT * FROM `correction request` where `l_name` ='" + TextBox5.Text + "'"
            cmd = New MySqlCommand(query, con)
            rd = cmd.ExecuteReader
            While rd.Read

                TextBox1.Text = rd.Item("Incident_no")
                TextBox9.Text = rd.Item("date_submitted")
                TextBox3.Text = rd.Item("f_name")
                TextBox4.Text = rd.Item("m_name")
                TextBox2.Text = rd.Item("emp_no")
                TextBox6.Text = rd.Item("dept")
                ComboBox1.Text = rd.Item("status")
                ComboBox2.Text = rd.Item("correction_type")
                TextBox7.Text = rd.Item("prob_des")
                TextBox8.Text = rd.Item("resolution")



            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim a As DialogResult = MsgBox("Are You Sure You Want to Exit ?", 4 + 32, )

        If a = DialogResult.Yes Then



            Me.Dispose()
            Me.Close()



        End If




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '<------  clear all fields ---->

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox9.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class