using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Nota
    {
        public int NotaExamen { get; set; }
        public DateTime DiaExamen { get; set; }
        public bool Aprobada { get; set; }

        public Nota()
        {

        }

        public Nota(int nota)
        {
            NotaExamen = nota;
            Aprobada = nota > 5;
            DiaExamen = DateTime.Now;
        }
    }
}
