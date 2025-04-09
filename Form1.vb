Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports WinIaoraLib
Imports WinPopUpPlus
Public Class Form1
    'Private PopupHelper As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carica i dati iniziali nel DataGridView ClientiDataGrid
        ' ho questa routine che richiede un solo parametro
        Dim Cquery As String
        Cquery = "select * from clienti"
        DataGVLoad.CaricaDGV(ClientiDataGrid, Cquery)
        SchermoUty.CentraMonitor(Me)
        ' Utilizzo della mia Libreria
        FrmTitolo.CTitolo(Me, "Esempio di utilizzo Funzioni per DataGrid")

        Dim imgCerca As Image = My.Resources.search_engine
        ' Imposta l'immagine del pulsante di ricerca
        Dim imgEvidenzia As Image = My.Resources.laptop
        ' Imposta l'immagine del pulsante di evidenziazione
        PopupHelper.AttachPopup(BtnCercaCliente, "Attenzione, utilizzo del pulsante Cerca", imgCerca)
        PopupHelper.AttachPopup(BtnEvidenzia, "Attenzione, utilizzo del pulsante Evidenzia", imgEvidenzia)
    End Sub

    ' Metodo per caricare gli ordini del cliente selezionato
    Public Sub CaricaOrdiniPerCliente2()
        Try
            ' Ottieni l'IdClienti del cliente selezionato nel DataGridView ClientiDataGrid
            Dim idCliente As Integer = Convert.ToInt32(ClientiDataGrid.SelectedRows(0).Cells("IdClienti").Value)

            ' Query per caricare gli ordini del cliente selezionato
            Dim sql As String = "SELECT * FROM Ordini WHERE IdCliOrd = @IdCliOrd"

            ' Parametri per la query (in questo caso, solo uno: IdCliOrdini)
            Dim parametri() As String = {"@IdCliOrd"}
            Dim valori() As String = {idCliente.ToString()}
            Dim parametri2() As String = {}
            Dim valori2() As String = {}

            ' Carica il DataGridView degli ordini
            DataGVLoad.CaricaDGV3(OrdiniDataGrid, sql, parametri, valori, parametri2, valori2)
            'GestioneColori.AgoNoSel(OrdiniDataGrid)
        Catch ex As Exception
            MessageBox.Show("Riga vuota, non è selezionabile")
        End Try
    End Sub

    ' Evento che scatta quando viene selezionata una riga nel DataGridView ClientiDataGrid
    Private Sub ClientiDataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles ClientiDataGrid.SelectionChanged


        If ClientiDataGrid.SelectedRows.Count > 0 Then
            ' Carica gli ordini del cliente selezionato
            CaricaOrdiniPerCliente2()

            ' Utilizzo della mia Libreria

            ' qui potrei assegnare una variabile con textBox 
            ' esempio: ' Ottieni il valore dalla TextBox
            '   Dim siglaFiltro As String = TxtCercaSigla.Text.Trim().ToUpper()
            ' Applica la colorazione sulla griglia in base al valore inserito
            '  GridUty.ColoraGriglia(ClientiDataGrid, 5, 4, 7, siglaFiltro)

            ' la commento per usare il BtnEvidenzia
            '  GridUty.ColoraGriglia(ClientiDataGrid, 5, 4, 7, "RM")
            ' **************************
            ModGrid.Ago2Grid(OrdiniDataGrid, 4, 5, 2)
        End If
    End Sub

    Private Sub BtnCercaCliente_Click(sender As Object, e As EventArgs) Handles BtnCercaCliente.Click
        ' La query SQL per cercare il cliente in modo insensibile al caso
        Dim sql As String = "SELECT * FROM Clienti WHERE UPPER(Cliente) LIKE @Cliente"

        ' Ottieni il valore dalla TextBox per il filtro cliente e convertilo in maiuscolo
        Dim filtroCliente As String = TxtCercaCliente.Text.Trim().ToUpper()

        ' Aggiungi il filtro solo se il valore non è vuoto
        If Not String.IsNullOrEmpty(filtroCliente) Then
            ' Aggiungi i parametri per la query (includiamo il simbolo di wildcard "%" per la ricerca parziale)
            Dim parametri() As String = {"@Cliente"}
            Dim valori() As String = {"%" & filtroCliente & "%"} ' Aggiungi il simbolo "%" per ricerca parziale

            ' Carica i dati nel DataGridView con il filtro applicato
            DataGVLoad.CaricaDGV2(ClientiDataGrid, sql, parametri, valori)
            ' la commento per usare il BtnEvidenzia
            ' GridUty.ColoraGriglia(ClientiDataGrid, 5, 4, 7, "RM")
        Else
            ' Se il filtro è vuoto, carica semplicemente tutti i clienti
            sql = "SELECT * FROM Clienti"
            DataGVLoad.CaricaDGV(ClientiDataGrid, sql)

            ' inverto i colori di sfondo
            'ModGrid.Ago2Grid(ClientiDataGrid, 4, 5, 2)

        End If
    End Sub

    Private Sub BtnEvidenzia_Click(sender As Object, e As EventArgs) Handles BtnEvidenzia.Click
        ' Utilizzo della mia Libreria

        Dim siglaFiltro As String = TxtEvidenzia.Text.Trim().ToUpper()
        ' Applica la colorazione sulla griglia in base al valore inserito
        '  GridUty.ColoraGriglia(ClientiDataGrid, 5, 4, 7, siglaFiltro)
        GridUty.ColoraGriglia(ClientiDataGrid, 5, 4, 2, siglaFiltro)
    End Sub

End Class
