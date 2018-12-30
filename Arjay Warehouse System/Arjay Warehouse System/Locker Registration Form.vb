Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO

' Comments, Error and URL ' 
' Timeouts = https://www.grasshopper3d.com/group/slingshot/forum/topics/problem-with-connection '
' Out of range = https://stackoverflow.com/questions/14284494/mysql-error-1264-out-of-range-value-for-column '



Public Class Locker_Registration_Form
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick

        '<-- Mouse click Event -- >


        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        con.Open()
        query = "SELECT * FROM `Locker Registration`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader



        Dim locker_no As String = ListView1.SelectedItems(0).SubItems(0).Text()
        Dim emp_no As String = ListView1.SelectedItems(0).SubItems(1).Text()
        Dim f_name As String = ListView1.SelectedItems(0).SubItems(2).Text()
        Dim m_name As String = ListView1.SelectedItems(0).SubItems(3).Text()
        Dim l_name As String = ListView1.SelectedItems(0).SubItems(4).Text()
        Dim dept As String = ListView1.SelectedItems(0).SubItems(5).Text()
        Dim Issued_by As String = ListView1.SelectedItems(0).SubItems(6).Text()

        '<-- Load event after -->

        TextBox1.Text = locker_no
        TextBox2.Text = f_name
        TextBox3.Text = m_name
        TextBox4.Text = l_name
        TextBox5.Text = dept
        TextBox6.Text = Issued_by
        ComboBox1.Text = emp_no

        Me.TextBox6.Text = Admin_Panel.Label1.Text

        con.Close()






    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Locker_Registration_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.TextBox6.Text = Admin_Panel.Label1.Text

        '<-- Listview when form loads -->


        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        con.Open()
        query = "SELECT * FROM `Locker Registration`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader
        ListView1.Items.Clear()
        While rd.Read
            Dim lv As ListViewItem = ListView1.Items.Add(rd("locker_no").ToString())
            lv.SubItems.Add(rd("emp_no").ToString())
            lv.SubItems.Add(rd("f_name").ToString())
            lv.SubItems.Add(rd("m_name").ToString())
            lv.SubItems.Add(rd("l_name").ToString())
            lv.SubItems.Add(rd("dept").ToString())
            lv.SubItems.Add(rd("Issued_by").ToString())
            

        End While

        Me.TextBox6.Text = Admin_Panel.Label1.Text

        con.Close()



        '< -- Load event for Combobox -->

        Dim adapter As New MySqlDataAdapter("SELECT `emp_no`, `hire_date`, `f_name`, `m_name`, `l_name`, `dob`, `gender`, `address`, `contact_no`, `ssn`, `tin`, `dept`, `emer_name`, `emer_contact`, `emer_rel`, `emer_address` FROM `employee record`", con)
        Dim table As New DataTable()

        '< -- Fill function 

        adapter.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.ValueMember = "emp_no"
        ComboBox1.DisplayMember = "emp_no"

        '<-- Clear Function -->

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""

        '< -- End of function here -->

        Me.TextBox6.Text = Admin_Panel.Label1.Text

    End Sub

    Private Sub Locker_Registration_Form_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick

      


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        '< -- Auto Load after fill Reader -->

        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        Dim adapter As New MySqlDataAdapter("SELECT `emp_no`, `hire_date`, `f_name`, `m_name`, `l_name`, `dob`, `gender`, `address`, `contact_no`, `ssn`, `tin`, `dept`, `emer_name`, `emer_contact`, `emer_rel`, `emer_address` FROM `employee record`", con)
        Dim table As New DataTable()
        Dim da As New SqlClient.SqlDataAdapter
        Dim rd As MySqlDataReader
        'Dim reader As SqlClient.MySqlDataReader
        Try


            con.Open()
            Dim query As String
            query = "select * from  `employee record` where `emp_no` ='" + ComboBox1.Text + "'"
            cmd = New MySqlCommand(query, con)
            rd = cmd.ExecuteReader
            While rd.Read
                TextBox2.Text = rd.Item("f_name")
                TextBox3.Text = rd.Item("m_name")
                TextBox4.Text = rd.Item("l_name")
                TextBox5.Text = rd.Item("dept")

            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Dim a As DialogResult = MsgBox("Are You Sure You Want to Exit ?", 4 + 32, )

        If a = DialogResult.Yes Then



            Me.Dispose()
            Me.Close()



        End If


    End Sub
End Class