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
        
        int[] randomNumbers = new int[5];
        Random rnd = new Random();
        
        bool jackpot5 = false;
        bool jackpot3_4 = false;
        int counter;
        for (int i = 0; i < 5; i++)
        {
            int randomNumber = rnd.Next(0, 9);
            randomNumbers[i] = randomNumber;
        }

        for (int i = 0; i < randomNumbers.Length; i++)
        {
            counter = 0;
            for (int j = 0; j < randomNumbers.Length; j++)
            {
                if (randomNumbers[j] == randomNumbers[i])
                {
                    counter++;
                }
            }

            if (counter == 5)
            {
                jackpot5 = true;
            }else if(counter == 4 || counter == 3)
            {
                jackpot3_4 = true;
            }
        }
        
        Console.Write("Vos nombres sont les: ");
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            Console.Write($"[ {randomNumbers[i]} ] ");
        }
        
        Console.WriteLine();
        if (jackpot5)
        {
            double gain = Math.Pow(montant, 5);
            Console.WriteLine($"Jackpot! Vous gagnez {gain:F2} $CAD.");
        }
        else if (jackpot3_4)
        {
            Console.WriteLine($"Vous récupérez votre mise de {montant} $CAD.");
        }
        else
        {
            Console.WriteLine("Désolé, vous perdez votre mise.");
        }
    }
}