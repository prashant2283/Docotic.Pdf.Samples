Imports System.Diagnostics

Imports BitMiracle.Docotic.Pdf

Namespace BitMiracle.Docotic.Pdf.Samples
    Public NotInheritable Class ExtractImages
        Public Shared Sub Main()
            ' NOTE: 
            ' When used in trial mode, the library imposes some restrictions.
            ' Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            ' for more information.

            Using pdf As New PdfDocument("Sample Data\gmail-cheat-sheet.pdf")
                For Each image As PdfImage In pdf.GetImages()
                    Dim imageFile As String = image.Save("ExtractedImage")
                    Process.Start(imageFile)

                    ' Only extract first image in this sample
                    Exit For
                Next
            End Using
        End Sub
    End Class
End Namespace