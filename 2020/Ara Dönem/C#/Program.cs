using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Karesi Alınacak Sayiyi Gir:" );
            string a = Console.ReadLine();
            int sayi = Convert.ToInt32(a);
            Console.WriteLine(sayi * sayi);
            Console.ReadKey();




  
     

        }
    }
}
