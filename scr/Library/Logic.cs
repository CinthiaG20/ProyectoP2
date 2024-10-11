using System.Reflection.PortableExecutable;

namespace Library;

public class Logic
{
    public Player Jugador1 { get; set; }
    public Player Jugador2 { get; set; }
    public int turno { get; set; }

    public Battle(Player p1, Player p2)
    {
        Jugador1 = p1;
        Jugador2 = p2;
        turno = 1
    }

    public bool Endgame()
    {
        return (!Jugador1.EstaVivo() || !Jugador2.EstaVivo());
    }

    public void Iniciar()
    {
        Console.WriteLine($"¡Inicia la batalla entre {Jugador1.Name} y {Jugador2.Name}!");
        while (!Endgame())
        {
            RealizarTurno();
        }
        DeclararGanador();
    }

    public void RealizarTurno()
    {
        Action accion1 = PedirAccion(Jugador1);
        Action accion2 = PedirAccion(Jugador2);

        if (accion1.Priority > accion2.Priority)
        {
            EjecutarAcciones(accion1, accion2);
        }
        else if (accion1.Priority < accion2.Priority)
        {
            EjecutarAcciones(accion2, accion1);
        }
        else
        {
            if (Jugador1.ActivePokemon.Vel > Jugador2.ActivePokemon.Vel)
            {
                EjecutarAcciones(accion1, accion2);
            }
            else
            {
                EjecutarAcciones(accion2, accion1);
            }
        }

        turno++;
    }

    public Action PedirAccion(Player jugador) // Cambié el tipo de retorno a 'Action'
    {
        Console.WriteLine($"{jugador.Name}, elige tu acción: (1) Atacar (2) Cambiar Pokémon");
        int input = Convert.ToInt32(Console.ReadLine());

        // Aquí puedes definir las acciones con prioridad
        if (input == 1)
            return new Action { Accion = "Atacar", Priority = 1 }; // Agrega una acción de atacar
        else if (input == 2)
            return new Action { Accion = "Cambiar", Priority = 2 }; // Agrega una acción de cambiar Pokémon
        else
            return new Action { Accion = "Invalido", Priority = 0 }; // Acción inválida
    }

    public void EjecutarAcciones(Action accion1, Action accion2)
    {
        if (accion1.Accion == "Atacar")
        {
            // Lógica de ataque
            Console.WriteLine($"{Jugador1.Name} realiza un ataque.");
            // Aquí iría la lógica para calcular el daño, etc.
        }
        else if (accion1.Accion == "Cambiar")
        {
            // Lógica para cambiar Pokémon
            Console.WriteLine($"{Jugador1.Name} cambia de Pokémon.");
            // Aquí iría la lógica para cambiar el Pokémon activo.
        }

        // Similar para la acción 2
        if (accion2.Accion == "Atacar")
        {
            Console.WriteLine($"{Jugador2.Name} realiza un ataque.");
            // Lógica de daño, etc.
        }
        else if (accion2.Accion == "Cambiar")
        {
            Console.WriteLine($"{Jugador2.Name} cambia de Pokémon.");
            // Lógica para cambiar el Pokémon activo.
        }
    }
    public void DeclararGanador()
    {
        if (Jugador1.EstaVivo())
        {
            Console.WriteLine($"{Jugador1.Name} ha ganado la batalla!");
        }
        else
        {
            Console.WriteLine($"{Jugador2.Name} ha ganado la batalla!");
        }
    }
}
