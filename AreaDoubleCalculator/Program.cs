using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDoubleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация объекта класса

            /*Console.WriteLine("***** Вычисление периметра и площади прямоугольника*****\n");
            Console.WriteLine(" Введите длину прямоугольника: ");
            double side1;
            double side2;
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите ширину прямоугольника: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle CalculateRectangle = new Rectangle(side1, side2);
            CalculateRectangle.AreaCalculator(CalculateRectangle.SideOne, CalculateRectangle.SideTwo);
            CalculateRectangle.PerimeterCalculator(CalculateRectangle.SideOne, CalculateRectangle.SideTwo);
            Console.WriteLine("Площадь прямоугольника: {0}\n" +
                "Периметр прямоугольника: {1}",CalculateRectangle.Area, CalculateRectangle.Perimeter);
            Console.ReadLine();
            */
            Console.WriteLine("***** Вычисление периметра и площади прямоугольника*****\n");
            Console.WriteLine(" Введите длину прямоугольника: ");
            double side1, side2;
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите ширину прямоугольника: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle CalculateRectangle = new Rectangle(side1, side2);
            Console.WriteLine("Периметр прямоугольника: {0}\n" +
                "Площадь прямоугольника: {1} ", CalculateRectangle.Perimetr1, CalculateRectangle.Area1);
            Console.ReadLine();
        }
    }
}
