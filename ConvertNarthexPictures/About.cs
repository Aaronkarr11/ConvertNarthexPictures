using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertNarthexPictures
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            lblCR.Text = $"© {System.DateTime.Now.Year}";

            Assembly assembly = Assembly.GetExecutingAssembly();
            Version version = assembly.GetName().Version;
            vers.Text = $"Version {version}";
        }

    }
}
