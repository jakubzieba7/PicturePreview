using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tydz6_Zad2_PodglądZdjęcia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializePaths();
        }

        private void btnPicLoad_Click(object sender, EventArgs e)
        {

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

    }
}
