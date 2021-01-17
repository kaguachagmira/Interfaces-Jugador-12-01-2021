using Negocio;
using Entidades;
using Interfaces;
using ImplementacionAtaque;
using ImplementacionPasiva;
using ImplementacionDefensa;
using System;
using Ninject;

namespace VideoJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcion = 0;
           
            /* Usados para inyección sin Ninject
            IAccion accionPasiva = new Pasivo();
            IAccion accionAtaque = new Ataque();
            IAccion accionDefensa = new Defensa();*/

            do
            {
                Console.Clear();
                Console.WriteLine("**************************");
                Console.WriteLine("*    Kevin Guachagmira   *");
                Console.WriteLine("*       14/01/2021       *");
                Console.WriteLine("*       INYECCION DE     *");
                Console.WriteLine("*       DEPENDENCIAS     *");
                Console.WriteLine("*          EN C#         *");
                Console.WriteLine("**************************");
                Console.WriteLine("(1) Personaje Elder");
                Console.WriteLine("(2) Personaje Imperius");
                Console.WriteLine("(3) Personaje Sniper");
                Console.WriteLine("(4) Personaje Kael");
                Console.WriteLine("(5) Personaje Orfea");
                Console.WriteLine("(6) Personaje Muradin");
                Console.WriteLine("(7) Salir");
                Console.WriteLine("Seleccione una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Seleccionaste el personaje Elder");
                        var kernel = new StandardKernel();
                        Personaje elder = new Personaje("Elder");
                        kernel.Bind<IAccion>().To<Ataque>();
                        var juegoAtaqueElder = kernel.Get<Juego>();
                        juegoAtaqueElder.MoverJugador(elder);
                        Program.PresionarYSalir();
                        break;
                    case 2:
                        var kernel1 = new StandardKernel();
                        Console.WriteLine("Seleccionaste el personaje Imperius");
                        Personaje imperius = new Personaje("Imperius");
                        kernel1.Bind<IAccion>().To<Defensa>();
                        var juegoDefensaImperius = kernel1.Get<Juego>();
                        juegoDefensaImperius.MoverJugador(imperius);
                        Program.PresionarYSalir();
                        break;
                    case 3:
                        var kernel2 = new StandardKernel();
                        Console.WriteLine("Seleccionaste el personaje Sniper");
                        Personaje sniper = new Personaje("Sniper");
                        kernel2.Bind<IAccion>().To<Pasivo>();
                        var juegoPasivoSniper = kernel2.Get<Juego>();
                        juegoPasivoSniper.MoverJugador(sniper);
                        Program.PresionarYSalir();
                        break;
                    case 4:
                        var kernel3 = new StandardKernel();
                        Console.WriteLine("Seleccionaste el personaje Kael");
                        Personaje kael = new Personaje("Kael");
                        kernel3.Bind<IAccion>().To<Ataque>();
                        var juegoAtaqueKael = kernel3.Get<Juego>();
                        juegoAtaqueKael.MoverJugador(kael);
                        Program.PresionarYSalir();
                        break;
                    case 5:
                        var kernel4 = new StandardKernel();
                        Console.WriteLine("Seleccionaste el personaje Orfea");
                        Personaje orfea = new Personaje("Orfea");
                        kernel4.Bind<IAccion>().To<Ataque>();
                        var juegoAtaqueOrfea = kernel4.Get<Juego>();
                        juegoAtaqueOrfea.MoverJugador(orfea);
                        Program.PresionarYSalir();
                        break;
                    case 6:
                        var kernel5 = new StandardKernel();
                        Console.WriteLine("Seleccionaste el personaje Muradin");
                        Personaje muradin = new Personaje("Imperius");
                        kernel5.Bind<IAccion>().To<Ataque>();
                        var juegoDefensaMuradin = kernel5.Get<Juego>();
                        juegoDefensaMuradin.MoverJugador(muradin);
                        Program.PresionarYSalir();
                        break;
                    case 7:
                        Console.WriteLine("Muchas gracias por usar este programita");
                        Program.PresionarYSalir();
                        opcion = 7;
                        break;
                    default:
                        Console.WriteLine("La opción escogida no esta dentro del menú vuelve a digitarlo porfavor");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != 7);
        }

        public static void PresionarYSalir()
        {
            Console.WriteLine("Presiona una tecla para continuar");
            Console.ReadLine();
        }
    }

}
