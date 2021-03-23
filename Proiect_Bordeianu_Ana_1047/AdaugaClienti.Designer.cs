namespace Proiect_Bordeianu_Ana_1047
{
    partial class AdaugaClienti
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbIdClient = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(253, 70);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(184, 27);
            this.tbNume.TabIndex = 0;
            // 
            // tbIdClient
            // 
            this.tbIdClient.Location = new System.Drawing.Point(253, 136);
            this.tbIdClient.Name = "tbIdClient";
            this.tbIdClient.Size = new System.Drawing.Size(184, 27);
            this.tbIdClient.TabIndex = 1;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(253, 209);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(184, 27);
            this.tbTelefon.TabIndex = 2;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(253, 284);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(184, 27);
            this.tbAdresa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Afiseaza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 39);
            this.label5.TabIndex = 10;
            this.label5.Text = "ADAUGARE CLIENTI";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 48);
            this.button3.TabIndex = 20;
            this.button3.Text = "Inapoi la pagina principala";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdaugaClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 427);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbIdClient);
            this.Controls.Add(this.tbNume);
            this.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdaugaClienti";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbIdClient;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}