using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_
{
    class Outsource : Part //child2
    {
        public string CompanyName { get; set; }

        public Outsource(int id, string nm, int iv, decimal pc, int mn, int mx, string co) : base(id, nm, iv, pc, mn, mx)
        {
            CompanyName = co;
        }
    }
}
