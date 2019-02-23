using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fracciones
{
    class Frac
    {
        private int num;
        private int den;
        public Frac(int num, int den)
        {
            this.num = num;
            this.den = den;
        }
        public Frac()
        {
            num = 1;
            den = 1;
        }
        public static Frac operator +(Frac x, Frac y)
        {
            Frac result = new
            Frac(x.num * y.den + x.den * y.num, x.den * y.den);
            return result;
        }
        public static Frac operator -(Frac x, Frac y)
        {
            Frac result = new
            Frac(x.num * y.den - x.den * y.num, x.den * y.den);
            return result;
        }
        public static Frac operator *(Frac x, Frac y)
        {
            Frac result = new
            Frac(x.num * y.num, x.den * y.den);
            return result;
        }
        public static Frac operator /(Frac x, Frac y)
        {
            Frac result = new
            Frac(x.num * y.den, x.den * y.num);
            return result;
        }
        public decimal a_decimal()
            {
            return num / den;
        }
        public void imprime()
        {
            Console.WriteLine("{0}/{1}", num, den);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Frac a = new Frac(1, 2);
            Frac b = new Frac(2, 4);
            a.imprime();
            b.imprime();
            Frac c = new Frac();
            c= a + b;
            c.imprime();
            Frac d = new Frac();
            d = a - b;
            d.imprime();
            Frac e = new Frac();
            e = a * b;
            e.imprime();
            Frac f = new Frac();
            f = a / b;
            f.imprime();
            Console.ReadKey();
        }

    }
}
