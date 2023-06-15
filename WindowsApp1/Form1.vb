Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form1
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If conn.State = ConnectionState.Closed Then

            conn.Open()
        End If
        cmd.CommandText = "select * from admin"
        cmd.Connection = conn
        dt.Clear()

        da.SelectCommand = cmd
        da.Fill(dt)
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("please enter username and password")


        ElseIf dt.Rows(0).Item(0).ToString = TextBox1.Text And dt.Rows(0).Item(1) = TextBox2.Text Then
            MsgBox("login successfull")
            Form5.Show()
        Else
            MsgBox("please enter valid username or password")
        End If


    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kimij\Documents\Database1.accdb"

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim sql As String = "select * from admin"
        da = New OleDb.OleDbDataAdapter
        cmd = New OleDb.OleDbCommand
        dt = New DataTable
        conn.Close()



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
