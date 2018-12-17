Imports MySql.Data.MySqlClient

Public Class Employee_database
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Employee_database_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")

        con.Open()
        query = "Select * from `employee record`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        'ListView1.Items.Clear()

        While rd.Read
            Dim lv As ListViewItem = ListView1.Items.Add(rd("emp_no").ToString())

            lv.SubItems.Add(rd("hire_date").ToString())
            lv.SubItems.Add(rd("f_name").ToString())
            lv.SubItems.Add(rd("m_name").ToString())
            lv.SubItems.Add(rd("l_name").ToString())
            lv.SubItems.Add(rd("dob").ToString())
            lv.SubItems.Add(rd("gender").ToString())
            lv.SubItems.Add(rd("address").ToString())
            lv.SubItems.Add(rd("contact_no").ToString())
            lv.SubItems.Add(rd("ssn").ToString())
            lv.SubItems.Add(rd("tin").ToString())
            lv.SubItems.Add(rd("dept").ToString())
            lv.SubItems.Add(rd("emer_name").ToString())
            lv.SubItems.Add(rd("emer_contact").ToString())
            lv.SubItems.Add(rd("emer_rel").ToString())
            lv.SubItems.Add(rd("emer_address").ToString())


        End While
        con.Close()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        TextBox1.Text = ""
        con.Open()
        query = "Select * from `employee record`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        ListView1.Items.Clear()

        While rd.Read
            Dim lv As ListViewItem = ListView1.Items.Add(rd("emp_no").ToString())

            lv.SubItems.Add(rd("hire_date").ToString())
            lv.SubItems.Add(rd("f_name").ToString())
            lv.SubItems.Add(rd("m_name").ToString())
            lv.SubItems.Add(rd("l_name").ToString())
            lv.SubItems.Add(rd("dob").ToString())
            lv.SubItems.Add(rd("gender").ToString())
            lv.SubItems.Add(rd("address").ToString())
            lv.SubItems.Add(rd("contact_no").ToString())
            lv.SubItems.Add(rd("ssn").ToString())
            lv.SubItems.Add(rd("tin").ToString())
            lv.SubItems.Add(rd("dept").ToString())
            lv.SubItems.Add(rd("emer_name").ToString())
            lv.SubItems.Add(rd("emer_contact").ToString())
            lv.SubItems.Add(rd("emer_rel").ToString())
            lv.SubItems.Add(rd("emer_address").ToString())


        End While
        con.Close()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Open()
        query = "Select * from `employee record` Where `l_name`='" & TextBox1.Text & "'"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        If TextBox1.Text = "" Then
            MsgBox(" Please Enter Employees Last Name", 0 + 64)

        Else

            ListView1.Items.Clear()

        End If

        ListView1.Items.Clear()


        While rd.Read

            Dim lv As ListViewItem = ListView1.Items.Add(rd("emp_no").ToString())

            lv.SubItems.Add(rd("hire_date").ToString())
            lv.SubItems.Add(rd("f_name").ToString())
            lv.SubItems.Add(rd("m_name").ToString())
            lv.SubItems.Add(rd("l_name").ToString())
            lv.SubItems.Add(rd("dob").ToString())
            lv.SubItems.Add(rd("gender").ToString())
            lv.SubItems.Add(rd("address").ToString())
            lv.SubItems.Add(rd("contact_no").ToString())
            lv.SubItems.Add(rd("ssn").ToString())
            lv.SubItems.Add(rd("tin").ToString())
            lv.SubItems.Add(rd("dept").ToString())
            lv.SubItems.Add(rd("emer_name").ToString())
            lv.SubItems.Add(rd("emer_contact").ToString())
            lv.SubItems.Add(rd("emer_rel").ToString())
            lv.SubItems.Add(rd("emer_address").ToString())


        End While

        con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class