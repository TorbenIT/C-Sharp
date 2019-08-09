using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Artikel
    {
        int art_nr;

        string bezeichnung;

        double price;

        double pay;

        public int Art_nr { get => art_nr; set => art_nr = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public double Price { get => price; set => price = value; }

        public  double Pay { get => pay; set => pay = value;
        }   
        public override string ToString()
        {
            return Bezeichnung + "";
        }
    }
}
