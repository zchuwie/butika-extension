Imports butika.Models
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports QRCoder
Imports System.IO

Friend Class Receipt
    Dim account As New Account()
    Dim document As New PdfDocument()
    Public documentPath As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
    Public Property fullPath As String

    Public Sub New(account As Account)
        Me.account = account
    End Sub

    'variables
    Dim boldtexts As New XFont("Arial", 25, XFontStyleEx.Bold)
    Dim totalbold As New XFont("Arial", 30, XFontStyleEx.Bold)
    Dim tablebold As New XFont("Arial", 15, XFontStyleEx.Bold)
    Dim regtexts As New XFont("Arial", 15, XFontStyleEx.Regular)
    Dim smalltexts As New XFont("Arial", 10, XFontStyleEx.Regular)

    Dim logo As XImage = XImage.FromFile("greenbglogo.png")
    Dim envelope As XImage = XImage.FromFile("envelope.png")

    Dim darkgreen As XBrush = New XSolidBrush(XColor.FromArgb(22, 66, 60))
    Dim white As XBrush = New XSolidBrush(XColor.FromArgb(255, 255, 255))

    Dim pagewidth As Double = 450
    Dim pageheight As Double = 842
    Dim columnWidth As Double = 125
    Dim rowHeight As Double = 20
    Dim tableTop As Double = 310
    Dim col1 As Double = 40, col2 As Double = 175, col3 As Double = 250, col4 As Double = 350

    Dim itemsOnPage As Integer = 0

    Public Sub PdfReceipt(itemReceipt As List(Of Cart), totalPrice As Decimal, transactionID As String, acc As Account)
        Dim filepath As String = Path.Combine(documentPath, $"ORID_{transactionID}.pdf")
        fullPath = Path.GetFullPath(filepath)

        'qrgenerator
        Dim qrCodeImage As XImage
        Using qrGenerator As New QRCodeGenerator()
            Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode($"Your TransactionID number: {transactionID}", QRCodeGenerator.ECCLevel.Q)
            Using qrCode As New QRCode(qrCodeData)
                Using qrBitmap As Bitmap = qrCode.GetGraphic(20)
                    Using ms As New MemoryStream()
                        qrBitmap.Save(ms, Imaging.ImageFormat.Png)
                        qrCodeImage = XImage.FromStream(ms)
                    End Using
                End Using
            End Using
        End Using

        Dim newpage As PdfPage = document.AddPage()
        newpage.Width = XUnitPt.FromPoint(pagewidth)
        newpage.Height = XUnitPt.FromPoint(pageheight)
        Dim gfx As XGraphics = XGraphics.FromPdfPage(newpage)

        'function
        Header(gfx, newpage, pagewidth, acc)
        tableTop += rowHeight
        For i As Integer = 0 To itemReceipt.Count - 1
            If itemsOnPage >= 15 Then
                Footer(gfx, newpage, qrCodeImage, transactionID)

                newpage = document.AddPage()
                newpage.Width = XUnitPt.FromPoint(pagewidth)
                newpage.Height = XUnitPt.FromPoint(pageheight)
                gfx = XGraphics.FromPdfPage(newpage)

                tableTop = 310 + rowHeight
                itemsOnPage = 0
                Header(gfx, newpage, pagewidth, acc)
            End If

            Dim item As Cart = itemReceipt(i)
            If item.Medicine.MedicineName.Length > 15 Then
                item.Medicine.MedicineName = item.Medicine.MedicineName.Substring(0, 15) & "..."
            End If
            gfx.DrawString($"{item.Medicine.MedicineName}", regtexts, darkgreen, New XRect(col1, tableTop, columnWidth, rowHeight), XStringFormats.TopLeft)
            gfx.DrawString($"{item.Quantity}", regtexts, darkgreen, New XRect(col2, tableTop, col3 - col2, rowHeight), XStringFormats.TopCenter)
            gfx.DrawString($"{item.Medicine.MedicinePrice:0.00}", regtexts, darkgreen, New XRect(col3, tableTop, col4 - col3, rowHeight), XStringFormats.TopCenter)
            gfx.DrawString($"{item.Medicine.MedicinePrice * item.Quantity}", regtexts, darkgreen, New XRect(col4, tableTop, 70, rowHeight), XStringFormats.TopRight)

            tableTop += rowHeight
            itemsOnPage += 1
        Next
        Total(gfx, tableTop, totalPrice)
        Footer(gfx, newpage, qrCodeImage, transactionID)

        document.Save(filepath)
    End Sub

    Public Sub OpenPDF()
        Try
            Dim psi As New ProcessStartInfo With {
            .FileName = fullPath,
            .UseShellExecute = True
        }
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Failed to open PDF: " & ex.Message)
        End Try
    End Sub

    Sub Header(graphics As XGraphics, page As PdfPage, pagewidth As Double, acc As Account)
        graphics.DrawRectangle(darkgreen, 0, 0, pagewidth, 240)
        graphics.DrawString($"Your receipt is here, {acc.UserName}!", boldtexts, white, New XRect(50, 15, pagewidth - 100, 30), XStringFormats.Center)

        Dim logo As XImage = XImage.FromFile("greenbglogo.png")
        graphics.DrawImage(logo, (pagewidth / 3) + 5, 45, 150, 150)

        graphics.DrawString($"We received your order. {DateTime.Now:d}", tablebold, white, New XRect(50, 185, pagewidth - 100, 50), XStringFormats.Center)
        graphics.DrawString("Thank you for using our system! We hope to improve your health easier.", boldtexts, white, New XRect(50, 200, pagewidth - 100, 50), XStringFormats.Center)

        graphics.DrawString("PAYMENT SUMMARY", tablebold, darkgreen, New XRect(30, 260, pagewidth - 100, 30), XStringFormats.TopLeft)
        graphics.DrawString("Item", tablebold, darkgreen, New XRect(40, 290, 125, 20), XStringFormats.TopLeft)
        graphics.DrawString("Quantity", tablebold, darkgreen, New XRect(175, 290, 125, 20), XStringFormats.TopLeft)
        graphics.DrawString("Price", tablebold, darkgreen, New XRect(250, 290, 70, 20), XStringFormats.TopRight)
        graphics.DrawString("Total Price", tablebold, darkgreen, New XRect(350, 290, 70, 20), XStringFormats.TopRight)
    End Sub

    Private Sub Total(graphics As XGraphics, tableTop As Double, totalAmount As Decimal)
        graphics.DrawString("TOTAL", totalbold, darkgreen, New XRect(30, tableTop + 20, 150, 40), XStringFormats.TopLeft)
        graphics.DrawString($"Php {totalAmount:0.00}", totalbold, darkgreen, New XRect(270, tableTop + 20, 150, 40), XStringFormats.TopRight)
    End Sub

    Private Sub Footer(graphics As XGraphics, page As PdfPage, qrCodeImage As XImage, transactionID As String)
        graphics.DrawRectangle(darkgreen, 0, 700, 450, 90)

        graphics.DrawImage(qrCodeImage, 70, 700, 90, 90)
        graphics.DrawString("Any questions?", boldtexts, white, New XRect(118, 725, 320, 40), XStringFormats.Center)
        graphics.DrawString("Reach us out through: butikaimnida@gmail.com", smalltexts, white, New XRect(115, 743, 330, 40), XStringFormats.Center)

        graphics.DrawString($"TransactionID: {transactionID}", tablebold, darkgreen, New XRect(50, 795, 350, 40), XStringFormats.Center)
    End Sub
End Class
