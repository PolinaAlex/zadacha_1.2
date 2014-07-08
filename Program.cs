using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Координаты точек первого отрезка АВ");
            Console.WriteLine("Введите координату Х1 для точки А:");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y1 для точки А:");
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Х2 для точки В:");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y2 для точки В:");
            Double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Координаты точек второго отрезка СD");
            Console.WriteLine("Введите координату Х3 для точки С:");
            Double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y3 для точки С:");
            Double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Х4 для точки D:");
            Double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y4 для точки D:");
            Double y4 = Convert.ToDouble(Console.ReadLine());

            Double k1 = (x2 - x1) / (y2 - y1);
            Double k2 = (x4 - x3) / (y4 - y3);
            Double b1 = -k1 * x1 + y1;
            Double b2 = -k2 * x3 + y3;

            if (k1 == k2 && b1 == b2) // Проверяем, лежат ли отрезки AB и CD на одной прямой.
            {
                Double ymax1 = Math.Max(y1, y2);
                Double ymin1 = Math.Min(y1, y2);
                Double ymax2 = Math.Max(y3, y4);
                Double ymin2 = Math.Min(y3, y4);

                if ((ymin1 < y3 && y3 < ymax1) || (ymin1 < y4 && y4 < ymax1) || (ymin2 < y1 && y1 < ymax2) || (ymin2 < y2 && y2 < ymax2))

                    Console.WriteLine("Отрезки лежат на одной прямой и имеют общие точки");
                else Console.WriteLine("Отрезки лежат на одной прямой и не имеют общих точек");
            }

            if (k1 == k2 && b1 != b2) // Проверяем, параллельны ли отрезки AB и CD.
            {
                Console.WriteLine("Отрезки параллельных. Общих точек нет)");
            }

            if (k1 != k2) // Рассматрим случай пересекающихся прямых.
            {
                Double xp = (b2 - b1) / (k1 - k2);
                Double xmax1 = Math.Max(x1, x2);
                Double xmin1 = Math.Min(x1, x2);
                Double xmax2 = Math.Max(x3, x4);
                Double xmin2 = Math.Min(x3, x4);

                if ((xmin1 < xp && xp < xmax1) && (xmin2 < xp && xp < xmax2))

                    Console.WriteLine("Отрезки лежат на пересекающихся прямых и имеют общую точки");
            }
            else Console.WriteLine("Отрезки лежат на пересекающихся прямых и не имеют общих точек");
            Console.ReadKey();
        }
    }
}
