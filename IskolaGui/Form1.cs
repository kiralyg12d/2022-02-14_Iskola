using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IskolaGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.ReadAllLines("nevek.txt").ToList()
                .ForEach(sor => listBox1.Items.Add(sor));
        }

        private void btnTörlés_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Nem jelölt ki senkit!");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            
        }
    }
}
