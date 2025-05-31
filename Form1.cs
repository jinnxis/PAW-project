using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string nume = txtNumeProdus.Text.Trim();
            string unitate = txtUnitate.Text.Trim();


            var p = new Produse(id, nume, unitate);
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
            int idLot = int.Parse(txtIdLot.Text);
            int cantitate = int.Parse(txtCantitate.Text);
            DateTime data = dtpData.Value;

            var produsSelectat = (Produse)cmbProduse.SelectedItem;

            var lot = new LotFabricatie(idLot, produsSelectat, cantitate, data);
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
            int idFisa = int.Parse(txtIdFisa.Text);
            string material = txtMaterial.Text.Trim();
            int cantMaterial = int.Parse(txtCantMaterial.Text);

            var lotSelectat = (LotFabricatie)cmbLoturi.SelectedItem;

            var fisa = new FisaConsum(idFisa, lotSelectat, material, cantMaterial);
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

        // Evenimente auxiliare (opțional)
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
            // Poți adăuga afișare detalii dacă vrei
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

    }
}
