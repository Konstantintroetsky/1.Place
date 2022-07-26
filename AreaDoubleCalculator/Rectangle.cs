using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDoubleCalculator
{
    internal class Rectangle
    {
        // Поля описывающие длины сторон прямоугольника
        private double side1;
        private double side2;
        private double area;
        private double perimeter;

        // Свойства класса для доступа к изменению и чтению полей
        public double SideOne
        {
            get { return side1; }
            set { side1 = value; }
        }
        public double SideTwo
        {
            get { return side2; }
            set { side2 = value; }
        }

        public double Area
        {
            get { return area; }
        }
        public double Perimeter
        {
            get { return perimeter; }
        }


        public double Perimetr1
        {
            get { return this.PerimeterCalculator(); }
        }

        public double Area1
        {
            get { return this.AreaCalculator(); }
        }

        // Конструктор принимающий 2 аргумента 
        public Rectangle(double side1, double side2)
        {
            SideOne = side1;
            SideTwo = side2;
        }

        // Метод для расчета площади прямоугольника
        public double AreaCalculator()
        {
            area = side1 * side2;
            return Area;            
        }

        public double PerimeterCalculator()
        {
            perimeter = (side1 + side2) * 2;
            return Perimeter;
        }




    }
}
