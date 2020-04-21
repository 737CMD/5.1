using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая5._1
{
    class figure
    {
        protected int x;
        protected int y;
        public figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public figure()
        {
            x = 0;
            y = 0;
        }
        public void show()
        {
            Console.WriteLine("Координаты стартовой точки: ({0}, {1})", x, y);
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { x = value; }
        }
    }
    class triangle : figure
    {
        int a;
        int b;
        double beta;
        public triangle(int x, int y, int beta, int a, int b) : base(x, y)
        {
            this.a = a;
            this.b = b;
            this.beta = beta * 0.017;
        }
        public triangle():base()
        {
            a = 5;
            b = 7;
            beta = 50 * 0.017;
        }
        new public void show()
        {
            base.show();
            Console.WriteLine("Первая Сторона: {0}; вторая сторона: {1}; угол={2:F2} (в радианах)", a, b, beta);
        }
        public double area()
        {
            return a * b * Math.Sin(beta);
        }
        public double C
        {
            get { return Math.Sqrt(Math.Pow(x, 2)+Math.Pow(y,2)-2*Math.Cos(beta)*x*y); }
        }
        public bool isrb
        {
            get
            {
                if(a==b&&a==C&&b==C)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
    class rectangle:figure
    {
        int width;
        int height;
        public rectangle():base()
        {
            width = 4;
            height = 8;
        }
        public rectangle(int x, int y, int width, int height):base(x,y)
        {
            this.width = width;
            this.height = height;
        }
        new public void show()
        {
            base.show();
            Console.WriteLine("Ширина прямоугольника: " + width + "; Высота: " + height);
        }
        public double area()
        {
            return width * height;
        }
        public bool IsSquare
        {
            get
            {
                if (width == height) return true;
                else return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ну ща момент всё ща обрисуем про объекты всякие разные. Короче, вводим сначала для треугольника всё по очереди. Координата х начальной точки, координата у начальной точки, длина первой стороны, длина второй стороны, угол между ними");
            triangle objtr1 = new triangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            triangle objtr2 = new triangle();
            rectangle objrec1 = new rectangle();
            Console.WriteLine("Ну вот сейчас вводим всё для прямоугольника ровно по очереди. Координата х начальной точки, координата у начальной точки, длина первой стороны, длина второй стороны.");
            rectangle objrec2 = new rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Ну всё, замечательно, ща обрисуем всё");
            Console.WriteLine("Характеристики первого треугольника:");
            objtr1.show();
            Console.WriteLine("Первый треугольник равнобедренный? {0}. Площадь треугольника: {1:F2}", objtr1.isrb, objtr1.area());
            Console.WriteLine("Характеристики второго треугольника:");
            objtr2.show();
            Console.WriteLine("Второй треугольник равнобедренный? {0}. Площадь треугольника: {1:F2}", objtr2.isrb, objtr2.area());
            Console.WriteLine("Характеристики первого прямоугольника:");
            objrec1.show();
            Console.WriteLine("Первый прямоугольник - квадрат? {0}. Площадь первого прямоугольника: {1}", objrec1.IsSquare, objrec1.area());
            Console.WriteLine("Характеристики первого прямоугольника:");
            objrec2.show();
            Console.WriteLine("Второй прямоугольник - квадрат? {0}. Площадь второго прямоугольника: {1}", objrec2.IsSquare, objrec2.area());
            Console.ReadKey();
        }
    }
}
