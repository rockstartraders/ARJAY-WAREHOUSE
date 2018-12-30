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
            Dim lv As ListViewItem = ListView1.Items.Add(rd("locker_no.").ToString())
            lv.SubItems.Add(rd("emp_no.").ToString())
            lv.SubItems.Add(rd("f_name").ToString())
            lv.SubItems.Add(rd("m_name").ToString())
            lv.SubItems.Add(rd("l_name").ToString())
            lv.SubItems.Add(rd("dept").ToString())
            lv.SubItems.Add(rd("Issued_by").ToString())
            

        End While

        con.Close()


    End Sub
End Class