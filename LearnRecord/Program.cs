namespace LearnRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1, 2);
            var p2 = new Point(1, 2);
            var p3 = new Point { X = 3, Y = 4, Z = 2 };
            //Console.WriteLine(p1);
            //Console.WriteLine(p1.Equals(p2));
            //Console.WriteLine(Object.ReferenceEquals(p1, p2));
            //// p2 = p1; // p2 now points to the same object as p1
            //Console.WriteLine(Object.ReferenceEquals(p1, p2));
            //Console.WriteLine(p1.Equals(p2));
            //Console.WriteLine(p1.GetHashCode() + " " + p2.GetHashCode()); //GetHashCode: from object class



            var p222 = new Point2(1, 2);
            var ppp = new Point22(1, 2);
            //var (s, d) = p111;
            //var aa = new Point2 { X = 3, Y = 4 };
            //Console.WriteLine(aa + " " + s);
            //Console.WriteLine(p111.Equals(p222)); // true records compare values, not references.
            //Console.WriteLine(p111.GetHashCode() + " " + p222.GetHashCode());


            var pp1 = new Point3(1, 2);
            var pp2 = pp1 with { X = 11010 }; // Creates a new record without modifying the original.
            // pp1.X = 20;
            Console.WriteLine(pp2);


            var testbranch1 = new StructBranch1(1);
            testbranch1.X = 10;
        }

        class Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public Point()
            {

            }
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; init; }
            public override bool Equals(object? obj)
            {
                Point p = obj as Point;
                if (p is null)
                {
                    return false;
                }
                return p.X == X && p.Y == Y;
            }
            public override int GetHashCode()
            {
                return X.GetHashCode() ^ Y.GetHashCode();
            }
        }

        record Point2(int X, int Y)
        {
            public Point2() : this(0, 0)
            {

            }
        }
        record Point22 : Point2
        {
            public Point22(int x, int y) : base(x, y)
            {
            }
        }
        public record struct Point3(int X, int Y); // postioned record struct can assgin values to properties 

        record TestBranches(int x);
        record TestMainBranche(int x);

        public record struct StructBranch1(int X);
    }
}
