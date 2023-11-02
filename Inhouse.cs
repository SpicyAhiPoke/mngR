using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace IMS_
{
    class Inhouse : Part //derived class(child)
    {
        public int MachID { get; set; }

        public Inhouse(int id, string nm, int iv, decimal pc, int mn, int mx, int mc) : base(id, nm, iv, pc , mn, mx)
        {
            MachID = mc;
        }
    }
}
