namespace VideoJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccion accionPasiva = new Pasivo();
            IAccion accionAtaque = new Ataque();
            IAccion accionDefensa = new Defensa();
            //Juego juego = new Juego(accionPasiva);
            Juego juego = new Juego(accionAtaque);
            //Juego juego = new Juego(accionDefensa);
            
            Personaje personaje = new Personaje("Hulk");
            juego.MoverJugador(personaje);
        }

    }
}
