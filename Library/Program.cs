namespace Program;
using Library;
public class Program
{
    public static void Main(String[] args)
    {
        Jugador jugador1 = new Jugador("PEPE");
        Jugador jugador2 = new Jugador("JUAN");
        Logica logica = new Logica(jugador1, jugador2);
        logica.Iniciar();
    }

}