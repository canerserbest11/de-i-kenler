using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger); // yazı olduğu için yanına ekledi

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // sayı değeri olduğu için yazıyı rakama çevirip topladı

            string datetime = DateTime.Now.ToString("dd/mm.yyyy");
            Console.WriteLine(datetime);
            string datetime2 = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(datetime2);
            Console.Read();
        }
    }
}