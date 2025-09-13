using OOP_TP1.Exercices;

class Program
{
	static void Main()
	{
		
			Console.WriteLine("\n=== Menu des Exercices ===");
			Console.WriteLine("1. Delta (équation du second degré)");
			Console.WriteLine("2. Division sans / ni %");
			Console.WriteLine("3. HexaToBin (conversion hexadécimal → binaire)");
			Console.WriteLine("4. EcartType (calcul de l'écart-type)");
			Console.WriteLine("5. ClasserPhrase (classement par poids de phrase)");
			Console.WriteLine("6. FusionMots (fusion de deux mots)");
			Console.WriteLine("7. AffCaractères (affichage de lettres)");
			Console.WriteLine("8. MachineÀSous (machine à sous)");
			Console.WriteLine("9. QCM (questions à choix multiples)");
			Console.WriteLine("0. Quitter");
            Console.WriteLine("--------------------------");
			Console.Write("Votre choix : ");
			string? choix = Console.ReadLine();
            switch (choix)
            {
                case "0":
                    Console.WriteLine("Au revoir !");
                    return;
                case "1":
                    Delta.Run();
                    break;
                case "2":
	                Division.Run();
	                break;
                case "3":
	                HexaToBin.Run();
	                break;
                case "4":
	                EcartType.Run();
	                break;
                default:
                    Console.WriteLine("(L'exercice n'est pas encore implémenté)");
                    break;
            }
			
		
	}
}