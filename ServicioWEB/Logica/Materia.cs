using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Nota> Notas { get; set; }
        public bool EnElPlan { get; set; }

        public Materia()
        {

        }

        public Materia(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            EnElPlan = true;

            Random rnd = new Random();

            Notas = new List<Nota>()
            {
                new Nota(rnd.Next(0,11)),
                new Nota(rnd.Next(0,11)),
                new Nota(rnd.Next(0,11)),
            };
        }

        public List<Nota> ObtenerNotas()
        {
            return Notas;
        }
    }
}
