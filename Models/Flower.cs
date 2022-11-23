using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Models
{
    internal record Flower         
    {
        public string name;
        public string color;
        public double price;
        public string Name
        {
            get
            { return name; }
            set
            {
                name = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (value.Length > 2 && value.Length < 30)
                {
                    color = value;
                }
            }

        }
        public double Price
        {
            get { return price; }
            set 
            { 
                if(value>0.1 && value<50000)
                {
                    price = value;
                }

             }
        }
        
    }
}
