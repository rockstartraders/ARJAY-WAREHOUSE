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

        ah.Show()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim ahaa As New View_Correction_Request   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        ahaa.Show()


    End Sub

    Private Sub Dispatch_Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim ahaaa As New Dispatch_Self_Help_Reset_Password   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        ahaaa.Show()

       


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim ahaaahz As New Consignors_Address_Book   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        ahaaahz.Show()


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

    End Sub
End Class