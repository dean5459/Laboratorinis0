using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorinis0
{
    public partial class Form1 : Form
    {
        public string Nuoroda = @"C:\Lab1\Moduliai.txt";
        public List<string> Eilutes = new List<string>();
        public List<Modulis> Moduliai = new List<Modulis>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Eilutes = File.ReadAllLines(Nuoroda).ToList();
            foreach(string line in Eilutes)
            {
                string[] items = line.Split(',');
                Modulis m = new Modulis(items[0],);
            }
        }

        private void buttonPridetiModuli_Click(object sender, EventArgs e)
        {
            var NaujasLangas = new Form2();
            NaujasLangas.Show();
        }
    }
}
