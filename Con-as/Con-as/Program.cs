using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        static void Exercise1_1(string text)
        {
            var dict = new Dictionary<Char, int>();
            foreach (var c in text)
            {
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z')
                {
                    if (dict.ContainsKey(uc))
                        dict[uc]++;
                    else
                        dict[uc] = 1;
                }
            }
        }
}