using Entidades;
using Interfaces;

namespace Negocio
{
    public class Juego
    {
        IAccion accion;
        public Juego(IAccion accion)
        {
            this.accion = accion;
        }
        public  void MoverJugador(Personaje personaje)
        {
            accion.Correr(personaje);
            accion.Nadar(personaje);
            accion.Saltar(personaje);
        }
    }
}
