using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***   Fun for a room   ***");
            Calculations calc = new Calculations();

            Console.WriteLine("Enter room parameters ");
            calc.AreaWallCalculation();

            Console.WriteLine("Enter the size of the wallpaper roll");
            calc.AreaWallpaperCalculation();

            calc.QuantityMaterials();

            Console.ReadLine();
        }
    }
}
