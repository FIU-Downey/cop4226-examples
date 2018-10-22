using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeBinding
{
    interface IShapeComponent
    {
        TextBox R { get; }
        TextBox G { get; }
        TextBox B { get; }
        TextBox X { get; }
        TextBox Y { get; }

    }
}
