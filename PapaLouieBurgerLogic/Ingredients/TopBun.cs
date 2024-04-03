using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{
    public class TopBun : Ingredient
    {

        private BunType _type { get; set; }
        public BunType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                switch (_type)
                {
                    case BunType.ClassicBun:
                        Cost = 16.0;
                        Weight = 40.0;
                        Ccal = 282.0;
                        break;
                    case BunType.SesameBun:
                        Cost = 18.0;
                        Weight = 44.0;
                        Ccal = 305.0;
                        break;
                    case BunType.RyeBun:
                        Cost = 16.0;
                        Weight = 40.0;
                        Ccal = 275.0;
                        break;
                    case BunType.Ciabatta:
                        Cost = 15.0;
                        Weight = 34.0;
                        Ccal = 295.0;
                        break;
                    case BunType.Toast:
                        Cost = 12.0;
                        Weight = 15.0;
                        Ccal = 313.0;
                        break;
                    default:
                        throw new ArgumentException("Unknown type");
                }
            }
        }        

        public TopBun(int batch, DateOnly release, BunType type) : base(batch, release)
        {
            Type = type;
            
        }




    }
}
