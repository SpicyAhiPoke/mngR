using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IMS_
{
    static class Inventory //dependent on product; associated with part; static for access
    {
        public static BindingList<Part> allParts = new BindingList<Part>();
        public static BindingList<Part> AllParts { get { return allParts; } set { allParts = value; } }

        public static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Product> Products { get { return products; } set { products = value; } }

        public static Part CurrPart { get; set; }
        public static Product CurrProd { get; set; }

        public static int CurrID { get; set; }
        public static int CurrPartX { get; set; }
        public static int CurrProdX { get; set; }


        public static int prID = 0;
        public static int paID = 0;
        static Inventory()
        {
            AllParts.Clear();
            AllParts.Add(new Inhouse(paID++,"Seat", 1200, 200, 1000, 1500, 1234));
            AllParts.Add(new Inhouse(paID++, "Battery", 1200, 500, 1000, 1500, 1234));
            AllParts.Add(new Inhouse(paID++, "Tires", 1200, 200, 1000, 1500, 1234));
            AllParts.Add(new Outsource(paID++, "Motor", 1200, 500, 1000, 1500, "eleCH"));
            AllParts.Add(new Outsource(paID++, "Frame", 1200, 500, 1000, 1500, "meCH"));
            AllParts.Add(new Outsource(paID++, "Controller", 1200, 500, 1000, 1500, "teCH"));
            Products.Clear();
            Products.Add(new Product(prID++, "RX", 250, 3495, 100, 2500));
            Products.Add(new Product(prID++, "R ", 250, 2995, 100, 2500));
            Products.Add(new Product(prID++, "S2", 250, 2695, 100, 2500));
            Products.Add(new Product(prID++, "S ", 250, 2195, 100, 2500));
            Products.Add(new Product(prID++, "ZX", 250, 1995, 100, 2500));
            Products.Add(new Product(prID++, "Z ", 250, 1495, 100, 2500));
        }

        public static Part LookupPart(int i)
        {
            for (int j = 0; j < AllParts.Count; j++)
            {
                if (AllParts[j].ID.Equals(i))
                {
                    CurrPartX = j;
                    return AllParts[j];
                }
            }
            CurrPartX = -1;
            return null;
        }
        public static Product LookupProduct(int i)
        {
            for (int j = 0; j < Products.Count; j++)
            {
                if (Products[j].ID.Equals(i))
                {
                    CurrProdX = j;
                    return Products[j];
                }
            }
            CurrProdX = -1;
            return null;
        }
        public static void AddPart(Part pa)
        {
            AllParts.Add(pa);
        }
        public static void AddProduct(Product pr)
        {
            Products.Add(pr);
        }
        public static bool DeletePart(Part pa)
        {
            AllParts.RemoveAt(CurrPartX);
            return true;
        }
        public static bool RemoveProduct(int i)
        {
            Products.RemoveAt(CurrProdX);
            return true;
        }
        public static void UpdatePart(int i, Part pa)
        {
            AllParts.Insert(CurrPartX, pa);
            AllParts.RemoveAt(CurrPartX + 1);
        }
        public static void UpdateProduct(int i, Product pr)
        {
            Products.Insert(CurrProdX, pr);
            Products.RemoveAt(CurrProdX + 1);
            //Products[CurrProdX] = pr;//2 bees 1 stone
        }
    }
}
