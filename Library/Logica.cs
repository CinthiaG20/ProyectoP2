
namespace Library;

public class Logica
{
    public Jugador Jugador1 { get; set; }
    public Jugador Jugador2 { get; set; }

    public Logica(Jugador p1, Jugador p2)
    {
        Jugador1 = p1;
        Jugador2 = p2;
    }

    public void Iniciar()
    {
        while (Jugador1.PokemonActivo.Vida > 0 && Jugador2.PokemonActivo.Vida > 0)
        {
            Turno(Jugador1, Jugador2);
            if (Jugador2.EstaVivo())
            {
                Turno(Jugador2, Jugador1);
            }
        }

        if (Jugador1.EstaVivo())
            Console.WriteLine($"{Jugador1.Nombre} ha ganado!");
        else
            Console.WriteLine($"{Jugador2.Nombre} ha ganado!");
    }

    private void Turno(Jugador atacante, Jugador defensor)
    {
        Console.WriteLine($"{atacante.Nombre} ataca a {defensor.Nombre}!");
        defensor.PokemonActivo.RecibirDanio();
        if (defensor.PokemonActivo.Vida <= 0)
        {
            Console.WriteLine("A que pokemon quieres cambiar?");
            string nombre = Console.ReadLine();
            if (nombre == null || nombre == "" || nombre == " ")
            {
                Console.WriteLine("El nombre no puede estar en blanco");
            }
            else
            {
                defensor.CambiarPokemon(nombre);
            }
        }
        else
        {
            Console.WriteLine($"{defensor.Nombre} tiene {defensor.VidaPokemon} de salud restante.");
        }
       
    }
}
