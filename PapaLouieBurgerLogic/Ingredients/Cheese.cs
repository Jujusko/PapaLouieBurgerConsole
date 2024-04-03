using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{
    public enum CheeseType
    {
        Cheddar,
        Gouda,
        Parmesan,
        Feta,
        DorBlue
    }
    public class Cheese : Ingredient
    {
        private CheeseType _type { get; set; }
        public CheeseType CheeseType
        {
            get { return _type; }
            set
            {
                _type = value;
                switch (_type)
                {
                    case CheeseType.Cheddar:
                        Cost = 10.0;
                        Weight = 19.0;
                        Ccal = 420.0;
                        break;
                    case CheeseType.Gouda:
                        Cost = 10.0;
                        Weight = 19.0;
                        Ccal = 356.0;
                        break;
                    case CheeseType.Parmesan:
                        Cost = 25.0;
                        Weight = 17.0;
                        Ccal = 431.0;
                        break;
                    case CheeseType.Feta:
                        Cost = 15.0;
                        Weight = 20.0;
                        Ccal = 265.0;
                        break;
                    case CheeseType.DorBlue:
                        Cost = 25.0;
                        Weight = 15.0;
                        Ccal = 337.0;
                        break;
                    default: throw new ArgumentException("Unknown type");
                }

            }
        }
        public Cheese(int batch, DateOnly relese, CheeseType type) : base(batch, relese)
        {
            CheeseType = type;
        }


    }
}
