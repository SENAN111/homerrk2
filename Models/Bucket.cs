using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Models
{
    internal class Bucket
    {
        public string _flower;
        public int _flowercount;
        public double _discountprecent;
        public string Flower
        {
            get { return _flower; } set { _flower = value; }
        }
        public int Flowercount
        {
            get { return _flowercount; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _flowercount = value;
                }
            }

        }
        public  double totalprice()
        {
            totalprice_=Flowercount
        }
    }
}
