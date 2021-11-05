using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_4_1204029
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("MENU PERSEGI PANJANG \n");
            Console.Write("1. Hitung Luas \n");
            Console.Write("2. Hitung Keliling \n");
            Console.Write("3. Hitung Panjang Diagonal \n");

            Console.Write("Menu Pilihan : ");
            int mp = Convert.ToInt16(Console.ReadLine());

            if (mp <= 1)
            {
                Console.WriteLine("LUAS PERSEGI PANJANG\n");
                Console.Write("Masukan Panjang : ");
                int pan = Convert.ToInt16(Console.ReadLine());
                Console.Write("Masukan Lebar : \n");
                int leb = Convert.ToInt16(Console.ReadLine());

                
                int hasil1 = pan * leb;
                Console.WriteLine("Luas Persegi Panjang : {0}", hasil1);

            }
            else if (mp <= 2)
            {
                Console.WriteLine("KELILING PERSEGI PANJANG");
                Console.Write("Masukan Panjang : ");
                int pan1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("Masukan Lebar : ");
                int leb1 = Convert.ToInt16(Console.ReadLine());


                int hasil2 = 2*( pan1 * leb1);
                Console.WriteLine("Luas Persegi Panjang : {0}", hasil2);
            }
            else if (mp <= 3)
            {
                Console.WriteLine("PANJANG DIAGONAL PERSEGI PANJANG");
                Console.Write("Masukan Panjang : ");
                double pan2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukan Lebar : ");
                double leb2 = Convert.ToDouble(Console.ReadLine());
                


                double hasil3 = (pan2*pan2)+(leb2*leb2);
                double total = Math.Sqrt(hasil3);
                Console.WriteLine("Luas Persegi Panjang : {0}", total);
            }
        }
    }
}
