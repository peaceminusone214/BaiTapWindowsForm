
namespace Lab1_Bai2
{
    partial class frmBai2
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
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.lblSo1 = new System.Windows.Forms.Label();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbChia = new System.Windows.Forms.RadioButton();
            this.rbNhan = new System.Windows.Forms.RadioButton();
            this.rbTru = new System.Windows.Forms.RadioButton();
            this.rbCong = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblasd = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(128, 29);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(119, 20);
            this.txtSo1.TabIndex = 0;
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // lblSo1
            // 
            this.lblSo1.AutoSize = true;
            this.lblSo1.Location = new System.Drawing.Point(54, 32);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(68, 13);
            this.lblSo1.TabIndex = 2;
            this.lblSo1.Text = "Số thứ nhất: ";
            // 
            // lblSo2
            // 
            this.lblSo2.AutoSize = true;
            this.lblSo2.Location = new System.Drawing.Point(61, 59);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(61, 13);
            this.lblSo2.TabIndex = 2;
            this.lblSo2.Text = "Số thứ hai: ";
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(128, 55);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(119, 20);
            this.txtSo2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbChia);
            this.groupBox1.Controls.Add(this.rbNhan);
            this.groupBox1.Controls.Add(this.rbTru);
            this.groupBox1.Controls.Add(this.rbCong);
            this.groupBox1.Location = new System.Drawing.Point(128, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán: ";
            // 
            // rbChia
            // 
            this.rbChia.AutoSize = true;
            this.rbChia.Location = new System.Drawing.Point(6, 103);
            this.rbChia.Name = "rbChia";
            this.rbChia.Size = new System.Drawing.Size(46, 17);
            this.rbChia.TabIndex = 4;
            this.rbChia.Text = "Chia";
            this.rbChia.UseVisualStyleBackColor = true;
            // 
            // rbNhan
            // 
            this.rbNhan.AutoSize = true;
            this.rbNhan.Location = new System.Drawing.Point(6, 80);
            this.rbNhan.Name = "rbNhan";
            this.rbNhan.Size = new System.Drawing.Size(51, 17);
            this.rbNhan.TabIndex = 4;
            this.rbNhan.Text = "Nhân";
            this.rbNhan.UseVisualStyleBackColor = true;
            // 
            // rbTru
            // 
            this.rbTru.AutoSize = true;
            this.rbTru.Location = new System.Drawing.Point(6, 57);
            this.rbTru.Name = "rbTru";
            this.rbTru.Size = new System.Drawing.Size(41, 17);
            this.rbTru.TabIndex = 4;
            this.rbTru.Text = "Trừ";
            this.rbTru.UseVisualStyleBackColor = true;
            // 
            // rbCong
            // 
            this.rbCong.AutoSize = true;
            this.rbCong.Checked = true;
            this.rbCong.Location = new System.Drawing.Point(6, 34);
            this.rbCong.Name = "rbCong";
            this.rbCong.Size = new System.Drawing.Size(50, 17);
            this.rbCong.TabIndex = 4;
            this.rbCong.TabStop = true;
            this.rbCong.Text = "Cộng";
            this.rbCong.UseVisualStyleBackColor = true;
            this.rbCong.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(128, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xem kết quả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblasd
            // 
            this.lblasd.AutoSize = true;
            this.lblasd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasd.Location = new System.Drawing.Point(125, 275);
            this.lblasd.Name = "lblasd";
            this.lblasd.Size = new System.Drawing.Size(81, 18);
            this.lblasd.TabIndex = 5;
            this.lblasd.Text = "Kết quả là: ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(212, 280);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(10, 13);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblasd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSo2);
            this.Controls.Add(this.lblSo1);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbChia;
        private System.Windows.Forms.RadioButton rbNhan;
        private System.Windows.Forms.RadioButton rbTru;
        private System.Windows.Forms.RadioButton rbCong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblasd;
        private System.Windows.Forms.Label lblKetQua;
    }
}