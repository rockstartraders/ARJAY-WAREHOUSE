﻿Imports System.IO
Imports System.Net
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Admin_Panel
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim query As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim aaa As New Password_Reset_Admin_Panel    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaa.ShowDialog()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim aai As New Admin_Create_Account_Landing_Page    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        ' Me.Hide()
        aai.ShowDialog()
        'End


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim aaaa As New Admin_Correction_Form    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaa.ShowDialog()




    End Sub

    Private Sub Admin_Panel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


      

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim aaaab As New Employee_Registration_Form    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaab.ShowDialog()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim aaaad As New Entry_Log_Viewer    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaad.ShowDialog()



    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim aaaak As New Employee_database    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaak.ShowDialog()



    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Dim aaaaka As New Admin_Self_Help_Password_Reset    ' -- I need to create a new dim to avoid same instance and avoid instance error 


        aaaaka.ShowDialog()



    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click



    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        'Dim aaaaka As New Admin_Self_Help_Password_Reset    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        ' Later lagay dito using Admin changes log

        'aaaaka.ShowDialog()

    End Sub
End Class