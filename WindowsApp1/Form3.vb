Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form3
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim dt As DataTable
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim subtotal = 0
    Dim tax = 0
    Dim grdtotal = 0
    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles noodles.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Fries.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Wrap.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Public Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datelbl.Text = DateTime.Now.ToLongTimeString
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datelbl.Text = DateTime.Now.ToLongTimeString

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles NuddCb.CheckedChanged

        If NuddCb.Checked = True Then
            NuddTb.Enabled = True

        End If
        If NuddCb.Checked = False Then
            NuddTb.Enabled = False
            NuddTb.Text = "0"

        End If
    End Sub

    Private Sub NuddTb_TextChanged(sender As Object, e As EventArgs) Handles NuddTb.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles PizzaTb.TextChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles PizzaCb.CheckedChanged
        If PizzaCb.Checked = True Then
            PizzaTb.Enabled = True



        End If
        If PizzaCb.Checked = False Then
            PizzaTb.Enabled = False
            PizzaTb.Text = "0"

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FriesCb_CheckedChanged(sender As Object, e As EventArgs) Handles FriesCb.CheckedChanged
        If FriesCb.Checked = True Then
            FriesTb.Enabled = True


        End If
        If FriesCb.Checked = False Then
            FriesTb.Enabled = False
            FriesTb.Text = "0"

        End If
    End Sub

    Private Sub WrapCb_CheckedChanged(sender As Object, e As EventArgs) Handles WrapCb.CheckedChanged
        If WrapCb.Checked = True Then
            WrapTb.Enabled = True

        End If
        If WrapCb.Checked = False Then
            WrapTb.Enabled = False
            WrapTb.Text = "0"

        End If
    End Sub



    Private Sub CapCb_CheckedChanged(sender As Object, e As EventArgs) Handles CapCb.CheckedChanged
        If CapCb.Checked = True Then
            CapTb.Enabled = True

        End If
        If CapCb.Checked = False Then
            CapTb.Enabled = False
            CapTb.Text = "0"

        End If
    End Sub

    Private Sub MozCb_CheckedChanged(sender As Object, e As EventArgs) Handles MozCb.CheckedChanged
        If MozCb.Checked = True Then
            MozTb.Enabled = True

        End If
        If MozCb.Checked = False Then
            MozTb.Enabled = False
            MozTb.Text = "0"

        End If
    End Sub

    Private Sub CoffeCb_CheckedChanged(sender As Object, e As EventArgs) Handles CoffeCb.CheckedChanged
        If CoffeCb.Checked = True Then
            CoffeTb.Enabled = True

        End If
        If CoffeCb.Checked = False Then
            CoffeTb.Enabled = False
            CoffeTb.Text = "0"

        End If
    End Sub

    Private Sub PastyCb_CheckedChanged(sender As Object, e As EventArgs) Handles PastyCb.CheckedChanged
        If PastyCb.Checked = True Then
            PastyTb.Enabled = True

        End If
        If PastyCb.Checked = False Then
            PastyTb.Enabled = False
            PastyTb.Text = "0"

        End If
    End Sub

    Private Sub WaffCb_CheckedChanged(sender As Object, e As EventArgs) Handles WaffCb.CheckedChanged
        If WaffCb.Checked = True Then
            WaffTb.Enabled = True

        End If
        If WaffCb.Checked = False Then
            WaffTb.Enabled = False
            WaffTb.Text = "0"

        End If
    End Sub

    Private Sub IceCb_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BurgerCb_CheckedChanged(sender As Object, e As EventArgs) Handles BurgerCb.CheckedChanged
        If BurgerCb.Checked = True Then
            BurgerTb.Enabled = True

        End If
        If BurgerCb.Checked = False Then
            BurgerTb.Enabled = False
            BurgerTb.Text = "0"

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        receiptTb.Clear()
        subtotal = 0
        receiptTb.AppendText(Environment.NewLine)
        receiptTb.AppendText("MUGS & BITES RESTAURANT" + Environment.NewLine)

        receiptTb.AppendText("***********************" + Environment.NewLine)

        Dim conn As New OleDb.OleDbConnection
        Dim cmdd As OleDb.OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kimij\Documents\Databases2.accdb"
        conn.Open()
        If BurgerCb.Checked = True Then
            Dim qty, price As Integer
            qty = CInt(BurgerTb.Text)
            price = CInt(BurgerLb.Text)
            Dim res As Integer = qty * price
            Dim sql As String = "Insert into Table1(item,qty,price,amount) values('" & Burger.Text & "','" & BurgerTb.Text & "','" & BurgerLb.Text & "','" & res.ToString & "')"
            cmdd = New OleDb.OleDbCommand(sql, conn)
            cmdd.ExecuteNonQuery()
            receiptTb.AppendText("BURGER:" + res.ToString + "RS" + Environment.NewLine)
            subtotal = subtotal + res.ToString
            subtotalLb.Text = "" + subtotal.ToString
        End If

        If PizzaCb.Checked = True Then
            Dim qty, price As Integer
            qty = CInt(PizzaTb.Text)
            price = CInt(PizzaLb.Text)
            Dim res As Integer = qty * price
            Dim sql As String = "Insert into Table1(item,qty,price,amount) values('" & Pizza.Text & "','" & PizzaTb.Text & "','" & PizzaLb.Text & "','" & res.ToString & "')"
            cmdd = New OleDb.OleDbCommand(sql, conn)
            cmdd.ExecuteNonQuery()
            receiptTb.AppendText("PIZZA:" + res.ToString + "RS" + Environment.NewLine)
            subtotal = subtotal + res.ToString
            subtotalLb.Text = "" + subtotal.ToString
        End If
        If NuddCb.Checked = True Then
            Dim qty, price As Integer
            qty = CInt(NuddTb.Text)
            price = CInt(NuddLb.Text)
            Dim res As Integer = qty * price
            Dim sql As String = "Insert into Table1(item,qty,price,amount) values('" & noodles.Text & "','" & NuddTb.Text & "','" & NuddLb.Text & "','" & res.ToString & "')"
            cmdd = New OleDb.OleDbCommand(sql, conn)
            cmdd.ExecuteNonQuery()
            receiptTb.AppendText("NOODLES:" + res.ToString + "RS" + Environment.NewLine)
            subtotal = subtotal + res.ToString
            subtotalLb.Text = "" + subtotal.ToString
        End If
        If FriesCb.Checked = True Then
            Dim qty, price As Integer
            qty = CInt(FriesTb.Text)
            price = CInt(FriesLb.Text)
            Dim res As Integer = qty * price
            Dim sql As String = "Insert into Table1(item,qty,price,amount) values('" & Fries.Text & "','" & FriesTb.Text & "','" & FriesLb.Text & "','" & res.ToString & "')"
            cmdd = New OleDb.OleDbCommand(sql, conn)
            cmdd.ExecuteNonQuery()
            receiptTb.AppendText("PERI PERI FRIES:" + res.ToString + "RS" + Environment.NewLine)
            subtotal = subtotal + res.ToString
            subtotalLb.Text = "" + subtotal.ToString
        End If
        If WrapCb.Checked = True Then
            Dim qty, price As Integer
            qty = CInt(WrapTb.Text)
            price = CInt(WrapLb.Text)
            Dim res As Integer = qty * price
            Dim sql As String = "Insert into Table1(item,qty,price,amount) values('" & Wrap.Text & "','" & WrapTb.Text & "','" & WrapLb.Text & "','" & res.ToString & "')"
            cmdd = New OleDb.OleDbCommand(sql, conn)
            cmdd.ExecuteNonQuery()
            receiptTb.AppendText("WRAP:" + res.ToString + "RS" + Environment.NewLine)
            subtotal = subtotal + res.ToString
            subtotalLb.Text = "" + subtotal.ToString
        End If

        If CapCb.Checked = True Then
            Dim qty, price As Integer
            qty = CInt(CapTb.Text)
            price = CInt(CapLb.Text)
            Dim res As Integer = qty * price
            Dim sql As String = "Insert into Table1(item,qty,price,amount) values('" & Cap.Text & "','" & CapTb.Text & "','" & CapLb.Text & "','" & res.ToString & "')"
            cmdd = New OleDb.OleDbCommand(sql, conn)
            cmdd.ExecuteNonQuery()
            receiptTb.AppendText("cappuccino:" + res.ToString + "RS" + Environment.NewLine)
            subtotal = subtotal + res.ToString
            subtotalLb.Text = "" + subtotal.ToString
        End If
        If MozCb.Checked = True Then
            Dim qty, price As Integer
            qty = CInt(MozTb.Text)
            price = CInt(MozLb.Text)
            Dim res As Integer = qty * price
            Dim sql As String = "Insert into Table1(item,qty,price,amount) values('" & Moz.Text & "','" & MozTb.Text & "','" & MozLb.Text & "','" & res.ToString & "')"
            cmdd = New OleDb.OleDbCommand(sql, conn)
            cmdd.ExecuteNonQuery()
            receiptTb.AppendText("Mint Mozito:" + res.ToString + "RS" + Environment.NewLine)
            subtotal = subtotal + res.ToString
            subtotalLb.Text = "" + subtotal.ToString
        End If

        If CoffeCb.Checked = True Then
            Dim qty, price As Integer
            qty = CInt(CoffeTb.Text)
            price = CInt(CoffeLb.Text)
            Dim res As Integer = qty * price
            Dim sql As String = "Insert into Table1(item,qty,price,amount) values('" & Coffe.Text & "','" & CoffeTb.Text & "','" & CoffeLb.Text & "','" & res.ToString & "')"
            cmdd = New OleDb.OleDbCommand(sql, conn)
            cmdd.ExecuteNonQuery()
            receiptTb.AppendText("coco frappe:" + res.ToString + "RS" + Environment.NewLine)
            subtotal = subtotal + res.ToString
            subtotalLb.Text = "" + subtotal.ToString
        End If
        If PastyCb.Checked = True Then
            Dim qty, price As Integer
            qty = CInt(PastyTb.Text)
            price = CInt(PastyLb.Text)
            Dim res As Integer = qty * price
            Dim sql As String = "Insert into Table1(item,qty,price,amount) values('" & Pasty.Text & "','" & PastyTb.Text & "','" & PastyLb.Text & "','" & res.ToString & "')"
            cmdd = New OleDb.OleDbCommand(sql, conn)
            cmdd.ExecuteNonQuery()
            receiptTb.AppendText("fruit pastry:" + res.ToString + "RS" + Environment.NewLine)
            subtotal = subtotal + res.ToString
            subtotalLb.Text = "" + subtotal.ToString
        End If
        If WaffCb.Checked = True Then
            Dim qty, price As Integer
            qty = CInt(WaffTb.Text)
            price = CInt(WaffLb.Text)
            Dim res As Integer = qty * price
            Dim sql As String = "Insert into Table1(item,qty,price,amount) values('" & Waff.Text & "','" & WaffTb.Text & "','" & WaffLb.Text & "','" & res.ToString & "')"
            cmdd = New OleDb.OleDbCommand(sql, conn)
            cmdd.ExecuteNonQuery()
            receiptTb.AppendText("nutty waffle:" + res.ToString + "RS" + Environment.NewLine)
            subtotal = subtotal + res.ToString
            subtotalLb.Text = "" + subtotal.ToString
        End If
        tax = subtotal * 0.16
        grdtotal = subtotal + tax
        taxLb.Text = "" + tax.ToString
        totalLb.Text = "" + grdtotal.ToString
        receiptTb.AppendText(Environment.NewLine)
        receiptTb.AppendText(Environment.NewLine)
        receiptTb.AppendText("TIME OF PLACING ORDER" + datelbl.Text + Environment.NewLine)


    End Sub

    Private Sub FriesTb_TextChanged(sender As Object, e As EventArgs) Handles FriesTb.TextChanged

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles subtotalLb.Click

    End Sub

    Private Sub BurgerTb_TextChanged(sender As Object, e As EventArgs) Handles BurgerTb.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (PrintPreviewDialog1.ShowDialog() = DialogResult.OK) Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub receiptTb_TextChanged(sender As Object, e As EventArgs) Handles receiptTb.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BurgerCb.Checked = False
        PizzaCb.Checked = False
        NuddCb.Checked = False
        FriesCb.Checked = False
        WrapCb.Checked = False
        CapCb.Checked = False
        MozCb.Checked = False
        CoffeCb.Checked = False
        PastyCb.Checked = False
        WaffCb.Checked = False
    End Sub

    Private Sub datelbl_Click(sender As Object, e As EventArgs) Handles datelbl.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(receiptTb.Text + "subtotal=" + subtotalLb.Text + "     " + "tax=" + taxLb.Text + "     " + "grand total=" + totalLb.Text, New Font("Century Gothic", 29, FontStyle.Regular), Brushes.Blue, New Point())
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form4.Show()
    End Sub
End Class