using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    public enum biomas
    {
        Desierto, Nevado, Selva
    }
    internal class MundoAbierto : VideoJuego
    {
        public float tamañomapa
        {
            get { return tamañomapa; }
            set
            {
                if (value >= 0)
                {
                    tamañomapa = value;
                }
                else
                {
                    Console.WriteLine("No pueden ser ingresados valores negativos");
                }
            }
        }
        public int numJefes
        {
            get { return numJefes; }
            set
            {
                if (value > 0)
                {
                    numJefes = value;
                }
                else
                {
                    Console.WriteLine("Debe de existir por lo menos un Jefe");
                }
            }
        }
        public biomas biomasgame { get;set;}    

        public void Lugar()
        {
            switch (biomasgame)
            {
                case biomas.Desierto:
                    Console.WriteLine("El mundo tiene " + tamañomapa+"m2, Iniciaste en el biomas "+biomasgame);
                    break;
                case biomas.Nevado:
                    Console.WriteLine("El mundo tiene " + tamañomapa + "m2, Iniciaste en el biomas " + biomasgame);
                    break;
                case biomas.Selva:
                    Console.WriteLine("El mundo tiene " + tamañomapa + "m2, Iniciaste en el biomas " + biomasgame);
                    break;
            }
        }
        public void Jefes()
        {
            if (numJefes >= 1)
                Console.WriteLine("Te costara encontrarlos");
            else if (numJefes >= 5)
                Console.WriteLine("Te tomara un MUY buen tiempo");
            else if (numJefes >= 10)
                Console.WriteLine("Olvidate de la vida social");
        }
    }
}
