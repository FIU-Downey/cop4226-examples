namespace ShapeBinding
{
    partial class DialogShapeInstance
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
            this.groupBoxNan = new System.Windows.Forms.GroupBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxNan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNan
            // 
            this.groupBoxNan.Controls.Add(this.labelPosition);
            this.groupBoxNan.Controls.Add(this.buttonEnd);
            this.groupBoxNan.Controls.Add(this.buttonNext);
            this.groupBoxNan.Controls.Add(this.buttonPrev);
            this.groupBoxNan.Controls.Add(this.buttonStart);
            this.groupBoxNan.Location = new System.Drawing.Point(40, 319);
            this.groupBoxNan.Name = "groupBoxNan";
            this.groupBoxNan.Size = new System.Drawing.Size(718, 79);
            this.groupBoxNan.TabIndex = 12;
            this.groupBoxNan.TabStop = false;
            this.groupBoxNan.Text = "Navigation";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(310, 44);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(0, 13);
            this.labelPosition.TabIndex = 4;
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
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(314, 169);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 13;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(683, 415);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // DialogShapeInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.groupBoxNan);
            this.Name = "DialogShapeInstance";
            this.Text = "DialogShapeInstance";
            this.groupBoxNan.ResumeLayout(false);
            this.groupBoxNan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNan;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonOK;
    }
}