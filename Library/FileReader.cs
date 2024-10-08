using System;
using System.Collections.Generic;
using System.IO;

namespace Library;
public class FileReader
{
    private string _rutaArchivo;

    public void LeerArchivo(string rutaArchivo)
    {
        _rutaArchivo = rutaArchivo;
    }

    public List<Pokemon> CargarPokemons()
    {
        Catalogo pokemons = new Catalogo();

        try
        {
            using (StreamReader lector = new StreamReader(_rutaArchivo))
            {
                string contenido = lector.ReadToEnd(); // Lee todo el contenido del archivo
                // Separar los Pokémon por el delimitador "."
                string[] entradas = contenido.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string entrada in entradas)
                {
                    // Separar cada Pokémon por comas
                    string[] valores = entrada.Split(',');

                    if (valores.Length >= 7)
                    {
                        string nombre = valores[0];
                        int vida = int.Parse(valores[1]);
                        string tipo = valores[2];
                        /*string ataque1 = valores[3];
                        string ataque2 = valores[4];
                        string ataque3 = valores[5];
                        string ataque4 = valores[6];*/

                        // Crear un objeto Pokemon y agregarlo a la lista
                        Pokemon pokemon = new Pokemon(nombre, vida, tipo, ataque1, ataque2, ataque3, ataque4);
                        pokemons.AgregarCatalogo(pokemon);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer el archivo: {ex.Message}");
        }

        return pokemons;
    }
}