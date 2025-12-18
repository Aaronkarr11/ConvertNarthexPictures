using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertNarthexPictures
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.txtHelp.Text = "Input Location: This is the location where the source images should be stored\r\n\r\nOutput Location: This is the location where the images are compressed\r\n\r\nSave Locations: Save your input and output locations\r\n\r\nLoad Locations: Load the locations that were saved\r\n\r\nDelete All Files From Input Location: Deletes the files (if any) from the input location\r\n\r\nDelete All Files From Output Location: Deletes the files (if any) from the output location\r\n\r\nCopy and Compress: Compresses and copies the files\r\n";

        }
    }
}
