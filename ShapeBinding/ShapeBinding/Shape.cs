using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeBinding
{
    public class Shape : INotifyPropertyChanged
    {

        Color backColor;
        public Color BackColor
        {
            get { return backColor; }
            set {
                OnChange("BackColor");
                this.backColor = value;
            }
        }

        internal void Paint(Graphics graphics)
        {
            using (Brush b = new SolidBrush(BackColor)) { 
                graphics.FillEllipse(b, new Rectangle(Location, new Size(100, 50)));
            }
        }

        Point location;

        public Shape(Color backColor, Point point)
        {
            this.BackColor = backColor;
            this.Location = point;
        }

        public Point Location
        {
            get { return location; }
            set {
                OnChange("Location");
                this.location = value;
            }
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
