Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo, "Logout")
        If ask = MsgBoxResult.Yes Then
            Form1.Show()
            Me.Hide()

        Else

        End If

    End Sub
End Class