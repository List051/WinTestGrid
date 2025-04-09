Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms

Public Class DataGVLoader
    ' Metodo per caricare un DataGridView con una query SQL senza parametri
    Public Shared Sub CaricaDGV(ByRef dgv As DataGridView, ByVal sql As String)
        Dim connString As String = ConfigurationManager.ConnectionStrings("MiaConnessione").ConnectionString
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim da As New SqlDataAdapter(sql, conn)
                Dim ds As New DataSet()
                da.Fill(ds, "tabella")
                dgv.DataSource = ds.Tables("tabella")
            End Using
        Catch ex As Exception
            MessageBox.Show("Errore durante il caricamento del DataGridView: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Metodo per caricare un DataGridView con query SQL e parametri
    Public Shared Sub CaricaDGV(ByRef dgv As DataGridView, ByVal sql As String, ByVal parametri() As String, ByVal valori() As String)
        If parametri.Length <> valori.Length Then
            Throw New ArgumentException("Il numero di parametri e valori deve essere uguale.")
        End If
        
        Dim connString As String = ConfigurationManager.ConnectionStrings("MiaConnessione").ConnectionString
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim da As New SqlDataAdapter(sql, conn)
                For i As Integer = 0 To parametri.Length - 1
                    da.SelectCommand.Parameters.AddWithValue(parametri(i), valori(i))
                Next
                Dim ds As New DataSet()
                da.Fill(ds, "tabella")
                dgv.DataSource = ds.Tables("tabella")
            End Using
        Catch ex As Exception
            MessageBox.Show("Errore durante il caricamento del DataGridView: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Metodo per caricare un DataGridView con query SQL e due set di parametri
    Public Shared Sub CaricaDGV(ByRef dgv As DataGridView, ByVal sql As String, ByVal parametri() As String, ByVal valori() As String, ByVal parametri2() As String, ByVal valori2() As String)
        If parametri.Length <> valori.Length OrElse parametri2.Length <> valori2.Length Then
            Throw New ArgumentException("Il numero di parametri e valori deve essere uguale per entrambi i set.")
        End If
        
        Dim connString As String = ConfigurationManager.ConnectionStrings("MiaConnessione").ConnectionString
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim da As New SqlDataAdapter(sql, conn)
                For i As Integer = 0 To parametri.Length - 1
                    da.SelectCommand.Parameters.AddWithValue(parametri(i), valori(i))
                Next
                For i As Integer = 0 To parametri2.Length - 1
                    da.SelectCommand.Parameters.AddWithValue(parametri2(i), valori2(i))
                Next
                Dim ds As New DataSet()
                da.Fill(ds, "tabella")
                dgv.DataSource = ds.Tables("tabella")
            End Using
        Catch ex As Exception
            MessageBox.Show("Errore durante il caricamento del DataGridView: " & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
