namespace ConvertNarthexPictures
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            txtHelp = new RichTextBox();
            SuspendLayout();
            // 
            // txtHelp
            // 
            txtHelp.Enabled = false;
            txtHelp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtHelp.Location = new Point(5, 6);
            txtHelp.Name = "txtHelp";
            txtHelp.Size = new Size(383, 277);
            txtHelp.TabIndex = 0;
            txtHelp.Text = "";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 289);
            Controls.Add(txtHelp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Help";
            Text = "Help";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtHelp;
    }
}