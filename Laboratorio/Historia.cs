using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    internal class Historia : VideoJuego
    {
        public int capitulos
        {
            get { return capitulos; }
            set
            {
                if (value > 0)
                {
                    capitulos = value;
                }
                else
                {
                    Console.WriteLine("El juego debe de tener por lo menos un capitulo");
                }
            }
        }
        public int duración
        {
            get { return duración; }
            set
            {
                if (value > 0)
                {
                    duración = value;
                }
                else
                {
                    Console.WriteLine("El juego no puedo durar menos de una hora");
                }
            }
        }

        public void Caps()
        {
            if (capitulos >= 1)
            {
                Console.WriteLine("El juego tiene " + capitulos + " Capitulos");
                Console.WriteLine("Esto sera sencillo");
            }
            else if (capitulos >= 5)
            {
                Console.WriteLine("El juego tiene " + capitulos + " Capitulos");
                Console.WriteLine("Te tardaras un tiempo");
            }
            else if (capitulos >= 10)
            {
                Console.WriteLine("El juego tiene " + capitulos + " Capitulos");
                Console.WriteLine("No es para hacer un SpeedRun");
            }
        }

        public void Aprox()
        {
            Console.WriteLine("Te tardaras un aproximado de: " + duración+".h");
        }

        public virtual void dificultad ()
        { Console.WriteLine("La dificultad es Prederminad"); }
    }
}
