using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_BABOIU_BIANCA_GABRIELA_1053
{
    public class LotFabricatie
    {
        public int IdLot { get; set; }
        public Produse ProdusFabricat { get; set; }
        public int Cantitate { get; set; }
        public DateTime DataFabricatie { get; set; }

        public LotFabricatie(int idLot, Produse produs, int cantitate, DateTime data)
        {
            IdLot = idLot;
            ProdusFabricat = produs;
            Cantitate = cantitate;
            DataFabricatie = data;
        }

        public override string ToString()
        {
            return $"Lot {IdLot}: {ProdusFabricat?.Nume}, Cantitate: {Cantitate}, Data: {DataFabricatie.ToShortDateString()}";
        }
    }
}
