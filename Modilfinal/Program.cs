namespace Modilfinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива");
            int elementCount = int.Parse(Console.ReadLine());
            int[] array = new int[elementCount];
            Random random = new Random();
            for (int i = 0; i < elementCount; i++)
            {
                array[i] = random.Next(1, 26);
            }
            int evencount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) == 0)
                {
                    evencount = ++evencount;

                }
            }
            int oddcount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddcount = ++oddcount;
                }
            }

            int[] EvenNumbers = new int[evencount];
            int[] oddNumbeers = new int[oddcount];
            int evenIndex = 0;
            int oddIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    EvenNumbers[evenIndex] = array[i];
                    evenIndex++;
                }
                else
                {
                    oddNumbeers[oddIndex] = array[i];
                    oddIndex++;
                }

            }
            /* Створити ще 2 масиви символів char 
            */
            char[] pairSymbols = new char[evenIndex];
            char[] oddSymbols = new char[oddIndex];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < pairSymbols.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if ((EvenNumbers[i] - 1) == j)
                    {
                        pairSymbols[i] = alphabet[j];
                    }
                }
            }

            for (int i = 0; i < oddSymbols.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if ((oddNumbeers[i] - 1) == j)
                    {
                        oddSymbols[i] = alphabet[j];
                    }
                }
            }
            /* буква є одній із списку (a, e, i, d, h, j) то вона має бути у верхньому регістрі*/
            char[] uppSymbols = new[] { 'a', 'e', 'i', 'd', 'h', 'j' };
            for (int i = 0; i < pairSymbols.Length; i++)
            {
                for (int j = 0; j < uppSymbols.Length; j++)
                {
                    if (pairSymbols[i] == uppSymbols[j])
                    {
                        pairSymbols[i] = char.ToUpper(pairSymbols[i]);
                    }
                }
            }

            for (int i = 0; i < oddSymbols.Length; i++)
            {
                for (int j = 0; j < uppSymbols.Length; j++)
                {
                    if (oddSymbols[i] == uppSymbols[j])
                    {
                        oddSymbols[i] = char.ToUpper(oddSymbols[i]);
                    }
                }
            }

            for (int i = 0; i < pairSymbols.Length; i++)
            {
                Console.Write(pairSymbols[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < oddSymbols.Length; i++)
            {
                Console.Write(oddSymbols[i] + " ");
            }
        }
    }
}