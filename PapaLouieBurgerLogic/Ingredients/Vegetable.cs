using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{
    /// <summary>
    /// Типы овоща для бургера на выбор
    /// </summary>
    public enum VegType
    {
        Onion,
        Tomato,
        Salad,
        Coleslaw,
        Pickles,
        Paprika
    }
    /// <summary>
    /// Класс овоща на выбор какингредиента
    /// </summary>
    public class Vegetable : Ingredient
    {
        /// <summary>
        /// Приватная переменная для работы с get;set; у VegType
        /// </summary>
        private VegType _type;
        public VegType VegType
        {
            get { return _type; }

            /// <summary>
            /// Здесь настраивается информация о цене, весе и энергетической ценности овоща в зависимости от его типа 
            /// </summary>
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
                        throw new ArgumentException("Неизвестный тип ингрединта"); // Ошибка для случая, когда тип овоща не был выбран
                }
            }
        }
        /// <summary>
        /// Конструктор для создания овоща 
        /// </summary>
        /// <param name="batch">Номер партии продукта</param>
        /// <param name="release">Дата выпуска продукта</param>
        /// <param name="type">Тип овоща</param>
        public Vegetable(int batch, DateOnly release, VegType type) : base(batch, release)
        {

            VegType = type;
        }
    }
}
