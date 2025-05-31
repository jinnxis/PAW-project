using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_BABOIU_BIANCA_GABRIELA_1053
{
    public class Produse
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string UnitateMasura { get; set; }

        public Produse(int id, string nume, string unitateMasura)
        {
            Id = id;
            Nume = nume;
            UnitateMasura = unitateMasura;
        }

        public override string ToString()
        {
            return $"{Id}: {Nume} ({UnitateMasura})";
        }
    }
}
