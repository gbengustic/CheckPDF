using Google.Cloud.Vision.V1;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CheckPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAndExecuteBatch()
        {
            if (TxtPDFPath.Text == "") return;
            try
            {
                //This will create a new .bat file in the bat directory.
                StreamWriter file = new StreamWriter("test.bat");
                //The code below will write lines to the .bat file.
                //The dir command is used in a Command to list files in the specified directory.
                //The > command in this case sends the list to a text file.
                string c = Convert.ToChar(34).ToString();
                file.WriteLine(@"pdftotext.exe " + c + TxtPDFPath.Text + c);
                file.WriteLine("exit");
                file.Close();
                //The System.Dignostics.Process Process Class allows a Visual Studio Program
                //to execute another application
                Process proc = new Process();
                proc = new Process();
                proc.EnableRaisingEvents = false;
                //This line executes the .bat file created above.
                proc.StartInfo.FileName = "test.bat";
                proc.Start();
                proc.WaitForExit();
                TxtPdfText.Text = File.ReadAllText(TxtPDFPath.Text.ToLower().Replace(".pdf", ".txt"));
                if (TxtPdfText.Text.Length < 10)
                {
                    string value = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");
                    // Instantiates a client
                    var client = ImageAnnotatorClient.Create();
                    
                    Byte[] bytes = File.ReadAllBytes(TxtPDFPath.Text);
                    var content_byte = ByteString.CopyFrom(bytes);

                    var syncRequest = new AnnotateFileRequest
                    {
                        InputConfig = new InputConfig
                        {
                            Content = content_byte,
                            // Supported mime_types are: 'application/pdf' and 'image/tiff'
                            MimeType = "application/pdf"

                        }
                    };
                    syncRequest.Features.Add(new Feature
                    {
                        Type = Feature.Types.Type.DocumentTextDetection
                    });

                    List<AnnotateFileRequest> requests =
                        new List<AnnotateFileRequest>();
                    requests.Add(syncRequest);

                    var response = client.BatchAnnotateFiles(requests);
                    TxtPdfText.Text = response.Responses[0].Responses[0].FullTextAnnotation.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Pdf Files|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtPDFPath.Text = openFileDialog1.FileName;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            CreateAndExecuteBatch();
        }
    }
}
