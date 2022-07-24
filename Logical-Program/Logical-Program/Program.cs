namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0, remainder = 0;

            Console.WriteLine("Enter the Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }
            Console.WriteLine("Reverse Number is : " + reverse);
        }
    }
}