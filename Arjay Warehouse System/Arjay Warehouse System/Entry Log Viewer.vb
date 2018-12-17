Imports MySql.Data.MySqlClient

' tutorial for export process : http://tutlogger.blogspot.com/2015/07/how-to-export-list-view-items-to-excel.html

Public Class Entry_Log_Viewer

    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String
    Private Sub Entry_Log_Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")

        con.Open()
        query = "SELECT * FROM `entry log`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        'ListView1.Items.Clear()

        While rd.Read
            Dim lv As ListViewItem = ListView1.Items.Add(rd("time_stamp").ToString())

            lv.SubItems.Add(rd("username").ToString())
            lv.SubItems.Add(rd("pcname").ToString())
            lv.SubItems.Add(rd("ipaddress").ToString())
            lv.SubItems.Add(rd("access type").ToString())

        End While
        con.Close()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        con.Open()
        query = "Select * from `entry log` Where `access type`='" & TextBox1.Text & "'"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        If TextBox1.Text = "" Then
            MsgBox(" Please Enter Employees Last Name", 0 + 64)

        Else

            ListView1.Items.Clear()

        End If

        ListView1.Items.Clear()

        While rd.Read
            Dim lv As ListViewItem = ListView1.Items.Add(rd("time_stamp").ToString())

            lv.SubItems.Add(rd("username").ToString())
            lv.SubItems.Add(rd("pcname").ToString())
            lv.SubItems.Add(rd("ipaddress").ToString())
            lv.SubItems.Add(rd("access type").ToString())

        End While
        con.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        con.Open()
        query = "Select * from `entry log`"
        cmd = New MySqlCommand(query, con)
        rd = cmd.ExecuteReader

        ListView1.Items.Clear()
        While rd.Read
            Dim lv As ListViewItem = ListView1.Items.Add(rd("time_stamp").ToString())

            lv.SubItems.Add(rd("username").ToString())
            lv.SubItems.Add(rd("pcname").ToString())
            lv.SubItems.Add(rd("ipaddress").ToString())
            lv.SubItems.Add(rd("access type").ToString())

        End While
        con.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        ' Delete function in ListView : https://social.msdn.microsoft.com/Forums/vstudio/en-US/b22ac2cf-b1e2-4463-a11a-a17d4fabc82a/how-to-remove-selected-row-in-listview?forum=vbgeneral
        Dim a As DialogResult = MsgBox("Are You Sure You Want To Delete All Logs? Once Deleted This Cannot Be Undone.  Please Make Sure To Export It First Before Deleting It.", 4 + 32, "Confirmation")
        If a = DialogResult.Yes Then

            con.Open()
            query = "Delete from `entry log` where `time_stamp`='" & ListView1.SelectedItems(0).Text & "'"
            cmd = New MySqlCommand(query, con)
            rd = cmd.ExecuteReader

            ListView1.Items.Clear()
            While rd.Read
                Dim lv As ListViewItem = ListView1.Items.Add(rd("time_stamp").ToString())

                lv.SubItems.Add(rd("username").ToString())
                lv.SubItems.Add(rd("pcname").ToString())
                lv.SubItems.Add(rd("ipaddress").ToString())
                lv.SubItems.Add(rd("access type").ToString())

            End While
        Else
            Me.Show()
        End If
        con.Close()

    End Sub
End Class