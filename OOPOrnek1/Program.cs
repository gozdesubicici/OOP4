using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorluTasit mt = new MotorluTasit();
            mt.Git();

            Araba araba = new Araba();
            araba.Git();

            MotorluTasit tasit = new Araba();
            tasit.Git();

            Console.ReadLine();
        }
    }
}
