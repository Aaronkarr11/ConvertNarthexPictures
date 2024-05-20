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
            btnCopy = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // btnInput
            // 
            btnInput.Location = new Point(366, 22);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(109, 33);
            btnInput.TabIndex = 0;
            btnInput.Text = "Input Location";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // btnOutput
            // 
            btnOutput.Location = new Point(366, 97);
            btnOutput.Name = "btnOutput";
            btnOutput.Size = new Size(109, 33);
            btnOutput.TabIndex = 1;
            btnOutput.Text = "Output Location";
            btnOutput.UseVisualStyleBackColor = true;
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
            // btnCopy
            // 
            btnCopy.Location = new Point(214, 158);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(127, 36);
            btnCopy.TabIndex = 4;
            btnCopy.Text = "Copy and Compress";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(256, 218);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 15);
            lblOutput.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 255);
            Controls.Add(lblOutput);
            Controls.Add(btnCopy);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnOutput);
            Controls.Add(btnInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button btnCopy;
        private Label lblOutput;
    }
}
