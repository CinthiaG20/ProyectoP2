using System.Collections;

namespace Library;

public class Pokemon
{
    private int vida;
    public int Vida { get; set; }
    private string tipo;
    public string Tipo { get; set; }
    private string nombre;
    public string Nombre { get; set; }
    private List<Ataque> listaAtk;
    public List<Ataque> ListaAtk { get; set; }

    public void Atacar(Pokemon a)
    {
        
    }

    public void Defender(Pokemon a)
    {
        
    }
    public void RecibirDanio(){}

    public void AgregarAtaque(Ataque a)
    {
        ListaAtk.Add(a );
    }


    public Pokemon( string tipo, string nombre,int vida)
    {
        Vida = vida;
        Tipo = tipo;
        Nombre = nombre;
        ListaAtk = new List<Ataque>(4);
    }
}