using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCurve
{
    internal static class DragonFractal
    {
        public static (double c, double d) Calc(double x, double y, double angle, int randomise)
        {
            var dx = (x * Math.Cos(angle) - y * Math.Sin(angle)) / Math.Sqrt(2) + randomise;
            var d = (x * Math.Sin(angle) + y * Math.Cos(angle)) / Math.Sqrt(2);
            var c = dx;
            return (c, d);
        }

        public static void DrawDragonFractal(Pixels pixels, int numOfIterations, int seed)
        {
            double c = 1, d = 0;
            var random = new Random(seed);
            while (numOfIterations-- > 0)
            {
                var randomise = random.Next(2);
                var angle = Math.PI / 4 + Math.PI / 2 * randomise;
                (c, d) = Calc(c, d, angle, randomise);
                pixels.SetPixel(c, d);
            }
        }
    }
}
