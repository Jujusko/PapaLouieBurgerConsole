using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{
    public enum PattyType
    {
        Beef,
        Pork,
        Chiken,
        Fish,
        Falafel
    }
    public class BurgerPatty : Ingredient
    {
        private PattyType _type;
        public PattyType PattyType
        {
            get { return _type; }
            set
            {
                _type = value;
                switch (_type)
                {
                    case PattyType.Beef:
                        Cost = 105.0;
                        Weight = 110.0;
                        Ccal = 210.0;
                        break;
                    case PattyType.Pork:
                        Cost = 95.0;
                        Weight = 112.0;
                        Ccal = 205.0;
                        break;
                    case PattyType.Chiken:
                        Cost = 85.0;
                        Weight = 108.0;
                        Ccal = 180.0;
                        break;
                    case PattyType.Fish:
                        Cost = 130.0;
                        Weight = 105.0;
                        Ccal = 144.0;
                        break;
                    case PattyType.Falafel:
                        Cost = 115.0;
                        Weight = 113.0;
                        Ccal = 333.0;
                        break;
                    default:
                        throw new ArgumentException("Unknown type");
                }

            }

        }       
        public BurgerPatty(int batch, DateOnly release, PattyType pattyType) : base(batch, release)
        {
            PattyType = pattyType;
        }
    }

}
