Imports System.IO

Public Class Login_As

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Login_As_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing



    End Sub

    Private Sub Login_As_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

       



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


       


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        

    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->

        Dim ab As New Admin_Login    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        ab.ShowDialog()
        Me.Dispose()
        Me.Close()


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->

        Dim ac As New Dispatch_Login   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        ac.ShowDialog()
        End


    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->

        Dim ad As New Receiving_Login    ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        ad.ShowDialog()
        End



    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Me.Cursor = Cursors.WaitCursor    ' < -- cursor wait function -->

        Dim produkto As New chart   ' -- I need to create a new dim to avoid same instance and avoid instance error 

        Me.Hide()
        produkto.ShowDialog()
        Me.Cursor = Cursors.Default    ' < -- cursor wait function -->
        Me.Dispose()
        Me.Close()



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

        ' < -- This is needed to Avoid Modal Error -->

        Dim palabokfiesta As DialogResult = MsgBox("Are You Sure You Want to Sign Out From This Session ?", 4 + 32, )

        If palabokfiesta = DialogResult.Yes Then



            Dim consignorkagebunshinreadonlyonetwo As New Login_As   ' -- I need to create a new dim to avoid same instance and avoid instance error 


            Me.Hide()
            MsgBox("Goodbye", 0)
            Me.Dispose()
            Me.Close()


        End If


    End Sub
End Class