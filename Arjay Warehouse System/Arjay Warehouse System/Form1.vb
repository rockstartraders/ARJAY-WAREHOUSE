Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form1
    Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;")

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection("Server=db4free.net;port=3306;userid=arjaywarehouse;password=Hulinghulingproject;database=arjay_warehouse;old guids=true;")

        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

        Dim command As New MySqlCommand("INSERT INTO `test`(`username`, `password`, `img`) VALUES  (@username,@password,@img)", con)


        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray()

        con.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Image Inserted")

        Else
            MessageBox.Show("Image Not Inserted")
        End If

        con.Close()

    End Sub
End Class
