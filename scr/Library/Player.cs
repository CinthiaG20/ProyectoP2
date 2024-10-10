namespace Library;

public class Player
{
    private string nombre;
    public string Nombre { get; set; }
    private List<IPokemon> listaPokemons;
    public List<IPokemon> ListaPokemons { get; set; }
    private IPokemon pokemonActivo;
    public IPokemon PokemonActivo { get; set; }
    private double vidaPokemon;
    public double VidaPokemon { get; set; }
    private Dictionary<int, IAttack> listaAtk;
    public Dictionary<int, IAttack> ListaAtk { get; set; }
    private int turno;
    public int Turno { get; set; }

    public void CambiarPokemon(string nombre)
    {
        foreach (IPokemon VARIABLE in listaPokemons)
        {
            if (VARIABLE.Name == nombre)
            {
                pokemonActivo = VARIABLE;
            }
            else
            {
                Console.WriteLine("No tienes ese pokemon");
            }
        }
    }

    public bool EstaVivo()
    {
        int pokemonMuerto = 0;
        foreach (IPokemon VARIABLE in listaPokemons)
        {
            if (VARIABLE.PS == 0)
            {
                pokemonMuerto += 1;
            }

            if (pokemonMuerto == 6)
            {
                return false;
            }
        }

        return true;
    }

    public Player(string nombre)
    {
        Nombre = nombre;
        ListaPokemons = new List<IPokemon>();
        PokemonActivo = null;
        VidaPokemon = PokemonActivo.PS;
        ListaAtk = pokemonActivo.Attacks;
        //Turno=
    }
}