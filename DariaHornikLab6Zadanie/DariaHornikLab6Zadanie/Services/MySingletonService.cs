using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DariaHornikLab6Zadanie.Services
{
    class MySingletonService :IMySingletonService
    {
        private List<DariaHornikLab6Zadanie.Models.Attraction> attractions;
        private static readonly MySingletonService _mySingletonServiceInstance = new MySingletonService();


        private MySingletonService()
        {
            attractions = new List<Models.Attraction>();
            attractions.Add(new Models.Attraction("Most czarownic", "Szewska 10", "Popularna nazwa łącznika w formie mostu łączącego " +
                "na wysokości ostatniej kondygnacji obie wieże katedry św. Marii Magdaleny we Wrocławiu. " +
                "Istnienie tego łącznika wzmiankowane jest po raz pierwszy w 1459, krótko po ukończeniu budowy obu wież.", 3));
            attractions.Add(new Models.Attraction("Rynek", "Rynek", " Średniowieczny plac targowy we Wrocławiu, obecnie centralna część strefy pieszej." +
                " Jeden z największych rynków staromiejskich Europy, z największymi ratuszami w Polsce.", 3));
            attractions.Add(new Models.Attraction("Ogród Japoński", "Adama Mickiewicza 1", "Ogród japoński został założony w latach 1909–1913" +
                " wokół dawnego stawu Ludwiga Theodora Moritza-Eichborna w obrębie obecnego Parku Szczytnickiego, " +
                "jako jedyny egzotyczny ogród prezentowany na Wystawie Ogrodniczej w 1913 r. Wystawa ta stanowiła część Wystawy Stulecia", 2));
            attractions.Add(new Models.Attraction("Hydropolis", "Na Grobli 17", "Centrum wiedzy poświęcone wodzie, które zlokalizowane jest we Wrocławiu," +
                " w Polsce. Ośrodek łączy walory edukacyjne z nowoczesną formą wystawienniczą.", 1));
        }

        public static MySingletonService GetInstance() => _mySingletonServiceInstance;
        public List<DariaHornikLab6Zadanie.Models.Attraction> GetAttractions() => attractions;
        public void AddAttractions(DariaHornikLab6Zadanie.Models.Attraction attr) => attractions.Add(attr);
    }
}
