class sum
{
    static void Main(string[] args)
    {
        int testnum = int.Parse(Console.ReadLine());

        for (int i = 0; i < testnum; i++)
        {
            string[] a = Console.ReadLine().Split(' ');
            Console.WriteLine(int.Parse(a[0]) + int.Parse(a[1]));
        }
    }
}