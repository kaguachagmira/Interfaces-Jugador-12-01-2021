using System;

namespace VideoJuego
{
    class Pasivo : IAccion
    {
        public bool Correr(Personaje personaje)
        {
            Console.WriteLine("El personaje {0} esta caminando", personaje.Nombre);
            return true;
        }
        public bool Nadar(Personaje personaje)
        {
            Console.WriteLine("El personaje {0} esta nadando", personaje.Nombre);
            return true;
        }
        public bool Saltar(Personaje personaje)
        {
            Console.WriteLine("El personaje {0} esta saltando", personaje.Nombre);
            return true;
        }
    }
}
