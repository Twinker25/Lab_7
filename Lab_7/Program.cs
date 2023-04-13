namespace Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());  
            Array array = new Array(size);
            array.Show();
            Console.Write("\n\nEnter information message: ");
            string info = Console.ReadLine();
            array.Show(info);
        }
    }
}