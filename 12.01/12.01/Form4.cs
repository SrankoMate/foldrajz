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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = null;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string feladat = "asd";
            string megoldas = "asd2";
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string feladat = "asd";
            string megoldas = "asd2";
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string feladat = "asd";
            string megoldas = "asd2";
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string feladat = "asd";
            string megoldas = "asd2";
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string feladat = "asd";
            string megoldas = "asd2";
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string feladat = "asd";
            string megoldas = "asd2";
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string feladat = "asd";
            string megoldas = "asd2";
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string feladat = "asd";
            string megoldas = "asd2";
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string feladat = "asd";
            string megoldas = "asd2";
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            string feladat = "asd";
            string megoldas = "asd2";
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
