Console.WriteLine("Value type demo:");
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1;

p2.X = 200;

Console.Write("p1 -- ");
p1.Print();

Console.Write("p2 -- ");
p2.Print();

Console.Write("Reference type demo:");
PointRef r1 = new PointRef { X = 1, Y = 2 };
PointRef r2 = r1;
r2.X = 200;

Console.Write("r1 -- ");
r1.Print();
Console.Write("r2 -- ");
r2.Print();

Console.Write("Boxing demo:");
BoxingTester.Test();
