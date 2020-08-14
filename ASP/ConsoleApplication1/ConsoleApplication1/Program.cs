using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Indonesia!");
            Console.WriteLine("Hello Lombok!");
            Console.WriteLine("Saya balajar C#!");

            string strpassword = "petanikode";

            if (strpassword == "petanikode")
            {
                Console.WriteLine("Selamat datang");
            }

        }

        public class Mobil
        {
            public double kecepatan;
            public double bensin;
            public double posisi;
            //public string nama;

            public void percepat()
            {
                this.kecepatan += 10;
                this.bensin -= 5;
            }
            public void maju()
            {
                this.posisi += this.kecepatan;
                this.bensin -= 2;
            }
            public void isiBensin(double bensin)
            {
                this.bensin += bensin;
            }

       }





    }
}
