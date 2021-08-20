using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    class Araba
    {
        public string Marka { get; set; }
        public string Renk { get; set; }
        public string  Model { get; set; }
        public string UretimYili { get; set; }

        public string OzellikleriYaz()
        {
            //Labelda ekrana yazdrılması için kullanan metot
            return "Markası:" + Marka + "\nModeli: " + Model + "\nRengi: " +Renk + "\nÜretim Yılı: " + UretimYili;
  
        }

        public override string ToString()
        {
            return Marka+ " - " + Model;
        }
    }
}
