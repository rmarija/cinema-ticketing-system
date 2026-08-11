using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent
{
    internal class Komunikacija
    {
        private static Komunikacija instance;

        public static Komunikacija Instance
        {
            get
            {
                if (instance == null) instance = new Komunikacija();
                return instance;
            }
        }

        private Komunikacija()
        {
        }

        private Socket socket;
        private JsonNetworkSerializer serializer;

        internal void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                serializer = new JsonNetworkSerializer(socket);
            }
        }


        internal bool Login(string username, string password)
        {
            Connect();

            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.Login,
                Objekat = new Prodavac { Username = username, Password = password }
            };

            serializer.Send(zahtev);

            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno)
            {
                throw new Exception(odgovor.Greska);
            }

            return serializer.ReadTypeValue<bool>(odgovor.Objekat);
        }


        internal List<Prodavac> VratiSviProdavac()
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiSviProdavac
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);

            return serializer.ReadType<List<Prodavac>>(odgovor.Objekat);
        }

        internal List<Kupac> VratiListuSviKupac()
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiListuSviKupac
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);

            return serializer.ReadType<List<Kupac>>(odgovor.Objekat);
        }

        internal List<Karta> VratiListuSviKarta()
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiListuSviKarta
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);

            return serializer.ReadType<List<Karta>>(odgovor.Objekat);
        }

        internal List<Mesto> VratiListuSviMesto()
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiListuSviMesto
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);

            return serializer.ReadType<List<Mesto>>(odgovor.Objekat);
        }


        internal void SacuvajRacun(Racun racun)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.SacuvajRacun,
                Objekat = racun
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);
        }

        internal List<Racun> VratiRacunPoProdavcu(string kriterijum)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiRacunPoProdavcu,
                Objekat = kriterijum
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);

            return serializer.ReadType<List<Racun>>(odgovor.Objekat);
        }

        internal Racun VratiRacunPoId(int idRacun)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiRacunPoId,
                Objekat = idRacun.ToString()
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);

            return serializer.ReadType<Racun>(odgovor.Objekat);
        }

        internal void AzurirajRacun(Racun azuriran)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.AzurirajRacun,
                Objekat = azuriran
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);
        }


        internal void SacuvajKupac(Kupac kupac)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.SacuvajKupac,
                Objekat = kupac
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);
        }

        internal Kupac VratiKupcaPoId(int idKupac)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiKupcaPoId,
                Objekat = idKupac.ToString()
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);

            return serializer.ReadType<Kupac>(odgovor.Objekat);
        }

        internal List<Kupac> VratiKupcePoNazivuMesta(string kriterijum)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.VratiKupcePoNazivuMesta,
                Objekat = kriterijum
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);

            return serializer.ReadType<List<Kupac>>(odgovor.Objekat);
        }

        internal void AzurirajKupac(Kupac azuriran)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.AzurirajKupac,
                Objekat = azuriran
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);
        }

        internal void ObrisiKupac(int idKupac)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.ObrisiKupac,
                Objekat = idKupac.ToString()
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);
        }


        internal void SacuvajStrucnaSprema(StrucnaSprema strucnaSprema)
        {
            Zahtev zahtev = new Zahtev
            {
                Operacija = Operacija.SacuvajStrucnaSprema,
                Objekat = strucnaSprema
            };

            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Recive<Odgovor>();

            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);
        }
    }
}