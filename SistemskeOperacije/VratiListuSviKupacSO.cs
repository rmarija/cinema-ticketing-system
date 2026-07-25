using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiListuSviKupacSO : BaseSO
    {
        public List<Kupac> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
           
            string upit = @"SELECT k.*, m.idMesto, m.naziv as mestoNaziv, m.postanskiBroj 
                            FROM Kupac k 
                            JOIN Mesto m ON k.idMesto = m.idMesto";

            Result = broker.GetByQuery(new Kupac(), upit).Cast<Kupac>().ToList();
        }
    }
}