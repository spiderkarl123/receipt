Imports System.Drawing.Printing
Public Class Form1
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint, PrintDocument1.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        'pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "****************************************************************"

        e.Graphics.DrawString("TINDAHAN-PAMILIHAN :", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("GMA CAVITE", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Tel #87000", f10, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString("DRW8555RE", f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 85)
        e.Graphics.DrawString("Jackie Chan", f8, Brushes.Black, 70, 85)

        e.Graphics.DrawString("08/17/2025 | 15.34", f8, Brushes.Black, 0, 95)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 120)

        Dim height As Integer 'DGV Position
        Dim i As Long
        DataGridView1.AllowUserToAddRows = False
        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 0, 115 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f8, Brushes.Black, 25, 115 + height)
            i = DataGridView1.Rows(row).Cells(2).Value
            DataGridView1.Rows(row).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 180, 115 + height, right)
        Next

        Dim height2 As Integer
        height2 = 145 + height

        sumprice() 'call sub 
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total: " & Format(t_price, "##,##0"), f10b, Brushes.Black, rightmargin, 15 + height2, right)
        e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 0, 15 + height2)

        e.Graphics.DrawString("~ SALAMAT SHOPPEE ~", f10, Brushes.Black, centermargin, 70 + height2, center)
        e.Graphics.DrawString("~ TINDAHAN-PAMILIHAN ~", f10, Brushes.Black, centermargin, 85 + height2, center)
    End Sub
    Dim t_price As Long
    Dim t_qty As Long
    Sub sumprice()
        Dim countprice As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countprice = countprice + Val(DataGridView1.Rows(rowitem).Cells(2).Value * DataGridView1.Rows(rowitem).Cells(1).Value)
        Next
        t_price = countprice
        Dim countqty As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countqty = countqty + DataGridView1.Rows(rowitem).Cells(1).Value
        Next
        t_qty = countqty
    End Sub


    Private Sub BTNPRINT_Click(sender As Object, e As EventArgs) Handles BTNPRINT.Click
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()  'Direct Print
    End Sub

    Private Sub BTREFRESH_Click(sender As Object, e As EventArgs)
        DataGridView1.AllowUserToAddRows = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles max.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub mini_Click(sender As Object, e As EventArgs) Handles mini.Click
        Me.WindowState = WindowState.Minimized
    End Sub
End Class
