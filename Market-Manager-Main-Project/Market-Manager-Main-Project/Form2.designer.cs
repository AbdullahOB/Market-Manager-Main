using System;

namespace market_manager
{
    partial class Form2
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
            this.clsDurumBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.temBtn = new System.Windows.Forms.Button();
            this.gdBtn = new System.Windows.Forms.Button();
            this.hKBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takip Ekrani";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çalışanların durumunu takibi";
            // 
            // clsDurumBtn
            // 
            this.clsDurumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsDurumBtn.Location = new System.Drawing.Point(110, 204);
            this.clsDurumBtn.Name = "clsDurumBtn";
            this.clsDurumBtn.Size = new System.Drawing.Size(121, 42);
            this.clsDurumBtn.TabIndex = 2;
            this.clsDurumBtn.Text = "Çalışan Durumu";
            this.clsDurumBtn.UseVisualStyleBackColor = true;
            this.clsDurumBtn.Click += new System.EventHandler(this.clsDurumBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(735, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stok Durumu Takibi";
            // 
            // temBtn
            // 
            this.temBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temBtn.Location = new System.Drawing.Point(704, 244);
            this.temBtn.Name = "temBtn";
            this.temBtn.Size = new System.Drawing.Size(215, 42);
            this.temBtn.TabIndex = 2;
            this.temBtn.Text = "Temizlik Ürünleri";
            this.temBtn.UseVisualStyleBackColor = true;
            this.temBtn.Click += new System.EventHandler(this.temBtn_Click);
            // 
            // gdBtn
            // 
            this.gdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdBtn.Location = new System.Drawing.Point(704, 292);
            this.gdBtn.Name = "gdBtn";
            this.gdBtn.Size = new System.Drawing.Size(215, 42);
            this.gdBtn.TabIndex = 2;
            this.gdBtn.Text = "Gıda Ürünleri";
            this.gdBtn.UseVisualStyleBackColor = true;
            // 
            // hKBtn
            // 
            this.hKBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hKBtn.Location = new System.Drawing.Point(704, 189);
            this.hKBtn.Name = "hKBtn";
            this.hKBtn.Size = new System.Drawing.Size(215, 49);
            this.hKBtn.TabIndex = 2;
            this.hKBtn.Text = "Haftalık kampanya Ürünleri";
            this.hKBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 549);
            this.Controls.Add(this.hKBtn);
            this.Controls.Add(this.gdBtn);
            this.Controls.Add(this.temBtn);
            this.Controls.Add(this.clsDurumBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clsDurumBtn;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button gdBtn;
        public System.Windows.Forms.Button hKBtn;
        public System.Windows.Forms.Button temBtn;
    }
}