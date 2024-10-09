using System.Collections;

namespace Library;

public class Catalogo
{
    private List<Pokemon> catalogo_pokemons;
    public List<Pokemon> Catalogo_pokemons { get; set; }

    public List<Pokemon> AgregarCatalogo(Pokemon a)
    {
        Catalogo_pokemons.Add(a);
        return Catalogo_pokemons;
    }
    public Catalogo()
    {
        Catalogo_pokemons = new List<Pokemon>();
    }
}