using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{
    /// <summary>
    /// Типы соуса для бургера на выбор
    /// </summary>
    public enum SauceType
    {
        Ketchup,
        Mayonnaise,
        Mustard,
        Chili,
        Tartar,
        BBQ,
        BeeSauce
    }

    /// <summary>
    /// Класс соуса как ингредиента
    /// </summary>
    public class Sauce : Ingredient
    {
        /// <summary>
        /// Приватная переменная для работы с get;set; у SauceType
        /// </summary>
        private SauceType _type;
        public SauceType SauceType
        {
            get { return _type; }

            /// <summary>
            /// Здесь настраивается информация о цене, весе и энергетической ценности соуса в зависимости от его типа 
            /// </summary>
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
                        case SauceType.BeeSauce:
                        Cost = 12.0;
                        Weight = 12.0;
                        Ccal = 214.0;
                        break;
                    default:
                        throw new ArgumentException("Неизвестный тип ингрединта"); //Ошибка  для случая, когда тип соуса не был выбран
                }
            }
        }
        /// <summary>
        /// Конструктор для создания соуса
        /// </summary>
        /// <param name="batch">Номер партии продукта</param>
        /// <param name="relese">Дата выпуска продукта</param>
        /// <param name="type">Тип соуса</param>
        public Sauce(int batch, DateOnly release, SauceType type) : base(batch, release)
        {
            SauceType = type;
        }




    }
}
