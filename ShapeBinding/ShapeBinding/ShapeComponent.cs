using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeBinding
{
    public class ShapeComponent : INotifyPropertyChanged
    {

        int x;
        public int X
        {
            get { return x; }
            set
            {
                OnChange("X");
                this.x = value;
            }
        }

        int y;
        public int Y
        {
            get { return y; }
            set
            {
                OnChange("Y");
                this.y = value;
            }
        }

        int b;
        public int B
        {
            get { return b; }
            set
            {
                OnChange("B");
                this.b = value;
            }
        }

        int g;
        public int G
        {
            get { return g; }
            set
            {
                OnChange("G");
                this.g = value;
            }
        }

        int r;
        public int R
        {
            get { return r; }
            set
            {
                OnChange("R");
                this.r = value;
            }
        }

        internal void Paint(Graphics graphics)
        {
            Color color = Color.FromArgb(r, g, b);
            using (Brush b = new SolidBrush(color))
            {
                graphics.FillEllipse(b, new Rectangle(new Point(X, Y), new Size(100, 50)));
            }
        }

        public ShapeComponent(Color backColor, Point point)
        {
            this.R = backColor.R;
            this.G = backColor.G;
            this.B = backColor.B;
            this.X = point.X;
            this.Y = point.Y;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnChange(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
