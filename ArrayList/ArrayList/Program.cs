using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Đầu tiên ta sẽ khởi tạo ArrayList
            ArrayList arrayList = new ArrayList();

            //  Ta có thể khởi tạo và chỉ định Capacity ban đầu cho nó
            ArrayList MyHash2 = new ArrayList(6);

            // Ta add value
            arrayList.Add("NguyenPro");
            arrayList.Add("Trang");
            arrayList.Add("Nhi");

            //In ra so phan tu trong ArrayList
            Console.WriteLine("So phan tu trong ArrayList: " + arrayList.Count);
            // In ra các value
            foreach(object item in arrayList)
            {
                Console.WriteLine();
                Console.WriteLine(""+item);
            }
            
        }
    }
}
