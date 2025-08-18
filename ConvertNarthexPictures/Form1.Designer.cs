namespace ConvertNarthexPictures
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnInput = new Button();
            btnOutput = new Button();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnSaveSettings = new Button();
            button1 = new Button();
            btnLoadSettings = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            btnDeleteInputFiles = new Button();
            progressBar1 = new ProgressBar();
            lblOutput = new Label();
            vers = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInput
            // 
            btnInput.BackColor = SystemColors.ControlLight;
            btnInput.Location = new Point(366, 28);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(127, 23);
            btnInput.TabIndex = 0;
            btnInput.Text = "Input Location";
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            // 
            // btnOutput
            // 
            btnOutput.BackColor = SystemColors.ControlLight;
            btnOutput.Location = new Point(366, 103);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(127, 23);
            btnOutput.TabIndex = 1;
            btnOutput.Text = "Output Location";
            btnOutput.UseVisualStyleBackColor = false;
            btnOutput.Click += btnOutput_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(24, 28);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(317, 23);
            txtInput.TabIndex = 2;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(24, 103);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(317, 23);
            txtOutput.TabIndex = 3;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.BackColor = SystemColors.ControlLight;
            btnSaveSettings.Location = new Point(156, 18);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(103, 24);
            btnSaveSettings.TabIndex = 4;
            btnSaveSettings.Text = "Save Locations";
            btnSaveSettings.UseVisualStyleBackColor = false;
            btnSaveSettings.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(366, 159);
            button1.Name = "button1";
            button1.Size = new Size(127, 43);
            button1.TabIndex = 6;
            button1.Text = "Copy and Compress";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCopy_Click;
            // 
            // btnLoadSettings
            // 
            btnLoadSettings.BackColor = SystemColors.ControlLight;
            btnLoadSettings.Location = new Point(6, 18);
            btnLoadSettings.Name = "btnLoadSettings";
            btnLoadSettings.Size = new Size(103, 24);
            btnLoadSettings.TabIndex = 7;
            btnLoadSettings.Text = "Load Locations";
            btnLoadSettings.UseVisualStyleBackColor = false;
            btnLoadSettings.Click += btnLoadSettings_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnDeleteInputFiles);
            groupBox1.Controls.Add(btnSaveSettings);
            groupBox1.Controls.Add(btnLoadSettings);
            groupBox1.Location = new Point(24, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 113);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.Location = new Point(6, 80);
            button3.Name = "button3";
            button3.Size = new Size(253, 24);
            button3.TabIndex = 9;
            button3.Text = "Delete All Files From Output Location";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnDeleteInputFiles
            // 
            btnDeleteInputFiles.BackColor = Color.MistyRose;
            btnDeleteInputFiles.Location = new Point(6, 51);
            btnDeleteInputFiles.Name = "btnDeleteInputFiles";
            btnDeleteInputFiles.Size = new Size(253, 24);
            btnDeleteInputFiles.TabIndex = 8;
            btnDeleteInputFiles.Text = "Delete All Files From Input Location";
            btnDeleteInputFiles.UseVisualStyleBackColor = false;
            btnDeleteInputFiles.Click += btnDeleteInputFiles_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(103, 253);
            progressBar1.Margin = new Padding(1);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(299, 15);
            progressBar1.TabIndex = 9;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(102, 268);
            lblOutput.Margin = new Padding(1, 0, 1, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 15);
            lblOutput.TabIndex = 10;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vers
            // 
            vers.AutoSize = true;
            vers.Location = new Point(462, 299);
            vers.Margin = new Padding(1, 0, 1, 0);
            vers.Name = "vers";
            vers.Size = new Size(0, 15);
            vers.TabIndex = 11;
            vers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(522, 342);
            Controls.Add(vers);
            Controls.Add(lblOutput);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnOutput);
            Controls.Add(btnInput);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Convert Narthex Pictures";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInput;
        private Button btnOutput;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnSaveSettings;
        private Button button1;
        private Button btnLoadSettings;
        private GroupBox groupBox1;
        private ProgressBar progressBar1;
        private Label lblOutput;
        private Button btnDeleteInputFiles;
        private Button button3;
        private Label vers;
    }
}
