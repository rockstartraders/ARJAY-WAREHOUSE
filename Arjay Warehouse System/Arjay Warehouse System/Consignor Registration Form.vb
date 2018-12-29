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


        Dim random As New Random
        Dim password As New System.Text.StringBuilder
        For i As Int32 = 0 To 3
            password.Append(Chr(random.Next(48, 57)))
        Next
        TextBox1.Text = "ARJ" + "-" + "001" + password.ToString


        ' <-- For Admin ID to be captured -->

        Me.TextBox9.Text = Admin_Panel.Label1.Text


    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click



        Dim a As DialogResult = MsgBox("Are You Sure You Want to Exit ?", 4 + 32, )

        If a = DialogResult.Yes Then


            
            Me.Dispose()
            Me.Close()



        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;Connection Timeout=240;")

        con.Open()
        Dim query As String
        query = "INSERT INTO `Consignor Record`(`Con_ID`, `Con_name`, `Con_address`, `Con_landline_no`, `Con_mobile_no`, `Con_email`, `Con_sign_up_date`, `Storage_location`, `con_contact_person`, `Processed_by`) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & DateTimePicker1.Text & "','" & ComboBox1.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')"
        cmd = New MySqlCommand(query, con)
        cmd.CommandTimeout = 240  'for time out errors
        rd = cmd.ExecuteReader()
        ' MsgBox(" New Employee Account has Been Created ")
        con.Close()

        con.Open()
        query = "INSERT INTO `Inventory`(`Con_ID`, `Con_Name`, `Prod_Camote`, `Prod_Chili`, `Prod_Coffee_Beans`, `Prod_Corn`, `Prod_Potatoes`, `Prod_Rice`, `Prod_Tobacco`, `Prod_Tomatoes`) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox7.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "','" & TextBox16.Text & "')"
        cmd = New MySqlCommand(query, con)
        cmd.CommandTimeout = 240  'for time out errors
        rd = cmd.ExecuteReader()
        MsgBox(" New Consignor Record has Been Created ")
        con.Close()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        'DateTimePicker1.Text = ""
        ComboBox1.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""

        'InitializeComponent() 'load all the controls again
        Consignor_Registration_Form_Load(e, e) 'Load everything in your form load event again





    End Sub
End Class