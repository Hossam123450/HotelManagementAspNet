using System;
using prepaControle.Models;
namespace prepaControle.Data
{
    public class ChambreData
    {
        private static List<Chambre> chambres = new List<Chambre> {
            new Chambre
            {
                Num=1,
                Type="chambre simple",
                NumEtage=2,
                DateDebut=new DateTime(2020,03,12),
                DateFin=new DateTime(2020,03,15),

            },
            new Chambre
            {
                Num=2,
                Type="chambre double",
                NumEtage=2,
                DateDebut=new DateTime(2020,03,12),
                DateFin=new DateTime(2020,03,15),
            },
            new Chambre
            {
                Num=3,
                Type="suite",
                NumEtage=2,
                DateDebut=new DateTime(2020,03,12),
                DateFin=new DateTime(2020,03,15),

            }
        };
        public static List<Chambre> GetChambre()
        {
            return chambres;
        }


    }
}
