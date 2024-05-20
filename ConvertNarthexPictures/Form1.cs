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
            lblOutput.Text = "";
            try
            {
                _inputURL = txtInput.Text;
                _outputURL = txtOutput.Text;

                string[] fileNames = Directory.GetFiles(_inputURL);
                int counter = 0;

                foreach (string fileName in fileNames)
                {
                    string newFilePath = String.Empty;
                    byte[] bytes = File.ReadAllBytes(fileName);
                    var newFile = _convertNarthexPicturesBusiness.ConvertPngToJpeg(bytes);
                    counter++;
                    newFilePath = $"{_outputURL}\\{counter}.jpeg";
                    _convertNarthexPicturesBusiness.WriteByteArrayToFile(newFilePath, newFile);
                }

                lblOutput.Text = "All Done!";
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }
    }
}
