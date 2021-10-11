using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "123{4}567{8901}2345";
            Console.WriteLine(s);
            int m = s.IndexOf('{');
            int n = s.IndexOf('}');
            int mn = n - m + 1;
            int k = s.LastIndexOf('{');
            int l = s.LastIndexOf('}');
            int kl = l - k + 1;
            s = s.Remove(k, kl).Remove(m, mn);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
