using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_BKJN
{
    internal class MenuItem
    {
        public Random random = new Random();
        public string[] Proteins = { "Wolowina", "Salami", "Indyk", "Szynka", "Pastrami", "Tofu" };
        public string[] Condiments = { "musztardo żółta", "musztarda brązowa", "musztarda miodowa", "majonez", "przyprawy", "sosfrancuski" };
        public string[] Bred = {"Ryżowe", "Białe", "Przenne", "Pumpernikiel", "Bułka" };
        public string description = "";
        public string Price;

        public void Generate()
        {
            string randomProteins = Proteins[random.Next(Proteins.Length)];
            string randomCondiments = Condiments[random.Next(Condiments.Length)];
            string randomBred = Bred[random.Next(Bred.Length)];


            description = randomProteins + randomCondiments + "Pieczywo: " + randomBred + ".";

            decimal bucks = random.Next(2, 5);
            decimal cents = random.Next(1, 98);
            decimal price = bucks + (cents * 0.1M);
            Price = price.ToString("c");
        }
    }
}
