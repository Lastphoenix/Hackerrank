using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareTheTriplets
{
    static void Main(String[] args)
    {
        String[] aliceTriplet = Console.ReadLine().Split(' ');
        int[] aliceArray = Array.ConvertAll(aliceTriplet, Int32.Parse);
        String[] bobTriplet = Console.ReadLine().Split(' ');
        int[] bobArray = Array.ConvertAll(bobTriplet, Int32.Parse);
        int alice = 0;
        int bob = 0;

        for(int i = 0;i < 3; i++)
        {
            if (aliceArray[i] > bobArray[i])
            {
                alice++;
            }
            if(aliceArray[i] < bobArray[i])
            {
                bob++;
            }
        }
        Console.WriteLine(alice + " " + bob);
    }
}

