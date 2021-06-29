//https://www.hackerrank.com/challenges/string-similarity/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
  
namespace StringRedDemo
{
    class Solution
    {
        static int finalLength = 0;
        static void Main(string[] args)
        {
            int totalInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i <totalInputs; i++)
            {
                string strToProcess = Console.ReadLine();
                int totalstrLength = strToProcess.Length;
                finalLength = totalstrLength;
                char[] masterarraychar = strToProcess.ToCharArray();
                for (int k = 1; k<totalstrLength; k++)
                {
  
                    if (masterarraychar[0] != masterarraychar[k])
                        continue;
                    matchlen(masterarraychar, k);
  
                }
                Console.WriteLine(finalLength);
            }
            Console.ReadKey();
        }
        private static void matchlen(char[] masterarraychar, int k)
        {
            for (int j = 0; j < masterarraychar.Length - k; j++)
            {
                if (masterarraychar[j + k] == masterarraychar[j])
                {
                    finalLength++;
                }
                else
                {
                    break;
                }
            }
        }
  
    }
}
