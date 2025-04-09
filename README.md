# Uty_DataGridView

## Libreria WinIaoraLib inclusa

[![GitHub](https://img.shields.io/badge/GitHub-Iaora--Projects-blue?logo=github)](https://github.com/Iaora/Uty_DataGridView)

##  Descrizione

`Uty_DataGridView` è una raccolta di funzioni pratiche in VB.NET per la gestione di `DataGridView`, 
con particolare attenzione al caricamento dati da database e alle relazioni tra tabelle (es. clienti/ordini).

---

##  Esempio di utilizzo

### Obiettivo

Caricare i dati di **clienti** e **ordini** in due `DataGridView` separati, filtrando dinamicamente gli ordini in base al cliente selezionato.

---

### 1️ Caricare i Clienti

```vbnet
Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Carica i clienti all'avvio della form
    Dim Cquery As String = "SELECT * FROM Clienti"
    CaricaDGV(ClientiDataGrid, Cquery)
End Sub

Public Sub CaricaOrdiniPerCliente2()
    ' Ottieni l'ID del cliente selezionato
    Dim idCliente As Integer = Convert.ToInt32(ClientiDataGrid.SelectedRows(0).Cells("IdClienti").Value)

    Dim sql As String = "SELECT * FROM Ordini WHERE IdCliOrd = @IdCliOrd"
    Dim parametri() As String = {"@IdCliOrd"}
    Dim valori() As String = {idCliente.ToString()}
    Dim parametri2() As String = {}
    Dim valori2() As String = {}

    CaricaDGV3(OrdiniDataGrid, sql, parametri, valori, parametri2, valori2)
End Sub

Private Sub ClientiDataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles ClientiDataGrid.SelectionChanged
    If ClientiDataGrid.SelectedRows.Count > 0 Then
        CaricaOrdiniPerCliente2()
    End If
End Sub

Private Sub BtnCercaCliente_Click(sender As Object, e As EventArgs) Handles BtnCercaCliente.Click
    Dim sql As String = "SELECT * FROM Clienti WHERE UPPER(Cliente) LIKE @Cliente"
    Dim filtroCliente As String = TxtCercaCliente.Text.Trim().ToUpper()

    If Not String.IsNullOrEmpty(filtroCliente) Then
        Dim parametri() As String = {"@Cliente"}
        Dim valori() As String = {"%" & filtroCliente & "%"}
        CaricaDGV2(ClientiDataGrid, sql, parametri, valori)
    Else
        sql = "SELECT * FROM Clienti"
        CaricaDGV(ClientiDataGrid, sql)
    End If
End Sub
```

###  Cdice Colori
		 Select Case colorIndex
            Case 1
                Return MyColorVerde
            Case 2
                Return MyColorBianco
            Case 3
                Return MyColorNero
            Case 4
                Return MyColorCyan
            Case 5
                Return MyColorGiallo
            Case 6
                Return MyColorGold
            Case Else
                Return MyColorVerdeChiaro ' Default color
				
				
## 🎬 Video Demo

Guarda su YouTube :  https://youtu.be/DhrGJItaxSk


> 👉 Clicca sull'immagine per vedere la dimostrazione su YouTube.

Struttura del progetto

    ClientiDataGrid: mostra tutti i clienti

    OrdiniDataGrid: mostra gli ordini relativi al cliente selezionato

    TxtCercaCliente: consente la ricerca clienti (case-insensitive)

    BtnCercaCliente: pulsante di avvio ricerca
	
Riepilogo funzionalità

    Caricamento dinamico dei dati nei DataGridView

    Supporto per parametri SQL

    Filtro dati con LIKE

    Gestione relazioni (es. Clienti → Ordini)

    Ricerca insensibile a maiuscole/minuscole
