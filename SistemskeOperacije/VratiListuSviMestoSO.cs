using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiListuSviMestoSO : BaseSO
    {
        public List<Mesto> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAll(new Mesto()).Cast<Mesto>().ToList();
        }
    }
}
