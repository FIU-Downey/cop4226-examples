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
    public partial class DialogShape : Form, IShapeComponent
    {

        public DialogShape()
        {
            InitializeComponent();

        }

        Object dataSource;
        public Object DataSource
        {
            set {
                this.dataSource = value;
                rTextBox.DataBindings.Add("Text", dataSource, "R");
                gTextBox.DataBindings.Add("Text", dataSource, "G");
                bTextBox.DataBindings.Add("Text", dataSource, "B");
                xTextBox.DataBindings.Add("Text", dataSource, "X");
                yTextBox.DataBindings.Add("Text", dataSource, "Y");
            }
        }

        public TextBox R { get => rTextBox; }
        public TextBox G { get => gTextBox; }
        public TextBox B { get => bTextBox; }
        public TextBox X { get => xTextBox; }
        public TextBox Y { get => yTextBox; }

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
    }
}
