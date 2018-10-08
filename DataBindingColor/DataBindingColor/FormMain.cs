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
    public partial class FormMain : Form
    {
        DataClass data;
        public FormMain()
        {
            InitializeComponent();
            data = new DataClass();
            data.Text = this.BackColor.Name;
        }

        private void buttonOpenColorForm_Click(object sender, EventArgs e)
        {
            DialogText dlg = new DialogText();
            dlg.DataBindingSource.DataSource = data;
            dlg.ShowDialog();
            this.BackColor = Color.FromName(data.Text);

        }
    }
}
