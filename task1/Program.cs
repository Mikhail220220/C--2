internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter number ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 100 || number > 1000)
        {
            Console.WriteLine("Введите трех значное число");
            return;
        }
        int result = number / 10 % 10;
        
            Console.WriteLine (result);
        
    }
}