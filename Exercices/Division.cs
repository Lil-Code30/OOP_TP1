namespace OOP_TP1.Exercices;

public static class Division
{
    /// <summary>
    /// 2.
    /// Créer le programme "Division" qui permet de trouver le résultat et le reste d’une division
    /// sans utiliser de division ou modulo (/ %)
    /// </summary>
    public static void Run()
    {
        Console.Write("Enter the numerator of the division: ");
        int numerator = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the denominator of the division: ");
        int denominator = int.Parse(Console.ReadLine());

        int resultat = 1;
        int rest = numerator - denominator;
        
        while (rest > denominator )
        {
            rest -= denominator; 
            resultat++;

        } 
    
        
        Console.WriteLine($"{numerator} / {denominator} = {resultat} avec un reste de {rest}");
    }
}