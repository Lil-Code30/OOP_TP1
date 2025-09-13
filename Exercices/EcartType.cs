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
        Console.Write("Enter numbers separated by commas, (Nb: no spaces should be added): ");
        string mergeNumbers = Console.ReadLine(); // 2,4,4,4,5,5,7,9
        
        string[] numbersArr = mergeNumbers.Split(',');
        
        int n = numbersArr.Length;
    
        int total = 0;
        

        for (int i = 0; i < n; i++)
        {
            total += int.Parse(numbersArr[i]); // mean = mean + numbersArr[i]    
             
        }
        int mean = total / n;
        
        double topSum = 0;

        for (int i = 0; i < n; i++)
        {   
            int x = int.Parse(numbersArr[i]) - mean;
            topSum += Math.Pow(x, 2);
        }
        
        double avg = topSum / n;
        double ecartType = Math.Sqrt(avg);
        
        Console.WriteLine($"L'EcartType est : {ecartType:0.00}");
    }
}