namespace Lab_5___Grunderna_OOP
{
    class Sphere
    {
        float _pi = 3.141f;
        int _Radius;

        public Sphere(int radius)
        {
            _Radius = radius;
        }

        public void getArea()
        {
            float area = 4 * _pi * (_Radius*_Radius);
            Console.WriteLine($"Sfarens area ar {area} kvadratcentimeter!");
        }
        public void getVolume()
        {
            float volume = (4/3)*_pi * (_Radius * _Radius *_Radius);
            Console.WriteLine($"Sfarens volym ar {volume} kubikcentimeter!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sphere firstSphere = new Sphere(5);
            firstSphere.getArea();
            firstSphere.getVolume();

            Sphere secondSphere = new Sphere(6);
            secondSphere.getArea();
            secondSphere.getVolume();
        }
    }
}