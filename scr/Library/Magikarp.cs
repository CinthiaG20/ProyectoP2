using System.Security.Cryptography.X509Certificates;

namespace Library;

public class Magikarp : IPokemon
{
    public Magikarp()
    {
        this.name = "Magikarp";
        this.lvl = 100;
        this.psmax = 244;
        this.ps = psmax;
        this.atk = 130;
        this.def = 229;
        this.spatk = 141;
        this.spdef = 152;
        this.spd = 284;
        this.attacks.Add(1,);
        this.attacks.Add(2,);
    }

    public double DamageCalculator(IAttack attack, IPokemon pokemon)
    {
        double stab;
        if (this.types.Contains(attack.Type))
        {
            stab = 1.5;
        }
        else
        {
            stab = 1;
        }

        Random rnd = new Random();
        int variacion = rnd.Next(85, 100);
        int pot = attack.Potency;
        double effectiveness = TypeTable.GetEffectiveness(attack.Type, pokemon.Types);
        double totaldaño;
        double dañostats;

        if (attack.TypeOfAtack == TypeAttack.Physical)
        {
            dañostats = (((0.2 * lvl + 1) * atk * pot) / (25 * pokemon.Def)) + 2;
            totaldaño = (0.01 * stab * (effectiveness) * variacion * dañostats);
        }
        else
        {
            dañostats = (((0.2 * lvl + 1) * spatk * pot) / (25 * pokemon.SpDef)) + 2;
            totaldaño = (0.01 * stab * (effectiveness) * variacion * dañostats);
        }

        return totaldaño;
    }

    public void UsarAtaque(IAttack attack, IPokemon pokemon)
    {
        double daño = DamageCalculator(attack,pokemon);
        pokemon.RecibirDaño(DamageCalculator(attack, pokemon));
    } 
        
    public void RecibirDaño(double Damage)
    {
        this.PS -= Damage;
    }

    private string name;
    private List<Type> types;
    private int lvl;
    private double psmax;
    private double ps;
    private int atk;
    private int def;
    private int spatk;
    private int spdef;
    private int spd;
    private Dictionary<int,IAttack> attacks;
    
    public string Name
    {
        get { return name; }
    }

    public double PSMax
    {
        get { return psmax; }
    }
    public double PS
    {
        get { return ps; }
        set { ps = value; }
    }
    public int Lvl
    {
        get { return lvl; }
    }
    public int Atk
    {
        get { return atk; }
    }
    public int Def
    {
        get { return def; }
    }
    public int SpAtk
    {
        get { return spatk; }
    }
    public int SpDef
    {
        get { return spdef; }
    }
    public int Spd
    {
        get { return spd; }
    }

    public List<Type> Types
    {
        get { return types;}
    }

    public Dictionary<int,IAttack> Attacks
    {
        get { return attacks; }
    }
}

