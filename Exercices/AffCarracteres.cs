namespace OOP_TP1.Exercices;

public class AffCarracteres{
    /// <summary>
    /// Créer le programme "AffCarracteres" qui demande le nombre de lignes à afficher,
    /// le nombre de lettres à utiliser et affiche les lettres (commençant par "A")
    /// </summary>
    public static void Run(){
        char letter = 'A';
        Console.Write("Entrez le nombre de lignes: ");
        int nombreLignes = int.Parse(Console.ReadLine());
        
        Console.Write("Entrez le nombre de lettres a utiliser: ");
        int nombreLettre = int.Parse(Console.ReadLine());

        for (int i = nombreLignes; i >= 1; i--)
        {
            for (int j = 0; j <= nombreLignes - i; j++)
            {
        
                Console.Write(" ");
            }

            for (int k = 0; k < i; k++)
            {
                int position = letter - 'A' + 1;
                if (position <= nombreLettre)
                {
                    Console.Write($" {letter}");
                }
                else
                {
                    letter = 'A';
                    Console.Write($" {letter}");
                }

                letter++;

            }
            Console.WriteLine();
        }
    }
}