﻿namespace ShapeBinding
{
    partial class FormMain
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
            this.buttonInstance = new System.Windows.Forms.Button();
            this.tabControlChoice = new System.Windows.Forms.TabControl();
            this.tabPageComponent = new System.Windows.Forms.TabPage();
            this.tabPageInstance = new System.Windows.Forms.TabPage();
            this.tabControlChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInstance
            // 
            this.buttonInstance.Location = new System.Drawing.Point(112, 380);
            this.buttonInstance.Name = "buttonInstance";
            this.buttonInstance.Size = new System.Drawing.Size(75, 23);
            this.buttonInstance.TabIndex = 0;
            this.buttonInstance.Text = "Instance";
            this.buttonInstance.UseVisualStyleBackColor = true;
            this.buttonInstance.Click += new System.EventHandler(this.buttonInstance_Click);
            // 
            // tabControlChoice
            // 
            this.tabControlChoice.Controls.Add(this.tabPageComponent);
            this.tabControlChoice.Controls.Add(this.tabPageInstance);
            this.tabControlChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlChoice.Location = new System.Drawing.Point(0, 0);
            this.tabControlChoice.Name = "tabControlChoice";
            this.tabControlChoice.SelectedIndex = 0;
            this.tabControlChoice.Size = new System.Drawing.Size(800, 450);
            this.tabControlChoice.TabIndex = 1;
            // 
            // tabPageComponent
            // 
            this.tabPageComponent.Location = new System.Drawing.Point(4, 22);
            this.tabPageComponent.Name = "tabPageComponent";
            this.tabPageComponent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComponent.Size = new System.Drawing.Size(792, 424);
            this.tabPageComponent.TabIndex = 0;
            this.tabPageComponent.Text = "Component";
            this.tabPageComponent.UseVisualStyleBackColor = true;
            this.tabPageComponent.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageComponent_Paint);
            this.tabPageComponent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPageComponent_MouseClick);
            // 
            // tabPageInstance
            // 
            this.tabPageInstance.Location = new System.Drawing.Point(4, 22);
            this.tabPageInstance.Name = "tabPageInstance";
            this.tabPageInstance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstance.Size = new System.Drawing.Size(792, 424);
            this.tabPageInstance.TabIndex = 1;
            this.tabPageInstance.Text = "Instance";
            this.tabPageInstance.UseVisualStyleBackColor = true;
            this.tabPageInstance.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPageInstance_Paint);
            this.tabPageInstance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPageInstance_MouseClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlChoice);
            this.Controls.Add(this.buttonInstance);
            this.Name = "FormMain";
            this.Text = "Shape Binding";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseClick);
            this.tabControlChoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInstance;
        private System.Windows.Forms.TabControl tabControlChoice;
        private System.Windows.Forms.TabPage tabPageComponent;
        private System.Windows.Forms.TabPage tabPageInstance;
    }
}

