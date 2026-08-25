using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Server
{
    internal class ClientHandler
    {
        private Socket klijent;
        private readonly List<ClientHandler> klijenti;
        private readonly Server server;
        private JsonNetworkSerializer serializer;

        public ClientHandler(Socket klijent, List<ClientHandler> klijenti)
        {
            this.klijent = klijent;
            this.klijenti = klijenti;
            serializer = new JsonNetworkSerializer(klijent);
        }

        public void Handle()
        {
            try
            {
                while (true)
                {
                    Zahtev zahtev = serializer.Recive<Zahtev>();
                    Odgovor odgovor = ProcesuirajZahtev(zahtev);
                    serializer.Send(odgovor);
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine("Komunikacija sa klijentom je prekinuta!");
                Debug.WriteLine(">>>SOCKET>>> " + ex.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine("Komunikacija sa klijentom je prekinuta!");
                Debug.WriteLine(">>>IO>>> " + ex.Message);
            }
            finally
            {
                klijenti.Remove(this);
                serializer.Close();
            }
        }

        private Odgovor ProcesuirajZahtev(Zahtev? zahtev)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Uspesno = true;

            try
            {
                switch (zahtev.Operacija)
                {
                    case Operacija.VratiSviProdavac:
                        odgovor.Objekat = Kontroler.Instance.VratiListuSviProdavac();
                        break;
                    case Operacija.VratiListuSviKupac:
                        odgovor.Objekat = Kontroler.Instance.VratiListuSviKupac();
                        break;
                    case Operacija.VratiListuSviKarta:
                        odgovor.Objekat = Kontroler.Instance.VratiListuSviKarta();
                        break;
                    case Operacija.SacuvajRacun:
                        Kontroler.Instance.SacuvajRacun(serializer.ReadType<Racun>(zahtev.Objekat));
                        break;
                    case Operacija.VratiRacunPoProdavcu:
                        odgovor.Objekat = Kontroler.Instance.VratiRacunPoProdavcu(serializer.ReadType<string>(zahtev.Objekat));
                        break;
                    case Operacija.VratiRacunPoId:
                        odgovor.Objekat = Kontroler.Instance.VratiRacunPoId(int.Parse(serializer.ReadType<string>(zahtev.Objekat)));
                        break;
                    case Operacija.AzurirajRacun:
                        Kontroler.Instance.AzurirajRacun(serializer.ReadType<Racun>(zahtev.Objekat));
                        break;
                    case Operacija.SacuvajKupac:
                        Kontroler.Instance.SacuvajKupac(serializer.ReadType<Kupac>(zahtev.Objekat));
                        break;
                    case Operacija.AzurirajKupac:
                        Kontroler.Instance.AzurirajKupac(serializer.ReadType<Kupac>(zahtev.Objekat));
                        break;
                    case Operacija.ObrisiKupac:
                        Kontroler.Instance.ObrisiKupac(int.Parse(serializer.ReadType<string>(zahtev.Objekat)));
                        break;
                    case Operacija.Login:
                        odgovor.Objekat = Kontroler.Instance.Login(serializer.ReadType<Prodavac>(zahtev.Objekat).Username, serializer.ReadType<Prodavac>(zahtev.Objekat).Password);
                        break;
                    case Operacija.SacuvajStrucnaSprema:
                        Kontroler.Instance.SacuvajStrucnaSprema(serializer.ReadType<StrucnaSprema>(zahtev.Objekat));
                        break;
                    case Operacija.VratiListuSviMesto:
                        odgovor.Objekat = Kontroler.Instance.VratiListuSviMesto();
                        break;
                    case Operacija.VratiKupcePoNazivuMesta:
                        odgovor.Objekat = Kontroler.Instance.VratiKupcePoNazivuMesta(serializer.ReadType<string>(zahtev.Objekat));
                        break;

                    case Operacija.VratiKupcaPoId:
                        odgovor.Objekat = Kontroler.Instance.VratiKupcaPoId(int.Parse(serializer.ReadType<string>(zahtev.Objekat)));
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(odgovor.Greska);
                odgovor.Greska = ex.Message;
                odgovor.Uspesno = false;
            }

            return odgovor;
        }

        internal void Close()
        {
            klijent.Close();
        }
    }
}
