namespace ConsoleApp1
{
    internal class Excep
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();

            int num;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                num = int.Parse(Console.ReadLine());

                try
                {

                    if (!ints.Contains(num))
                    {
                        ints.Add(num);
                    }

                }

                catch
                {

                    Console.WriteLine("Dublicate number");

                }




            }
        }
    }
}
