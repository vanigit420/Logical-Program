namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, flag = 0;
            int min, max;

            Console.WriteLine("Find the Prime number within a given range of number");

            Console.WriteLine("Input the starting number of range:");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Ending number of range:");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers within the given range");
            if (min >= 2)
            {
                for (n = min; n <= max; n++)
                {
                    i = 2;
                    flag = 0;
                    while (i <= n/2)
                    {
                        if (n % i == 0)
                        {
                            flag = 1;
                            break;
                        }
                        i = i + 1;
                    }
                    if (flag == 0)
                        Console.Write("{0} ", n);
                }
            }
        }
    }
}