namespace Proiect_Bordeianu_Ana_1047
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generareFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturiVechiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evoluțieComenziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaFurnizorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareFurnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareClientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generareFacturaToolStripMenuItem,
            this.bazaDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generareFacturaToolStripMenuItem
            // 
            this.generareFacturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturiVechiToolStripMenuItem,
            this.evoluțieComenziToolStripMenuItem,
            this.adaugareFacturaToolStripMenuItem});
            this.generareFacturaToolStripMenuItem.Name = "generareFacturaToolStripMenuItem";
            this.generareFacturaToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.generareFacturaToolStripMenuItem.Text = "Facturi";
            // 
            // facturiVechiToolStripMenuItem
            // 
            this.facturiVechiToolStripMenuItem.Name = "facturiVechiToolStripMenuItem";
            this.facturiVechiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.facturiVechiToolStripMenuItem.Text = "Facturi vechi";
            this.facturiVechiToolStripMenuItem.Click += new System.EventHandler(this.facturiVechiToolStripMenuItem_Click);
            // 
            // evoluțieComenziToolStripMenuItem
            // 
            this.evoluțieComenziToolStripMenuItem.Name = "evoluțieComenziToolStripMenuItem";
            this.evoluțieComenziToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.evoluțieComenziToolStripMenuItem.Text = "Valori Comenzi";
            this.evoluțieComenziToolStripMenuItem.Click += new System.EventHandler(this.evoluțieComenziToolStripMenuItem_Click);
            // 
            // adaugareFacturaToolStripMenuItem
            // 
            this.adaugareFacturaToolStripMenuItem.Name = "adaugareFacturaToolStripMenuItem";
            this.adaugareFacturaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.adaugareFacturaToolStripMenuItem.Text = "Adaugare factura";
            this.adaugareFacturaToolStripMenuItem.Click += new System.EventHandler(this.adaugareFacturaToolStripMenuItem_Click);
            // 
            // bazaDeDateToolStripMenuItem
            // 
            this.bazaDeDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.furnizoriToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.produseToolStripMenuItem});
            this.bazaDeDateToolStripMenuItem.Name = "bazaDeDateToolStripMenuItem";
            this.bazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.bazaDeDateToolStripMenuItem.Text = "Baza de date";
            // 
            // furnizoriToolStripMenuItem
            // 
            this.furnizoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaFurnizorToolStripMenuItem,
            this.vizualizareFurnizoriToolStripMenuItem});
            this.furnizoriToolStripMenuItem.Name = "furnizoriToolStripMenuItem";
            this.furnizoriToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.furnizoriToolStripMenuItem.Text = "Furnizori";
            // 
            // adaugaFurnizorToolStripMenuItem
            // 
            this.adaugaFurnizorToolStripMenuItem.Name = "adaugaFurnizorToolStripMenuItem";
            this.adaugaFurnizorToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.adaugaFurnizorToolStripMenuItem.Text = "Adauga furnizor";
            this.adaugaFurnizorToolStripMenuItem.Click += new System.EventHandler(this.adaugaFurnizorToolStripMenuItem_Click);
            // 
            // vizualizareFurnizoriToolStripMenuItem
            // 
            this.vizualizareFurnizoriToolStripMenuItem.Name = "vizualizareFurnizoriToolStripMenuItem";
            this.vizualizareFurnizoriToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.vizualizareFurnizoriToolStripMenuItem.Text = "Vizualizare furnizori";
            this.vizualizareFurnizoriToolStripMenuItem.Click += new System.EventHandler(this.vizualizareFurnizoriToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaClientToolStripMenuItem,
            this.vizualizareClientiToolStripMenuItem});
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.clientiToolStripMenuItem.Text = "Clienti";
            // 
            // adaugaClientToolStripMenuItem
            // 
            this.adaugaClientToolStripMenuItem.Name = "adaugaClientToolStripMenuItem";
            this.adaugaClientToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.adaugaClientToolStripMenuItem.Text = "Adauga client";
            this.adaugaClientToolStripMenuItem.Click += new System.EventHandler(this.adaugaClientToolStripMenuItem_Click);
            // 
            // vizualizareClientiToolStripMenuItem
            // 
            this.vizualizareClientiToolStripMenuItem.Name = "vizualizareClientiToolStripMenuItem";
            this.vizualizareClientiToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.vizualizareClientiToolStripMenuItem.Text = "Vizualizare clienti";
            this.vizualizareClientiToolStripMenuItem.Click += new System.EventHandler(this.vizualizareClientiToolStripMenuItem_Click);
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaProdusToolStripMenuItem,
            this.vizualizareProduseToolStripMenuItem});
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.produseToolStripMenuItem.Text = "Produse";
            // 
            // adaugaProdusToolStripMenuItem
            // 
            this.adaugaProdusToolStripMenuItem.Name = "adaugaProdusToolStripMenuItem";
            this.adaugaProdusToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.adaugaProdusToolStripMenuItem.Text = "Adauga produs";
            this.adaugaProdusToolStripMenuItem.Click += new System.EventHandler(this.adaugaProdusToolStripMenuItem_Click);
            // 
            // vizualizareProduseToolStripMenuItem
            // 
            this.vizualizareProduseToolStripMenuItem.Name = "vizualizareProduseToolStripMenuItem";
            this.vizualizareProduseToolStripMenuItem.Size = new System.Drawing.Size(290, 34);
            this.vizualizareProduseToolStripMenuItem.Text = "Vizualizare produse";
            this.vizualizareProduseToolStripMenuItem.Click += new System.EventHandler(this.vizualizareProduseToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Activitatea de aprovizionare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generareFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturiVechiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaFurnizorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareFurnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareClientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareProduseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem evoluțieComenziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareFacturaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

