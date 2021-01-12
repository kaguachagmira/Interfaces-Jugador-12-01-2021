namespace VideoJuego
{
    class Juego
    {
        IAccion accion;
        public Juego(IAccion accion)
        {
            this.accion = accion;
        }
        internal void MoverJugador(Personaje personaje)
        {
            accion.Correr(personaje);
            accion.Nadar(personaje);
            accion.Saltar(personaje);
        }
    }
}
