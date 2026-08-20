using DBBroker;
using SistemskeOperacije;
using Zajednicki.Domen;

public class SacuvajRacunSO : BaseSO
{
    private Racun racun;

    private static readonly Dictionary<string, int> KapacitetSale = new Dictionary<string, int>
    {
        { "Sala 1", 100 },
        { "Sala 2", 80 },
        { "Sala 3", 60 }
    };

    public SacuvajRacunSO(Racun racun)
    {
        this.racun = racun;
    }

    protected override void ExecuteConcreteOperation()
    {
        ProveriKapacitetSale();

        int idRacuna = broker.AddWithId(racun);
        racun.IdRacun = idRacuna;
        int rb = 1;
        foreach (var stavka in racun.Stavke)
        {
            stavka.Racun = racun;
            stavka.Rb = rb++;
            broker.Add(stavka);
        }
    }

    private void ProveriKapacitetSale()
    {
        foreach (var stavka in racun.Stavke)
        {
            if (!KapacitetSale.TryGetValue(stavka.Karta.Sala, out int kapacitet))
                throw new Exception($"Nepoznata sala: {stavka.Karta.Sala}");

            string query = $"select isnull(sum(kolicina), 0) from StavkaRacuna where idKarta = {stavka.Karta.IdKarta}";
            int vecProdato = broker.ExecuteScalar(query);

            if (vecProdato + stavka.Kolicina > kapacitet)
            {
                throw new Exception(
                    $"Prekoračen kapacitet sale za projekciju \"{stavka.Karta.NazivFilma}\" " +
                    $"({stavka.Karta.DatumVremeProjekcije:g}). Slobodno je još {kapacitet - vecProdato} mesta.");
            }
        }
    }
}