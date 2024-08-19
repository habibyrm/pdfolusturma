namespace pdfdeneme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtsoyad = new TextBox();
            label3 = new Label();
            txttarih = new TextBox();
            btnpdf = new Button();
            label4 = new Label();
            txttc = new TextBox();
            label5 = new Label();
            txtanne = new TextBox();
            label6 = new Label();
            txtbaba = new TextBox();
            SuspendLayout();
            // 
            // txtad
            // 
            txtad.Location = new Point(12, 95);
            txtad.Name = "txtad";
            txtad.Size = new Size(100, 23);
            txtad.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 147);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Soyad:";
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(12, 170);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(100, 23);
            txtsoyad.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 221);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "Doğum Tarihi:";
            // 
            // txttarih
            // 
            txttarih.Location = new Point(12, 244);
            txttarih.Name = "txttarih";
            txttarih.Size = new Size(100, 23);
            txttarih.TabIndex = 4;
            // 
            // btnpdf
            // 
            btnpdf.Location = new Point(348, 269);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new Size(75, 23);
            btnpdf.TabIndex = 6;
            btnpdf.Text = "pdf";
            btnpdf.UseVisualStyleBackColor = true;
            btnpdf.Click += btnpdf_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 5);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 8;
            label4.Text = "TC:";
            // 
            // txttc
            // 
            txttc.Location = new Point(12, 28);
            txttc.Name = "txttc";
            txttc.Size = new Size(100, 23);
            txttc.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 300);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 10;
            label5.Text = "Anne Adı:";
            // 
            // txtanne
            // 
            txtanne.Location = new Point(12, 323);
            txtanne.Name = "txtanne";
            txtanne.Size = new Size(100, 23);
            txtanne.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 374);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 12;
            label6.Text = "Baba Adı:";
            // 
            // txtbaba
            // 
            txtbaba.Location = new Point(12, 397);
            txtbaba.Name = "txtbaba";
            txtbaba.Size = new Size(100, 23);
            txtbaba.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtbaba);
            Controls.Add(label5);
            Controls.Add(txtanne);
            Controls.Add(label4);
            Controls.Add(txttc);
            Controls.Add(btnpdf);
            Controls.Add(label3);
            Controls.Add(txttarih);
            Controls.Add(label2);
            Controls.Add(txtsoyad);
            Controls.Add(label1);
            Controls.Add(txtad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtad;
        private Label label1;
        private Label label2;
        private TextBox txtsoyad;
        private Label label3;
        private TextBox txttarih;
        private Button btnpdf;
        private Label label4;
        private TextBox txttc;
        private Label label5;
        private TextBox txtanne;
        private Label label6;
        private TextBox txtbaba;
    }
}
