namespace dswartout1730ex2b
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUSDTotal = new System.Windows.Forms.TextBox();
            this.txtUSDBritain = new System.Windows.Forms.TextBox();
            this.txtUSDEuro = new System.Windows.Forms.TextBox();
            this.txtUSDGuatemala = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUSDAustralia = new System.Windows.Forms.TextBox();
            this.txtRateBritain = new System.Windows.Forms.TextBox();
            this.txtRateEuro = new System.Windows.Forms.TextBox();
            this.txtRateGuatemala = new System.Windows.Forms.TextBox();
            this.txtRateAustralia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountBritain = new System.Windows.Forms.TextBox();
            this.txtAmountEuro = new System.Windows.Forms.TextBox();
            this.txtAmountGuatemala = new System.Windows.Forms.TextBox();
            this.txtAmountAustralia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(300, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 23);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(183, 219);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 23);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(551, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "USD:";
            // 
            // txtUSDTotal
            // 
            this.txtUSDTotal.Location = new System.Drawing.Point(590, 193);
            this.txtUSDTotal.Name = "txtUSDTotal";
            this.txtUSDTotal.ReadOnly = true;
            this.txtUSDTotal.Size = new System.Drawing.Size(111, 20);
            this.txtUSDTotal.TabIndex = 56;
            this.txtUSDTotal.TabStop = false;
            this.txtUSDTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDBritain
            // 
            this.txtUSDBritain.Location = new System.Drawing.Point(417, 193);
            this.txtUSDBritain.Name = "txtUSDBritain";
            this.txtUSDBritain.ReadOnly = true;
            this.txtUSDBritain.Size = new System.Drawing.Size(111, 20);
            this.txtUSDBritain.TabIndex = 55;
            this.txtUSDBritain.TabStop = false;
            this.txtUSDBritain.Text = "0";
            this.txtUSDBritain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDEuro
            // 
            this.txtUSDEuro.Location = new System.Drawing.Point(300, 193);
            this.txtUSDEuro.Name = "txtUSDEuro";
            this.txtUSDEuro.ReadOnly = true;
            this.txtUSDEuro.Size = new System.Drawing.Size(111, 20);
            this.txtUSDEuro.TabIndex = 54;
            this.txtUSDEuro.TabStop = false;
            this.txtUSDEuro.Text = "0";
            this.txtUSDEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDGuatemala
            // 
            this.txtUSDGuatemala.Location = new System.Drawing.Point(183, 193);
            this.txtUSDGuatemala.Name = "txtUSDGuatemala";
            this.txtUSDGuatemala.ReadOnly = true;
            this.txtUSDGuatemala.Size = new System.Drawing.Size(111, 20);
            this.txtUSDGuatemala.TabIndex = 53;
            this.txtUSDGuatemala.TabStop = false;
            this.txtUSDGuatemala.Text = "0";
            this.txtUSDGuatemala.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Rates:";
            // 
            // txtUSDAustralia
            // 
            this.txtUSDAustralia.Location = new System.Drawing.Point(66, 193);
            this.txtUSDAustralia.Name = "txtUSDAustralia";
            this.txtUSDAustralia.ReadOnly = true;
            this.txtUSDAustralia.Size = new System.Drawing.Size(111, 20);
            this.txtUSDAustralia.TabIndex = 51;
            this.txtUSDAustralia.TabStop = false;
            this.txtUSDAustralia.Text = "0";
            this.txtUSDAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateBritain
            // 
            this.txtRateBritain.Location = new System.Drawing.Point(418, 166);
            this.txtRateBritain.Name = "txtRateBritain";
            this.txtRateBritain.Size = new System.Drawing.Size(111, 20);
            this.txtRateBritain.TabIndex = 49;
            this.txtRateBritain.Text = "1.23442";
            this.txtRateBritain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateBritain.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtRateEuro
            // 
            this.txtRateEuro.Location = new System.Drawing.Point(301, 167);
            this.txtRateEuro.Name = "txtRateEuro";
            this.txtRateEuro.Size = new System.Drawing.Size(111, 20);
            this.txtRateEuro.TabIndex = 47;
            this.txtRateEuro.Text = "1.10437";
            this.txtRateEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateEuro.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtRateGuatemala
            // 
            this.txtRateGuatemala.Location = new System.Drawing.Point(184, 167);
            this.txtRateGuatemala.Name = "txtRateGuatemala";
            this.txtRateGuatemala.Size = new System.Drawing.Size(111, 20);
            this.txtRateGuatemala.TabIndex = 46;
            this.txtRateGuatemala.Text = "0.130313";
            this.txtRateGuatemala.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateGuatemala.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtRateAustralia
            // 
            this.txtRateAustralia.Location = new System.Drawing.Point(67, 167);
            this.txtRateAustralia.Name = "txtRateAustralia";
            this.txtRateAustralia.Size = new System.Drawing.Size(111, 20);
            this.txtRateAustralia.TabIndex = 43;
            this.txtRateAustralia.Text = "0.685588";
            this.txtRateAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateAustralia.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Amount:";
            // 
            // txtAmountBritain
            // 
            this.txtAmountBritain.Location = new System.Drawing.Point(418, 140);
            this.txtAmountBritain.Name = "txtAmountBritain";
            this.txtAmountBritain.Size = new System.Drawing.Size(111, 20);
            this.txtAmountBritain.TabIndex = 38;
            this.txtAmountBritain.Text = "0.00";
            this.txtAmountBritain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountBritain.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtAmountEuro
            // 
            this.txtAmountEuro.Location = new System.Drawing.Point(301, 141);
            this.txtAmountEuro.Name = "txtAmountEuro";
            this.txtAmountEuro.Size = new System.Drawing.Size(111, 20);
            this.txtAmountEuro.TabIndex = 36;
            this.txtAmountEuro.Text = "0.00";
            this.txtAmountEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountEuro.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtAmountGuatemala
            // 
            this.txtAmountGuatemala.Location = new System.Drawing.Point(184, 141);
            this.txtAmountGuatemala.Name = "txtAmountGuatemala";
            this.txtAmountGuatemala.Size = new System.Drawing.Size(111, 20);
            this.txtAmountGuatemala.TabIndex = 34;
            this.txtAmountGuatemala.Text = "0.00";
            this.txtAmountGuatemala.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountGuatemala.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // txtAmountAustralia
            // 
            this.txtAmountAustralia.Location = new System.Drawing.Point(67, 141);
            this.txtAmountAustralia.Name = "txtAmountAustralia";
            this.txtAmountAustralia.Size = new System.Drawing.Size(111, 20);
            this.txtAmountAustralia.TabIndex = 31;
            this.txtAmountAustralia.Text = "0.00";
            this.txtAmountAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountAustralia.TextChanged += new System.EventHandler(this.Calculate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "US Dollar";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(300, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(111, 109);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "British Pound";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(590, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 109);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Euro";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(417, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Guatemalan Quetzal";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(183, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Australian Dollar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUSDTotal);
            this.Controls.Add(this.txtUSDBritain);
            this.Controls.Add(this.txtUSDEuro);
            this.Controls.Add(this.txtUSDGuatemala);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUSDAustralia);
            this.Controls.Add(this.txtRateBritain);
            this.Controls.Add(this.txtRateEuro);
            this.Controls.Add(this.txtRateGuatemala);
            this.Controls.Add(this.txtRateAustralia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmountBritain);
            this.Controls.Add(this.txtAmountEuro);
            this.Controls.Add(this.txtAmountGuatemala);
            this.Controls.Add(this.txtAmountAustralia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUSDTotal;
        private System.Windows.Forms.TextBox txtUSDBritain;
        private System.Windows.Forms.TextBox txtUSDEuro;
        private System.Windows.Forms.TextBox txtUSDGuatemala;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUSDAustralia;
        private System.Windows.Forms.TextBox txtRateBritain;
        private System.Windows.Forms.TextBox txtRateEuro;
        private System.Windows.Forms.TextBox txtRateGuatemala;
        private System.Windows.Forms.TextBox txtRateAustralia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmountBritain;
        private System.Windows.Forms.TextBox txtAmountEuro;
        private System.Windows.Forms.TextBox txtAmountGuatemala;
        private System.Windows.Forms.TextBox txtAmountAustralia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

