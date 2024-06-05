using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Phone
    {
        public int id;
        public int shopId;
        public string name;
        public int price;
        public string des;
        public Phone(int id, int shopId, string name, int price, string des)
        {
            this.id = id;
            this.shopId = shopId;
            this.name = name;
            this.price = price;
            this.des = des;
        }
    }
}
