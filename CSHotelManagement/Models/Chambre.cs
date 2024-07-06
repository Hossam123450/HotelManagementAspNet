using System;
namespace prepaControle.Models
{
    public class Chambre
    {
        public int Num { get; set; }
        public string Type { get; set; }

        public int NumEtage { get; set; }
        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }
    }
}
