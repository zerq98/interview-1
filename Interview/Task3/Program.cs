using System;
using Task3.Comparers;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var areaComparer = new AreaComparer();
            var result1 = areaComparer.Compare(new Square(5), new Sphere(4));
            var result2 = areaComparer.Compare(new Square(5), new Circle(5));
            var volumeComparer = new VolumeComparer();
            var result3 = volumeComparer.Compare(new Cube(30),new Sphere(30));
        }
    }
}
