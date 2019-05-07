using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Đầu tiên ta sẽ khởi tạo HashTable, cấu trúc giống như khởi tạo ArrayList vậy
            Hashtable MyHash = new Hashtable();

            // Vì giống 1 ArrayList nên ta có thể khởi tạo và chỉ định Capacity ban đầu cho nó
            Hashtable MyHash2 = new Hashtable(6);

            // Ta add 1 cặp key và value
            MyHash.Add("N", "NguyenPro");
            MyHash.Add("T", "Trang");
            MyHash.Add("N1", "Nhi");

            // Count and WriteLine hashtable
            #region
            // Kiểm tra số phần tử trong MyHash và in ra
            Console.WriteLine("So phan tu trong hash: " + MyHash.Count);
            Console.WriteLine();

            // Ta sẽ xuất các phần tử ra từ HashTable vừa tạo
            // Bằng cách:
            //          * Duyệt(chạy) qua các phần tử trong MyHash
            //          * Vì mỗi phần tử là 1 DictionaryEntry nên ta sẽ chỉ định kiểu
            //              dữ liệu cho item là DictionaryEntry luôn.
            //          * Và in ra màn hình key và value của các phần tử được duyệt qua
            foreach (DictionaryEntry item in MyHash)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.WriteLine();
            #endregion

            // WriteLine 1 phan tu co gia tri va k co gia tri
            #region
            //// Ta sẽ in ra value của 1 key nằm trong MyHash
            //Console.WriteLine("Key: N" + "\t"+"Value: "+MyHash["N"]);
            //Console.WriteLine();

            //// Ta sẽ in ra value của 1 key không nằm trong MyHash
            //Console.WriteLine("Key: A" + "\t"+"Value: " + MyHash["A"]);
            //Console.WriteLine();

            //// Vì khi 1 Key không có trong hash mà ta tìm thì hashtable sẽ tự động thêm key đó
            ////      và gắn value của key = null
            //if (MyHash["A"] == null)
            //{
            //    Console.WriteLine("Gia tri cua Key A là null ");
            //    Console.WriteLine();
            //}
            #endregion

            // Add and seen
            #region
            //// Nếu ta thêm cặp key value nữa thì bảng ra sao?
            //MyHash.Add("B", "123");

            //MyHash.Add("C", "456");

            //// Kiểm tra số phần tử trong MyHash và in ra
            //Console.WriteLine("So phan tu trong hash: " + MyHash.Count);
            //Console.WriteLine();

            //// Ta sẽ xuất các phần tử ra từ HashTable vừa tạo
            //// Bằng cách:
            ////          * Duyệt(chạy) qua các phần tử trong MyHash
            ////          * Vì mỗi phần tử là 1 DictionaryEntry nên ta sẽ chỉ định kiểu
            ////              dữ liệu cho item là DictionaryEntry luôn.
            ////          * Và in ra màn hình key và value của các phần tử được duyệt qua
            //foreach (DictionaryEntry item in MyHash)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}
            #endregion

            //Clear
            #region
            //// Clear
            //MyHash.Clear();

            //// Kiểm tra số phần tử trong MyHash và in ra
            //Console.WriteLine("So phan tu trong hash: " + MyHash.Count);
            //Console.WriteLine();

            //// Ta sẽ xuất các phần tử ra từ HashTable vừa tạo
            //// Bằng cách:
            ////          * Duyệt(chạy) qua các phần tử trong MyHash
            ////          * Vì mỗi phần tử là 1 DictionaryEntry nên ta sẽ chỉ định kiểu
            ////              dữ liệu cho item là DictionaryEntry luôn.
            ////          * Và in ra màn hình key và value của các phần tử được duyệt qua
            //foreach (DictionaryEntry item in MyHash)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}
            #endregion

            //Remove
            #region
            //MyHash.Remove("N");

            //// Kiểm tra số phần tử trong MyHash và in ra
            //Console.WriteLine("So phan tu trong hash: " + MyHash.Count);
            //Console.WriteLine();

            //// Ta sẽ xuất các phần tử ra từ HashTable vừa tạo
            //// Bằng cách:
            ////          * Duyệt(chạy) qua các phần tử trong MyHash
            ////          * Vì mỗi phần tử là 1 DictionaryEntry nên ta sẽ chỉ định kiểu
            ////              dữ liệu cho item là DictionaryEntry luôn.
            ////          * Và in ra màn hình key và value của các phần tử được duyệt qua
            //foreach (DictionaryEntry item in MyHash)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}
            //Console.WriteLine();
            #endregion

            //Clone
            #region
            //MyHash.Clone();
            //// Kiểm tra số phần tử trong MyHash và in ra
            //Console.WriteLine("So phan tu trong hash: " + MyHash.Count);
            //Console.WriteLine();

            //// Ta sẽ xuất các phần tử ra từ HashTable vừa tạo
            //// Bằng cách:
            ////          * Duyệt(chạy) qua các phần tử trong MyHash
            ////          * Vì mỗi phần tử là 1 DictionaryEntry nên ta sẽ chỉ định kiểu
            ////              dữ liệu cho item là DictionaryEntry luôn.
            ////          * Và in ra màn hình key và value của các phần tử được duyệt qua
            //foreach (DictionaryEntry item in MyHash)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}
            //Console.WriteLine();
            #endregion

            

            Console.ReadLine();
        }
    }
}
