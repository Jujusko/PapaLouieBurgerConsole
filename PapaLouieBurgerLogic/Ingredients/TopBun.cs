using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{
    /// <summary>
    /// Класс верхней булочки как ингредиента
    /// </summary>
    public class TopBun : Ingredient
    {
        /// <summary>
        /// Приватная переменная для работы с get;set; у BunType
        /// </summary>
        private BunType _type;
        public BunType Type
        {
            get { return _type; }

            /// <summary>
            /// Здесь настраивается информация о цене, весе и энергетической ценности верхней булочки в зависимости от её типа 
            /// </summary>
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
                        throw new ArgumentException("Неизвестный тип ингрединта"); // Ошибка для случая, когда тип булочки не был выбран
                }
            }
        }
        /// <summary>
        /// Конструктор для создания верхней булочки
        /// </summary>
        /// <param name="batch">Номер партии продукта</param>
        /// <param name="release">Дата выпуска продукта</param>
        /// <param name="type">Тип верхней булочки</param>
        public TopBun(int batch, DateOnly release, BunType type) : base(batch, release)
        {
            Type = type;
            
        }




    }
}
