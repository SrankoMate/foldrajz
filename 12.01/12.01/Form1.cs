using MySqlConnector;
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
    public partial class Form1 : Form
    {
        public static class Kapcsolat
        {

            public static MySqlConnection kapcsolat = new MySqlConnection("server=localhost;user=root;port=3306;password=;database=foldrajz");
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kapcsolat.kapcsolat.Open();
        }

        private void button1_Click(object sender, EventArgs e) //1-10
        {
            panel1.Controls.Clear();
            Form2 frm = new Form2() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e) // 11-20
        {
            panel1.Controls.Clear();
            Form3 frm = new Form3() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e) //21-30
        {
            panel1.Controls.Clear();
            Form4 frm = new Form4() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e) //31-40
        {
            panel1.Controls.Clear();
            Form5 frm = new Form5() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e) // 41-50
        {
            panel1.Controls.Clear();
            Form6 frm = new Form6() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e) // 51-60
        {
            panel1.Controls.Clear();
            Form7 frm = new Form7() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
