using CompleteWebApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CompleteWebApp.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Rover> Rovers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rover>().HasData(new Rover { Id = 1, Name = "Spirit", History = "Spirit, också känd som MER-A (Mars Exploration Rover – A) eller MER-2, var NASAs första sond i Marsutforskningsprogrammet Mars Exploration Rover Mission. Den sköts upp med en Delta II-raket från Cape Canaveral Air Force Station, den 10 juni 2003 och landade på Mars yta, den 3 januari 2004. Uppdraget var tänkt att pågå i 90 dagar, men tack vare att solcellerna då och då blåstes rena av starka vindar på Mars, överlevde Spirit i 2 269 dagar. Under sin tid på Mars tillryggalade den totalt 7,73 kilometer." });
            modelBuilder.Entity<Rover>().HasData(new Rover { Id = 2, Name = "Opportunity", History = "Opportunity, också känd som MER-B (Mars Exploration Rover – B) eller MER-1 var NASAs andra rymdsond i Mars-utforskningsprogrammet Mars Exploration Rover Mission. MER-B sköts iväg med en Delta II-raket från Cape Canaveral Air Force Station , 8 juli 2003 och landade i området Meridiani planum på planeten Mars den 25 januari 2004. NASA förklarade den 13 februari 2019 uppdraget för avslutat då man inte sedan juni 2018 haft kontakt med farkosten. Detta efter att en större sandstorm dragit fram över området där den befann sig. Opportunity var verksam i hela 15 år och 19 dagar trots att uppdraget endast planerade pågå i 90 dagar." });
            modelBuilder.Entity<Rover>().HasData(new Rover { Id = 3, Name = "Curiosity", History = "Curiosity (Mars Science Laboratory, förkortas MSL) är en obemannad motoriserad landfarkost (strövare) som sköts upp med en Atlas V 541-raket från Cape Canaveral Air Force Station, den 26 november 2011. Enligt plan landade strövaren på Mars vid kratern Gale den 5 augusti 2012. Strövaren är tre gånger så tung och dubbelt så bred som de tidigare Mars Exploration Rovers (MER) Spirit och Opportunity. Strövaren förväntades vid uppskjutningen arbeta i minst ett marsår (cirka två jordår) och planerades att bli den strövare som täckte en större del av planetytan än någon tidigare strövare. Uppdraget var att undersöka Mars tidigare och dåvarande förmåga att hysa liv. Curiosity är 2021 fortfarande aktiv, vilket innebär att den har överlevt långt längre än vad man först trodde eller planerade för." });
        }
    }
}
