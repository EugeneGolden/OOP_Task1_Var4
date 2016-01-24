using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создать класс Rectangle, разработав следующие элементы класса:
a. Поля:
double a, b; // стороны прямоугольника
b.  Конструктор, позволяющий создать экземпляр класса:
с одним параметром,  задающим  сторону  квадрата;
с заданными длинами сторон.
c. Методы, позволяющие:
вывести длины сторон прямоугольника на экран;
получить периметр прямоугольника;
получить площадь прямоугольника.
*/
namespace OOP_Task1_Var4
{
    class Rectangle
    {
        double a, b;
        public Rectangle(double squareSide)
        {
            a = squareSide;
            b = squareSide;
        }

        public Rectangle(double length, double width)
        {
            a = length;
            b = width;
        }

        public void Print()
        {
            Console.WriteLine("Length = " + a);
            Console.WriteLine("Width = " + b);
        }

        public double Perimeter()
        {
            return 2 * a + 2 * b;
        }

        public double Square()
        {
            return a * b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            Rectangle rec1 = new Rectangle(a);
            rec1.Print();
            Console.WriteLine(rec1.Perimeter());
            Console.WriteLine(rec1.Square());
            
            a = 7;
            double b = 8;
            Rectangle rec2 = new Rectangle(a, b);
            rec2.Print();
            Console.WriteLine(rec2.Perimeter());
            Console.WriteLine(rec2.Square());

            Console.ReadKey();
        }
    }
}
