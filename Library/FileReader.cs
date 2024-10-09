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

    public Catalogo CargarPokemons(Catalogo pokemons)
    {

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

                    if (valores.Length >= 3)
                    {
                        string nombre = valores[0];
                        string tipo = valores[1];
                        int vida = int.Parse(valores[2]);
                        /*string ataque2 = valores[4];
                        string ataque3 = valores[5];
                        string ataque4 = valores[6];*/

                        // Crear un objeto Pokemon y agregarlo a la lista
                        Pokemon pokemon = new Pokemon(tipo,nombre,vida);
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

    public Ataque AgregarAtk(Pokemon a)
    {
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

                    if (valores.Length >= 6)
                    {
                        string nombre = valores[3];
                        string tipo = valores[4];
                        bool especial = bool.Parse(valores[5]);
                        
                        string nombre1 = valores[6];
                        string tipo1 = valores[7];
                        bool especial1 = bool.Parse(valores[8]);
                        
                        string nombre2 = valores[9];
                        string tipo2 = valores[10];
                        bool especial2 = bool.Parse(valores[11]);
                        
                        string nombre3 = valores[12];
                        string tipo3 = valores[13];
                        bool especial3 = bool.Parse(valores[14]);
                        
                        Ataque ataque = new Ataque(nombre,tipo,especial);
                        Ataque ataque1 = new Ataque(nombre1, tipo1, especial1);
                        Ataque ataque2 = new Ataque(nombre2, tipo2, especial2);
                        Ataque ataque3 = new Ataque(nombre3, tipo3, especial3);
                        a.AgregarAtaque(ataque);
                        a.AgregarAtaque(ataque1);
                        a.AgregarAtaque(ataque2);
                        a.AgregarAtaque(ataque3);
                        
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            
        }
        
        return null;
    }
}