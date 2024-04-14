using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieBurgerLogic.Ingredients
{
    /// <summary>
    /// Класс ингредиента
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// Номер партии ингредиента
        /// </summary>
        public int NumberOfBatch { get; set; }

        /// <summary>
        /// Дата выпуска ингредиента
        /// </summary>
        public DateOnly ReleaseDate { get; set; }

        /// <summary>
        /// Цена ингредиента 
        /// </summary>
        public double Cost { get; protected set; } //узнать, стоит ли делать cost, weight и ccal приватными

        /// <summary>
        /// Вес ингредиента
        /// </summary>
        public double Weight { get; protected set; }

        /// <summary>
        /// Калорийность ингредиента
        /// </summary>
        public double Ccal { get; protected set; }        

        /// <summary>
        /// Конструктор для создания ингредиента
        /// </summary>
        /// <param name="batch">Номер партии продукта</param>
        /// <param name="release">Даты выпуска продукта</param>
        public Ingredient(int batch, DateOnly release)
        {
            NumberOfBatch = batch;
            ReleaseDate = release;
        }

    }
}
