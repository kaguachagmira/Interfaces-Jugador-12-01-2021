using Entidades;

namespace Interfaces
{
    public interface IAccion
    {
         bool Correr(Personaje personaje);
         bool Nadar(Personaje personaje);
         bool Saltar(Personaje personaje);
    }
}
