namespace OOP_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);

            Circle circle2 = new Circle(6);

            Console.WriteLine(circle1.GetArea());

            Console.WriteLine(circle2.GetArea());
        }
    }

    public class Circle
    {
        private float _pi = 3.141f;
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public float GetArea()
        {
            return _radius * _radius * _pi;
        }
    }
}