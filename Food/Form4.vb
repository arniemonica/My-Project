Imports System.Data.OleDb

Public Class Form4
    Dim provider As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection




    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            '(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)
            '(Asc(e.KeyChar) = 46
            '(Asc(e.KeyChar) = 8
        Else
            e.Handled = True

        End If
    End Sub



    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then TextBox1.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then TextBox2.Enabled = True
        TextBox2.Focus()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            '(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)
            '(Asc(e.KeyChar) = 46
            '(Asc(e.KeyChar) = 8
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            '(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)
            '(Asc(e.KeyChar) = 46
            '(Asc(e.KeyChar) = 8
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then TextBox3.Enabled = True 
        TextBox3.Focus()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Close()

    End Sub

    Dim pay As String
    Dim change As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pay = TextBox6.Text
        change = pay - total12

        ListBox1.Items.Add("Payment ..... ₱" + pay)
        ListBox1.Items.Add("")
        ListBox1.Items.Add("Change ..... ₱" + change)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then TextBox4.Enabled = True
        TextBox4.Focus()
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then TextBox5.Enabled = True
        TextBox5.Focus()
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            '(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)
            '(Asc(e.KeyChar) = 46
            '(Asc(e.KeyChar) = 8
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            '(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)
            '(Asc(e.KeyChar) = 46
            '(Asc(e.KeyChar) = 8
        Else
            e.Handled = True

        End If
    End Sub


    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then TextBox10.Enabled = True
        TextBox10.Focus()
    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked Then TextBox9.Enabled = True
        TextBox9.Focus()
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then TextBox8.Enabled = True
        TextBox8.Focus()
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked Then TextBox7.Enabled = True
        TextBox7.Focus()
    End Sub

    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            '(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)
            '(Asc(e.KeyChar) = 46
            '(Asc(e.KeyChar) = 8
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            '(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)
            '(Asc(e.KeyChar) = 46
            '(Asc(e.KeyChar) = 8
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            '(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)
            '(Asc(e.KeyChar) = 46
            '(Asc(e.KeyChar) = 8
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            '(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)
            '(Asc(e.KeyChar) = 46
            '(Asc(e.KeyChar) = 8
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            '(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)
            '(Asc(e.KeyChar) = 46
            '(Asc(e.KeyChar) = 8
        Else
            e.Handled = True

        End If
    End Sub





    Private Sub TextBox13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            '(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57)
            '(Asc(e.KeyChar) = 46
            '(Asc(e.KeyChar) = 8
        Else
            e.Handled = True

        End If
    End Sub


    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked Then TextBox11.Enabled = True
        TextBox11.Focus()
    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked Then TextBox12.Enabled = True
        TextBox12.Focus()

    End Sub

    Dim bmd As Double
    Dim bm As Double
    Dim ff As Double
    Dim dc As Double
    Dim qp As Double
    Dim sc As Double
    Dim cf As Double
    Dim cfa As Double
    Dim ms As Double
    Dim c As Double
    Dim it As Double

    Dim t1 As String
    Dim t2 As String
    Dim t3 As String
    Dim t4 As String
    Dim t5 As String
    Dim t7 As String
    Dim t8 As String
    Dim t9 As String
    Dim t10 As String
    Dim t11 As String
    Dim t12 As String

    Dim total As Double
    Dim total1 As Double
    Dim total2 As Double
    Dim total3 As Double
    Dim total4 As Double
    Dim total5 As Double
    Dim total6 As Double
    Dim total7 As Double
    Dim total8 As Double
    Dim total9 As Double
    Dim total10 As Double
    Dim total11 As Double
    Dim total12 As String


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        t1 = TextBox1.Text
        t2 = TextBox2.Text
        t3 = TextBox3.Text
        t4 = TextBox4.Text
        t5 = TextBox5.Text
        t7 = TextBox7.Text
        t8 = TextBox8.Text
        t9 = TextBox9.Text
        t10 = TextBox10.Text
        t11 = TextBox11.Text
        t12 = TextBox12.Text



        provider = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=C:\Users\genden0902\Documents\Food\Food.accdb"
        connstring = provider
        myconnection.ConnectionString = connstring
        myconnection.Open()
        Dim str As String
        str = "Insert into Table1([MC],[BM],[FF],[DC],[QP],[SP],[CF],[CFAK],[MS],[IT],[Coke],[Amount]) Values (?,?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.Parameters.Add(New OleDbParameter("MC", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("BM", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("FF", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("DC", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("QP", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("SP", CType(TextBox10.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CF", CType(TextBox9.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CFAK", CType(TextBox8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MS", CType(TextBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("IT", CType(TextBox12.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Coke", CType(TextBox11.Text, String)))


        If CheckBox1.Checked = True Then
            bmd = 35.0
            total = bmd * t1

            ListBox1.Items.Add(t1 + "  Burger McDo")
            ListBox1.Items.Add(total)
            ListBox1.Items.Add("")

        End If

        If CheckBox2.Checked = True Then
            bm = 149.0
            total1 = bm * t2

            ListBox1.Items.Add(t2 + "  Big Mac")
            ListBox1.Items.Add(total1)
            ListBox1.Items.Add("")

        End If
        If CheckBox3.Checked = True Then
            ff = 120.0
            total2 = ff * t3

            ListBox1.Items.Add(t3 + "  Filet-O-Fish")
            ListBox1.Items.Add(total2)
            ListBox1.Items.Add("")
        End If
        If CheckBox4.Checked = True Then
            dc = 116.0
            total3 = dc * t4

            ListBox1.Items.Add(t4 + "  Double Cheeseburger")
            ListBox1.Items.Add(total3)
            ListBox1.Items.Add("")

        End If
        If CheckBox5.Checked = True Then
            qp = 149.0
            total4 = qp * t5
            ListBox1.Items.Add(t5 + "  Quarter Pounder w/ Cheese")
            ListBox1.Items.Add(total4)
            ListBox1.Items.Add("")
        End If

        If CheckBox10.Checked = True Then
            sc = 112.0
            total5 = 112 * t10

            ListBox1.Items.Add(t10 + "  1-pc Chicken McDo w/ Rice")
            ListBox1.Items.Add(total5)
            ListBox1.Items.Add("")

        End If

        If CheckBox9.Checked = True Then
            cf = 113.0
            total6 = cf * t9

            ListBox1.Items.Add(t9 + "  McCrispy Chicken Fillet w/ Rice Fries")
            ListBox1.Items.Add(total6)
            ListBox1.Items.Add("")

        End If
        If CheckBox8.Checked = True Then
            cfa = 81.0

            total7 = cfa * t8

            ListBox1.Items.Add(t8 + "  McCrispy Chicken Fillet Ala King w/ Rice")
            ListBox1.Items.Add(total7)
            ListBox1.Items.Add("")
        End If
        If CheckBox7.Checked = True Then
            ms = 116.0

            total8 = ms * t7

            ListBox1.Items.Add(t7 + "  1-pc Chicken McDo w/ Rice Mushroom Soup")
            ListBox1.Items.Add(total8)
            ListBox1.Items.Add("")

        End If
        If CheckBox11.Checked = True Then
            c = 47.0
            total9 = c * t11
            ListBox1.Items.Add(t11 + "  Coke")
            ListBox1.Items.Add(total9)
            ListBox1.Items.Add("")

        End If
        If CheckBox12.Checked = True Then
            it = 56.0
            total10 = it * t12
            ListBox1.Items.Add(t12 + "  Iced Tea")
            ListBox1.Items.Add(total10)
            ListBox1.Items.Add("")

        End If
        If CheckBox1.Checked = True Or CheckBox2.Checked = True Or CheckBox3.Checked = True Or CheckBox4.Checked = True Or
            CheckBox5.Checked = True Or CheckBox7.Checked = True Or CheckBox8.Checked = True Or CheckBox9.Checked = True Or
            CheckBox10.Checked = True Or CheckBox11.Checked = True Or CheckBox12.Checked = True Then
            total12 = total + total1 + total2 + total3 + total4 + total5 + total6 + total7 + total8 + total9 + total10 + total11


            ListBox1.Items.Add("Total ..... ₱" + total12)
            ListBox1.Items.Add("")
            TextBox13.Text = total12


        End If


        cmd.Parameters.Add(New OleDbParameter("Amount", CType(TextBox13.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox10.Clear()
            TextBox9.Clear()
            TextBox8.Clear()
            TextBox7.Clear()
            TextBox11.Clear()
            TextBox12.Clear()





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        






        
        TextBox6.Enabled = True
        TextBox6.Focus()

    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        CheckBox1.Checked = False
        TextBox1.Enabled = False
        TextBox1.Text = ("")
        CheckBox2.Checked = False
        TextBox2.Enabled = False
        TextBox2.Text = ("")
        CheckBox3.Checked = False
        TextBox3.Enabled = False
        TextBox3.Text = ("")
        CheckBox4.Checked = False
        TextBox4.Enabled = False
        TextBox4.Text = ("")
        CheckBox5.Checked = False
        TextBox5.Enabled = False
        TextBox5.Text = ("")
        CheckBox7.Checked = False
        TextBox7.Enabled = False
        TextBox7.Text = ("")
        CheckBox8.Checked = False
        TextBox8.Enabled = False
        TextBox8.Text = ("")
        CheckBox9.Checked = False
        TextBox9.Enabled = False
        TextBox9.Text = ("")
        CheckBox10.Checked = False
        TextBox10.Enabled = False
        TextBox10.Text = ("")
        CheckBox11.Checked = False
        TextBox11.Enabled = False
        TextBox11.Text = ("")
        CheckBox12.Checked = False
        TextBox12.Text = ("")
        TextBox12.Enabled = False
        TextBox6.Text = ("")
        TextBox6.Enabled = False
        TextBox13.Enabled = False
        TextBox13.Text = ""

    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class