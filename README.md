

<p align="center">
  <img src="Logo.png" alt="Ital Pascal Logo" width="220">
</p>

<p align="center">
  Libreria di utilità per applicazioni VB.NET WinForms
</p>

<p align="center">

  <!-- NuGet -->
  <a href="https://www.nuget.org/packages/WinItalPascal">
    <img src="https://img.shields.io/nuget/v/WinItalPascal?style=for-the-badge" alt="NuGet Version">
  </a>
  <a href="https://www.nuget.org/packages/WinItalPascal">
    <img src="https://img.shields.io/nuget/dt/WinItalPascal?style=for-the-badge" alt="NuGet Downloads">
  </a>

  <!-- GitHub -->
  <img src="https://img.shields.io/github/stars/List051/WinItalPascal_Lib?style=for-the-badge" alt="Stars">
  <img src="https://img.shields.io/github/forks/List051/WinItalPascal_Lib?style=for-the-badge" alt="Forks">
  <img src="https://img.shields.io/github/issues/List051/WinItalPascal_Lib?style=for-the-badge" alt="Issues">
  <img src="https://img.shields.io/github/last-commit/List051/WinItalPascal_Lib?style=for-the-badge" alt="Last Commit">

  <!-- License -->
  <a href="https://github.com/List051/WinItalPascal_Lib/blob/main/License.txt">
    <img src="https://img.shields.io/github/license/List051/WinItalPascal_Lib?style=for-the-badge" alt="License">
  </a>

</p>


## Ora è inserito in Libreria WinItalPascal - vedi NuGet

# Uty_DataGridView

🎬 **Demo Video:** [Guarda su YouTube](https://youtu.be/DhrGJItaxSk)

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

<div align="center">
  <h2>⭐ Come supportare il progetto</h2>
  <p>Se questo progetto ti è utile, puoi supportarlo con un semplice gesto:</p>


<!-- Pulsante Star -->
  <a href="https://github.com/List051/WinTestGrid">
    <img src="https://img.shields.io/github/stars/List051/WinTestGrid?style=social" alt="Star this repo">
  </a>

  <!-- Pulsante Fork -->
  <a href="https://github.com/List051/WinItalPascal_Help/fork">
    <img src="https://img.shields.io/github/forks/List051/WinItalPascal_Help?label=fork&style=social" alt="Fork this repo">
  </a>
  <p>Mettere una ⭐ o fare un Fork aiuta il progetto a crescere e permette ad altri sviluppatori di scoprirlo.</p>

  <br>

  <!-- Pulsante Follow autore -->
  <p>Vuoi restare aggiornato sui nuovi progetti?</p>

  <a href="https://github.com/List051">
    <img src="https://img.shields.io/github/followers/List051?label=Follow%20%40List051&style=social" alt="Follow @List051">
  </a>

  <p>Grazie per il tuo supporto!</p>
</div>
