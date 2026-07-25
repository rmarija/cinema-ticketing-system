using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiListuSviKartaSO : BaseSO
    {
        public List<Karta> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Karta()).Cast<Karta>().ToList();
        }
    }
}