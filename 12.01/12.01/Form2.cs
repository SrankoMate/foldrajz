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
    public static class Kapcsolat
    {

        public static MySqlConnection kapcsolat = new MySqlConnection("server=localhost;user=root;port=3306;password=;database=foldrajz");
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string feladat = "Mi MADAGASZKÁR fővárosa? ";
            string sql1 = "SELECT fovaros, penznem FROM orszagok WHERE orszag LIKE 'MADAGASZKÁR'";
            MySqlCommand command_1 = new MySqlCommand(sql1, Kapcsolat.kapcsolat);
            MySqlDataReader read_1 = command_1.ExecuteReader();
            string megoldas = "";
            while (read_1.Read())
            {
                megoldas = read_1[0] + " " + read_1[1];
            }
            read_1.Close();
            panel1.Controls.Clear();
            popup frm = new popup(feladat,megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string feladat = "Mennyi az országok területe összesen?";
            string sql2 = "SELECT SUM(terulet) FROM orszagok";
            MySqlCommand command = new MySqlCommand(sql2, Kapcsolat.kapcsolat);
            MySqlDataReader read = command.ExecuteReader();
            string megoldas = "";
            while (read.Read())
            {
                megoldas = " \nLegidősebb: " + read[0] + " Legfiatalabb: " + read[1];
            }
            read.Close();
            panel1.Controls.Clear();
            popup frm = new popup(feladat,megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string feladat = "Hány lakosa van a Földnek?";
            string sql2 = "SELECT SUM(nepesseg*1000) FROM orszagok;";
            MySqlCommand command = new MySqlCommand(sql2, Kapcsolat.kapcsolat);
            MySqlDataReader read = command.ExecuteReader();
            string megoldas = "";
            while (read.Read())
            {
                megoldas = " \nLegidősebb: " + read[0] + " Legfiatalabb: " + read[1];
            }
            read.Close();
            panel1.Controls.Clear();
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string feladat = "Mennyi Japán népsűrűsége?";
            string sql2 = "SELECT nepesseg*1000/terulet AS 'Népsűrűség' FROM orszagok WHERE orszag LIKE 'Japán'";
            MySqlCommand command = new MySqlCommand(sql2, Kapcsolat.kapcsolat);
            MySqlDataReader read = command.ExecuteReader();
            string megoldas = "";
            while (read.Read())
            {
                megoldas = " \nLegidősebb: " + read[0] + " Legfiatalabb: " + read[1];
            }
            read.Close();
            panel1.Controls.Clear();
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string feladat = "Hányan laknak Máltán?";
            string sql2 = "SELECT nepesseg*1000 FROM orszagok WHERE orszag LIKE 'Málta'";
            MySqlCommand command = new MySqlCommand(sql2, Kapcsolat.kapcsolat);
            MySqlDataReader read = command.ExecuteReader();
            string megoldas = "";
            while (read.Read())
            {
                megoldas = " \nLegidősebb: " + read[0] + " Legfiatalabb: " + read[1];
            }
            read.Close();
            panel1.Controls.Clear();
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string feladat = "Mekkora területű Monaco?";
            string sql2 = "SELECT terulet FROM orszagok WHERE orszag LIKE 'Monaco'";
            MySqlCommand command = new MySqlCommand(sql2, Kapcsolat.kapcsolat);
            MySqlDataReader read = command.ExecuteReader();
            string megoldas = "";
            while (read.Read())
            {
                megoldas = " \nLegidősebb: " + read[0] + " Legfiatalabb: " + read[1];
            }
            read.Close();
            panel1.Controls.Clear();
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string feladat = "Melyik ország nemzetközi telefon-hívószáma a 61?";
            string sql2 = "SELECT orszag FROM orszagok WHERE telefon = 61";
            MySqlCommand command = new MySqlCommand(sql2, Kapcsolat.kapcsolat);
            MySqlDataReader read = command.ExecuteReader();
            string megoldas = "";
            while (read.Read())
            {
                megoldas = " \nLegidősebb: " + read[0] + " Legfiatalabb: " + read[1];
            }
            read.Close();
            panel1.Controls.Clear();
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string feladat = "Melyik ország pénzének jele az SGD?";
            string sql2 = "SELECT orszag FROM orszagok WHERE penznem LIKE 'SGD'";
            MySqlCommand command = new MySqlCommand(sql2, Kapcsolat.kapcsolat);
            MySqlDataReader read = command.ExecuteReader();
            string megoldas = "";
            while (read.Read())
            {
                megoldas = " \nLegidősebb: " + read[0] + " Legfiatalabb: " + read[1];
            }
            read.Close();
            panel1.Controls.Clear();
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string feladat = "Melyik ország autójele a TT?";
            string sql2 = "SELECT orszag FROM orszagok WHERE autojel LIKE 'TT'";
            MySqlCommand command = new MySqlCommand(sql2, Kapcsolat.kapcsolat);
            MySqlDataReader read = command.ExecuteReader();
            string megoldas = "";
            while (read.Read())
            {
                megoldas = " \nLegidősebb: " + read[0] + " Legfiatalabb: " + read[1];
            }
            read.Close();
            panel1.Controls.Clear();
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string feladat = "Melyik ország fővárosa OUAGADOUGOU?";
            string sql2 = "SELECT orszag FROM orszagok WHERE fovaros LIKE 'OUAGADOUGOU'";
            MySqlCommand command = new MySqlCommand(sql2, Kapcsolat.kapcsolat);
            MySqlDataReader read = command.ExecuteReader();
            string megoldas = "";
            while (read.Read())
            {
                megoldas = " \nLegidősebb: " + read[0] + " Legfiatalabb: " + read[1];
            }
            read.Close();
            panel1.Controls.Clear();
            popup frm = new popup(feladat, megoldas) { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
