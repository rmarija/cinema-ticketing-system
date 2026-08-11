using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using System.Collections.Generic;

namespace SistemskeOperacije
{
    public class LoginSO : BaseSO
    {
        private string username;
        private string password;
        public bool Result { get; set; }

        public LoginSO(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        protected override void ExecuteConcreteOperation()
        {
            string query = $"SELECT * FROM Prodavac WHERE username = '{username}' AND password = '{password}'";
            Prodavac p = new Prodavac();
            List<IEntity> result = broker.GetByQuery(p, query);
            Result = result.Count > 0;
        }
    }
}