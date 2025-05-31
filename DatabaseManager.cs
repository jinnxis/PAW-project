using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Proiect_BABOIU_BIANCA_GABRIELA_1053
{

    public class DatabaseManager
    {
        private string connString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\ProjectDatabase.accdb;";

        public void AdaugaProdus(int id, string nume, string unitate)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO Produse (ID, Nume, Unitate) VALUES (?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.Parameters.AddWithValue("?", nume);
                    cmd.Parameters.AddWithValue("?", unitate);
                    cmd.ExecuteNonQuery();


                }
            }
            catch (OleDbException ex)
            {
                if (ex.Message.Contains("duplicate") || ex.Message.Contains("duplicate values") || ex.ErrorCode == -2147467259)
                {
                    MessageBox.Show("Eroare: exista deja un produs cu acest ID. Foloseste un ID diferit.");
                }
                else
                {
                    MessageBox.Show("A aparut o eroare la inserare: " + ex.Message);
                }
            }
        }

        public void StergeProdus(int id)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM Produse WHERE ID = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void AdaugaLot(LotFabricatie lot)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO LotFabricatie (ID, Produs, Cantitate, DataFabricatie) VALUES (?, ?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = lot.IdLot;
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = lot.ProdusFabricat.Nume;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = lot.Cantitate;
                    cmd.Parameters.Add("?", OleDbType.Date).Value = lot.DataFabricatie;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (OleDbException ex)
            {
                if (ex.Message.Contains("duplicate") || ex.Message.Contains("duplicate values") || ex.ErrorCode == -2147467259)
                {
                    MessageBox.Show("Eroare: exista deja un lot cu acest ID. Foloseste un ID diferit.");
                }
                else
                {
                    MessageBox.Show("A aparut o eroare la inserare: " + ex.Message);
                }
            }
        }

        public void StergeLot(int id)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM LotFabricatie WHERE ID = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void AdaugaFisa(FisaConsum fisa)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO FisaConsum (ID, Lot, Material, CantitateMaterial) VALUES (?, ?, ?, ?)";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", fisa.Id);
                    cmd.Parameters.AddWithValue("?", fisa.Lot.ProdusFabricat.Nume);
                    cmd.Parameters.AddWithValue("?", fisa.Material);
                    cmd.Parameters.AddWithValue("?", fisa.CantitateMaterial);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (OleDbException ex)
            {
                if (ex.Message.Contains("duplicate") || ex.Message.Contains("duplicate values") || ex.ErrorCode == -2147467259)
                {
                    MessageBox.Show("Eroare: exista deja o fisa cu acest ID. Foloseste un ID diferit.");
                }
                else
                {
                    MessageBox.Show("A aparut o eroare la inserare: " + ex.Message);
                }
            }
        }

        public void StergeFisa(int id)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM FisaConsum WHERE ID = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", id);
                cmd.ExecuteNonQuery();
            }
        }

        
    }
}
