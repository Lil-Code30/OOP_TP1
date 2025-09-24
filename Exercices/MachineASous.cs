namespace OOP_TP1.Exercices;

public class MachineASous
{
    /// <summary>
    /// Créer le programme "MachineÀSous" qui demande à l’utilisateur de saisir un montant et lui génère 5 entiers
    /// entre 0 et 9. Si les 5 entiers sont égaux, il gagne le jackpot (le montant saisi à la puissance 5).
    /// Si un entier se répète 3 ou 4 fois, l’utilisateur récupère son montant.
    /// Ajouter une partie de code en commentaire dans votre code source que si on l’active l’utilisateur ne pourra
    /// jamais gagner le jackpot
    /// </summary>
    public static void Run()
    {
        Console.Write("Entrer un montant: ");
        int montant = int.Parse(Console.ReadLine());
        
        Dictionary<int, int> numberAndTime = new Dictionary<int, int>();

        int[] randomNumbers = new int[5];
        Random rnd = new Random();
        int counter = 1;
        
        for (int i = 0; i < 5; i++)
        {
            int randomNumber = rnd.Next(0, 9);
            randomNumbers[i] = randomNumber;
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 1; j < 5; j++)
            {
                if (randomNumbers[i] == randomNumbers[j])
                {
                    if(numberAndTime.ContainsKey(randomNumbers[i]))
                    {
                        numberAndTime[randomNumbers[i]]++;
                    }
                    else
                    {
                        numberAndTime.Add(randomNumbers[i], counter);
                    }
                }
                
            }
           
        }

        foreach (KeyValuePair<int, int> pair in numberAndTime)
        {
            Console.WriteLine($"{pair.Key} counter: {pair.Value}");
        }
        
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            Console.Write(randomNumbers[i]);
        }
    }
}