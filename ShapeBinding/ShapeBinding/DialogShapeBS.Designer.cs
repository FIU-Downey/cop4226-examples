namespace ShapeBinding
{
    partial class DialogShapeBS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label gLabel;
            System.Windows.Forms.Label rLabel;
            System.Windows.Forms.Label xLabel;
            System.Windows.Forms.Label yLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogShapeBS));
            this.shapeComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapeComponentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.shapeComponentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.gTextBox = new System.Windows.Forms.TextBox();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            bLabel = new System.Windows.Forms.Label();
            gLabel = new System.Windows.Forms.Label();
            rLabel = new System.Windows.Forms.Label();
            xLabel = new System.Windows.Forms.Label();
            yLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shapeComponentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeComponentBindingNavigator)).BeginInit();
            this.shapeComponentBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(386, 145);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(17, 13);
            bLabel.TabIndex = 1;
            bLabel.Text = "B:";
            // 
            // gLabel
            // 
            gLabel.AutoSize = true;
            gLabel.Location = new System.Drawing.Point(386, 171);
            gLabel.Name = "gLabel";
            gLabel.Size = new System.Drawing.Size(18, 13);
            gLabel.TabIndex = 3;
            gLabel.Text = "G:";
            // 
            // rLabel
            // 
            rLabel.AutoSize = true;
            rLabel.Location = new System.Drawing.Point(386, 197);
            rLabel.Name = "rLabel";
            rLabel.Size = new System.Drawing.Size(18, 13);
            rLabel.TabIndex = 5;
            rLabel.Text = "R:";
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new System.Drawing.Point(386, 223);
            xLabel.Name = "xLabel";
            xLabel.Size = new System.Drawing.Size(17, 13);
            xLabel.TabIndex = 7;
            xLabel.Text = "X:";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new System.Drawing.Point(386, 249);
            yLabel.Name = "yLabel";
            yLabel.Size = new System.Drawing.Size(17, 13);
            yLabel.TabIndex = 9;
            yLabel.Text = "Y:";
            // 
            // shapeComponentBindingSource
            // 
            this.shapeComponentBindingSource.DataSource = typeof(ShapeBinding.ShapeComponent);
            // 
            // shapeComponentBindingNavigator
            // 
            this.shapeComponentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.shapeComponentBindingNavigator.BindingSource = this.shapeComponentBindingSource;
            this.shapeComponentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.shapeComponentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.shapeComponentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.shapeComponentBindingNavigatorSaveItem});
            this.shapeComponentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shapeComponentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.shapeComponentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.shapeComponentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.shapeComponentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.shapeComponentBindingNavigator.Name = "shapeComponentBindingNavigator";
            this.shapeComponentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.shapeComponentBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.shapeComponentBindingNavigator.TabIndex = 0;
            this.shapeComponentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // shapeComponentBindingNavigatorSaveItem
            // 
            this.shapeComponentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shapeComponentBindingNavigatorSaveItem.Enabled = false;
            this.shapeComponentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shapeComponentBindingNavigatorSaveItem.Image")));
            this.shapeComponentBindingNavigatorSaveItem.Name = "shapeComponentBindingNavigatorSaveItem";
            this.shapeComponentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.shapeComponentBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // bTextBox
            // 
            this.bTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapeComponentBindingSource, "B", true));
            this.bTextBox.Location = new System.Drawing.Point(410, 142);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 2;
            // 
            // gTextBox
            // 
            this.gTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapeComponentBindingSource, "G", true));
            this.gTextBox.Location = new System.Drawing.Point(410, 168);
            this.gTextBox.Name = "gTextBox";
            this.gTextBox.Size = new System.Drawing.Size(100, 20);
            this.gTextBox.TabIndex = 4;
            // 
            // rTextBox
            // 
            this.rTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapeComponentBindingSource, "R", true));
            this.rTextBox.Location = new System.Drawing.Point(410, 194);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(100, 20);
            this.rTextBox.TabIndex = 6;
            // 
            // xTextBox
            // 
            this.xTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapeComponentBindingSource, "X", true));
            this.xTextBox.Location = new System.Drawing.Point(410, 220);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 8;
            // 
            // yTextBox
            // 
            this.yTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shapeComponentBindingSource, "Y", true));
            this.yTextBox.Location = new System.Drawing.Point(410, 246);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 20);
            this.yTextBox.TabIndex = 10;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(571, 352);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // DialogShapeBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(bLabel);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(gLabel);
            this.Controls.Add(this.gTextBox);
            this.Controls.Add(rLabel);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(xLabel);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(yLabel);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.shapeComponentBindingNavigator);
            this.Name = "DialogShapeBS";
            this.Text = "DialogShapeBS";
            ((System.ComponentModel.ISupportInitialize)(this.shapeComponentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeComponentBindingNavigator)).EndInit();
            this.shapeComponentBindingNavigator.ResumeLayout(false);
            this.shapeComponentBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource shapeComponentBindingSource;
        private System.Windows.Forms.BindingNavigator shapeComponentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton shapeComponentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox gTextBox;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Button buttonOK;
    }
}