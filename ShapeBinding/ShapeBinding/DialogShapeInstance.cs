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
    public partial class DialogShapeInstance : Form
    {
        public DialogShapeInstance()
        {
            InitializeComponent();
            hiddenTextBox = new TextBox();
            this.Controls.Add(hiddenTextBox);
        }

        TextBox hiddenTextBox;

        Object dataSource;
        public Object DataSource
        {
            set
            {
                this.dataSource = value;
                hiddenTextBox.DataBindings.Clear();
                hiddenTextBox.DataBindings.Add("BackColor", dataSource, "BackColor");
                hiddenTextBox.DataBindings.Add("Location", dataSource, "Location");
            }
        }

        BindingManagerBase BindingManager
        {
            get { return this.BindingContext[dataSource]; }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position = 0;
            RefreshItems();
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            --this.BindingManager.Position;
            RefreshItems();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ++this.BindingManager.Position;
            RefreshItems();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.BindingManager.Position =
                this.BindingManager.Count - 1;
            RefreshItems();
        }

        void RefreshItems()
        {
            int count = this.BindingManager.Count;
            int position = this.BindingManager.Position + 1;

            this.labelPosition.Text = String.Format("{0} of {1}",
                position.ToString(), count.ToString());

            this.buttonStart.Enabled = position > 1;
            this.buttonPrev.Enabled = position > 1;
            this.buttonEnd.Enabled = position < count;
            this.buttonNext.Enabled = position < count;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.Color = hiddenTextBox.BackColor;
                colorDlg.ShowDialog();
                hiddenTextBox.BackColor = colorDlg.Color;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }
    }
}

