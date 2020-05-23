namespace _5_16
{
    partial class CalculateForm
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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTru = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnChia = new System.Windows.Forms.RadioButton();
            this.btnCong = new System.Windows.Forms.RadioButton();
            this.btnNhan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(257, 100);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 20);
            this.txtInput1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(264, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tinh toan";
            // 
            // btnTru
            // 
            this.btnTru.AutoSize = true;
            this.btnTru.Location = new System.Drawing.Point(497, 131);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(41, 17);
            this.btnTru.TabIndex = 2;
            this.btnTru.TabStop = true;
            this.btnTru.Text = "Tru";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.CheckedChanged += new System.EventHandler(this.btnTru_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ket qua";
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(257, 167);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 20);
            this.txtInput2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhap so thu nhat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(257, 232);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(100, 20);
            this.txtKetqua.TabIndex = 5;
            // 
            // btnChia
            // 
            this.btnChia.AutoSize = true;
            this.btnChia.Location = new System.Drawing.Point(497, 243);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(46, 17);
            this.btnChia.TabIndex = 7;
            this.btnChia.TabStop = true;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.CheckedChanged += new System.EventHandler(this.btnChia_CheckedChanged);
            // 
            // btnCong
            // 
            this.btnCong.AutoSize = true;
            this.btnCong.Location = new System.Drawing.Point(497, 72);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(50, 17);
            this.btnCong.TabIndex = 8;
            this.btnCong.TabStop = true;
            this.btnCong.Text = "Cong";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.CheckedChanged += new System.EventHandler(this.btnCong_CheckedChanged);
            // 
            // btnNhan
            // 
            this.btnNhan.AutoSize = true;
            this.btnNhan.Location = new System.Drawing.Point(497, 190);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(51, 17);
            this.btnNhan.TabIndex = 9;
            this.btnNhan.TabStop = true;
            this.btnNhan.Text = "Nhan";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.CheckedChanged += new System.EventHandler(this.btnNhan_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhap so thu hai";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(267, 294);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput1);
            this.Name = "CalculateForm";
            this.Text = "CalculateForm";
            this.Load += new System.EventHandler(this.CalculateForm_Load);
            this.Enter += new System.EventHandler(this.CalculateForm_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnTru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.RadioButton btnChia;
        private System.Windows.Forms.RadioButton btnCong;
        private System.Windows.Forms.RadioButton btnNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
    }
}