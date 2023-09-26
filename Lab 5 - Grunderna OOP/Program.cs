namespace Lab_5___Grunderna_OOP
{
    class Circle
    {
        float _pi = 3.141f;
        int _Radius;

        public Circle(int radius)
        {
            _Radius = radius;
        }

        public void getArea()
        {
            float area = _Radius * _Radius * _pi;
            Console.WriteLine($"Cirkelns area ar {area}!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle = new Circle(5);
            firstCircle.getArea();

            Circle secondCircle = new Circle(6);
            secondCircle.getArea();
        }
    }
}