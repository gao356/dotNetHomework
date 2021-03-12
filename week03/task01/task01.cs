using System;

namespace task01
{
    public interface Shape
    {
        double GetArea(); //计算面积
        bool IsValid(); //判断图形是否合法
    }

    public class Triangle : Shape
    {
        private double baseLength; //底边长度
        private double height; //高

        public Triangle(double _base, double height)
        {
            this.baseLength = _base;
            this.height = height;
        }

        public double BaseLength { set; get; }
        public double Height { set; get; }

        public double GetArea()
        {
            if (!this.IsValid()) return 0; //若边长不合法则输出0
            return baseLength * height * 0.5;
        }

        public bool IsValid()
        {
            return (baseLength > 0 && height > 0);
        }
    }

    public class Rectangle : Shape
    {
        private double baseLength; // 底边长度
        private double height; // 高度

        public Rectangle(double b, double h)
        {
            baseLength = b;
            height = h;
        }

        public virtual double BaseLength { set; get; }
        public virtual double Height { set; get; }

        public double GetArea()
        {
            if (!this.IsValid()) return 0;
            return baseLength * height;
        }

        public virtual bool IsValid()
        {
            return (baseLength > 0 && height > 0);
        }
    }

    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }

        public override double BaseLength {
            get {
                return this.BaseLength;
            } set {
                this.BaseLength = value;
                this.Height = value;
            }   
        }
        public override double Height {
            get
            {
                return this.Height;
            }
            set
            {
                this.BaseLength = value;
                this.Height = value;
            }
        }

        public override bool IsValid()
        {
            return (BaseLength > 0 && Height > 0 && (BaseLength == Height));
        }
    }

    class MainClass
    {
        static void Main()
        {
            Shape square = new Square(4);
            Console.WriteLine("The area of this square is {0}", square.GetArea());
            Shape triangle = new Triangle(3, 4);
            Console.WriteLine("The area of this triangle is {0}", triangle.GetArea());
            Shape rec = new Rectangle(3, 4);
            Console.WriteLine("The area of this rectangle is {0}", rec.GetArea());
        }
    }
}
