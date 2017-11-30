using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CreateAndnUseTypes
{

    public abstract class GeometricShape
    {
        public abstract void Draw();
    }
    public class Rectangle : GeometricShape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Rectangle.Draw");
        }
    }
    public class Circle : GeometricShape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Circle.Draw");
        }
    }
    public class Drawing
    {
        private ArrayList shapes;
        public Drawing()
        {
            shapes = new ArrayList();
        }
        public int Count
        {
            get
            {
                return shapes.Count;
            }
        }
        public GeometricShape this[int index]
        {
            get
            {
                return (GeometricShape)shapes[index];
            }
        }
        public void Add(GeometricShape shape)
        {
            shapes.Add(shape);
        }
    }
   
}


