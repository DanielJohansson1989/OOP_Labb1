namespace OOP_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);

            Circle circle2 = new Circle(6);

            Console.WriteLine($"The area of the first circle is {circle1.GetArea()}");

            Console.WriteLine($"The area of the second circle is {circle2.GetArea()}");

            Console.WriteLine($"The circumference of the first circle is {circle1.GetCircumference()}");
        }
    }
}