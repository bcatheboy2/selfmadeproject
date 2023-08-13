Imports System.Data.OleDb
Public Class Form5
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader

    Dim adp As OleDb.OleDbDataAdapter

    Private Sub Registration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Registration.Click
        Form3.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gupta.accdb"
            con.Open()
            MsgBox("success")
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

End Class 