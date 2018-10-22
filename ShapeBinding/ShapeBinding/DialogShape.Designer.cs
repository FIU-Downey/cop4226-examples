namespace ShapeBinding
{
    partial class DialogShape
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
            System.Windows.Forms.Label bLabel;
            System.Windows.Forms.Label gLabel;
            System.Windows.Forms.Label rLabel;
            System.Windows.Forms.Label xLabel;
            System.Windows.Forms.Label yLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.gTextBox = new System.Windows.Forms.TextBox();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            bLabel = new System.Windows.Forms.Label();
            gLabel = new System.Windows.Forms.Label();
            rLabel = new System.Windows.Forms.Label();
            xLabel = new System.Windows.Forms.Label();
            yLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPosition);
            this.groupBox1.Controls.Add(this.buttonEnd);
            this.groupBox1.Controls.Add(this.buttonNext);
            this.groupBox1.Controls.Add(this.buttonPrev);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Location = new System.Drawing.Point(44, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 79);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // buttonEnd
            // 
            this.buttonEnd.Location = new System.Drawing.Point(599, 32);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonEnd.TabIndex = 3;
            this.buttonEnd.Text = ">|";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(473, 32);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(155, 32);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(55, 32);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "|<";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // bLabel
            // 
            bLabel.AutoSize = true;
            bLabel.Location = new System.Drawing.Point(334, 125);
            bLabel.Name = "bLabel";
            bLabel.Size = new System.Drawing.Size(17, 13);
            bLabel.TabIndex = 12;
            bLabel.Text = "B:";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(358, 122);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 13;
            // 
            // gLabel
            // 
            gLabel.AutoSize = true;
            gLabel.Location = new System.Drawing.Point(334, 151);
            gLabel.Name = "gLabel";
            gLabel.Size = new System.Drawing.Size(18, 13);
            gLabel.TabIndex = 14;
            gLabel.Text = "G:";
            // 
            // gTextBox
            // 
            this.gTextBox.Location = new System.Drawing.Point(358, 148);
            this.gTextBox.Name = "gTextBox";
            this.gTextBox.Size = new System.Drawing.Size(100, 20);
            this.gTextBox.TabIndex = 15;
            // 
            // rLabel
            // 
            rLabel.AutoSize = true;
            rLabel.Location = new System.Drawing.Point(334, 177);
            rLabel.Name = "rLabel";
            rLabel.Size = new System.Drawing.Size(18, 13);
            rLabel.TabIndex = 16;
            rLabel.Text = "R:";
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(358, 174);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(100, 20);
            this.rTextBox.TabIndex = 17;
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new System.Drawing.Point(334, 203);
            xLabel.Name = "xLabel";
            xLabel.Size = new System.Drawing.Size(17, 13);
            xLabel.TabIndex = 18;
            xLabel.Text = "X:";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(358, 200);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 19;
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new System.Drawing.Point(334, 229);
            yLabel.Name = "yLabel";
            yLabel.Size = new System.Drawing.Size(17, 13);
            yLabel.TabIndex = 20;
            yLabel.Text = "Y:";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(358, 226);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 20);
            this.yTextBox.TabIndex = 21;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(310, 44);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(0, 13);
            this.labelPosition.TabIndex = 4;
            // 
            // DialogShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
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
            this.Controls.Add(this.groupBox1);
            this.Name = "DialogShape";
            this.Text = "DialogShape";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox gTextBox;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Label labelPosition;
    }
}