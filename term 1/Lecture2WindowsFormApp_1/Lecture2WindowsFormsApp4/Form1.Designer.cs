namespace Lecture2WindowsFormsApp4
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
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.textBoxPricePerKm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPriceExVat = new System.Windows.Forms.Label();
            this.labelVat = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(433, 101);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start km";
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Location = new System.Drawing.Point(433, 138);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnd.TabIndex = 2;
            // 
            // textBoxPricePerKm
            // 
            this.textBoxPricePerKm.Location = new System.Drawing.Point(433, 176);
            this.textBoxPricePerKm.Name = "textBoxPricePerKm";
            this.textBoxPricePerKm.Size = new System.Drawing.Size(100, 20);
            this.textBoxPricePerKm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price / km";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(576, 176);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(576, 101);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 7;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price ex VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(585, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total price";
            // 
            // labelPriceExVat
            // 
            this.labelPriceExVat.AutoSize = true;
            this.labelPriceExVat.Location = new System.Drawing.Point(379, 246);
            this.labelPriceExVat.Name = "labelPriceExVat";
            this.labelPriceExVat.Size = new System.Drawing.Size(16, 13);
            this.labelPriceExVat.TabIndex = 11;
            this.labelPriceExVat.Text = "---";
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Location = new System.Drawing.Point(505, 246);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(16, 13);
            this.labelVat.TabIndex = 12;
            this.labelVat.Text = "---";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(585, 246);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(16, 13);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelVat);
            this.Controls.Add(this.labelPriceExVat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPricePerKm);
            this.Controls.Add(this.textBoxEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.TextBox textBoxPricePerKm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPriceExVat;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.Label labelTotal;
    }
}

