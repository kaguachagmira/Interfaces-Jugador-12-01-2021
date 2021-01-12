namespace VideoJuego
{
    interface IAccion
    {
        public bool Correr(Personaje personaje);
        public bool Nadar(Personaje personaje);
        public bool Saltar(Personaje personaje);
    }
}
