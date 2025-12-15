using System.Reflection;
using System.Text.Json;
using System.Web;

namespace ConvertNarthexPictures
{
    public partial class Form1 : Form
    {
        private string _inputURL;
        private string _outputURL;
        private IConvertNarthexPicturesBusiness _convertNarthexPicturesBusiness;

        public Form1()
        {
            _convertNarthexPicturesBusiness = new ConvertNarthexPicturesBusiness();
            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();
            Version version = assembly.GetName().Version;
            vers.Text = $"v{version}";

            progressBar1.Visible = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtInput.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtOutput.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            lblOutput.Text = "";
            try
            {
                _inputURL = txtInput.Text;
                _outputURL = txtOutput.Text;

                string[] fileNames = Directory.GetFiles(_inputURL);
                int counter = 0;
                int totalFiles = fileNames.Count();

                if (totalFiles < 10)
                {
                    progressBar1.Maximum = 10;
                }

                foreach (string fileName in fileNames)
                {
                    string newFilePath = String.Empty;
                    byte[] bytes = File.ReadAllBytes(fileName);
                    var newFile = _convertNarthexPicturesBusiness.ConvertPngToJpeg(bytes);
                    counter++;
                    newFilePath = $"{_outputURL}\\{counter}.jpeg";
                    _convertNarthexPicturesBusiness.WriteByteArrayToFile(newFilePath, newFile);
                    RenderLoadingBar(totalFiles, counter);

                }
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        private void RenderLoadingBar(int total, int current)
        {
            progressBar1.PerformStep();
            if (total == current)
            {
                lblOutput.Text = "All Done! 😊";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.InputLocation = txtInput.Text;
            settings.OutputLocation = txtOutput.Text;

            string jsonString = JsonSerializer.Serialize(settings);
            _convertNarthexPicturesBusiness.WriteSettings(jsonString);
        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            Settings settings = _convertNarthexPicturesBusiness.ReadSettings();
            txtInput.Text = settings.InputLocation;
            txtOutput.Text = settings.OutputLocation;
        }

        private void btnDeleteInputFiles_Click(object sender, EventArgs e)
        {
            var result = _convertNarthexPicturesBusiness.DeleteFileContentsOfDirectory(txtInput.Text);
            lblOutput.Text = result;
        }

        private void btnDeleteOutputFiles_Click(object sender, EventArgs e)
        {
            var result = _convertNarthexPicturesBusiness.DeleteFileContentsOfDirectory(txtOutput.Text);
            lblOutput.Text = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            var n = new Help();
            n.Show();
        }
    }
}
