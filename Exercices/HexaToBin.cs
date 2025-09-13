namespace OOP_TP1.Exercices;

public static class HexaToBin
{
    /// <summary>
    /// 3.
    /// Créer votre propre programme "HexaToBin" qui permet la conversion d’un nombre
    /// hexadécimal en binaire. E.g. 1016 = 100002
    /// </summary>
    public static void Run()
    {
        /*
         * 🚨 Remember, when converting hexadecimal to binary, assign the corresponding 4-bit binary
           representation to each hexadecimal digit. 
         */
        string result = "";
        Dictionary<char, string> binaryNumbers = new Dictionary<char, string>()
        {
            { '0', "0000" },
            { '1', "0001" },
            { '2', "0010" },
            { '3', "0011" },
            { '4', "0100" },
            { '5', "0101" },
            { '6', "0110" },
            { '7', "0111" },
            { '8', "1000" },
            { '9', "1001" },
            { 'A', "1010" },
            { 'B', "1011" },
            { 'C', "1100" },
            { 'D', "1101" },
            { 'E', "1110" },
            { 'F', "1111" }
        };
        
        Console.Write("Enter the Hexadecimal number to convert to binary: ");
        
        string hexaNumber = Console.ReadLine().ToUpper(); // FD

        for (int i = 0; i < hexaNumber.Length; i++)
        {   
            
            result +=  binaryNumbers[hexaNumber[i]];
        }
        
        Console.WriteLine($"{hexaNumber} de Hexadecimal en Binaire : {result}");
    }
}