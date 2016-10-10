Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim missDial As MissDial
        Dim md_number As String
        Dim md_datetime As String
        Dim md_operator As String
        Dim md_circle As String
        Dim md_dnd As String
        Dim md_prefix As String
        Dim sql_dataSource As String
        Dim sql_dataName As String

        sql_dataSource = "USER\SQLEXPRESS" 'Set your sql data source
        sql_dataName = "testDb" 'Set your database name


        md_number = Request.QueryString("nos") 'get number from query string
        md_datetime = Request.QueryString("dttime") 'get datetime from query string
        md_operator = Request.QueryString("operator") 'get user area from query string
        md_circle = Request.QueryString("circle") 'get operator from query string
        md_dnd = Request.QueryString("dnd") 'get number from query string
        md_prefix = Request.QueryString("prefix") 'get dnd/ndnd from query string

        missDial = New MissDial(md_number, md_datetime, md_circle, md_operator, md_dnd, md_prefix)

        Dim query As String = String.Empty
        query &= "INSERT INTO missdial (number, datetime, circle, operator, ndnd, prefix)  "
        query &= "VALUES (@colNumber,@colDtTime, @colCircle, @colOperator,@colDnd, @colPrefix)"



        Using conn As New SqlConnection("Data Source='" & sql_dataSource & "';Initial Catalog='" & sql_dataName & "';Integrated Security=True")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandText = query
                    .Parameters.AddWithValue("@colNumber", missDial.getNumber)
                    .Parameters.AddWithValue("@colDtTime", missDial.getDateTime)
                    .Parameters.AddWithValue("@colCircle", missDial.getCircle)
                    .Parameters.AddWithValue("@colOperator", missDial.getMobOperator)
                    .Parameters.AddWithValue("@colDnd", missDial.getDnd)
                    .Parameters.AddWithValue("@colPrefix", missDial.getPrefix)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message.ToString())
                End Try
            End Using
        End Using
    End Sub
End Class
