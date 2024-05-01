string[] a = Console.ReadLine().Split(' ');

            int[] b = {1,1,2,2,2,8};
            
            for (int i = 0; i < a.Length; i++)
            {
                b[i] -= int.Parse(a[i]);
            }

            Console.WriteLine(string.Join(" ",b));
