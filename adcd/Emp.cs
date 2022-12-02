using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace adcd
{
    public class Emp
    {
        private int eid;
        private string name;
        private double bs, hra, da, pf, total,net;

        public void GetValues(int eid, string name, int bs)
        {
            this.eid = eid;
            this.name = name;
            this.bs = bs;
        }
        public void Salary()
        {
            hra = bs * 0.4;
            da = bs * 0.2;
            pf = bs * 0.12;
            total = bs + hra + da;
            net = total - pf;
        }
        public string Print()
        {
            return $"name  {name}\n salary {total} \n net salary{net}";
        }
    }


}    