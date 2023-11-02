using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IMS_
{
    public class Product //independent; depended on by inventory; associated with part
    {
        public BindingList<Part> prodPart = new BindingList<Part>();
        public BindingList<Part> AssociatedParts
        {
            get { return prodPart; }
            set { prodPart = value; }
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Inv { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public Product(int id, string nm, int iv, decimal pc, int mn, int mx)
        {
            ID = id;
            Name = nm;
            Inv = iv;
            Price = pc;
            Min = mn;
            Max = mx;
        }
        public static int CurrX { get; set; }


        public Part LookupAssociatedPart(int i, Part pa)
        {
            for (int j = 0; j < AssociatedParts.Count; j++)
            {
                if (AssociatedParts[j].ID.Equals(i))
                {
                    CurrX = j;
                    return AssociatedParts[j];
                }
            }
            CurrX = -1;
            return null;
        }
        public void AddAssociatedPart(Part pa)
        {
            AssociatedParts.Add(pa);
        }
        public bool RemoveAssociatedPart(int i)
        {
            AssociatedParts.RemoveAt(CurrX);
            return true;
        }
    }
}
