using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect_BABOIU_BIANCA_GABRIELA_1053
{
    public partial class Form1 : Form
    {
        List<Produse> produse = new List<Produse>();
        List<LotFabricatie> loturi = new List<LotFabricatie>();
        List<FisaConsum> fise = new List<FisaConsum>();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstProduse.SelectedIndexChanged += LstProduse_SelectedIndexChanged;
            lstLoturi.SelectedIndexChanged += LstLoturi_SelectedIndexChanged;
            lstFise.SelectedIndexChanged += LstFise_SelectedIndexChanged;
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdProdus.Text);
            string nume = txtNumeProdus.Text;
            string unitate = txtUnitate.Text;

            if (!int.TryParse(txtIdProdus.Text, out id))
            {
                MessageBox.Show("ID-ul produsului trebuie sa fie un numar.");
                return;
            }

            if (produse.Any(prod => prod.Id == id))
            {
                MessageBox.Show("Exista deja un produs cu acest ID.");
                return;
            }

            Produse p = new Produse(id, nume, unitate);
            produse.Add(p);

            lstProduse.Items.Add(p);
            cmbProduse.Items.Add(p);

            txtIdProdus.Clear();
            txtNumeProdus.Clear();
            txtUnitate.Clear();
        }

        private void btnStergeProdus_Click(object sender, EventArgs e)
        {
            if (lstProduse.SelectedItem == null)
                return;

            var produsSelectat = (Produse)lstProduse.SelectedItem;

            produse.Remove(produsSelectat);
            lstProduse.Items.Remove(produsSelectat);
            cmbProduse.Items.Remove(produsSelectat);
        }

        private void btnAdaugaLot_Click(object sender, EventArgs e)
        {
            int id;
            int cantitate;
            if (!int.TryParse(txtIdLot.Text, out id))
            {
                MessageBox.Show("ID-ul lotului trebuie sa fie un numar intreg.");
                return;
            }

            if (!int.TryParse(txtCantitate.Text, out cantitate))
            {
                MessageBox.Show("Cantitatea trebuie sa fie un numar intreg.");
                return;
            }

            if (cmbProduse.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza un produs din lista.");
                return;
            }

            if (loturi.Any(l => l.IdLot == id))
            {
                MessageBox.Show("Exista deja un lot cu acest ID.");
                return;
            }

            DateTime data = dtpData.Value;
            Produse produs = (Produse)cmbProduse.SelectedItem;

            LotFabricatie lot = new LotFabricatie(id, produs, cantitate, data);
            loturi.Add(lot);

            lstLoturi.Items.Add(lot);
            cmbLoturi.Items.Add(lot);

            txtIdLot.Clear();
            txtCantitate.Clear();
        }

        private void btnStergeLot_Click(object sender, EventArgs e)
        {
            var lotSelectat = (LotFabricatie)lstLoturi.SelectedItem;
            loturi.Remove(lotSelectat);

            lstLoturi.Items.Remove(lotSelectat);
            cmbLoturi.Items.Remove(lotSelectat);
        }

        private void btnAdaugaFisa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdFisa.Text);
            int cant;

            if (!int.TryParse(txtIdFisa.Text, out id))
            {
                MessageBox.Show("ID-ul fisei trebuie sa fie un numar intreg.");
                return;
            }

            if (!int.TryParse(txtCantMaterial.Text, out cant))
            {
                MessageBox.Show("Cantitatea materialului trebuie sa fie un numar.");
                return;
            }

            if (cmbLoturi.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza un lot din lista.");
                return;
            }
            
            if (fise.Any(f => f.Id == id))
            {
                MessageBox.Show("Exista deja o fisa cu acest ID.");
                return;
            }

            LotFabricatie lot = (LotFabricatie)cmbLoturi.SelectedItem;
            string material = txtMaterial.Text;
            int cantitate = int.Parse(txtCantMaterial.Text);

            FisaConsum fisa = new FisaConsum(id, lot, material, cantitate);
            fise.Add(fisa);

            lstFise.Items.Add(fisa);

            txtIdFisa.Clear();
            txtMaterial.Clear();
            txtCantMaterial.Clear();
        }

        private void btnStergeFisa_Click(object sender, EventArgs e)
        {
            var fisaSelectata = (FisaConsum)lstFise.SelectedItem;
            fise.Remove(fisaSelectata);

            lstFise.Items.Remove(fisaSelectata);
        }

        private void LstProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProduse.Items.Clear();
            foreach (var p in produse)
                cmbProduse.Items.Add(p);
        }

        private void LstLoturi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLoturi.Items.Clear();
            foreach (var l in loturi)
                cmbLoturi.Items.Add(l);
        }

        private void LstFise_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AfiseazaGraficCantitatiProduse()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            chart1.ChartAreas.Add(new ChartArea("MainArea"));

            Series serie = new Series("Cantitati produse");
            serie.ChartType = SeriesChartType.Column;

            var cantitatiPerProdus = loturi
                .GroupBy(l => l.ProdusFabricat.Nume)
                .Select(g => new
                {
                    NumeProdus = g.Key,
                    CantitateTotala = g.Sum(l => l.Cantitate)
                });

            foreach (var item in cantitatiPerProdus)
            {
                serie.Points.AddXY(item.NumeProdus, item.CantitateTotala);
            }

            chart1.Series.Add(serie);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfiseazaGraficCantitatiProduse();
        }
    }
}
