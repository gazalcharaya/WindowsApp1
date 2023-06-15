Public Class Form4
    Dim sql As String
    Dim namee As String


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Cname.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim conn As New OleDb.OleDbConnection
        Dim cmdd As OleDb.OleDbCommand
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kimij\Documents\customers.accdb"
        conn.Open()
        namee = Cname.Text


        Dim sql As String = "Insert into customers(name) values('" & namee & "')"
        cmdd = New OleDb.OleDbCommand(sql, conn)
        cmdd.ExecuteNonQuery()
        MsgBox("customer entered success")
    End Sub
End Class