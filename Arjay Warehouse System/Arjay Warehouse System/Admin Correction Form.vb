Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO

' Comments, Error and URL ' 
' Timeouts = https://www.grasshopper3d.com/group/slingshot/forum/topics/problem-with-connection '
' Out of range = https://stackoverflow.com/questions/14284494/mysql-error-1264-out-of-range-value-for-column '


Public Class Admin_Correction_Form
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Admin_Correction_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim D As Date = Now()  ' this is date and time 
        Me.Label13.Text = D

        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        con.Open()
        query = "SELECT * FROM `correction request`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader
        ListView1.Items.Clear()
        While rd.Read
            Dim lv As ListViewItem = ListView1.Items.Add(rd("Incident_no").ToString())
            lv.SubItems.Add(rd("status").ToString())
            lv.SubItems.Add(rd("date_submitted").ToString())
            lv.SubItems.Add(rd("emp_no").ToString())
            lv.SubItems.Add(rd("f_name").ToString())
            lv.SubItems.Add(rd("m_name").ToString())
            lv.SubItems.Add(rd("l_name").ToString())
            lv.SubItems.Add(rd("dept").ToString())
            lv.SubItems.Add(rd("correction_type").ToString())
            lv.SubItems.Add(rd("prob_des").ToString())

        End While
        con.Close()

    End Sub

    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick

        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        con.Open()
        query = "SELECT * FROM `correction request`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader




        Dim Incident_no As String = ListView1.SelectedItems(0).SubItems(0).Text()
        Dim status As String = ListView1.SelectedItems(0).SubItems(1).Text()
        Dim date_submitted As String = ListView1.SelectedItems(0).SubItems(2).Text()
        Dim emp_no As String = ListView1.SelectedItems(0).SubItems(3).Text()
        Dim f_name As String = ListView1.SelectedItems(0).SubItems(4).Text()
        Dim m_name As String = ListView1.SelectedItems(0).SubItems(5).Text()
        Dim l_name As String = ListView1.SelectedItems(0).SubItems(6).Text()
        Dim dept As String = ListView1.SelectedItems(0).SubItems(7).Text()
        Dim correction_type As String = ListView1.SelectedItems(0).SubItems(8).Text()
        Dim prob_des As String = ListView1.SelectedItems(0).SubItems(9).Text()


        TextBox1.Text = Incident_no
        TextBox2.Text = emp_no
        Label3.Text = date_submitted
        TextBox3.Text = f_name
        TextBox4.Text = m_name
        TextBox5.Text = l_name
        TextBox6.Text = dept
        ComboBox1.Text = status
        ComboBox2.Text = correction_type
        TextBox7.Text = prob_des

        con.Close()


    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

        

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Incident_no As String
        Incident_no = TextBox1.Text
        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        con.Open()
        query = "UPDATE `correction request` SET `Incident_no`='" & TextBox1.Text & "',`date_submitted`='" & Label3.Text & "',`emp_no`='" & TextBox2.Text & "',`f_name`='" & TextBox3.Text & "',`m_name`='" & TextBox4.Text & "',`l_name`='" & TextBox5.Text & "',`dept`='" & TextBox6.Text & "',`status`='" & ComboBox1.Text & "',`correction_type`='" & ComboBox2.Text & "',`prob_des`='" & TextBox7.Text & "',`resolution`='" & TextBox8.Text & "',`resolved_date`='" & Label13.Text & "' WHERE `Incident_no`='" & TextBox1.Text & "'"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader()

        While rd.Read
            Dim lv As ListViewItem = ListView1.Items.Add(rd("Incident_no").ToString())
            lv.SubItems.Add(rd("status").ToString())
            lv.SubItems.Add(rd("date_submitted").ToString())
            lv.SubItems.Add(rd("emp_no").ToString())
            lv.SubItems.Add(rd("f_name").ToString())
            lv.SubItems.Add(rd("m_name").ToString())
            lv.SubItems.Add(rd("l_name").ToString())
            lv.SubItems.Add(rd("dept").ToString())
            lv.SubItems.Add(rd("correction_type").ToString())
            lv.SubItems.Add(rd("prob_des").ToString())

        End While
        MsgBox("Correction Request Has Been Resolved")

        ' <<----------------- Clear Function ------------------>>
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""

        con.Close()


        '----------------------- Update List View After ---------------------


        con.Open()
        query = "SELECT * FROM `correction request`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader
        ListView1.Items.Clear()
        While rd.Read
            Dim lv As ListViewItem = ListView1.Items.Add(rd("Incident_no").ToString())
            lv.SubItems.Add(rd("status").ToString())
            lv.SubItems.Add(rd("date_submitted").ToString())
            lv.SubItems.Add(rd("emp_no").ToString())
            lv.SubItems.Add(rd("f_name").ToString())
            lv.SubItems.Add(rd("m_name").ToString())
            lv.SubItems.Add(rd("l_name").ToString())
            lv.SubItems.Add(rd("dept").ToString())
            lv.SubItems.Add(rd("correction_type").ToString())
            lv.SubItems.Add(rd("prob_des").ToString())

        End While
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Dispose()
        Me.Close()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ' <-- export to excel function -->

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ExcelApp As Object, ExcelBook As Object
            Dim ExcelSheet As Object
            Dim i As Integer
            Dim j As Integer
            'create object of excel
            ExcelApp = CreateObject("Excel.Application")
            ExcelBook = ExcelApp.WorkBooks.Add
            ExcelSheet = ExcelBook.WorkSheets(1)
            With ExcelSheet
                For i = 1 To Me.ListView1.Items.Count
                    .cells(i, 1) = Me.ListView1.Items(i - 1).Text
                    For j = 1 To ListView1.Columns.Count - 1
                        .cells(i, j + 1) = Me.ListView1.Items(i - 1).SubItems(j).Text
                    Next
                Next
            End With
            ExcelApp.Visible = True
            ExcelSheet = Nothing
            ExcelBook = Nothing
            ExcelApp = Nothing
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try




    End Sub
End Class