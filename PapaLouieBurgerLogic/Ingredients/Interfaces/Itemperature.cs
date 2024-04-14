using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients.Interfaces
{
    public enum Temperature
    {
        Hot,
        Neutral,
        Cold
    }

    public interface Itemperature : IComparable
    {
        public Temperature Value { get; set; }
    }
}
