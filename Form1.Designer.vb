<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ClientiDataGrid = New System.Windows.Forms.DataGridView()
        Me.OrdiniDataGrid = New System.Windows.Forms.DataGridView()
        Me.BtnCercaCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCercaCliente = New System.Windows.Forms.TextBox()
        Me.TxtEvidenzia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEvidenzia = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdiniDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientiDataGrid
        '
        Me.ClientiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientiDataGrid.Location = New System.Drawing.Point(56, 267)
        Me.ClientiDataGrid.Name = "ClientiDataGrid"
        Me.ClientiDataGrid.RowHeadersWidth = 51
        Me.ClientiDataGrid.RowTemplate.Height = 24
        Me.ClientiDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ClientiDataGrid.Size = New System.Drawing.Size(1171, 278)
        Me.ClientiDataGrid.TabIndex = 0
        '
        'OrdiniDataGrid
        '
        Me.OrdiniDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrdiniDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdiniDataGrid.Location = New System.Drawing.Point(56, 623)
        Me.OrdiniDataGrid.Name = "OrdiniDataGrid"
        Me.OrdiniDataGrid.RowHeadersWidth = 51
        Me.OrdiniDataGrid.RowTemplate.Height = 24
        Me.OrdiniDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrdiniDataGrid.Size = New System.Drawing.Size(1171, 150)
        Me.OrdiniDataGrid.TabIndex = 1
        '
        'BtnCercaCliente
        '
        Me.BtnCercaCliente.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnCercaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCercaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCercaCliente.Location = New System.Drawing.Point(1030, 159)
        Me.BtnCercaCliente.Name = "BtnCercaCliente"
        Me.BtnCercaCliente.Size = New System.Drawing.Size(227, 39)
        Me.BtnCercaCliente.TabIndex = 2
        Me.BtnCercaCliente.Text = "Cerca Cliente"
        Me.BtnCercaCliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(519, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Inserisci Nome, anche parzialmente per cercare il Cliente"
        '
        'TxtCercaCliente
        '
        Me.TxtCercaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCercaCliente.Location = New System.Drawing.Point(858, 171)
        Me.TxtCercaCliente.Name = "TxtCercaCliente"
        Me.TxtCercaCliente.Size = New System.Drawing.Size(138, 27)
        Me.TxtCercaCliente.TabIndex = 4
        '
        'TxtEvidenzia
        '
        Me.TxtEvidenzia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEvidenzia.Location = New System.Drawing.Point(858, 214)
        Me.TxtEvidenzia.Name = "TxtEvidenzia"
        Me.TxtEvidenzia.Size = New System.Drawing.Size(138, 27)
        Me.TxtEvidenzia.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(696, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Digita parametro per evidenziare la cella, se vuoto colora le prime 3 colonne "
        '
        'BtnEvidenzia
        '
        Me.BtnEvidenzia.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnEvidenzia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEvidenzia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEvidenzia.Location = New System.Drawing.Point(1030, 202)
        Me.BtnEvidenzia.Name = "BtnEvidenzia"
        Me.BtnEvidenzia.Size = New System.Drawing.Size(227, 39)
        Me.BtnEvidenzia.TabIndex = 5
        Me.BtnEvidenzia.Text = "Evidenzia Colonne"
        Me.BtnEvidenzia.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 577)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(721, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Quando selezioni un rigo dal DataGrid Clienti filtra gli Ordini in questo DataGri" &
    "d"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.TestDataGrid.My.Resources.Resources.agoweb
        Me.PictureBox3.Location = New System.Drawing.Point(36, 54)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(144, 144)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TestDataGrid.My.Resources.Resources.computer
        Me.PictureBox2.Location = New System.Drawing.Point(1271, 623)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(135, 116)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TestDataGrid.My.Resources.Resources.copywriting
        Me.PictureBox1.Location = New System.Drawing.Point(1252, 267)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1432, 896)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtEvidenzia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEvidenzia)
        Me.Controls.Add(Me.TxtCercaCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCercaCliente)
        Me.Controls.Add(Me.OrdiniDataGrid)
        Me.Controls.Add(Me.ClientiDataGrid)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdiniDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientiDataGrid As DataGridView
    Friend WithEvents OrdiniDataGrid As DataGridView
    Friend WithEvents BtnCercaCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCercaCliente As TextBox
    Friend WithEvents TxtEvidenzia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEvidenzia As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
