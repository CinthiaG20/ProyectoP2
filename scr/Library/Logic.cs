namespace Library;

public class Logic
{ 
    public Player Jugador1 { get; set; }
    public Player Jugador2 { get; set; }

    public Logica(Player p1, Player p2)
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

    private void Turno(Player atacante, Player defensor)
    {
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine($"Elige un ataque:");
                foreach (IAttack VARIABLE in atacante.PokemonActivo.Attacks.Values)
                {
                    Console.WriteLine($"{VARIABLE.Name}");
                }
                int ataqueelegido = Convert.ToInt32(Console.ReadLine());
                switch (ataqueelegido)
                {
                    case 1:
                        atacante.PokemonActivo.UsarAtaque(atacante.PokemonActivo.Attacks[1],defensor.PokemonActivo);
                    case 2:
                }
                
                break;//menu atacar
            case 2:
                break;//menu cambiar pokemon
            default:
                Console.WriteLine("Numero no valido");
                break;
        }
        
        
        Console.WriteLine($"{atacante.Nombre} ataca a {defensor.Nombre}!");
        defensor.PokemonActivo.RecibirDaño();
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
