class Program
{
    static void Main(string[] args) //1001번
    {
        string[] a = Console.ReadLine().Split(' ');

        Console.WriteLine(int.Parse(a[0]) - int.Parse(a[1]));
    }
}