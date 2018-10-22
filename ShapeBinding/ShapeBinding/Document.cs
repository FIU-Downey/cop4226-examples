using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeBinding
{
    public class Document
    {
        List<ShapeComponent> shapes = new List<ShapeComponent>();

        public List<ShapeComponent> Shapes
        {
            get { return shapes; }
        }

        public void Add(ShapeComponent shape)
        {
            shapes.Add(shape);
        }

        internal void Paint(Graphics graphics)
        {
            foreach (ShapeComponent shape in shapes)
            {
                shape.Paint(graphics);
            }
        }
    }
}
