using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{

    public class Ingredient
    {
        public int NumberOfBatch { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public double Cost { get; protected set; }
        public double Weight { get; protected set; }
        public double Ccal { get; protected set; }        

        public Ingredient(int batch, DateOnly release)
        {
            NumberOfBatch = batch;
            ReleaseDate = release;
        }

    }
}
