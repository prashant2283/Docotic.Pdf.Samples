Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Windows.Forms

Imports Microsoft.VisualBasic

Imports BitMiracle.Docotic.Pdf

Namespace BitMiracle.Docotic.Pdf.Samples
    Public NotInheritable Class CompressWithSaveOptions
        Public Shared Sub Main()
            Const originalFile As String = "Sample Data\BRAILLE CODES WITH TRANSLATION.pdf"
            Const compressedFile As String = "CompressWithSaveOptions.pdf"

            ' NOTE: 
            ' When used in trial mode, the library imposes some restrictions.
            ' Please visit http://bitmiracle.com/pdf-library/trial-restrictions.aspx
            ' for more information.

            Using pdf As New PdfDocument(originalFile)
                pdf.SaveOptions.Compression = PdfCompression.Flate
                pdf.SaveOptions.UseObjectStreams = True
                pdf.SaveOptions.RemoveUnusedObjects = True
                pdf.SaveOptions.OptimizeIndirectObjects = True
                pdf.SaveOptions.WriteWithoutFormatting = True

                pdf.Save(compressedFile)
            End Using

            Dim message As String = String.Format(
                "Original file size: {0} bytes;" & vbCr & vbLf & "Compressed file size: {1} bytes",
                New FileInfo(originalFile).Length,
                New FileInfo(compressedFile).Length
            )
            MessageBox.Show(message)

            Process.Start(compressedFile)
        End Sub
    End Class
End Namespace