Imports System.Data.OleDb
Public Class Form3
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader

    Dim adp As OleDb.OleDbDataAdapter

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gupta.accdb"
            con.Open()
            MsgBox("success")
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd.Connection = con
        cmd.CommandText = "Insert into Table1(NAME,FATHER NAME,MOTHER NAME,D O B,ADDRESS,CITY,CONTECT,PIN CODE,E MAIL)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox9.Text + "','" + TextBox8.Text + "')"
        MsgBox("success")

    End Sub
End Class