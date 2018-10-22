using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeBinding
{
    public partial class DialogShapeBS : Form
    {
        public DialogShapeBS()
        {
            InitializeComponent();
        }

        public BindingSource BS
        {
            get { return this.shapeComponentBindingSource;  }
            set { this.shapeComponentBindingSource = value; }
        }
    }
}
