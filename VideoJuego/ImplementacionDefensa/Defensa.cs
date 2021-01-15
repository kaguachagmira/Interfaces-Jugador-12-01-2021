using System;
using Entidades;
using Interfaces;
namespace ImplementacionDefensa
{
    public class Defensa : IAccion
    {
        public bool Correr(Personaje personaje)
        {
            Console.WriteLine("El personaje {0} esta caminando defensivamente", personaje.Nombre);
            return true;
        }
        public bool Nadar(Personaje personaje)
        {
            Console.WriteLine("El personaje {0} esta nadando defensivamente", personaje.Nombre);
            return true;
        }
        public bool Saltar(Personaje personaje)
        {
            Console.WriteLine("El personaje {0} esta saltando defensivamente", personaje.Nombre);
            return true;
        }
    }
}
