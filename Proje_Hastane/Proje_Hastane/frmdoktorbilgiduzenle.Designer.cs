﻿namespace Proje_Hastane
{
    partial class frmdoktorbilgiduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdoktorbilgiduzenle));
            this.btnbilgiguncelle = new System.Windows.Forms.Button();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnbilgiguncelle
            // 
            this.btnbilgiguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnbilgiguncelle.Location = new System.Drawing.Point(226, 291);
            this.btnbilgiguncelle.Name = "btnbilgiguncelle";
            this.btnbilgiguncelle.Size = new System.Drawing.Size(133, 49);
            this.btnbilgiguncelle.TabIndex = 44;
            this.btnbilgiguncelle.Text = "Guncelle";
            this.btnbilgiguncelle.UseVisualStyleBackColor = false;
            this.btnbilgiguncelle.Click += new System.EventHandler(this.btnbilgiguncelle_Click);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(226, 143);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(133, 31);
            this.txtsoyad.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Soyad :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(226, 106);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(133, 31);
            this.txtad.TabIndex = 35;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(226, 180);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(133, 31);
            this.msktc.TabIndex = 34;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Branş :";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(226, 254);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(133, 31);
            this.txtsifre.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Şifre:";
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(226, 217);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(133, 31);
            this.cmbbrans.TabIndex = 47;
            // 
            // frmdoktorbilgiduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(564, 517);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnbilgiguncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmdoktorbilgiduzenle";
            this.Text = "Doktor Bilgi Guncelle";
            this.Load += new System.EventHandler(this.frmdoktorbilgiduzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbilgiguncelle;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbrans;
    }
}