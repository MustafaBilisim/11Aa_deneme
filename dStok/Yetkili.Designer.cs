namespace dStok
{
    partial class Yetkili
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKategoriler = new System.Windows.Forms.TabPage();
            this.tabUrunler = new System.Windows.Forms.TabPage();
            this.tabPersonel = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKategoriler);
            this.tabControl1.Controls.Add(this.tabUrunler);
            this.tabControl1.Controls.Add(this.tabPersonel);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 688);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabKategoriler
            // 
            this.tabKategoriler.Location = new System.Drawing.Point(4, 22);
            this.tabKategoriler.Name = "tabKategoriler";
            this.tabKategoriler.Padding = new System.Windows.Forms.Padding(3);
            this.tabKategoriler.Size = new System.Drawing.Size(1192, 662);
            this.tabKategoriler.TabIndex = 0;
            this.tabKategoriler.Text = "Kategoriler";
            this.tabKategoriler.UseVisualStyleBackColor = true;
            // 
            // tabUrunler
            // 
            this.tabUrunler.Location = new System.Drawing.Point(4, 22);
            this.tabUrunler.Name = "tabUrunler";
            this.tabUrunler.Padding = new System.Windows.Forms.Padding(3);
            this.tabUrunler.Size = new System.Drawing.Size(1192, 662);
            this.tabUrunler.TabIndex = 1;
            this.tabUrunler.Text = "Ürünler";
            this.tabUrunler.UseVisualStyleBackColor = true;
            // 
            // tabPersonel
            // 
            this.tabPersonel.Location = new System.Drawing.Point(4, 22);
            this.tabPersonel.Name = "tabPersonel";
            this.tabPersonel.Size = new System.Drawing.Size(1192, 662);
            this.tabPersonel.TabIndex = 2;
            this.tabPersonel.Text = "Personeller";
            this.tabPersonel.UseVisualStyleBackColor = true;
            // 
            // Yetkili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 700);
            this.Controls.Add(this.tabControl1);
            this.Name = "Yetkili";
            this.Text = "Yetkili";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Yetkili_FormClosing);
            this.Load += new System.EventHandler(this.Yetkili_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKategoriler;
        private System.Windows.Forms.TabPage tabUrunler;
        private System.Windows.Forms.TabPage tabPersonel;
    }
}