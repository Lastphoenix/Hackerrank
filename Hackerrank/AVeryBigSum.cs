using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AVeryBigSum
    {
    static void Main(String[] args)
    { 
        long n = Int64.Parse(Console.ReadLine());
        string[] bigArray = Console.ReadLine().Split(' ');
        long[] arr = Array.ConvertAll(bigArray, Int64.Parse);
        long add = 0;

        for(int i = 0; i < n; i++){
            add = add + arr[i];
            }
        Console.WriteLine(add);
    }
}
