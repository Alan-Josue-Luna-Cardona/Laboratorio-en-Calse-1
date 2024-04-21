using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    /// <summary>
    /// Esta Clase Padre tiene 4 errores lógicos
    /// debe de encontrarlos y corregirlos
    /// documente los errores encontrados y las correcciones realizadas
    /// </summary>
    internal class VideoJuego
    {
        private string titulo;
        private string desarrolladora;
        private double calificacion;
        private int anioLanzamiento;
        private bool jugando =false;
        public List<Zombies>VJZ{ get; set; }
        public List<MundoAbierto> VJMA { get; set; }
        public List<Historia> VJH { get; set; }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Desarrolladora
        {
            get { return desarrolladora; }
            set { desarrolladora = value; }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
               
                if (value >= 0 && value <= 10)
                {
                    calificacion = value;
                } else
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 10");
                }

            }
        }

        public int AnioLanzamiento
        {
            get { return anioLanzamiento; }
            set
            {
                if (value <= 2024)
                {
                    anioLanzamiento = value;
                }
                else
                {
                    Console.WriteLine("El año debe de ser anterior o igual a 2024");
                }
            }
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Desarrolladora: " + Desarrolladora);
            Console.WriteLine("Calificación: " + Calificacion);
            Console.WriteLine("Año de Lanzamiento: " + AnioLanzamiento);
        }

        public static void saludo()
        {
            Console.WriteLine("Hi Gamer:");
        }


        public void IniciarPartida()
        {
            jugando = true;
            Console.WriteLine("¡Partida iniciada!");
        }

        public void DetenerPartida()
        {
            // Error lógico
            jugando = false;
            Console.WriteLine("Partida detenida.");
        }

        public void TerminarJuego()
        {
            // Error lógico
            if (jugando)
            {
                DetenerPartida();
            }
            else
            {
                Console.WriteLine("No hay partida en curso.");
            }
        }
        public void Lista()
        {
            Console.WriteLine(VJZ);
            Console.WriteLine(VJMA);
            Console.WriteLine(VJH);
        }
    }
}
