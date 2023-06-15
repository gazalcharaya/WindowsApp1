Imports System.Reflection.Emit
Imports System.Configuration
Imports System.Data.OleDb
Public Class Form2
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cb As OleDbCommandBuilder
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form1.Show()



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kimij\Documents\Databases2.accdb"
        conn.Open()
        Dim sql As String = "select * from Table1"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        cmd = New OleDb.OleDbCommand
        dt = New DataTable
        cb = New OleDb.OleDbCommandBuilder(da)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        DataGridView1.Columns(0).HeaderText = "item"
        DataGridView1.Columns(1).HeaderText = "qty"
        DataGridView1.Columns(2).HeaderText = "price"
        DataGridView1.Columns(3).HeaderText = "amount"
        DataGridView1.Columns(3).HeaderText = "order no"

    End Sub
End Class