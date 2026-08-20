using System.Collections.Generic;
using SistemskeOperacije;
using Zajednicki.Domen;

namespace Server
{
    internal class Kontroler
    {
        private static Kontroler? instance;

        public static Kontroler Instance
        {
            get
            {
                if (instance == null) instance = new Kontroler();
                return instance;
            }
        }

        private Kontroler()
        {
        }

        internal List<Prodavac> VratiSviProdavac()
        {
            VratiListuSviProdavacSO so = new VratiListuSviProdavacSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal List<Kupac> VratiListuSviKupac()
        {
            VratiListuSviKupacSO so = new VratiListuSviKupacSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal List<Karta> VratiListuSviKarta()
        {
            VratiListuSviKartaSO so = new VratiListuSviKartaSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal void SacuvajRacun(Racun racun)
        {
            SacuvajRacunSO so = new SacuvajRacunSO(racun);
            so.ExecuteTemplate();
        }

        internal List<Racun> VratiRacunPoProdavcu(string kriterijum)
        {
            VratiRacunPoProdavcuSO so = new VratiRacunPoProdavcuSO(kriterijum);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal Racun VratiRacunPoId(int idRacun)
        {
            VratiRacunPoIdSO so = new VratiRacunPoIdSO(idRacun);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal void AzurirajRacun(Racun racun)
        {
            AzurirajRacunSO so = new AzurirajRacunSO(racun);
            so.ExecuteTemplate();
        }

        internal void SacuvajKupac(Kupac kupac)
        {
            SacuvajKupacSO so = new SacuvajKupacSO(kupac);
            so.ExecuteTemplate();
        }

        internal void AzurirajKupac(Kupac kupac)
        {
            AzurirajKupacSO so = new AzurirajKupacSO(kupac);
            so.ExecuteTemplate();
        }

        internal void ObrisiKupac(int idKupac)
        {
            ObrisiKupacSO so = new ObrisiKupacSO(idKupac);
            so.ExecuteTemplate();
        }

        internal bool Login(string username, string password)
        {
            LoginSO so = new LoginSO(username, password);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal void SacuvajStrucnaSprema(StrucnaSprema strucnaSprema)
        {
            SacuvajStrucnaSpremaSO so = new SacuvajStrucnaSpremaSO(strucnaSprema);
            so.ExecuteTemplate();
        }

        internal List<Mesto> VratiListuSviMesto()
        {
            VratiListuSviMestoSO so = new VratiListuSviMestoSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        internal List<Kupac> VratiKupcePoNazivuMesta(string kriterijum)
        {
            VratiKupcePoNazivuMestaSO so = new VratiKupcePoNazivuMestaSO(kriterijum);
            so.ExecuteTemplate();
            return so.Result;
        }

        internal Kupac VratiKupcaPoId(int idKupac)
        {
            VratiKupcaPoIdSO so = new VratiKupcaPoIdSO(idKupac);
            so.ExecuteTemplate();
            return so.Result;
        }
    }
}