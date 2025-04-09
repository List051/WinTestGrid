# WinPopUp

WinPopUpPlus è una libreria .NET che permette di associare popup informativi ai controlli di un form Windows Forms.

## Installazione
Aggiungi la libreria `WinPopUpPlus.dll` al tuo progetto tramite **Riferimenti**.

## Utilizzo
Importa la libreria nel tuo codice:

```vbnet
Imports WinPopUpPlus

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Carica le immagini dalle risorse (My.Resources)
            Dim imgInfo As Image = My.Resources.cashier  ' Nome dell'immagine senza estensione
            Dim imgWarning As Image = My.Resources.calculator_50

            ' Associa i popup ai pulsanti
            PopupHelper.AttachPopup(Button1, "Informazioni utili" & vbCr & "Altre informazioni", imgInfo)
            PopupHelper.AttachPopup(Button2, "Attenzione! Controlla i dati", imgWarning)
        Catch ex As Exception
            MessageBox.Show("Errore nel caricamento delle immagini: " & ex.Message)
        End Try
    End Sub
End Class
