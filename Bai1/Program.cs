using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> listInt = new List<int>() { 2, 4, 5, 6, 7, 8, 9 };
            List<string> listString = new List<string>() { null, "T1", "T2", "T3", null };
            List<String> listNull = new List<String>();
            //
            Console.WriteLine("Bai 1: ");
            Console.WriteLine("Bai 1a: Tìm số chẵn đầu tiên và lớn hơn 5 trong listInt");
            var first = listInt.FirstOrDefault(x => x % 2 == 0 && x > 5);            
            if (first != 0)
            {
                Console.WriteLine("Số chẵn đầu tiên và lớn hơn 5 trong listInt: " + first);
            }
            else
            {
                Console.WriteLine("Không có giá trị trong listInt!");
            }
            // 
            Console.WriteLine();
            Console.WriteLine("Bai 1b: Tìm phần tử cuối cùng trong listInt có giá trị > 200");
            var last = listInt.LastOrDefault(x => x > 200);
            if (last != 0)
            {                
                Console.WriteLine("Phần tử cuối cùng trong listInt có giá trị > 200: " + last);
            }
            else
            {
                Console.WriteLine("Không có giá trị trong listInt!");
            }
            //
            Console.WriteLine();
            Console.WriteLine("Bai 1c: Tìm phần tử đầu tiên trong listStr có giá trị bắt đầu bằng ký tự “T”");
            var str = listString.FirstOrDefault(x => x != null && x.Contains("T"));
            if (str != null)
            {
                Console.WriteLine("Phần tử đầu tiên trong listStr có giá trị bắt đầu bằng ký tự “T”: " + str);
            }
            else
            {
                Console.WriteLine("Không có phần tử nào trong listStr có giá trị bắt đầu bằng ký tự “T”");
            }
            //
            Console.WriteLine();
            Console.WriteLine("Bai 1d: Tính tổng các trị tại vị trí index lẻ và số đó chia hết cho 2 trong listInt");
            var index = listInt.Where((x, y) => x % 2 == 0 && y % 2 == 0).Sum();
            Console.WriteLine("Tổng: " + index);
            Console.Read();
        }
    }
}
