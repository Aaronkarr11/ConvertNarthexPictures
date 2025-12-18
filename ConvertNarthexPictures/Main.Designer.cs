namespace ConvertNarthexPictures
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btnInput = new Button();
            btnOutput = new Button();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnSaveSettings = new Button();
            button1 = new Button();
            btnLoadSettings = new Button();
            groupBox1 = new GroupBox();
            btnDeleteOutputFiles = new Button();
            btnDeleteInputFiles = new Button();
            progressBar1 = new ProgressBar();
            lblOutput = new RichTextBox();
            label1 = new Label();
            helpbtn = new Button();
            btnAbout = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInput
            // 
            btnInput.BackColor = SystemColors.ControlLight;
            btnInput.Location = new Point(377, 55);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(133, 23);
            btnInput.TabIndex = 0;
            btnInput.Text = "Input Location";
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            // 
            // btnOutput
            // 
            btnOutput.BackColor = SystemColors.ControlLight;
            btnOutput.Location = new Point(377, 103);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(133, 23);
            btnOutput.TabIndex = 1;
            btnOutput.Text = "Output Location";
            btnOutput.UseVisualStyleBackColor = false;
            btnOutput.Click += btnOutput_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(24, 55);
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
            button1.Location = new Point(377, 159);
            button1.Name = "button1";
            button1.Size = new Size(133, 43);
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
            groupBox1.Controls.Add(btnDeleteOutputFiles);
            groupBox1.Controls.Add(btnDeleteInputFiles);
            groupBox1.Controls.Add(btnSaveSettings);
            groupBox1.Controls.Add(btnLoadSettings);
            groupBox1.Location = new Point(24, 136);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 113);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // btnDeleteOutputFiles
            // 
            btnDeleteOutputFiles.BackColor = Color.MistyRose;
            btnDeleteOutputFiles.Location = new Point(6, 80);
            btnDeleteOutputFiles.Name = "btnDeleteOutputFiles";
            btnDeleteOutputFiles.Size = new Size(253, 24);
            btnDeleteOutputFiles.TabIndex = 9;
            btnDeleteOutputFiles.Text = "Delete All Files From Output Location";
            btnDeleteOutputFiles.UseVisualStyleBackColor = false;
            btnDeleteOutputFiles.Click += btnDeleteOutputFiles_Click;
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
            progressBar1.Location = new Point(103, 258);
            progressBar1.Margin = new Padding(1);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(299, 15);
            progressBar1.TabIndex = 9;
            // 
            // lblOutput
            // 
            lblOutput.Enabled = false;
            lblOutput.Location = new Point(24, 298);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(469, 59);
            lblOutput.TabIndex = 12;
            lblOutput.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 280);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 13;
            label1.Text = "Output:";
            label1.Click += label1_Click;
            // 
            // helpbtn
            // 
            helpbtn.BackColor = SystemColors.ActiveCaption;
            helpbtn.Location = new Point(377, 8);
            helpbtn.Name = "helpbtn";
            helpbtn.Size = new Size(58, 23);
            helpbtn.TabIndex = 14;
            helpbtn.Text = "Help";
            helpbtn.UseVisualStyleBackColor = false;
            helpbtn.Click += helpbtn_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.CadetBlue;
            btnAbout.Location = new Point(452, 8);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(58, 23);
            btnAbout.TabIndex = 15;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(522, 388);
            Controls.Add(btnAbout);
            Controls.Add(helpbtn);
            Controls.Add(label1);
            Controls.Add(lblOutput);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnOutput);
            Controls.Add(btnInput);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
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
        private Button btnDeleteInputFiles;
        private Button btnDeleteOutputFiles;
        private RichTextBox lblOutput;
        private Label label1;
        private Button helpbtn;
        private Button btnAbout;
    }
}
