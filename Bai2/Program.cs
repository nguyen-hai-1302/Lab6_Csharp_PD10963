using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Phone> phoneList = new List<Phone>();
            phoneList.Add(new Phone(1, 1, "IP 15", 100, "độc lạ Bình Dương"));
            phoneList.Add(new Phone(2, 2, "IP 16", 1000, "độc lạ Bình Dương"));
            phoneList.Add(new Phone(3, 3, "IP 17", 10000, "độc lạ Bình Dương"));
            phoneList.Add(new Phone(4, 1, "IP 18", 100000, "độc lạ Bình Dương"));
            List<Shop> shopList = new List<Shop>();
            shopList.Add(new Shop(1, "Hà Nội", "Quận Nam Từ Liên"));
            shopList.Add(new Shop(2, "HCM", "Quận 12"));
            shopList.Add(new Shop(3, "Đà Nẵng", "Quận Hải Châu"));
            //
            Console.WriteLine("Bai 2:");
            Console.WriteLine("Bai 2a:");
            var Query = from phone in phoneList
                        join shop in shopList on phone.shopId equals shop.id
                        select new
                        {
                            phone.id,
                            phone.name,
                            phone.price,
                            phone.des,
                            shop.city,
                            shop.district
                        };
            foreach (var result in Query)
            {
                Console.WriteLine("ShopID: " + result.id + " | Name: " + result.name + " | Price: " + result.price +
                                  " | Des: " + result.des + " | City: " + result.city + " | Dis: " + result.district);
            }
            //
            Console.WriteLine("Bai 2b:");
            var Group = shopList.GroupJoin(phoneList,
                                           shop => shop.id,
                                           phone => phone.shopId,
                                           (shop, phones) => new
                                           {
                                               shop.id,
                                               shop.city,
                                               shop.district,
                                               Phones = phones
                                           }
                );
            foreach (var shopGroup in Group)
            {
                Console.WriteLine("ShopID: " + shopGroup.id + " | City: " + shopGroup.city + " | District: " + shopGroup.district);
                Console.WriteLine("------------------------------------------------------");
                foreach (var phone in shopGroup.Phones)
                {
                    Console.WriteLine("|\t\tphoneName: " + phone.name );
                    Console.WriteLine("|\t\tphonePrice: " + phone.price);
                    Console.WriteLine("|\t\tphoneDes: " + phone.des);
                    Console.WriteLine("------------------------------------------------------");
                }
            }
            Console.ReadLine();
        }
    }
}
