using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2lon
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.Write("Ban muon tiep tuc nhap khong:");
                    string x = Console.ReadLine();
                    if(x.Equals("khong"))
                    {
                        Environment.Exit(0);
                        Console.Write("Nhap chi so hanh phuc:");
                        double chisohp = double.Parse(Console.ReadLine());
                        Console.Write("Nhap so hang:");
                        int sodong = int.Parse(Console.ReadLine());
                        Console.Write("Nhap so cot:");
                        int socot = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
    }
}
