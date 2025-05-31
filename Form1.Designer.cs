namespace Proiect_BABOIU_BIANCA_GABRIELA_1053
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtIdProdus;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.TextBox txtUnitate;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.Button btnStergeProdus;
        private System.Windows.Forms.ListBox lstProduse;

        private System.Windows.Forms.TextBox txtIdLot;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cmbProduse;
        private System.Windows.Forms.Button btnAdaugaLot;
        private System.Windows.Forms.Button btnStergeLot;
        private System.Windows.Forms.ListBox lstLoturi;

        private System.Windows.Forms.TextBox txtIdFisa;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtCantMaterial;
        private System.Windows.Forms.ComboBox cmbLoturi;
        private System.Windows.Forms.Button btnAdaugaFisa;
        private System.Windows.Forms.Button btnStergeFisa;
        private System.Windows.Forms.ListBox lstFise;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtIdProdus = new System.Windows.Forms.TextBox();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.txtUnitate = new System.Windows.Forms.TextBox();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.btnStergeProdus = new System.Windows.Forms.Button();
            this.lstProduse = new System.Windows.Forms.ListBox();
            this.txtIdLot = new System.Windows.Forms.TextBox();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cmbProduse = new System.Windows.Forms.ComboBox();
            this.btnAdaugaLot = new System.Windows.Forms.Button();
            this.btnStergeLot = new System.Windows.Forms.Button();
            this.lstLoturi = new System.Windows.Forms.ListBox();
            this.txtIdFisa = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtCantMaterial = new System.Windows.Forms.TextBox();
            this.cmbLoturi = new System.Windows.Forms.ComboBox();
            this.btnAdaugaFisa = new System.Windows.Forms.Button();
            this.btnStergeFisa = new System.Windows.Forms.Button();
            this.lstFise = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGrafic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdProdus
            // 
            this.txtIdProdus.Location = new System.Drawing.Point(49, 36);
            this.txtIdProdus.Name = "txtIdProdus";
            this.txtIdProdus.Size = new System.Drawing.Size(100, 20);
            this.txtIdProdus.TabIndex = 0;
            // 
            // txtNumeProdus
            // 
            this.txtNumeProdus.Location = new System.Drawing.Point(49, 118);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(100, 20);
            this.txtNumeProdus.TabIndex = 1;
            // 
            // txtUnitate
            // 
            this.txtUnitate.Location = new System.Drawing.Point(49, 198);
            this.txtUnitate.Name = "txtUnitate";
            this.txtUnitate.Size = new System.Drawing.Size(100, 20);
            this.txtUnitate.TabIndex = 2;
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.Location = new System.Drawing.Point(12, 256);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(84, 37);
            this.btnAdaugaProdus.TabIndex = 3;
            this.btnAdaugaProdus.Text = "Adauga produs";
            this.btnAdaugaProdus.Click += new System.EventHandler(this.btnAdaugaProdus_Click);
            // 
            // btnStergeProdus
            // 
            this.btnStergeProdus.Location = new System.Drawing.Point(121, 256);
            this.btnStergeProdus.Name = "btnStergeProdus";
            this.btnStergeProdus.Size = new System.Drawing.Size(84, 37);
            this.btnStergeProdus.TabIndex = 4;
            this.btnStergeProdus.Text = "Sterge produs";
            this.btnStergeProdus.Click += new System.EventHandler(this.btnStergeProdus_Click);
            // 
            // lstProduse
            // 
            this.lstProduse.Location = new System.Drawing.Point(12, 327);
            this.lstProduse.Name = "lstProduse";
            this.lstProduse.Size = new System.Drawing.Size(226, 186);
            this.lstProduse.TabIndex = 5;
            // 
            // txtIdLot
            // 
            this.txtIdLot.Location = new System.Drawing.Point(432, 36);
            this.txtIdLot.Name = "txtIdLot";
            this.txtIdLot.Size = new System.Drawing.Size(100, 20);
            this.txtIdLot.TabIndex = 6;
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(432, 85);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(100, 20);
            this.txtCantitate.TabIndex = 7;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(387, 141);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 8;
            // 
            // cmbProduse
            // 
            this.cmbProduse.Location = new System.Drawing.Point(421, 197);
            this.cmbProduse.Name = "cmbProduse";
            this.cmbProduse.Size = new System.Drawing.Size(121, 21);
            this.cmbProduse.TabIndex = 9;
            // 
            // btnAdaugaLot
            // 
            this.btnAdaugaLot.Location = new System.Drawing.Point(387, 256);
            this.btnAdaugaLot.Name = "btnAdaugaLot";
            this.btnAdaugaLot.Size = new System.Drawing.Size(84, 37);
            this.btnAdaugaLot.TabIndex = 10;
            this.btnAdaugaLot.Text = "Adauga lot";
            this.btnAdaugaLot.Click += new System.EventHandler(this.btnAdaugaLot_Click);
            // 
            // btnStergeLot
            // 
            this.btnStergeLot.Location = new System.Drawing.Point(503, 256);
            this.btnStergeLot.Name = "btnStergeLot";
            this.btnStergeLot.Size = new System.Drawing.Size(84, 37);
            this.btnStergeLot.TabIndex = 11;
            this.btnStergeLot.Text = "Sterge lot";
            this.btnStergeLot.Click += new System.EventHandler(this.btnStergeLot_Click);
            // 
            // lstLoturi
            // 
            this.lstLoturi.Location = new System.Drawing.Point(341, 327);
            this.lstLoturi.Name = "lstLoturi";
            this.lstLoturi.Size = new System.Drawing.Size(317, 186);
            this.lstLoturi.TabIndex = 12;
            // 
            // txtIdFisa
            // 
            this.txtIdFisa.Location = new System.Drawing.Point(836, 36);
            this.txtIdFisa.Name = "txtIdFisa";
            this.txtIdFisa.Size = new System.Drawing.Size(100, 20);
            this.txtIdFisa.TabIndex = 13;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(836, 85);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(100, 20);
            this.txtMaterial.TabIndex = 14;
            // 
            // txtCantMaterial
            // 
            this.txtCantMaterial.Location = new System.Drawing.Point(836, 141);
            this.txtCantMaterial.Name = "txtCantMaterial";
            this.txtCantMaterial.Size = new System.Drawing.Size(100, 20);
            this.txtCantMaterial.TabIndex = 15;
            // 
            // cmbLoturi
            // 
            this.cmbLoturi.Location = new System.Drawing.Point(826, 197);
            this.cmbLoturi.Name = "cmbLoturi";
            this.cmbLoturi.Size = new System.Drawing.Size(121, 21);
            this.cmbLoturi.TabIndex = 16;
            // 
            // btnAdaugaFisa
            // 
            this.btnAdaugaFisa.Location = new System.Drawing.Point(777, 256);
            this.btnAdaugaFisa.Name = "btnAdaugaFisa";
            this.btnAdaugaFisa.Size = new System.Drawing.Size(84, 37);
            this.btnAdaugaFisa.TabIndex = 17;
            this.btnAdaugaFisa.Text = "Adauga fisa";
            this.btnAdaugaFisa.Click += new System.EventHandler(this.btnAdaugaFisa_Click);
            // 
            // btnStergeFisa
            // 
            this.btnStergeFisa.Location = new System.Drawing.Point(893, 256);
            this.btnStergeFisa.Name = "btnStergeFisa";
            this.btnStergeFisa.Size = new System.Drawing.Size(84, 37);
            this.btnStergeFisa.TabIndex = 18;
            this.btnStergeFisa.Text = "Sterge fisa";
            this.btnStergeFisa.Click += new System.EventHandler(this.btnStergeFisa_Click);
            // 
            // lstFise
            // 
            this.lstFise.Location = new System.Drawing.Point(743, 327);
            this.lstFise.Name = "lstFise";
            this.lstFise.Size = new System.Drawing.Size(255, 186);
            this.lstFise.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Introdu ID produs.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Introdu numele produsului.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Introdu unitatea de masura.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Introdu ID lot.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Introdu cantitatea din lot.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Introdu data fabricatiei lotului.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Selecteaza produsul.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(851, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Introdu ID fisa.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(808, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Introdu principalul material folosit.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(823, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Introdu cantitatea de material.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(851, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Selecteaza lotul.";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(1062, 17);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(468, 449);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(1121, 490);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(352, 23);
            this.btnGrafic.TabIndex = 32;
            this.btnGrafic.Text = "Afiseaza grafic";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1550, 541);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdProdus);
            this.Controls.Add(this.txtNumeProdus);
            this.Controls.Add(this.txtUnitate);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.btnStergeProdus);
            this.Controls.Add(this.lstProduse);
            this.Controls.Add(this.txtIdLot);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cmbProduse);
            this.Controls.Add(this.btnAdaugaLot);
            this.Controls.Add(this.btnStergeLot);
            this.Controls.Add(this.lstLoturi);
            this.Controls.Add(this.txtIdFisa);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtCantMaterial);
            this.Controls.Add(this.cmbLoturi);
            this.Controls.Add(this.btnAdaugaFisa);
            this.Controls.Add(this.btnStergeFisa);
            this.Controls.Add(this.lstFise);
            this.Name = "Form1";
            this.Text = "Gestionare productie";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnGrafic;
    }
}

