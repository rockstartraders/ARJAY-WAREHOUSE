Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO

' Comments, Error and URL ' 
' Timeouts = https://www.grasshopper3d.com/group/slingshot/forum/topics/problem-with-connection '
' Out of range = https://stackoverflow.com/questions/14284494/mysql-error-1264-out-of-range-value-for-column '


Public Class Receiving_Panel
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->


        Dim bago As New Correction_Ticket    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        bago.Show()

        Me.Cursor = Cursors.Default ' < -- Return cursor to default --> 



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->

        Dim agaa As New View_Correction_Request   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        agaa.Show()

        Me.Cursor = Cursors.Default ' < -- Return cursor to default --> 


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->

        Dim ahaaazz As New Receiving_Self_Help_Password_Resetvb   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        ahaaazz.Show()

        Me.Cursor = Cursors.Default ' < -- Return cursor to default --> 


    End Sub

    Private Sub Receiving_Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->

        Dim no_more_brain As New Consignors_Address_Book   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        no_more_brain.Show()

        Me.Cursor = Cursors.Default ' < -- Return cursor to default --> 


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click


        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->

        Dim no_more_brain_left As New Incoming   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        no_more_brain_left.Show()

        Me.Cursor = Cursors.Default ' < -- Return cursor to default --> 


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click


        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->

        Dim no_more_brain_left_promise As New Invoice_Copy   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        no_more_brain_left_promise.Show()

        Me.Cursor = Cursors.Default ' < -- Return cursor to default --> 


    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click


        TextBox3.Text = My.Computer.Clock.LocalTime  ' < -- Current Time Logging -->

        Dim asube As DialogResult = MsgBox("Are You Sure You Want to Sign Out From This Session ?", 4 + 32, )

        If asube = DialogResult.Yes Then

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
End Class