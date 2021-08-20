using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek1
{
    class Araba: MotorluTasit
    {
        // Not: override ifadesi ile MotorluTasit Class'ında Git() metodu haline gelir ve içersinde değişiklik yapılırsa o metot ezilmiş olur. ancak, override'ı kaldırırsak MotorluTasittaki Git() metodu değil kendi Git() metodu olur.
        public override void Git()
        {
            Console.WriteLine("Araba gidiyor...");
        }
    }
}
