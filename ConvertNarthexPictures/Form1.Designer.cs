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
            lblOutput = new Label();
            button1 = new Button();
            btnLoadSettings = new Button();
            SuspendLayout();
            // 
            // btnInput
            // 
            btnInput.Location = new Point(889, 60);
            btnInput.Margin = new Padding(7, 8, 7, 8);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(265, 90);
            btnInput.TabIndex = 0;
            btnInput.Text = "Input Location";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // btnOutput
            // 
            btnOutput.Location = new Point(889, 265);
            btnOutput.Margin = new Padding(7, 8, 7, 8);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(265, 90);
            btnOutput.TabIndex = 1;
            btnOutput.Text = "Output Location";
            btnOutput.UseVisualStyleBackColor = true;
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
            btnSaveSettings.Location = new Point(44, 459);
            btnSaveSettings.Margin = new Padding(7, 8, 7, 8);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(249, 66);
            btnSaveSettings.TabIndex = 4;
            btnSaveSettings.Text = "Save Locations";
            btnSaveSettings.UseVisualStyleBackColor = true;
            btnSaveSettings.Click += btnSave_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(622, 596);
            lblOutput.Margin = new Padding(7, 0, 7, 0);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 41);
            lblOutput.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(846, 432);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(308, 93);
            button1.TabIndex = 6;
            button1.Text = "Copy and Compress";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnLoadSettings
            // 
            btnLoadSettings.Location = new Point(373, 459);
            btnLoadSettings.Margin = new Padding(7, 8, 7, 8);
            btnLoadSettings.Name = "btnLoadSettings";
            btnLoadSettings.Size = new Size(249, 66);
            btnLoadSettings.TabIndex = 7;
            btnLoadSettings.Text = "Load Locations";
            btnLoadSettings.UseVisualStyleBackColor = true;
            btnLoadSettings.Click += btnLoadSettings_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 570);
            Controls.Add(btnLoadSettings);
            Controls.Add(button1);
            Controls.Add(lblOutput);
            Controls.Add(btnSaveSettings);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnOutput);
            Controls.Add(btnInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Convert Narthex Pictures";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInput;
        private Button btnOutput;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnSaveSettings;
        private Label lblOutput;
        private Button button1;
        private Button btnLoadSettings;
    }
}
