namespace Sum_of_Digits_Digital_Root
{
    internal class Program
    {
        public static int DigitalRoot(long n) => n < 10 ? (int)n : DigitalRoot(n.ToString().Sum(c => c - '0'));
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRoot(16));
        }
    }
}