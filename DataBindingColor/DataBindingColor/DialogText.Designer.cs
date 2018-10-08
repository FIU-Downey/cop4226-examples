namespace DataBindingColor
{
    partial class DialogText
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
            System.Windows.Forms.Label textLabel;
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.dataClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            textLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(80, 56);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(108, 52);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(204, 56);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 52);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new System.Drawing.Point(76, 15);
            textLabel.Name = "textLabel";
            textLabel.Size = new System.Drawing.Size(43, 20);
            textLabel.TabIndex = 5;
            textLabel.Text = "Text:";
            // 
            // textTextBox
            // 
            this.textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataClassBindingSource, "Text", true));
            this.textTextBox.Location = new System.Drawing.Point(125, 12);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(173, 26);
            this.textTextBox.TabIndex = 6;
            // 
            // dataClassBindingSource
            // 
            this.dataClassBindingSource.DataSource = typeof(DataBindingColor.DataClass);
            // 
            // DialogText
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(365, 140);
            this.Controls.Add(textLabel);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "DialogText";
            this.Text = "DialogText";
            this.Load += new System.EventHandler(this.DialogText_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource dataClassBindingSource;
        private System.Windows.Forms.TextBox textTextBox;
    }
}