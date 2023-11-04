
namespace GYMapp
{
    partial class mainPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.productCode = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.shelfNoLabel = new System.Windows.Forms.Label();
            this.shelfNo = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productCodesButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // productCode
            // 
            this.productCode.Location = new System.Drawing.Point(98, 19);
            this.productCode.Name = "productCode";
            this.productCode.Size = new System.Drawing.Size(213, 20);
            this.productCode.TabIndex = 0;
            this.productCode.TextChanged += new System.EventHandler(this.productCode_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.Location = new System.Drawing.Point(9, 73);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(305, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Ara";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(6, 24);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(64, 13);
            this.productCodeLabel.TabIndex = 2;
            this.productCodeLabel.Text = "Ürün Kodu :";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(9, 48);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(44, 13);
            this.result.TabIndex = 3;
            this.result.Text = "Raf No:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Controls.Add(this.productCode);
            this.groupBox1.Controls.Add(this.productCodeLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.shelfNoLabel);
            this.groupBox2.Controls.Add(this.shelfNo);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.updateCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 133);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güncelle";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // shelfNoLabel
            // 
            this.shelfNoLabel.AutoSize = true;
            this.shelfNoLabel.Location = new System.Drawing.Point(6, 59);
            this.shelfNoLabel.Name = "shelfNoLabel";
            this.shelfNoLabel.Size = new System.Drawing.Size(47, 13);
            this.shelfNoLabel.TabIndex = 5;
            this.shelfNoLabel.Text = "Raf No :";
            // 
            // shelfNo
            // 
            this.shelfNo.Location = new System.Drawing.Point(98, 56);
            this.shelfNo.Name = "shelfNo";
            this.shelfNo.Size = new System.Drawing.Size(213, 20);
            this.shelfNo.TabIndex = 4;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.updateButton.Location = new System.Drawing.Point(9, 104);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(305, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Güncelle";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateCode
            // 
            this.updateCode.Location = new System.Drawing.Point(98, 21);
            this.updateCode.Name = "updateCode";
            this.updateCode.Size = new System.Drawing.Size(213, 20);
            this.updateCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Kodu :";
            // 
            // productCodesButton
            // 
            this.productCodesButton.BackColor = System.Drawing.Color.Transparent;
            this.productCodesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productCodesButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.productCodesButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.productCodesButton.Location = new System.Drawing.Point(9, 19);
            this.productCodesButton.Name = "productCodesButton";
            this.productCodesButton.Size = new System.Drawing.Size(305, 23);
            this.productCodesButton.TabIndex = 6;
            this.productCodesButton.Text = "Ürün Kodları";
            this.productCodesButton.UseVisualStyleBackColor = false;
            this.productCodesButton.Click += new System.EventHandler(this.productCodes_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.productCodesButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 55);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Kodları";
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 360);
            this.MinimumSize = new System.Drawing.Size(360, 360);
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox productCode;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label shelfNoLabel;
        private System.Windows.Forms.TextBox shelfNo;
        private System.Windows.Forms.Button productCodesButton;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

