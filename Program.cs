namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 1, 2, 3, 5, 7, 9 };
            int numero = 7;

            Array.Sort(lista);

            var indexLinear = LinearSearch(lista, numero);
            Console.WriteLine($"Item encontrado, {indexLinear}");

            var index = BinarySearch(lista, numero);
            Console.WriteLine($"Item encontrado, {index}");

            var indexRecursive = BinarySearchRecursive(lista, numero);
            Console.WriteLine($"Item encontrado, {indexRecursive}");

            Console.ReadKey();

        }

        private static int LinearSearch(int[] lista, int numero)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == numero)
                {
                    return i;
                }
            }
            return -1;
        }

        private static int BinarySearch(int[] lista, int numero)
        {
            var esquerda = 0;
            var direita = lista.Length - 1;

            while (esquerda <= direita)
            {
                var meio = (esquerda + direita) / 2;

                if (lista[meio] == numero)
                {
                    return meio;
                }

                if (lista[meio] > numero)
                {
                    direita = meio - 1;
                }
                else
                {
                    esquerda = meio + 1;
                }
            }
            return -1;
        }

        private static int BinarySearchRecursive(int[] lista, int numero) 
        {
            return BinarySearchRecursive(lista, 0, lista.Length - 1, numero);
        }

        private static int BinarySearchRecursive(int[] lista,int esquerda, int direita, int numero)
        {
            if (direita >= esquerda)
            {
                int meio = (direita + esquerda) / 2;

                if (lista[meio] == numero)
                {
                    return meio;
                }

                if (lista[meio] > numero)
                {
                    return BinarySearchRecursive(lista, esquerda, meio - 1, numero);
                }
                else
                {
                    return BinarySearchRecursive(lista, meio + 1, direita, numero);
                }
            }
            return -1;
        }
    }
}