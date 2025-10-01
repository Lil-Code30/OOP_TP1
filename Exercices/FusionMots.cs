namespace OOP_TP1.Exercices;

public class FusionMots
{
    /// <summary>
    /// 6.
    /// Créer le programme "FusionMots" qui demande deux mots et en crée un
    /// troisième en combinant les lettres des deux mots un de chaque. 
    /// Exemple : mot1 = "bonjour " , mot2 = "soir" → mot3 = "bsoonijrour"
    /// </summary>
    public static void Run()
    {
        Console.WriteLine("=== Fusion de deux mots ===");
        Console.Write("Entrez le premier mot: ");
        string mot1 = Console.ReadLine();
        Console.Write("Entrez le deuxième mot: ");
        string mot2 = Console.ReadLine();

        List<char> resultat = new List<char>();
        int len1 = mot1.Length, len2 = mot2.Length;
        int maxLen = Math.Max(len1, len2);

        for (int i = 0; i < maxLen; i++)
        {
            if (i < len1) resultat.Add(mot1[i]);
            if (i < len2) resultat.Add(mot2[i]);
        }

        string mot3 = new string(resultat.ToArray());
        Console.WriteLine($"Résultat de la fusion: {mot3}");
    }
    
}