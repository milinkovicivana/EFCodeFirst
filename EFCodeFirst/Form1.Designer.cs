namespace EFCodeFirst
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
            this.gridKlijenti = new System.Windows.Forms.DataGridView();
            this.gridServisi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImeKlijenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegBr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDodatniKom = new System.Windows.Forms.TextBox();
            this.btnDodajKlijenta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbKlijenti = new System.Windows.Forms.ComboBox();
            this.dtpUsluga = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOpisUsluge = new System.Windows.Forms.TextBox();
            this.btnDodajServis = new System.Windows.Forms.Button();
            this.btnIzmeniKlijenta = new System.Windows.Forms.Button();
            this.btnObrisiKlijenta = new System.Windows.Forms.Button();
            this.gridServisiZaKlijenta = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnServisiZaKlijenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridKlijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServisiZaKlijenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKlijenti
            // 
            this.gridKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKlijenti.Location = new System.Drawing.Point(12, 55);
            this.gridKlijenti.Name = "gridKlijenti";
            this.gridKlijenti.Size = new System.Drawing.Size(392, 217);
            this.gridKlijenti.TabIndex = 0;
            // 
            // gridServisi
            // 
            this.gridServisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServisi.Location = new System.Drawing.Point(439, 55);
            this.gridServisi.Name = "gridServisi";
            this.gridServisi.Size = new System.Drawing.Size(385, 217);
            this.gridServisi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klijenti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ime klijenta:";
            // 
            // txtImeKlijenta
            // 
            this.txtImeKlijenta.Location = new System.Drawing.Point(143, 282);
            this.txtImeKlijenta.MaxLength = 40;
            this.txtImeKlijenta.Name = "txtImeKlijenta";
            this.txtImeKlijenta.Size = new System.Drawing.Size(165, 20);
            this.txtImeKlijenta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Registarski broj:";
            // 
            // txtRegBr
            // 
            this.txtRegBr.Location = new System.Drawing.Point(143, 308);
            this.txtRegBr.MaxLength = 20;
            this.txtRegBr.Name = "txtRegBr";
            this.txtRegBr.Size = new System.Drawing.Size(165, 20);
            this.txtRegBr.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kontakt:";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(143, 333);
            this.txtKontakt.MaxLength = 40;
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(165, 20);
            this.txtKontakt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dodatni komentar:";
            // 
            // txtDodatniKom
            // 
            this.txtDodatniKom.Location = new System.Drawing.Point(143, 360);
            this.txtDodatniKom.MaxLength = 200;
            this.txtDodatniKom.Multiline = true;
            this.txtDodatniKom.Name = "txtDodatniKom";
            this.txtDodatniKom.Size = new System.Drawing.Size(165, 47);
            this.txtDodatniKom.TabIndex = 11;
            // 
            // btnDodajKlijenta
            // 
            this.btnDodajKlijenta.Location = new System.Drawing.Point(183, 413);
            this.btnDodajKlijenta.Name = "btnDodajKlijenta";
            this.btnDodajKlijenta.Size = new System.Drawing.Size(85, 33);
            this.btnDodajKlijenta.TabIndex = 12;
            this.btnDodajKlijenta.Text = "Dodaj klijenta";
            this.btnDodajKlijenta.UseVisualStyleBackColor = true;
            this.btnDodajKlijenta.Click += new System.EventHandler(this.txtDodajKlijenta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Klijent:";
            // 
            // cmbKlijenti
            // 
            this.cmbKlijenti.FormattingEnabled = true;
            this.cmbKlijenti.Location = new System.Drawing.Point(570, 279);
            this.cmbKlijenti.Name = "cmbKlijenti";
            this.cmbKlijenti.Size = new System.Drawing.Size(200, 21);
            this.cmbKlijenti.TabIndex = 14;
            // 
            // dtpUsluga
            // 
            this.dtpUsluga.Location = new System.Drawing.Point(570, 308);
            this.dtpUsluga.Name = "dtpUsluga";
            this.dtpUsluga.Size = new System.Drawing.Size(200, 20);
            this.dtpUsluga.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Datum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Opis usluge:";
            // 
            // txtOpisUsluge
            // 
            this.txtOpisUsluge.Location = new System.Drawing.Point(571, 336);
            this.txtOpisUsluge.MaxLength = 400;
            this.txtOpisUsluge.Multiline = true;
            this.txtOpisUsluge.Name = "txtOpisUsluge";
            this.txtOpisUsluge.Size = new System.Drawing.Size(199, 71);
            this.txtOpisUsluge.TabIndex = 18;
            // 
            // btnDodajServis
            // 
            this.btnDodajServis.Location = new System.Drawing.Point(625, 413);
            this.btnDodajServis.Name = "btnDodajServis";
            this.btnDodajServis.Size = new System.Drawing.Size(91, 32);
            this.btnDodajServis.TabIndex = 19;
            this.btnDodajServis.Text = "Dodaj uslugu";
            this.btnDodajServis.UseVisualStyleBackColor = true;
            this.btnDodajServis.Click += new System.EventHandler(this.btnDodajServis_Click);
            // 
            // btnIzmeniKlijenta
            // 
            this.btnIzmeniKlijenta.Location = new System.Drawing.Point(368, 308);
            this.btnIzmeniKlijenta.Name = "btnIzmeniKlijenta";
            this.btnIzmeniKlijenta.Size = new System.Drawing.Size(99, 39);
            this.btnIzmeniKlijenta.TabIndex = 20;
            this.btnIzmeniKlijenta.Text = "Izmeni ";
            this.btnIzmeniKlijenta.UseVisualStyleBackColor = true;
            this.btnIzmeniKlijenta.Click += new System.EventHandler(this.btnIzmeniKlijenta_Click);
            // 
            // btnObrisiKlijenta
            // 
            this.btnObrisiKlijenta.Location = new System.Drawing.Point(368, 371);
            this.btnObrisiKlijenta.Name = "btnObrisiKlijenta";
            this.btnObrisiKlijenta.Size = new System.Drawing.Size(99, 36);
            this.btnObrisiKlijenta.TabIndex = 21;
            this.btnObrisiKlijenta.Text = "Obrisi";
            this.btnObrisiKlijenta.UseVisualStyleBackColor = true;
            this.btnObrisiKlijenta.Click += new System.EventHandler(this.btnObrisiKlijenta_Click);
            // 
            // gridServisiZaKlijenta
            // 
            this.gridServisiZaKlijenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServisiZaKlijenta.Location = new System.Drawing.Point(224, 511);
            this.gridServisiZaKlijenta.Name = "gridServisiZaKlijenta";
            this.gridServisiZaKlijenta.Size = new System.Drawing.Size(360, 150);
            this.gridServisiZaKlijenta.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(360, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Servisi za klijenta";
            // 
            // btnServisiZaKlijenta
            // 
            this.btnServisiZaKlijenta.Location = new System.Drawing.Point(363, 667);
            this.btnServisiZaKlijenta.Name = "btnServisiZaKlijenta";
            this.btnServisiZaKlijenta.Size = new System.Drawing.Size(97, 40);
            this.btnServisiZaKlijenta.TabIndex = 26;
            this.btnServisiZaKlijenta.Text = "Prikazi";
            this.btnServisiZaKlijenta.UseVisualStyleBackColor = true;
            this.btnServisiZaKlijenta.Click += new System.EventHandler(this.btnServisiZaKlijenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 731);
            this.Controls.Add(this.btnServisiZaKlijenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gridServisiZaKlijenta);
            this.Controls.Add(this.btnObrisiKlijenta);
            this.Controls.Add(this.btnIzmeniKlijenta);
            this.Controls.Add(this.btnDodajServis);
            this.Controls.Add(this.txtOpisUsluge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpUsluga);
            this.Controls.Add(this.cmbKlijenti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDodajKlijenta);
            this.Controls.Add(this.txtDodatniKom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRegBr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImeKlijenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridServisi);
            this.Controls.Add(this.gridKlijenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKlijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServisiZaKlijenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridKlijenti;
        private System.Windows.Forms.DataGridView gridServisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImeKlijenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegBr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDodatniKom;
        private System.Windows.Forms.Button btnDodajKlijenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKlijenti;
        private System.Windows.Forms.DateTimePicker dtpUsluga;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOpisUsluge;
        private System.Windows.Forms.Button btnDodajServis;
        private System.Windows.Forms.Button btnIzmeniKlijenta;
        private System.Windows.Forms.Button btnObrisiKlijenta;
        private System.Windows.Forms.DataGridView gridServisiZaKlijenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnServisiZaKlijenta;
    }
}

