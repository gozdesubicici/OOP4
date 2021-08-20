using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void Form1_Load(object sender, EventArgs e)
        {
            Araba a1 = new Araba()
            {
                Marka = "Mercedes",
                Model = "A180",
                Renk = "Beyaz",
                UretimYili = "2020"
            };

            Araba a2 = new Araba()
            {
                Marka = "Honda",
                Model = "Crv",
                Renk = "Mavi",
                UretimYili = "2016"
            };

            Araba a3 = new Araba()
            {
                Marka = "Kia",
                Model = "Sorento",
                Renk = "Metalik Gri",
                UretimYili = "2018"
            };

            //lbxArabalar.Items.Add(a1.Marka + "-" + a1.Model);
            //lbxArabalar.Items.Add(a2.Marka + "-" + a2.Model);
            //lbxArabalar.Items.Add(a3.Marka + "-" + a3.Model);

            lbxArabalar.Items.Add(a1);
            lbxArabalar.Items.Add(a2);
            lbxArabalar.Items.Add(a3);

        }

        private void lbxArabalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Araba araba = lbxArabalar.SelectedItem as Araba;
            lblGoruntule.Text = araba.OzellikleriYaz();
        }
    }
}
