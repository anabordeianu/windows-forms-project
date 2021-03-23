namespace Proiect_Bordeianu_Ana_1047
{
    partial class AdaugareFactura
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
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVal = new System.Windows.Forms.TextBox();
            this.tbNrP = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(548, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 48);
            this.button3.TabIndex = 32;
            this.button3.Text = "Inapoi la pagina principala";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 39);
            this.label5.TabIndex = 31;
            this.label5.Text = "ADAUGARE FACTURA";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 48);
            this.button2.TabIndex = 30;
            this.button2.Text = "Afiseaza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 48);
            this.button1.TabIndex = 29;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Valoare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Numar Produse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cod Factura";
            // 
            // tbVal
            // 
            this.tbVal.Location = new System.Drawing.Point(300, 308);
            this.tbVal.Name = "tbVal";
            this.tbVal.Size = new System.Drawing.Size(184, 26);
            this.tbVal.TabIndex = 24;
            // 
            // tbNrP
            // 
            this.tbNrP.Location = new System.Drawing.Point(300, 233);
            this.tbNrP.Name = "tbNrP";
            this.tbNrP.Size = new System.Drawing.Size(184, 26);
            this.tbNrP.TabIndex = 23;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(300, 160);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(184, 26);
            this.tbId.TabIndex = 22;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(300, 94);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(184, 26);
            this.tbCod.TabIndex = 21;
            // 
            // AdaugareFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVal);
            this.Controls.Add(this.tbNrP);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbCod);
            this.Name = "AdaugareFactura";
            this.Text = "AdaugareFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVal;
        private System.Windows.Forms.TextBox tbNrP;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbCod;
    }
}