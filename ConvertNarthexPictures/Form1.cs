using System.Text.Json;

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

    }
}
