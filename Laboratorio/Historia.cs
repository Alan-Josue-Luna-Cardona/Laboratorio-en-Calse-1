using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    internal class Historia : VideoJuego
    {
        public int capitulos { get; set; }
        public float duración { get; set; }

        public void Caps()
        {
            if (capitulos >= 1)
                Console.WriteLine("Esto sera sencillo");
            else if (capitulos >= 5)
                Console.WriteLine("Te tardaras un tiempo");
            else if (capitulos >= 10)
                Console.WriteLine("No es para hacer un SpeedRun");
        }

        public void Aprox()
        {
            Console.WriteLine("Te tardaras un aproximado de: " + duración);
        }

        public virtual void dificultad ()
        { Console.WriteLine("La dificultad es Prederminad"); }
    }
}
