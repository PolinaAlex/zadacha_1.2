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
            Console.WriteLine("Введите координаты точек первого отрезка:");
            Console.WriteLine("Координата X1 начала первого отрезка");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координата Y1 начала первого отрезка");
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координата X2 конца первого отрезка");
            Double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координата Y2 конца первого отрезка");
            Double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точек второго отрезка:");
            Console.WriteLine("Координата X3 начала первого отрезка");
            Double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координата Y3 начала первого отрезка");
            Double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координата X4 конца первого отрезка");
            Double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координата Y4 конца первого отрезка");
            Double y4 = Convert.ToDouble(Console.ReadLine());
            Double k1 = (y2 - y1) / (x2 - x1);
            Double k2 = (y4 - y3) / (x4 - x3);
            Double b1 = -k1 * x1 + y1;
            Double b2 = -k2 * x3 + y3;

            if (x1 - x2 == 0 || x3 - x4 == 0)
                Console.WriteLine("Неверные параметры (деление на ноль не приветствуется)");
            else
            {
                if (k1 == k2) // Проверяем прямые на параллельность
                {
                    if (b1 != b2)
                    {
                        Console.WriteLine("Отрезки лежат на параллельных прямых (не имеют общих точек)");
                    }
                    if (b1 == b2) // Проверяем, лежат ли отрезки на одной прямой.
                    {
                        Double ymax1 = Math.Max(y1, y2);
                        Double ymin1 = Math.Min(y1, y2);
                        Double ymax2 = Math.Max(y3, y4);
                        Double ymin2 = Math.Min(y3, y4);
                        if ((ymin1 <= y3 && y3 <= ymax1) || (ymin1 <= y4 && y4 <= ymax1) || (ymin2 <= y1 && y1 <= ymax2) || (ymin2 <= y2 && y2 <= ymax2))
                            Console.WriteLine("Отрезки лежат на одной прямой и имеют общие точки");
                        else Console.WriteLine("Отрезки лежат на одной прямой и не имеют общих точек");
                    }
                }
                else // Рассматриваем случай пересекающихся прямых.
                {
                    Double xp = (b2 - b1) / (k1 - k2);
                    Double xmax1 = Math.Max(x1, x2);
                    Double xmin1 = Math.Min(x1, x2);
                    Double xmax2 = Math.Max(x3, x4);
                    Double xmin2 = Math.Min(x3, x4);
                    if ((xmin1 <= xp && xp <= xmax1) && (xmin2 <= xp && xp <= xmax2))
                        Console.WriteLine("Отрезки лежат на пересекающихся прямых и имеют общую точку");
                    else Console.WriteLine("Отрезки лежат на пересекающихся прямых и не имеют общих точек");
                }
            }

            Console.WriteLine("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}