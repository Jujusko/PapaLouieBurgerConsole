using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{
    public enum VegType
    {
        Onion,
        Tomato,
        Salad,
        Coleslaw,
        Pickles,
        Paprika
    }
    public class Vegetable : Ingredient
    {
        private VegType _type { get; set; }
        public VegType VegType
        {
            get { return _type; }

            set
            {
                _type = value;
                switch (_type)
                {
                    case VegType.Onion:
                        Cost = 5.0;
                        Weight = 20.0;
                        Ccal = 40.0;
                        break;
                    case VegType.Tomato:
                        Cost = 12.0;
                        Weight = 23.0;
                        Ccal = 24.0;
                        break;
                    case VegType.Salad:
                        Cost = 7.0;
                        Weight = 18.0;
                        Ccal = 15.0;
                        break;
                    case VegType.Coleslaw:
                        Cost = 15.0;
                        Weight = 20.0;
                        Ccal = 152.0;
                        break;
                    case VegType.Pickles:
                        Cost = 6.0;
                        Weight = 16.0;
                        Ccal = 11.0;
                        break;
                    case VegType.Paprika:
                        Cost = 12.0;
                        Weight = 20.0;
                        Ccal = 20.0;
                        break;
                    default:
                        throw new ArgumentException("Unknown type");
                }
            }
        }
        public Vegetable(int batch, DateOnly release, VegType type) : base(batch, release)
        {

            VegType = type;
        }
    }
}
