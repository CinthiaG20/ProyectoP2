using System.Collections;

namespace Library;

public class Jugador
{
    private string nombre;
    public string Nombre { get; set; }
    private List<Pokemon> listaPokemons;
    public List<Pokemon> ListaPokemons { get; set; }
    private Pokemon pokemonActivo;
    public Pokemon PokemonActivo { get; set; }
    private int vidaPokemon;
    public int VidaPokemon { get; set; }
    private List<Ataque> listaAtk;
    public List<Ataque> ListaAtk { get; set; }
    private int turno;
    public int Turno { get; set; }
    
    public void CambiarPokemon(string nombre)
    {
        foreach (Pokemon VARIABLE in listaPokemons)
        {
            if (VARIABLE.Nombre == nombre)
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
        foreach (Pokemon VARIABLE in listaPokemons)
        {
            if (VARIABLE.Vida == 0)
            {
                pokemonMuerto += 1;
            }

            if (pokemonMuerto==6)
            {
                return false;
            }
        }
        return true;
    }
    public Jugador(string nombre)
    {
        Nombre = nombre;
        ListaPokemons = new List<Pokemon>();
        PokemonActivo = null;
        VidaPokemon = PokemonActivo.Vida;
        ListaAtk = pokemonActivo.ListaAtk;
        //Turno=
    }
}