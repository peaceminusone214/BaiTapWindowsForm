﻿
namespace Lab1_Bai2
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi0 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi0});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi0
            // 
            this.tsmi0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi1,
            this.tsmi2,
            this.tsmi3});
            this.tsmi0.Name = "tsmi0";
            this.tsmi0.Size = new System.Drawing.Size(81, 20);
            this.tsmi0.Text = "Bài kiểm tra";
            this.tsmi0.Click += new System.EventHandler(this.tsmi0_Click);
            // 
            // tsmi1
            // 
            this.tsmi1.Image = ((System.Drawing.Image)(resources.GetObject("tsmi1.Image")));
            this.tsmi1.Name = "tsmi1";
            this.tsmi1.Size = new System.Drawing.Size(180, 22);
            this.tsmi1.Text = "Bài số 1";
            this.tsmi1.Click += new System.EventHandler(this.tsmi1_Click);
            // 
            // tsmi2
            // 
            this.tsmi2.Image = ((System.Drawing.Image)(resources.GetObject("tsmi2.Image")));
            this.tsmi2.Name = "tsmi2";
            this.tsmi2.Size = new System.Drawing.Size(180, 22);
            this.tsmi2.Text = "Bài số 2";
            this.tsmi2.Click += new System.EventHandler(this.tsmi2_Click);
            // 
            // tsmi3
            // 
            this.tsmi3.Image = ((System.Drawing.Image)(resources.GetObject("tsmi3.Image")));
            this.tsmi3.Name = "tsmi3";
            this.tsmi3.Size = new System.Drawing.Size(180, 22);
            this.tsmi3.Text = "Bài số 3";
            this.tsmi3.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi0;
        private System.Windows.Forms.ToolStripMenuItem tsmi1;
        private System.Windows.Forms.ToolStripMenuItem tsmi2;
        private System.Windows.Forms.ToolStripMenuItem tsmi3;
    }
}

