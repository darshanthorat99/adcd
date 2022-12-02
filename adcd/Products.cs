using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adcd
{
    public class Products
    {
        private int cid;
        private string name;
        private double nprices, dis,prices,discount;

        public void ShowUse(int cid, string name, int prices, int discount)
        {
            this.cid = cid;
            this.name = name;
            this.prices = prices;
            this.discount = discount;
        }
        public void Calculate()
        {
            dis = prices * (discount / 100);
            nprices = prices - dis;
        }
        public string Print()
        {
            return $"product name {name}\n prices {nprices}";
        }

    }
}
