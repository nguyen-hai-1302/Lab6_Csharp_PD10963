using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Shop
    {
        public int id;
        public string city;
        public string district;
        public Shop(int id, string city, string district)
        {
            this.id = id;
            this.city = city;
            this.district = district;
        }
    }
}
