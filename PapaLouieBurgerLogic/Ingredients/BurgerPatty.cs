using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{
    /// <summary>
    /// Типы колтлеты для бургера на выбор
    /// </summary>
    public enum PattyType
    {
        Beef,
        Pork,
        Chiken,
        Fish,
        Falafel
    }

    /// <summary>
    /// Класс котлеты как ингредиента
    /// </summary>
    public class BurgerPatty : Ingredient
    {
        /// <summary>
        /// Приватная переменная для работы с get;set; у PattyType
        /// </summary>
        private PattyType _type;
        public PattyType PattyType
        {
            get { return _type; }

            /// <summary>
            /// Здесь настраивается информация о цене, весе и энергетической ценности котлеты в зависимости от её типа 
            /// </summary>
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
                        throw new ArgumentException("Неизвестный тип ингрединта"); // Ошибка для случая, когда тип котлеты не был выбран
                }

            }

        }       
        /// <summary>
        /// Конструктор для создания котлеты для бургера
        /// </summary>
        /// <param name="batch">Номер партии продукта</param>
        /// <param name="release">Дата выпуска продукта</param>
        /// <param name="pattyType">Тип котлеты для бургера</param>
        public BurgerPatty(int batch, DateOnly release, PattyType pattyType) : base(batch, release)
        {
            PattyType = pattyType;
        }
    }

}
