using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int total_count = 1;
            int K = input[0];
            int L =input[1];
            int R = input[2];
            int[,] garden = new int[K,L];
            int[] rot1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int b = 0; b < K; b++)
            {
                for (int c = 0; c < L; c++)
                {
                    garden[b, c] = 0;
                }
            }
            garden[rot1[0], rot1[1]] = 1;
            string inp = Console.ReadLine();
            if (inp != "")
            {
                total_count++;
                int[] rot2 = inp.Split(' ').Select(int.Parse).ToArray();
                garden[rot2[0], rot2[1]] = 1;
            }
            
            for (int i = 1; i <R+1 ; i++)
            {
                for (int b = 0; b < K; b++)
                {
                    for (int c = 0; c < L; c++)
                    {
                        if(garden[b,c] == i) 
                        {
                            if (b > 0)
                            {
                                if (garden[b - 1, c] == 0) { garden[b - 1, c] = i + 1; total_count++; }
                            }
                            if (b < K - 1)
                            {
                                if (garden[b + 1, c] == 0) { garden[b + 1, c] = i + 1; total_count++; }
                            }
                            if (c > 0)
                            {
                                if (garden[b, c - 1] == 0) { garden[b, c - 1] = i + 1; total_count++; }
                            }
                            if (c < L - 1)
                            {
                                if (garden[b, c + 1] == 0) { garden[b, c + 1] = i + 1; total_count++; }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(K*L - total_count);
           

        }
    }
}
