using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace iedereenkanschilderen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            Createfile();
            MessageBox.Show("succesvol gecreeerd....");
            OpenFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            string filename = txbSaveFileName.Text + ".txt";

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter(filename))
            {
                string content = txbContent.Text;
                sw.Write(content);
            }

            /*string content = txbContent.Text;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();   
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.ShowDialog();
            banaan
                if (saveFileDialog1.FileName != "")
                {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
            }*/
        }
        private void Createfile()
        {
            using (FolderBrowserDialog Browse = new FolderBrowserDialog())
            {
                Browse.ShowDialog();
                string path = Browse.SelectedPath;
                string file = "\\" + txbNameFile.Text + ".txt";
                string pathfile = path + file;
                using (FileStream fs = File.Create(pathfile))
                {
                    //Byte[] info = new UTF8Encoding(true).GetBytes("");
                    // Add some information to the file.
                    //fs.Write(info, 0, info.Length);
                }
            }
        }
        private void OpenFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file    
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        txbContent.Text = fileContent;

                    }
                }
            }
        }
    }

}
