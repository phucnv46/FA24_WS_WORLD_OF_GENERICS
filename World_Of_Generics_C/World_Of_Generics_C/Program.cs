using System.Numerics;
using System.Text;

namespace World_Of_Generics_C
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var tong = Total(3, 6, 7, -2.5, 0,21,32,32); // Đoán kiểu dữ liệu
            var hieu = Subtract<double>(3, 45, 3.2, .33);
            Console.WriteLine($"Tổng: {tong}, kiểu dữ liệu {tong.GetType()}");

        }

        static T Total<T>(params T[] values) where T : struct, INumber<T> 
       // Từ khóa params cho phép truyền vào không xác định phần từ cùng loại
        {
            dynamic sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }  static T Subtract<T>(params T[] values) where T : struct, INumber<T> 
       // Từ khóa params cho phép truyền vào không xác định phần từ cùng loại
        {
            dynamic sum = 0;
            foreach (var value in values)
            {
                sum -= value;
            }
            return sum;
        }
    }
}
