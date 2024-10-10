namespace Library;

public class Player
{
    private string name;
    private Dictionary<int, IAttack> atkList;
    private List<IPokemon> pokemonsList;
    private IPokemon activePokemon;
    private double pokemonHealth;
    private int turno;
   
    public string Name { get; set; }
    public List<IPokemon> PokemonsList { get; set; }
   
    public IPokemon ActivePokemon { get; set; }
   
    public double PokemonHealth { get; set; }
    
    public Dictionary<int, IAttack> AtkList { get; set; }
  
    public int Turno { get; set; }

    public void CambiarPokemon(string nombre)
    {
        foreach (IPokemon VARIABLE in pokemonsList)
        {
            if (VARIABLE.Name == nombre)
            {
                activePokemon = VARIABLE;
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
        foreach (IPokemon VARIABLE in pokemonsList)
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
        Name = nombre;
        PokemonsList = new List<IPokemon>();
        ActivePokemon = null;
        PokemonHealth = ActivePokemon.PS;
        AtkList = ActivePokemon.Attacks;
        //Turno=
    }
}