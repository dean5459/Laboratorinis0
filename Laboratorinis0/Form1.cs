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
        public string NuorodaModuliai = @"C:\Lab1\Moduliai.txt";
        public string NuorodaPaskaitos = @"C:\Lab1\Paskaitos.txt";
        public List<string> EilutesModuliai = new List<string>();
        public List<string> EilutesPaskaitos = new List<string>();
        public List<Modulis> Moduliai = new List<Modulis>();
        public List<Paskaita> Paskaitos = new List<Paskaita>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            EilutesModuliai = File.ReadAllLines(NuorodaModuliai).ToList();
            for(int i = 0; i < EilutesModuliai.Count; i++)
            {
                string[] items = EilutesModuliai[i].Split(',');
                foreach (string pask in EilutesPaskaitos)
                {
                    string[] item = pask.Split(',');
                    if (item[0] == items[0])
                    {
                        Paskaita p = new Paskaita(Int32.Parse(item[0]), Int32.Parse(item[1]));
                        Paskaitos.Add(p);
                    }
                }
                Modulis m = new Modulis(items[1], Paskaitos);
                Moduliai.Add(m);
            }
        }

        private void buttonPridetiModuli_Click(object sender, EventArgs e)
        {
            var NaujasLangas = new Form2();
            NaujasLangas.Show();
        }
    }
}
