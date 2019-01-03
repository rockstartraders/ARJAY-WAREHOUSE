Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Image

' Comments, Error and URL ' 
' Timeouts = https://www.grasshopper3d.com/group/slingshot/forum/topics/problem-with-connection '
' Out of range = https://stackoverflow.com/questions/14284494/mysql-error-1264-out-of-range-value-for-column '


Public Class Invoice_Copy
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Invoice_Copy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' < -- Load Event for List View --> 

        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        con.Open()
        query = "SELECT * FROM `Invoice_copy`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader
        ListView1.Items.Clear()
        While rd.Read
            Dim lv As ListViewItem = ListView1.Items.Add(rd("Invoice_no").ToString())
            lv.SubItems.Add(rd("transaction").ToString())
            lv.SubItems.Add(rd("invoice_main").ToString())

            '<-- Warning came here -->

            ListView1.FullRowSelect = True




        End While



        con.Close()


    End Sub

    Private Sub Invoice_Copy_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick



        '< -- Mouse Click Event --> 

        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        con.Open()
        query = "SELECT * FROM `Invoice_copy`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        Dim Invoice_no As String = ListView1.SelectedItems(0).SubItems(0).Text()
        Dim transaction As String = ListView1.SelectedItems(0).SubItems(1).Text()
        Dim invoice_main As String = ListView1.SelectedItems(0).SubItems(2).Text()
        


        TextBox2.Text = Invoice_no
        TextBox3.Text = transaction
        TextBox1.Text = invoice_main



        '<-- EOL for this Function -- > 


        con.Close()

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

        '< -- Mouse Click Event --> 

        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
        con.Open()
        query = "SELECT * FROM `Invoice_copy`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        ' < -- Indexing purposes --> 

        If (ListView1.SelectedItems.Count > 0) Then



            Dim Invoice_no As String = ListView1.SelectedItems(0).SubItems(0).Text()
            Dim transaction As String = ListView1.SelectedItems(0).SubItems(1).Text()
            Dim invoice_main As String = ListView1.SelectedItems(0).SubItems(2).Text()



            TextBox2.Text = Invoice_no
            TextBox3.Text = transaction
            TextBox1.Text = invoice_main

            

            '<-- EOL for this Function -- > 


            con.Close()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


       

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim a As DialogResult = MsgBox("Are You Sure You Want to Exit ?", 4 + 32, )

        If a = DialogResult.Yes Then




            Me.Dispose()
            Me.Close()

        End If


    End Sub
End Class