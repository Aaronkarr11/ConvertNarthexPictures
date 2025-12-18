namespace ConvertNarthexPictures
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            label1 = new Label();
            lblCR = new Label();
            vers = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 0;
            label1.Text = "Aaron Karr - Made with Love <3";
            // 
            // lblCR
            // 
            lblCR.AutoSize = true;
            lblCR.Location = new Point(8, 9);
            lblCR.Name = "lblCR";
            lblCR.Size = new Size(0, 15);
            lblCR.TabIndex = 1;
            // 
            // vers
            // 
            vers.AutoSize = true;
            vers.Location = new Point(8, 35);
            vers.Margin = new Padding(1, 0, 1, 0);
            vers.Name = "vers";
            vers.Size = new Size(0, 15);
            vers.TabIndex = 12;
            vers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 65);
            Controls.Add(vers);
            Controls.Add(lblCR);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "About";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCR;
        private Label vers;
    }
}