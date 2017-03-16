using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SimpleArraySum {

    static void Main(String[] args)
    {

        int numberOfElements = Convert.ToInt32(Console.ReadLine());
        String[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int add = 0;

        for (int i = 0; i < numberOfElements; i++)
        {
            add = add + arr[i];
        }
        Console.WriteLine(add);
    }
}

