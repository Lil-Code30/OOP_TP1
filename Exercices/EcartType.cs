namespace OOP_TP1.Exercices;

public static class EcartType
{
    /// <summary>
    /// 4.
    /// Créer le programme "EcartType" qui permet de calculer l’écart-type d’un
    /// tableau saisi par l’utilisateur en utilisant la formule
    /// useful resource : https://en.wikipedia.org/wiki/Standard_deviation
    /// </summary>
    public static void Run()
    {
        Console.Write("Entrer le nombre d'elements dans le tableau");
        int n = int.Parse(Console.ReadLine());
        int[] numbersArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Entrer un nombre: ");
            numbersArr[i] = int.Parse(Console.ReadLine());
        }
        
        int total = 0;
        

        for (int i = 0; i < n; i++)
        {
            total += numbersArr[i];    
             
        }
        int mean = total / n;
        
        double topSum = 0;

        for (int i = 0; i < n; i++)
        {   
            int x = Math.Abs(numbersArr[i] - mean);
            topSum += Math.Pow(x, 2);
        }
        
        double avg = topSum / n;
        double ecartType = Math.Sqrt(avg);
        
        Console.WriteLine($"L'EcartType est : {ecartType:0.00}");
    }
}