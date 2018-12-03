Public Class FMlad1

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click, Label7.Click, Label6.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Label2.Text = txt1.Text * 12
        Label3.Text = Label2.Text * 0.05
        Label4.Text = Label2.Text - Label3.Text


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    
End Class
