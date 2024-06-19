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
            progressBar1 = new ProgressBar();
            lblOutput = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInput
            // 
            btnInput.BackColor = SystemColors.ControlLight;
            btnInput.Location = new Point(889, 77);
            btnInput.Margin = new Padding(7, 8, 7, 8);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(308, 63);
            btnInput.TabIndex = 0;
            btnInput.Text = "Input Location";
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            // 
            // btnOutput
            // 
            btnOutput.BackColor = SystemColors.ControlLight;
            btnOutput.Location = new Point(889, 282);
            btnOutput.Margin = new Padding(7, 8, 7, 8);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(308, 63);
            btnOutput.TabIndex = 1;
            btnOutput.Text = "Output Location";
            btnOutput.UseVisualStyleBackColor = false;
            btnOutput.Click += btnOutput_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(58, 77);
            txtInput.Margin = new Padding(7, 8, 7, 8);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(764, 47);
            txtInput.TabIndex = 2;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(58, 282);
            txtOutput.Margin = new Padding(7, 8, 7, 8);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(764, 47);
            txtOutput.TabIndex = 3;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.BackColor = SystemColors.ControlLight;
            btnSaveSettings.Location = new Point(379, 49);
            btnSaveSettings.Margin = new Padding(7, 8, 7, 8);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(250, 66);
            btnSaveSettings.TabIndex = 4;
            btnSaveSettings.Text = "Save Locations";
            btnSaveSettings.UseVisualStyleBackColor = false;
            btnSaveSettings.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(889, 435);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(308, 118);
            button1.TabIndex = 6;
            button1.Text = "Copy and Compress";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCopy_Click;
            // 
            // btnLoadSettings
            // 
            btnLoadSettings.BackColor = SystemColors.ControlLight;
            btnLoadSettings.Location = new Point(15, 49);
            btnLoadSettings.Margin = new Padding(7, 8, 7, 8);
            btnLoadSettings.Name = "btnLoadSettings";
            btnLoadSettings.Size = new Size(250, 66);
            btnLoadSettings.TabIndex = 7;
            btnLoadSettings.Text = "Load Locations";
            btnLoadSettings.UseVisualStyleBackColor = false;
            btnLoadSettings.Click += btnLoadSettings_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSaveSettings);
            groupBox1.Controls.Add(btnLoadSettings);
            groupBox1.Location = new Point(58, 410);
            groupBox1.Margin = new Padding(7, 8, 7, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(7, 8, 7, 8);
            groupBox1.Size = new Size(644, 142);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(250, 630);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(727, 41);
            progressBar1.TabIndex = 9;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(550, 709);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 41);
            lblOutput.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1268, 808);
            Controls.Add(lblOutput);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnOutput);
            Controls.Add(btnInput);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 8, 7, 8);
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
    }
}
