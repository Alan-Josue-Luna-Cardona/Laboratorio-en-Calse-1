using LaboratorioProgra1.dificultad;
using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;

static void EjemploPolimorfismo()
{
    Animal[] animales = new Animal[3];
    animales[0] = new Tortuga();
    animales[1] = new Gato();
    animales[2] = new Perro();
    foreach (Animal animal in animales)
    {
        animal.HacerSonido();
    }
}   

//static void Laboratorio()
//{
//    VideoJuego videoJuego = new VideoJuego();
//    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
//    videoJuego.Desarrolladora = "Nintendo";
//    videoJuego.Calificacion = 50;
//    videoJuego.AnioLanzamiento = 2017;
//    videoJuego.MostrarInformacion();
//}
//Laboratorio();
VideoJuego videojuego = new VideoJuego();   

Zombies zombies1 = new Zombies();
zombies1.Titulo = "Left4Dead";
zombies1.Desarrolladora = "Valve";
zombies1.Calificacion = 10;
zombies1.AnioLanzamiento = 2008;
zombies1.numZom = 50;
zombies1.armasgame = Armas.DeCerca;
videojuego.VJZ.Add(zombies1);

MundoAbierto mundoabierto1 = new MundoAbierto();
mundoabierto1.Titulo = "GTAV";
mundoabierto1.Desarrolladora = "RockStar";
mundoabierto1.Calificacion = 9;
mundoabierto1.AnioLanzamiento = 2013;
mundoabierto1.tamañomapa = 5000;
mundoabierto1.biomasgame = biomas.Desierto;
videojuego.VJMA.Add(mundoabierto1);

Historia historia1 = new Historia();
Dificil dificil = new Dificil();
historia1.Titulo = "Prince of Persia";
historia1.Desarrolladora = "Ubisoft";
historia1.Calificacion = 8.5;
historia1.AnioLanzamiento = 1989;
historia1.capitulos = 7;
historia1.duración = 20;
videojuego.VJH.Add(historia1);

void iniciar()
{ 
    int op1=0;
    VideoJuego.saludo();
    do
    {
        Console.WriteLine("Selecciona una Opcion: \n1.Iniciar Left4Dead \n2.Iniciar GTAV \n3.Iniciar Prince of Persia \n4.Mostrar información de los Juegos \n5.Mostrar Lista de Juegos \n6.Finalizar los juegos ");
        op1 = int.Parse(Console.ReadLine());
        switch (op1)
        {
            case 1:
                zombies1.IniciarPartida();
                zombies1.Equipo();
                zombies1.Peligro();
                Console.WriteLine("-----------------------");
                break;
            case 2:
                mundoabierto1.IniciarPartida();
                mundoabierto1.Lugar();
                mundoabierto1.Jefes();
                Console.WriteLine("-----------------------");
                break;
            case 3:
                historia1.IniciarPartida();
                historia1.Caps();
                historia1.Aprox();
                dificil.dificultad();
                Console.WriteLine("-----------------------");
                break;
            case 4:
                zombies1.MostrarInformacion();
                Console.WriteLine("-----------------------");
                mundoabierto1.MostrarInformacion();
                Console.WriteLine("-----------------------");
                historia1.MostrarInformacion();
                Console.WriteLine("-----------------------");
                break;
            case 5:
                videojuego.Lista();
                break;
            case 6:
                videojuego.TerminarJuego();
                break;
        }
    } while (op1 != 6);
}

iniciar();

//Laboratorio();
//VideoJuego.listaDeJuegos();



