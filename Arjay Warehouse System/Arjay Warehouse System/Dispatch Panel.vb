Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO

' Comments, Error and URL ' 
' Timeouts = https://www.grasshopper3d.com/group/slingshot/forum/topics/problem-with-connection '
' Out of range = https://stackoverflow.com/questions/14284494/mysql-error-1264-out-of-range-value-for-column '




Public Class Dispatch_Panel
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        Dim ah As New Correction_Ticket    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->
        ah.Show()
        Me.Cursor = Cursors.Default



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim ahaa As New View_Correction_Request   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->
        ahaa.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Dispatch_Panel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        ' < -- disable x button from form --> 

        e.Cancel = True


    End Sub

    Private Sub Dispatch_Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim D As Date = Now()  ' this is date and time 
        Me.Label24.Text = D

        Me.TextBox2.Text = My.Computer.Name

        For Each address As System.Net.IPAddress In System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList
            If address.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                TextBox1.Text = address.ToString()

                Exit For
            End If
        Next
       


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim ahaaa As New Dispatch_Self_Help_Reset_Password   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->
        ahaaa.Show()
        Me.Cursor = Cursors.Default
       


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim ahaaahz As New Consignors_Address_Book   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Cursor = Cursors.WaitCursor  ' < -- Curson Wait function -->
        ahaaahz.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        TextBox3.Text = My.Computer.Clock.LocalTime  ' < -- Current Time Logging -->

        Dim asuka As DialogResult = MsgBox("Are You Sure You Want to Sign Out From This Session ?", 4 + 32, )

        If asuka = DialogResult.Yes Then

            Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->

            con.Open()
            query = "INSERT INTO `entry log`(`time_stamp`, `username`, `pcname`, `ipaddress`, `access type`, `outcome`) values ('" & TextBox3.Text & "','" & Label1.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "','" & Label26.Text & "','" & Label25.Text & "')"
            cmd = New MySqlCommand(query, con)
            cmd.CommandTimeout = 240  'for time out errors
            rd = cmd.ExecuteReader()
            con.Close()

            Me.Hide()
            MsgBox("Goodbye")
            Me.Dispose()
            Me.Close()



        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click


        Dim no_more_brain_left_promise_again As New Invoice_Copy   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Cursor = Cursors.WaitCursor  ' < -- Curson Wait function -->
        no_more_brain_left_promise_again.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click


        Dim no_more_brain_left_promise_againandagain As New outgoing_dispatch   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Cursor = Cursors.WaitCursor  ' < -- Curson Wait function -->
        no_more_brain_left_promise_againandagain.Show()
        Me.Cursor = Cursors.Default


    End Sub
End Class