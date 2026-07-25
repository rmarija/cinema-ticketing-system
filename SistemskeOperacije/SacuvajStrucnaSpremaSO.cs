using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class SacuvajStrucnaSpremaSO : BaseSO
    {
        private StrucnaSprema strSprema;

        public SacuvajStrucnaSpremaSO(StrucnaSprema strSprema)
        {
            this.strSprema = strSprema;
        }

        protected override void ExecuteConcreteOperation()
        {
            int id = broker.AddWithId(strSprema);
            strSprema.IdStrucnaSprema = id;
        }
    }
}