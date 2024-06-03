namespace dz_c__arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int[,] array = new int[5, 6];
                int number = 1;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        array[i, j] = number;
                        number++;
                    }
                }


                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n\n\n");

                for (int i = 0; i < 5; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                    }
                    else
                    {
                        for (int j = 5; j >= 0; j--)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
        }
    }
}
