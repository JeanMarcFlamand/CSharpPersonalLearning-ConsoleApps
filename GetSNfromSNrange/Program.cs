
class Program
{
    static bool getsnfromsnrange(int valueToFind, string range)
    {
        // Séparer les plages et valeurs individuelles en utilisant ","
        string[] ranges = range.Split(',');

        foreach (string rangeStr in ranges)
        {
            string[] parts = rangeStr.Split('-');

            if (parts.Length == 1)
            {
                // Cas d'une valeur unique
                int singleValue = int.Parse(parts[0].Trim());
                if (valueToFind == singleValue)
                {
                    return true;
                }
            }
            else if (parts.Length == 2)
            {
                // Cas d'une plage
                int start = int.Parse(parts[0].Trim());
                int end = int.Parse(parts[1].Trim());

                if (valueToFind >= start && valueToFind <= end)
                {
                    return true;
                }
            }
        }

        return false;
    }

    static void Main()
    {
        bool continueApp = true;

        while (continueApp)
        {
            Console.Write("Entrez la valeur à rechercher : ");
            int valueToFind = int.Parse(Console.ReadLine());

            Console.Write("Entrez la plage de valeurs (utilisez le format '4-251, 255, 257-625, 627-660, 672-715') : ");
            string range = Console.ReadLine();

            bool found = getsnfromsnrange(valueToFind, range);

            if (found)
            {
                Console.WriteLine($"La valeur {valueToFind} est présente dans la plage.");
            }
            else
            {
                Console.WriteLine($"La valeur {valueToFind} n'est pas présente dans la plage.");
            }

            Console.Write("Voulez-vous faire un autre exemple ? (O/N) : ");
            string response = Console.ReadLine().Trim();

            if (response.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                continueApp = false;
            }
        }
    }
}
