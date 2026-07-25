using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiListuSviProdavacSO : BaseSO
    {
        public List<Prodavac>? Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Prodavac()).Cast<Prodavac>().ToList();
        }
    }
}
