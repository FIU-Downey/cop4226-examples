﻿using System;
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
        List<Shape> shapes = new List<Shape>();

        public List<Shape> Shapes
        {
            get { return shapes; }
        }

        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }

        internal void Paint(Graphics graphics)
        {
            foreach (Shape shape in shapes)
            {
                shape.Paint(graphics);
            }
        }
    }
}
