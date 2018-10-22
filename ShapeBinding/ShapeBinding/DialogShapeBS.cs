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

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
 
        }

        public event EventHandler Apply;

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (Apply != null)
            {
                Apply(this, EventArgs.Empty);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            shapeComponentBindingSource.EndEdit();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
