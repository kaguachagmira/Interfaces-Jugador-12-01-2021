# 12-01-2021-Usar un framework de Inyección de dependencias  y aplicarlo en acciones que un jugador tomar en un videjuego.

# Asignatura: Programación Visual

# Docente: Magister Gorky Estrella

# Nombre: Kevin Alexander Guachagmira Mantilla

# Fecha : 12-01-2021

# Actividad: Realizar un programa que Inyecte dependencias de accion a un jugador de un videojuego crear 6 personajes e inyectar a cada uno un comportamiento diferente


## Separación por capas modelo inversión de control
# UI  -> Programas.cs 
## Negocio -> Juego.cs

public Juego(IAccion accion)

El constructor recibe como parametro una interfaz como inyeccion de dependencia.

public  void MoverJugador(Personaje personaje)

El método Mover jugador recibe como parametro un personaje y mediante la interfaz inyectada
se da al jugador diferentes acciones acorde a su interfaz inyectada.
 

### Interfaces -> IAccion.cs 

public interface IAccion

         bool Correr(Personaje personaje);
         bool Nadar(Personaje personaje);
         bool Saltar(Personaje personaje);

### Entidades  -> Personaje.cs 

public Personaje(String nombre)

El constructor recibe como parametro el nombre del personaje

#### Implementacion 1 (Implementación de Ataque) ->  Ataque.cs

Se establece los métodos segun el contrato de la interfaz heredada (IAccion.cs)

#### Implementacion 2 (Implementación de Defensa)->  Defensa.cs

Se establece los métodos segun el contrato de la interfaz heredada (IAccion.cs)

#### Implementacion 3 (Implementación de Pasiva) ->  Pasiva.cs

Se establece los métodos segun el contrato de la interfaz heredada (IAccion.cs)


# Actividad de Evaluación temas tratados el día 12-01-2021 en la clase de Programación Visual
