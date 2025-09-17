namespace OOP_TP1.Exercices;

public class AffCarracteres
{
    /// <summary>
    /// Créer le programme "AffCarracteres" qui demande le nombre de lignes à afficher,
    /// le nombre de lettres à utiliser et affiche les lettres (commençant par "A")
    /// </summary>
    public static void Run()
    {
        char[] alphabet = new char[]
        {
            'A','B','C','D','E','F','G','H','I','J','K','L','M',
            'N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
    
        Console.Write("Entrez le nombre de lignes: ");
        int nombreLignes = int.Parse(Console.ReadLine());
        
        Console.Write("Entrez le nombre de lettres a utiliser: ");
        int nombreLettre = int.Parse(Console.ReadLine());

        for (int i = nombreLignes; i < 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(alphabet[j]);
            }
            Console.WriteLine();
        }
    }
}