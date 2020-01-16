//C# Code to solve the prpblem.

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        List<int> times = new List<int>();
        int total = 0;
        int R = int.Parse(Console.ReadLine());
        int V = int.Parse(Console.ReadLine());
        for (int i = 0; i < V; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int C = int.Parse(inputs[0]);
            int N = int.Parse(inputs[1]);
            int ndx = i;
            if(i < R) {
                times.Add(0);
            } else {
                ndx = times.IndexOf(times.Min());
            }
            times[ndx] += Convert.ToInt32(Math.Pow(5,C)) << N;
            total = Math.Max(total, times[ndx]);
        }
        Console.WriteLine(total);
    }
}
