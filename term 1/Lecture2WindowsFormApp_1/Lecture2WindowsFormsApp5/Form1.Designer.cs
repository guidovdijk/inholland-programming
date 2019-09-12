namespace Lecture2WindowsFormsApp5
{
    partial class Form1
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.textBoxShirts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJeans = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.BackgroundImage = global::Lecture2WindowsFormsApp5.Properties.Resources.calculator;
            this.btnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalc.Location = new System.Drawing.Point(194, 163);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(276, 33);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // textBoxShirts
            // 
            this.textBoxShirts.Location = new System.Drawing.Point(370, 92);
            this.textBoxShirts.Name = "textBoxShirts";
            this.textBoxShirts.Size = new System.Drawing.Size(100, 20);
            this.textBoxShirts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of t-shirts (x €30,00):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of jeans (x €100,00):";
            // 
            // textBoxJeans
            // 
            this.textBoxJeans.Location = new System.Drawing.Point(370, 126);
            this.textBoxJeans.Name = "textBoxJeans";
            this.textBoxJeans.Size = new System.Drawing.Size(100, 20);
            this.textBoxJeans.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalPriceLabel);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.vatLabel);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(194, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Location = new System.Drawing.Point(172, 109);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(89, 13);
            this.totalPriceLabel.TabIndex = 7;
            this.totalPriceLabel.Text = "---";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(153, 51);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(108, 13);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "---";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // vatLabel
            // 
            this.vatLabel.Location = new System.Drawing.Point(169, 80);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(92, 13);
            this.vatLabel.TabIndex = 5;
            this.vatLabel.Text = "---";
            this.vatLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(105, 26);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateLabel.Size = new System.Drawing.Size(156, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "---";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "VAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxJeans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxShirts);
            this.Controls.Add(this.btnCalc);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox textBoxShirts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJeans;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

