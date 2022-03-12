namespace Lab1_TranBaoAn
{
    partial class Bai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tong = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số thứ I:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số thứ II:";
            // 
            // Input1
            // 
            this.Input1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Input1.Location = new System.Drawing.Point(267, 93);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(333, 27);
            this.Input1.TabIndex = 2;
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(267, 167);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(333, 27);
            this.Input2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả:";
            // 
            // Tong
            // 
            this.Tong.Location = new System.Drawing.Point(270, 239);
            this.Tong.Name = "Tong";
            this.Tong.Size = new System.Drawing.Size(94, 29);
            this.Tong.TabIndex = 6;
            this.Tong.Text = "Tổng";
            this.Tong.UseVisualStyleBackColor = true;
            this.Tong.Click += new System.EventHandler(this.Tong_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(270, 304);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(330, 27);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(170, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "BÀI 1: TÍNH TỔNG";
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(380, 239);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(94, 29);
            this.Thoat.TabIndex = 9;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 362);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Tong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Input1;
        private TextBox Input2;
        private Label label3;
        private Button Tong;
        private TextBox textBox3;
        private Label label4;
        private Button Thoat;
    }
}