namespace Program;
using Library;
public class Program
{
    public static void Main(String[] args)
    {
        Catalogo catalogo = new Catalogo();
        FileReader reader = new FileReader();
        /*Pokemon uno = new Pokemon("tipo", "nombre");
        catalogo.AgregarCatalogo(uno);
        Console.WriteLine(catalogo.Catalogo_pokemons[0].Nombre);*/
        reader.LeerArchivo(@"C:\Users\cinty\OneDrive\Escritorio\ProyectoP2\Library\Ejemplo.txt");
        reader.CargarPokemons(catalogo);
        Pokemon pokemon1 = catalogo.Catalogo_pokemons[0];
        reader.AgregarAtk(pokemon1);
        foreach (var VARIABLE in pokemon1.ListaAtk)
        {
            Console.WriteLine(VARIABLE.Nombre);
        }

            
        
    } 

}