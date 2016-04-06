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
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using System.util;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;



namespace WindowsForms_TextReader
{
    public partial class Form1 : Form
    {
        string textToRead;
        int state = 1; //1 = reading; 0 = paused;
        SpeechSynthesizer read = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openedDialog = new OpenFileDialog();
            PDFParser pdfParser = new PDFParser();
            StringBuilder sbText = new StringBuilder();

            try
            {
                openedDialog.CheckFileExists = true;
                openedDialog.CheckPathExists = true;
                openedDialog.DefaultExt = "txt";
                openedDialog.DereferenceLinks = true;
                openedDialog.Filter = "PDF files (*.pdf)|*.pdf|" +
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

                if (openedDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(openedDialog.FileName.ToString()) == ".pdf")
                    {
                        PdfReader pdfReader = new PdfReader(openedDialog.FileName.ToString());
                        for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                        {
                            ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                            string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                            currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
                            sbText.Append(currentText);
                        }
                        pdfReader.Close();
                        pdfParser.ExtractText(openedDialog.FileName.ToString(),
                        Path.GetFileNameWithoutExtension(openedDialog.FileName.ToString()) + ".txt");

                        
                        rtxtbxBookText.Text = sbText.ToString();
                    }

                    else
                    {
                        StreamReader sr = new StreamReader(openedDialog.OpenFile());
                        rtxtbxBookText.Text = sr.ReadToEnd();
                    }
                    textToRead = sbText.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnReadBook_Click(object sender, EventArgs e)
        {

            if (state == 1)
            {
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
                    read.SpeakAsync(textToRead);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message.ToString());
                }
            }
            else 
            {
                read.Resume();
            }
            //catch () {
            //   MessageBox.Show("can not read the book", "Book to speech");
            //}
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            read.Pause();
            state = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            read.SpeakAsyncCancelAll();
        }

        
    }
}
