using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{
    /// <summary>
    /// Типы ломтика сыра для бургера на выбор
    /// </summary>
    public enum CheeseType
    {
        Cheddar,
        Gouda,
        Parmesan,
        Feta,
        DorBlue
    }
    /// <summary>
    /// Класс ломтика сыра как ингредиента
    /// </summary>
    public class Cheese : Ingredient
    {
        /// <summary>
        /// Приватная переменная для работы с get;set; у CheeseType
        /// </summary>
        private CheeseType _type;
        public CheeseType CheeseType
        {
            get { return _type; }

            /// <summary>
            /// Здесь настраивается информация о цене, весе и энергетической ценности ломтика сыра в зависимости от его типа 
            /// </summary>
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
                    default: 
                        throw new ArgumentException("Неизвестный тип ингрединта"); // Ошибка для случая, когда тип ломтика сыра не был выбран 
                }

            }
        }
        /// <summary>
        /// Конструктор для создания ломтика сыра
        /// </summary>
        /// <param name="batch">Номер партии продукта</param>
        /// <param name="relese">Дата выпуска продукта</param>
        /// <param name="type">Тип ломтика сыра</param>
        public Cheese(int batch, DateOnly relese, CheeseType type) : base(batch, relese)
        {
            CheeseType = type;
        }


    }
}
