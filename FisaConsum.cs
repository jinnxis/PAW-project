using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_BABOIU_BIANCA_GABRIELA_1053
{
    public class FisaConsum
    {
        public int Id { get; set; }
        public LotFabricatie Lot { get; set; }
        public string Material { get; set; }
        public int CantitateMaterial { get; set; }

        public FisaConsum(int id, LotFabricatie lot, string material, int cantitateMaterial)
        {
            Id = id;
            Lot = lot;
            Material = material;
            CantitateMaterial = cantitateMaterial;
        }

        public override string ToString()
        {
            return $"Fisa {Id}: {Material}, Cantitate: {CantitateMaterial}";
        }
    }
}
