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
    public partial class FormMain : Form
    {
        Document doc;
        DialogShape dlg;
        DialogShapeBS dlgBS;
        public FormMain()
        {
            InitializeComponent();
            doc = new Document();
            doc.Add(new ShapeComponent(Color.Red, new Point(10, 20)));
            doc.Add(new ShapeComponent(Color.Blue, new Point(100, 20)));
            doc.Add(new ShapeComponent(Color.Green, new Point(200, 20)));

            dlg = new DialogShape();
            dlgBS = new DialogShapeBS();

            //dlg.R.DataBindings.Add("Text", this.doc.Shapes, "R");
            //dlg.G.DataBindings.Add("Text", this.doc.Shapes, "G");
            //dlg.B.DataBindings.Add("Text", this.doc.Shapes, "B");
            //dlg.X.DataBindings.Add("Text", this.doc.Shapes, "X");
            //dlg.Y.DataBindings.Add("Text", this.doc.Shapes, "Y");
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            doc.Paint(e.Graphics);
        }
        #region Binding Manager

        BindingManagerBase BindingManager
        {
            get { return this.BindingContext[this.doc.Shapes]; }
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

            //this.labelPosition.Text = String.Format("{0} of {1}",
            //    position.ToString(), count.ToString());

            //this.buttonStart.Enabled = position > 1;
            //this.buttonBack.Enabled = position > 1;
            //this.buttonEnd.Enabled = position < count;
            //this.buttonNext.Enabled = position < count;
        }

        private void buttonAddWinMan_Click(object sender, EventArgs e)
        {
            //((RaceCarDriver)this.BindingManager.Current).Wins++;
        }


        #endregion

        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //dlg.DataSource = doc.Shapes;
                //dlg.ShowDialog();
                dlgBS.BS.DataSource = doc.Shapes;
                dlgBS.ShowDialog();
                this.Invalidate();
            }
        }
    }
}
