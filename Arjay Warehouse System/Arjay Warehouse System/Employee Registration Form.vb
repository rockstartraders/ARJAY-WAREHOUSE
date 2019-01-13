Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Image

' Comments, Error and URL ' 
' Timeouts = https://www.grasshopper3d.com/group/slingshot/forum/topics/problem-with-connection '
' Out of range = https://stackoverflow.com/questions/14284494/mysql-error-1264-out-of-range-value-for-column '






Public Class Employee_Registration_Form
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->

        'this should be present always
        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")

        con.Open()
        Dim query As String
        query = "Insert Into `employee record`(`emp_no`, `hire_date`, `f_name`, `m_name`, `l_name`, `dob`, `gender`, `address`, `contact_no`, `ssn`, `tin`, `dept`, `emer_name`, `emer_contact`, `emer_rel`, `emer_address`) values ('" & TextBox1.Text & "','" & TextBox13.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox14.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & ComboBox2.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "')"
        cmd = New MySqlCommand(query, con)
        cmd.CommandTimeout = 240  'for time out errors
        rd = cmd.ExecuteReader()
        MsgBox(" New Employee Account has Been Created ")

        Me.Cursor = Cursors.Default ' < -- Return cursor to default --> 
        con.Close()


        ' <-- Insert to Activity log -- >

        con.Open()
        query = "INSERT INTO `Admin changes log`(`action_made`, `date_process`, `emp_no`, `f_name`, `m_name`, `l_name`, `dept`, `done_by`) values ('" & Label18.Text & "','" & Label19.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "','" & TextBox16.Text & "')"
        cmd = New MySqlCommand(query, con)
        cmd.CommandTimeout = 240  'for time out errors
        rd = cmd.ExecuteReader()



        TextBox1.Text = ""
        TextBox13.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox14.Text = ""
        ComboBox1.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComboBox2.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""


        Me.Cursor = Cursors.Default ' < -- Return cursor to default --> 

        con.Close()


        ' < -- END -->


    End Sub





    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Employee_Registration_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rn As New Random
        TextBox1.Text = (rn.Next(113344, 9998855) + 8)

        Dim D As Date = Now()  ' this is date and time 
        Me.Label19.Text = D

        Me.TextBox16.Text = Admin_Panel.Label1.Text


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim a As DialogResult = MsgBox("Are You Sure You Want to Exit ?", 4 + 32, )

        If a = DialogResult.Yes Then



            Me.Dispose()
            Me.Close()



        End If






    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

End Class