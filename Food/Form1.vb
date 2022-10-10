Public Class Form1

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Username And
            TextBox2.Text = My.Settings.Password Then
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password!", MsgBoxStyle.Information, "Error")


        End If
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure you want to close the app?", MsgBoxStyle.YesNo, "Exit")
        If ask = MsgBoxResult.Yes Then
            Me.Close()


        Else

        End If


    End Sub
End Class
