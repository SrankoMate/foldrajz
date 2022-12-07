using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._01
{
    public partial class popup : Form
    {
        public popup(string megoldas,string feladat)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = null;
            megoldasrich.Text = megoldas;
            feladatbox.Text = feladat;
        }
        private void popup_Load(object sender, EventArgs e)
        {
        }
    }
}
