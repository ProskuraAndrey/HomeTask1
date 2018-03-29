using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    class Calculations
    {
        public double a, b, c, L, d, l, Sr, Sw,N;

        public void AreaWallCalculation()
        {
            Console.WriteLine("Enter the width  of the room:");
            Console.Write("a(m)= ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the room:");
            Console.Write("b(m)= ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the room:");
            Console.Write("c(m)= ");
            c = Convert.ToDouble(Console.ReadLine());

            Sr = (a + b) * c;
            Console.WriteLine("Surface area of walls Sr={0} m2", Sr);
        }

        public void AreaWallpaperCalculation()
        {
            Console.WriteLine("Enter the length of the wallpaper roll:");
            Console.Write("L(m)= ");
            L = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width  of the wallpaper roll(should be no more than 1 meter):");
            Console.Write("d(m)= ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the picture on the wallpaper:");
            Console.Write("l(m)= ");
            l = Convert.ToDouble(Console.ReadLine());

            Sw = L * d;
            Console.WriteLine("Area wallpaper roll Sw={0} m2", Sw);
        }

        public void QuantityMaterials()
        {
            Console.WriteLine("=========================================");
            if (c % l == 0)
            {
                Console.WriteLine("Number of rolls of wallpaper :");
                N = Sr / Sw;
                Console.WriteLine("N={0} pieces", N);
                Console.WriteLine("Number of wallpapers in meters - {0}m", N * L);
            }
            else
            {
                Console.WriteLine("Number of rolls of wallpaper :");
                N = Sr / Sw;
                Console.WriteLine("N={0} pieces", N);
                Console.WriteLine("Number of wallpapers in meters - {0}m", N * L);
                double remainder = c % l;
                double temp1 = (a + b) / d;
                double temp2 = (a + b) % d;
                if (temp2 < 1)
                    temp2 = 1;
                double AreaRemainder = remainder * temp1;
                Console.WriteLine("Remainder = {0} m", AreaRemainder);
                Console.WriteLine("Remainder = {0} pieces", AreaRemainder / 10);
            }
            Console.WriteLine("=========================================");
        }
    }
}
