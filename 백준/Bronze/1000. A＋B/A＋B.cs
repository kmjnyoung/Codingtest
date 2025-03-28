class Sum
{
    static void Main(string[] args)
    {
        int a;
        int b;

string[] ab = Console.ReadLine().Split(' ');

        a = int.Parse(ab[0]);
        b = int.Parse(ab[1]);

        int sum = a + b;

        Console.WriteLine(sum);
    }
}