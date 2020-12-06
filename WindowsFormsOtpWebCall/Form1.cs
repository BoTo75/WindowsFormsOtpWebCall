using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsOtpWebCall.WebCall;

namespace WindowsFormsOtpWebCall
{
    public partial class Form1 : Form
    {
        private string _url = "";
        private string _baseUrl;
        public Form1()
        {
            InitializeComponent();
            _baseUrl = ConfigurationManager.AppSettings["RestApiUrl"];
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _url = "";
            FilelistBox.Items.Clear();
            foreach (var file in CreateCall(DestinationFolderTextBox.Text))
            {
                FilelistBox.Items.Add(file);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FilelistBox.Items.Clear();
            _url = downladTheFlileTextBox.Text;
            FilelistBox.Items.Add(CreateCall(DestinationFolderTextBox.Text).First());                
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            UploadListBox.Items.Add(openFileDialog1.FileName);
        }

        private void uploadBt_Click(object sender, EventArgs e)
        {            
            CreatePostCall(UploadListBox);
        }       

        private void FolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            DestinationFolderTextBox.Text = folderBrowserDialog1.SelectedPath;
        }



        private void CreatePostCall(ListBox uploadListBox)
        {
            File_info[] fileinfo = new File_info[uploadListBox.Items.Count];
            int i = 0;
            foreach (var file in uploadListBox.Items)
            {
                fileinfo[i] = new File_info {
                    filename = Path.GetFileName(file.ToString()),
                    contentInbase64 = Convert.ToBase64String(File.ReadAllBytes(file.ToString()))
                };
                i++;
            }
            uploadListBox.Items.Clear();
            WebCalls postCall = new WebCalls(_baseUrl);
            var result = postCall.PostFile(fileinfo);
            foreach (var info in result)
            {
                uploadListBox.Items.Add(string.Format("{0} --> {1}", info.Key, info.Value));
            }



        }

        private List<string> CreateCall(string path)
        {
            WebCalls webcall = new WebCalls(_baseUrl +"/"+ _url);
            var fileList = webcall.GetAllDocument();
            if(fileList.ContainsKey("*info"))
                return new List<string> { "nem létező állomány!!" };
            SaveFiles(fileList, path);
            return new List<string>(fileList.Keys);
        }

        private void SaveFiles(Dictionary<string, string> fileList, string path)
        {
            foreach (var file in fileList)
            {
                string fullFilename = Path.Combine(path, file.Key);
                if (!File.Exists(fullFilename))
                {
                    File.WriteAllBytes(fullFilename, Convert.FromBase64String(file.Value));
                }
            }
        }

        public string Base64Encode(string FullName)
        {
            return Convert.ToBase64String(File.ReadAllBytes(FullName));
        }       
    }
}
