using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsForms_TextReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            string fileName;
            string fileType;
            OpenFileDialog openedDialog = new OpenFileDialog();
            PDFParser pdfParser = new PDFParser();

            try
            {
                openedDialog.CheckFileExists = true;
                openedDialog.CheckPathExists = true;
                openedDialog.DefaultExt = "txt";
                openedDialog.DereferenceLinks = true;
                openedDialog.Filter = "PDF files (*.pdf)|*.pdf" + 
                "Text files (*.txt)|*.txt|" +
                "RTF files (*.rtf)|*.rtf|" +
                " + Works 6 and 7 (*.wps)|*.wps|" +
                "Windows Write (*.wri)|*.wri|" +
                "WordPerfect document (*.wpd)|*.wpd";
                openedDialog.Multiselect = false;
                openedDialog.RestoreDirectory = true;
                openedDialog.ShowHelp = true;
                openedDialog.ShowReadOnly = false;
                openedDialog.Title = "select a file ";
                openedDialog.ValidateNames = true;
                fileName = openedDialog.FileName.ToString();

                if (openedDialog.ShowDialog() == DialogResult.OK)
                {
                    fileType = fileName.Substring(fileName.Length-3, fileName.Length);
                    if (fileType == "pdf")
                    {
                        PdfReader pdfReader = new PdfReader(fileName);
                        for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                        { 
                            
                        }
                        pdfParser.ExtractText(fileName,
                        Path.GetFileNameWithoutExtension(fileName) + ".txt");
                        StreamReader sr = new StreamReader(fileName + ".txt");
                        rtxtbxBookText.Text = sr.ReadToEnd();
                    }
                    else {
                        StreamReader sr = new StreamReader(openedDialog.OpenFile());
                        rtxtbxBookText.Text = sr.ReadToEnd();
                    }
                    
                    
                    
                }

                
                

            }
            catch
            {
                MessageBox.Show("can not open the file", "Text to speech");
            }
        }

        private void btnReadBook_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer read = new SpeechSynthesizer();

            try
            {
                switch (cbxVoiceType.SelectedItem.ToString())
                {
                    case "Select a voice":

                        read.SelectVoiceByHints(VoiceGender.NotSet);
                        break;
                    case "Female":
                        read.SelectVoiceByHints(VoiceGender.Female);
                        break;
                    case "Male":
                        read.SelectVoiceByHints(VoiceGender.Male);
                        break;
                    case "Neutral":
                        read.SelectVoiceByHints(VoiceGender.Neutral);
                        break;
                }

                read.Volume = tbarVolume.Value;
                read.Rate = tbarRate.Value;
                read.SpeakAsync(rtxtbxBookText.Text);
            }
            catch {
                MessageBox.Show("can not read the book", "Book to speech");
            }
        }

        
    }
}
