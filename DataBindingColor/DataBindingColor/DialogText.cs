using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingColor
{
    public partial class DialogText : Form, IBindingSource
    {
        public DialogText()
        {
            InitializeComponent();

        }

        public BindingSource DataBindingSource {
            get { return this.dataClassBindingSource; }
            set { this.dataClassBindingSource = value; }
        }

        private void DialogText_Load(object sender, EventArgs e)
        {

        }
    }
}
