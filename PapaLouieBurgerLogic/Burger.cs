using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaLouieBurgerLogic.Ingredients;

namespace PapaLouieBurgerLogic
{
    public class Burger
    {
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public int TotalCost { get; private set; }
        public int TotalWeight { get; private set; }

    }
}
w