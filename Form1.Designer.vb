<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PrintDocument1 = New Printing.PrintDocument()
        Button1 = New Button()
        max = New Button()
        Panel1 = New Panel()
        mini = New Button()
        BTNPRINT = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.OrangeRed
        Button1.BackgroundImage = My.Resources.Resources.remove
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = SystemColors.ControlLight
        Button1.Location = New Point(774, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(26, 23)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = False
        ' 
        ' max
        ' 
        max.BackColor = Color.OrangeRed
        max.BackgroundImage = CType(resources.GetObject("max.BackgroundImage"), Image)
        max.BackgroundImageLayout = ImageLayout.Zoom
        max.FlatStyle = FlatStyle.Flat
        max.ForeColor = SystemColors.ControlLight
        max.Location = New Point(742, 0)
        max.Name = "max"
        max.Size = New Size(26, 23)
        max.TabIndex = 3
        max.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DodgerBlue
        Panel1.Controls.Add(mini)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(max)
        Panel1.Location = New Point(1, 1)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 26)
        Panel1.TabIndex = 4
        ' 
        ' mini
        ' 
        mini.BackColor = Color.OrangeRed
        mini.BackgroundImage = CType(resources.GetObject("mini.BackgroundImage"), Image)
        mini.BackgroundImageLayout = ImageLayout.Zoom
        mini.FlatStyle = FlatStyle.Flat
        mini.ForeColor = SystemColors.ControlLight
        mini.Location = New Point(710, 0)
        mini.Name = "mini"
        mini.Size = New Size(26, 23)
        mini.TabIndex = 5
        mini.UseVisualStyleBackColor = False
        ' 
        ' BTNPRINT
        ' 
        BTNPRINT.BackColor = Color.Transparent
        BTNPRINT.BackgroundImage = My.Resources.Resources.photo_1530982011887_3cc11cc85693
        BTNPRINT.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BTNPRINT.Location = New Point(-3, 320)
        BTNPRINT.Name = "BTNPRINT"
        BTNPRINT.Size = New Size(433, 73)
        BTNPRINT.TabIndex = 0
        BTNPRINT.Text = "PRINT"
        BTNPRINT.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.BurlyWood
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(-3, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(430, 305)
        DataGridView1.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ITEM"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "QTY"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "PRICE"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(BTNPRINT)
        Panel2.Location = New Point(4, 23)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(799, 426)
        Panel2.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(801, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button1 As Button
    Friend WithEvents max As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mini As Button
    Friend WithEvents BTNPRINT As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel

End Class
