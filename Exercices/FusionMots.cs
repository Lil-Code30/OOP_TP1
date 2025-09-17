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
        Console.Write("Enter the first word: ");
        string word1 = Console.ReadLine();
        Console.Write("Enter the second word: ");
        string word2 = Console.ReadLine();

        string word3 = "";
        
        /// 🚨 Find out if we must start with the first word or not 
        string longestWord = word1.Length > word2.Length ? word1 : word2;
        string shortestWord = word1.Length > word2.Length ? word2 : word1;

        for (int j = 0; j < shortestWord.Length; j++)
          {
             word3 += Convert.ToChar(longestWord[j]) + ""+ Convert.ToChar(shortestWord[j]);
          }

        if (word1.Length != word2.Length)
        {
            for (int i = shortestWord.Length; i < longestWord.Length  ; i++)
            { 
                word3 += Convert.ToChar(longestWord[i]);
            }
        }
        
        Console.WriteLine(word3);
        
        
    }
    
}