Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Image

' Comments, Error and URL ' 
' Timeouts = https://www.grasshopper3d.com/group/slingshot/forum/topics/problem-with-connection '
' Out of range = https://stackoverflow.com/questions/14284494/mysql-error-1264-out-of-range-value-for-column '



Public Class Consignor_Registration_Form

    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Consignor_Registration_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click



        Dim a As DialogResult = MsgBox("Are You Sure You Want to Exit ?", 4 + 32, )

        If a = DialogResult.Yes Then



            'Me.Dispose()
            'Me.Close()





            Dim aeqqqq As New Admin_Panel    ' -- I need to create a new dim to avoid same instance and avoid instance error 

            Me.Hide()
            aeqqqq.ShowDialog()
            End


        End If

    End Sub
End Class