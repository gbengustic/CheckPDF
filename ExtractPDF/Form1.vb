Imports System.IO
Imports Google.Cloud.Vision.V1
Imports Google.Protobuf

Public Class Form1
    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        openFileDialog1.Filter = "Pdf Files|*.pdf"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            TxtPDFPath.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        CreateAndExecuteBatch()
    End Sub
    Private Sub CreateAndExecuteBatch()
        If TxtPDFPath.Text = "" Then Return

        Try
            Dim ffile As StreamWriter = New StreamWriter("test.bat")
            Dim c As String = Convert.ToChar(34).ToString()
            ffile.WriteLine("pdftotext.exe " & c & TxtPDFPath.Text & c)
            ffile.WriteLine("exit")
            ffile.Close()
            Dim proc As Process = New Process()
            proc = New Process()
            proc.EnableRaisingEvents = False
            proc.StartInfo.FileName = "test.bat"
            proc.Start()
            proc.WaitForExit()
            TxtPdfText.Text = File.ReadAllText(TxtPDFPath.Text.ToLower().Replace(".pdf", ".txt"))

            If TxtPdfText.Text.Length < 10 Then
                Dim value As String = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS")
                Dim client = ImageAnnotatorClient.Create()
                Dim bytes As Byte() = file.ReadAllBytes(TxtPDFPath.Text)
                Dim content_byte = ByteString.CopyFrom(bytes)
                Dim syncRequest = New AnnotateFileRequest With {
                    .InputConfig = New InputConfig With {
                        .Content = content_byte,
                        .MimeType = "application/pdf"
                    }
                }
                syncRequest.Features.Add(New Feature With {
                    .Type = Feature.Types.Type.DocumentTextDetection
                })
                Dim requests As List(Of AnnotateFileRequest) = New List(Of AnnotateFileRequest)()
                requests.Add(syncRequest)
                Dim response = client.BatchAnnotateFiles(requests)
                TxtPdfText.Text = response.Responses(0).Responses(0).FullTextAnnotation.Text
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class
