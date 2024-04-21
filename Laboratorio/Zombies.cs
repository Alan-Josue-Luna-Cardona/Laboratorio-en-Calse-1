using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    public enum Armas
    {
        DeCerca, CortaDistancia, MediaDistancia, LargaDistancia
    }
    internal class Zombies : VideoJuego
    {
        public int numZom
        {
            get { return numZom; }
            set
            {
                if (value >= 0)
                {
                    numZom = value;
                }
                else
                {
                    Console.WriteLine("El número debe de ser positivo");
                }

            }
        }
public Armas armasgame { get; set; }
        public void Equipo()
        {
            switch (armasgame)
            {
                case Armas.DeCerca:
                    Console.WriteLine("Tienes munición infinita, más tienes que pelear cuerpo a cuerpo");
                    Thread.Sleep(200);
                    break;
                case Armas.CortaDistancia:
                    Console.WriteLine("Tienes 10 balas. Espera a que se acerquen");
                    break;
                case Armas.MediaDistancia:
                    Console.WriteLine("Tienes 30 balas. Más no tienes mucha presición");
                    break;
                case Armas.LargaDistancia:
                    Console.WriteLine("Tienes 5 balas. Tienes más daño y más precisión");
                    break;
            }
        }
        public void Peligro()
        {
            if (numZom >= 25)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("¡¡PELIGRO!!");
                Thread.Sleep(200);
                Console.Write("           ");
                Thread.Sleep(200);
                Console.WriteLine("Se acerca una horda preparate");
            }
            else
                Console.WriteLine("No son una horda, pero ten cuidado");
        }

    }
}
