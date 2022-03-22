using Microsoft.EntityFrameworkCore;
//ovde se nalaze DbSet svojstva (properties) koje su povezane sa svim klasama koje predstavljaju model za bazu podataka

namespace Models {


    public class KuvarContext : DbContext {

        public DbSet<Kuvar> Kuvari { get; set; }

        public DbSet<Korisnik> Korisnici { get; set; }

        public DbSet<Sastojak> Sastojci { get; set; }

        public DbSet<Recept> Recepti { get; set; }

        public DbSet<ReceptKorak> Koraci { get; set; }

        public DbSet<ReceptOcena> Ocene { get; set; }

        public DbSet<ReceptSastojak> ReceptSastojak { get; set; }
//kolekcije koje nam vraća baza

        public KuvarContext(DbContextOptions options) : base(options) {

        }

    }
}