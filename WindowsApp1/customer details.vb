Imports System.Data.OleDb
Imports System.Reflection.Emit
Imports System.Configuration

Public Class customer_details
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cb As OleDbCommandBuilder
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub customer_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kimij\Documents\customers.accdb"
        conn.Open()
        Dim sql As String = "select * from customers"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        cmd = New OleDb.OleDbCommand
        dt = New DataTable
        cb = New OleDb.OleDbCommandBuilder(da)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Columns(0).HeaderText = "name"
        DataGridView1.Columns(1).HeaderText = "order no"

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class