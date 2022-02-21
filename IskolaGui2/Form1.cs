using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IskolaGui2
{
    public partial class Form1 : Form
    {
        List<Tanulo> tanulok = new List<Tanulo>();
        BindingSource bs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKilépés_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBetöltés_Click(object sender, EventArgs e)
        {
            foreach (var sor in File.ReadAllLines("nevek.txt"))
            {
                tanulok.Add(new Tanulo(sor));
            }
            bs = new BindingSource();
            bs.DataSource = tanulok;
            listBox1.DataSource = bs;
            listBox1.DisplayMember = "nev";
        }

        private void btnTörlés_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nem jelöltek semmit.");

            }
            else
            {
                tanulok.RemoveAt(listBox1.SelectedIndex);
                bs.ResetBindings(false);
            }
        }

        private void btnMentés_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("nevek.txt");
                sw.WriteLine(tanulok[listBox1.SelectedIndex].ToString());
                sw.Close();
                MessageBox.Show($"Sikeres mentés!");
            }
            catch (Exception error)
            {

                MessageBox.Show($"Hiba a mentés során:\n{error.Message}");
            }
        }
    }
}
