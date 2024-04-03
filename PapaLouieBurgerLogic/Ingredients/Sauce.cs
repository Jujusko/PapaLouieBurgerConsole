using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{
    public enum SauceType
    {
        Ketchup,
        Mayonnaise,
        Mustard,
        Chili,
        Tartar,
        BBQ
    }
    public class Sauce : Ingredient
    {
        private SauceType _type { get; set; }
        public SauceType SauceType
        {
            get { return _type; }
            set
            {
                _type = value;
                switch (_type)
                {
                    case SauceType.Ketchup:
                        Cost = 8.0;
                        Weight = 12.0;
                        Ccal = 112.0;
                        break;
                    case SauceType.Mayonnaise:
                        Cost = 9.0;
                        Weight = 12.0;
                        Ccal = 680.0;
                        break;
                    case SauceType.Mustard:
                        Cost = 7.0;
                        Weight = 12.0;
                        Ccal = 66.0;
                        break;
                    case SauceType.Chili:
                        Cost = 10.0;
                        Weight = 12.0;
                        Ccal = 44.0;
                        break;
                    case SauceType.Tartar:
                        Cost = 10.0;
                        Weight = 12.0;
                        Ccal = 211.0;
                        break;
                    case SauceType.BBQ:
                        Cost = 8.0;
                        Weight = 12.0;
                        Ccal = 172.0;
                        break;
                    default:
                        throw new ArgumentException("Unknown type");
                }
            }
        }
        public Sauce(int batch, DateOnly release, SauceType type) : base(batch, release)
        {
            SauceType = type;
        }




    }
}
