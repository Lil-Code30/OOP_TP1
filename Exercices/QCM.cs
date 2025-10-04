namespace OOP_TP1.Exercices;

public class QCM
{
    public static void Run()
        {
            // Questions du QCM
            string[] questions = new string[]
            {
                "Quel mot-clé est utilisé pour déclarer une classe en C# ?",
                "Quel est le type de données pour un entier en C# ?",
                "Quel mot-clé est utilisé pour empêcher une classe d'être héritée ?",
                "Quel est le mot-clé pour créer une instance d'une classe ?",
                "Quel mot-clé permet de surcharger une méthode virtuelle ?",
                "Quelle méthode est exécutée automatiquement lors de la création d'un objet ?",
                "Quel est le mot-clé pour lever une exception en C# ?",
                "Quel est le mot-clé pour gérer une exception en C# ?",
                "Quel mot-clé permet de garantir qu'une méthode ne peut pas être redéfinie ?",
                "Quel est le type de retour pour une méthode qui ne retourne rien ?"
            };

            // Réponses 
            string[,] options = new string[,]
            {
                { "A) class", "B) struct", "C) interface", "D) enum" },
                { "A) float", "B) double", "C) int", "D) bool" },
                { "A) abstract", "B) sealed", "C) virtual", "D) override" },
                { "A) create", "B) new", "C) make", "D) build" },
                { "A) virtual", "B) override", "C) abstract", "D) static" },
                { "A) Destructor", "B) Main", "C) Constructor", "D) Method" },
                { "A) catch", "B) throw", "C) try", "D) finally" },
                { "A) raise", "B) error", "C) catch", "D) throw" },
                { "A) sealed", "B) static", "C) final", "D) const" },
                { "A) void", "B) null", "C) int", "D) string" }
            };

            // Réponses correctes (A=0, B=1, C=2, D=3)
            int[] correctAnswers = new int[] { 0, 2, 1, 1, 1, 2, 1, 2, 0, 0 };

            // Générer 4 indices aléatoires parmi 0 à 9
            Random random = new Random();
            List<int> selectedIndices = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                int index;
                do
                {
                    index = random.Next(0, 10);
                } while (selectedIndices.Contains(index));
                selectedIndices.Add(index);
            }

            int score = 0;
            int[] usersAnswers = new int[4];
            bool[] isCorrect = new bool[4];

            Console.WriteLine("===== QCM =====");

            for(int i = 0; i < 4; i++)
            {
                int questionIndex = selectedIndices[i];
                Console.WriteLine($"\nQuestion {i + 1}: {questions[questionIndex]}");

                // Afficher les options
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine(options[questionIndex, j]);
                }

                Console.Write("Votre réponse (A, B, C, D): ");
                char userInput = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                int userChoice;
                switch (userInput)
                {
                    case 'A':
                        userChoice = 0;
                        break;
                    case 'B':
                        userChoice = 1;
                        break;
                    case 'C':
                        userChoice = 2;
                        break;
                    case 'D':
                        userChoice = 3;
                        break;
                    default:
                        Console.WriteLine("Réponse invalide. Veuillez choisir A, B, C ou D.");
                        i--; // Reposer la même question
                        continue;
                }

                usersAnswers[i] = userChoice;

                // Vérifier la réponse de l'utilisateur
                if (userChoice == correctAnswers[questionIndex])
                {
                    score++;
                    isCorrect[i] = true;
                }
                else
                {
                    isCorrect[i] = false;
                }
            }

            string grade;

            // Déterminer la note en fonction du score
            switch (score)
            {
                case 4:
                    grade = "A";
                    break;
                case 3:
                    grade = "B";
                    break;
                case 2:
                    grade = "D";
                    break;
                case 1:
                case 0:
                    grade = "E";
                    break;
                default:
                    grade = "mauvaise note: Erreur du systeme";
                    break;
            }

            Console.WriteLine("\n===== Résultats ========");
            Console.WriteLine($"Votre note : {grade} ");
            Console.WriteLine("========================\n");
            
            if(score == 4)
            {
                Console.WriteLine("\nExcellent travail ! Vous avez répondu correctement à toutes les questions.\n");

            }
            else
            {
                // Afficher les questions et les réponses ratées par l'utilisateur
                Console.WriteLine("===== Correction ========\n");
                for (int i = 0; i < 4; i++)
                {
                    if (!isCorrect[i])
                    {
                        int questionIndex = selectedIndices[i];
                        Console.WriteLine($"Question {i + 1}: {questions[questionIndex]}");
                        Console.WriteLine($"Votre réponse: {options[questionIndex, usersAnswers[i]]}");
                        Console.WriteLine($"Réponse correcte: {options[questionIndex, correctAnswers[questionIndex]]}\n");
                    }
                }
            }
        }
    }