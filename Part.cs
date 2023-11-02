using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IMS_
{
    public abstract class Part //base class(parent)
    {
        public int ID { get; set; } //auto props
        public string Name { get; set; }
        public int Inv { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Part(int id, string nm, int iv, decimal pc, int mn, int mx) //construct
        {
            ID = id;
            Name = nm;
            Inv = iv;
            Price = pc;
            Min = mn;
            Max = mx;
        }
    }

}
