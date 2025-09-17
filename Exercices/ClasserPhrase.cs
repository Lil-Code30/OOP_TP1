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
        char[] alphabet = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        Dictionary<string, int> phrasesAndWeights = new Dictionary<string, int>();
        
        Console.Write("Entrer le nombre de phrases: ");
        int n = int.Parse(Console.ReadLine());
        
        string[] phrases = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter un phrase: ");
            phrases[i] =  Console.ReadLine();
        }
        
        // wordsArr = ['Dog','Cat', 'fish']
        foreach (string word in phrases)
        {
            // word = Dog len = 3
            int poids = 0;
            for (int i = 0; i < word.Length; i++)
            {
               
                // abc = 1 + 2 + 3 
                // poids = alphabet.IndexOf(letter) + 1; 
                char letter = Convert.ToChar(word[i]); // D
                int letterIndex = Array.IndexOf(alphabet, char.ToUpper(letter));
                
                // total weight of the current word
                poids += letterIndex + 1;
            }
            // {'dog', 26} added to phrasesAndWeights
            phrasesAndWeights.Add(word, poids);
        }
    
        // sort the array in ascending order
        var sortedPhrasesAndWeights = phrasesAndWeights.OrderBy( entry => entry.Value);
         
        foreach (KeyValuePair<string, int> pair in sortedPhrasesAndWeights)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
        
    }
}