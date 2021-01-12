using System;

namespace VideoJuego
{
    class Ataque : IAccion
    {
        public bool Correr(Personaje personaje)
        {
            Console.WriteLine("El personaje {0} esta caminando en modo ataque", personaje.Nombre);
            return true;
        }
        public bool Nadar(Personaje personaje)
        {
            Console.WriteLine("El personaje {0} esta nadando en modo ataque", personaje.Nombre);
            return true;
        }
        public bool Saltar(Personaje personaje)
        {
            Console.WriteLine("El personaje {0} esta saltando en modo ataque", personaje.Nombre);
            return true;
        }
    }
}
