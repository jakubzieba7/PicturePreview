using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Tydz6_Zad2_PodglądZdjęcia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializePaths();
            InitializePicture();
        }

        private string _pictureFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PicturePath.txt");
        private void InitializePaths()
        {
            if (!File.Exists(_pictureFilePath))
            {
                File.Create(_pictureFilePath);
            }
            
            using (StreamReader readerPicturePath = new StreamReader(_pictureFilePath))
            {
                tbPicturePath.Text = readerPicturePath.ReadToEnd();
                readerPicturePath.Close();
            }
        }

        private void InitializePicture()
        {
            if (!string.IsNullOrEmpty(tbPicturePath.Text) && File.Exists(tbPicturePath.Text))
                pbPict.Image = Image.FromFile(tbPicturePath.Text);
            else
                SetOptionsWhenPictureIsNull();
        }

        private void btnPicBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)),
                Title = "Wyszukaj zdjęcie",
                CheckFileExists = true,
                CheckPathExists = true,
                FilterIndex = 5,
                RestoreDirectory = true,
            };

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string separator = string.Empty;

            foreach (var c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", string.Empty).Trim();
                openFileDialog1.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog1.Filter, separator, codecName, c.FilenameExtension);
                separator = "|";
            }

            openFileDialog1.Filter = String.Format("{0}{1}{2} ({3})|{3}", openFileDialog1.Filter, separator, "Wszystkie pliki", "*.*");

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPicturePath.Text = openFileDialog1.FileName;
            }

            SavePicturePath();

            pbPict.Image = Image.FromFile(tbPicturePath.Text);
            btnClearPicBox.Visible = true;
        }

        private void SavePicturePath()
        {
            using (StreamWriter writerPicturePath = new StreamWriter(_pictureFilePath))
            {
                writerPicturePath.Write(tbPicturePath.Text);
                writerPicturePath.Close();
            }
        }

        private void btnClearPicBox_Click(object sender, EventArgs e)
        {
            SetOptionsWhenPictureIsNull();
            SavePicturePath();
        }

        private void SetOptionsWhenPictureIsNull()
        {
            pbPict.Image = default(Image);
            tbPicturePath.Text = string.Empty;
            btnClearPicBox.Visible = false;
        }


    }
}
