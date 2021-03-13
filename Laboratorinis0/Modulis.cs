using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorinis0
{
    public class Modulis
    {
        public string Pavadinimas;
        public List<Paskaita> Paskaitos;

        public Modulis(string Pavadinimas, List<Paskaita> Paskaitos)
        {
            this.Pavadinimas = Pavadinimas;
            this.Paskaitos = Paskaitos;
        }

        public float Vidurkis()
        {
            float sum = 0;
            foreach (Paskaita paskaita in Paskaitos)
            {
                sum += paskaita.Balas;
            }
            return sum / Paskaitos.Count;
        }
    }
}
