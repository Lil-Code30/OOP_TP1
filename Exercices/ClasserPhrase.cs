namespace OOP_TP1.Exercices;

public class ClasserPhrase
{
    /// <summary>
    /// 5.
    /// Sachant que chaque lettre a un poids (1 pour A, 2 pour B…26 pour Z),
    /// créer le programme "ClasserPhrase" qui permet de classer les phrases
    /// saisies selon leur poids.
    /// </summary>
    public static void Run()
    {
        char[] alphabet =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        Dictionary<string, int> phrasesAndWeights = new Dictionary<string, int>();

        Console.WriteLine("=== Classement de phrases par poids ===");
        Console.Write("Combien de phrases voulez-vous saisir? ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] phrases = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Entrez la phrase (justes mots separer de l'espace: ");
            phrases[i] = Console.ReadLine();
        }
        
        foreach (string phrase in phrases)
        {
            int poidsPhrase = 0;
            
            foreach(char c in phrase.ToUpper())
            {
                if (c >= 'A' && c <= 'Z')
                {
                    int letterIndex = Array.IndexOf(alphabet, c);
                    poidsPhrase += letterIndex + 1;
                }
            }
            
            phrasesAndWeights.Add(phrase, poidsPhrase);
        }
        
        
        foreach (KeyValuePair<string, int> pair in phrasesAndWeights)
        { 
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
    } 
}

