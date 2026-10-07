using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liste_2026_39b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a= new int[10];
            a[5] = 5;
            List<string> ime = new List<string>();
            ime.Add("Lazar");
            ime.Add("Mihajlo");
            ime.Add("Filip");
            Console.WriteLine(ime[2]);
        }
    }
}
