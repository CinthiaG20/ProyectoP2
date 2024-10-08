using System.Collections;

namespace Library;

public class Catalogo
{
    private List<Pokemon> catalogo_pokemons;
    public List<Pokemon> Catalogo_pokemons { get; set; }

    public void AgregarCatalogo(Pokemon a)
    {
        Catalogo_pokemons.Add(a);
    }
    public Catalogo()
    {
        Catalogo_pokemons = new List<Pokemon>();
    }
}