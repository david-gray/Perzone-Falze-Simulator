﻿namespace PerzoneFalze
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RimuoviPerzone = new System.Windows.Forms.Button();
            this.AggiungiPersone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Perzona FALZA!!!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RimuoviPerzone
            // 
            this.RimuoviPerzone.Location = new System.Drawing.Point(192, 68);
            this.RimuoviPerzone.Name = "RimuoviPerzone";
            this.RimuoviPerzone.Size = new System.Drawing.Size(75, 23);
            this.RimuoviPerzone.TabIndex = 3;
            this.RimuoviPerzone.Text = "Rimuovi";
            this.RimuoviPerzone.UseVisualStyleBackColor = true;
            this.RimuoviPerzone.Click += new System.EventHandler(this.RimuoviPerzone_Click);
            // 
            // AggiungiPersone
            // 
            this.AggiungiPersone.Location = new System.Drawing.Point(192, 97);
            this.AggiungiPersone.Name = "AggiungiPersone";
            this.AggiungiPersone.Size = new System.Drawing.Size(75, 23);
            this.AggiungiPersone.TabIndex = 4;
            this.AggiungiPersone.Text = "Aggiungi";
            this.AggiungiPersone.UseVisualStyleBackColor = true;
            this.AggiungiPersone.Click += new System.EventHandler(this.AggiungiPersone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 165);
            this.Controls.Add(this.AggiungiPersone);
            this.Controls.Add(this.RimuoviPerzone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Perzone Falze Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RimuoviPerzone;
        private System.Windows.Forms.Button AggiungiPersone;
    }
}

