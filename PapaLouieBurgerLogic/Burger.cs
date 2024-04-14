using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaLouieBurgerLogic.Ingredients;

namespace PapaLouieBurgerLogic
{
    /// <summary>
    /// Класс бургера как готового продукта
    /// </summary>
    public class Burger
    {
        /// <summary>
        /// Лист ингредиентов для создания бургера
        /// </summary>
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        /// <summary>
        /// Итоговая цена бургера 
        /// </summary>
        public double TotalCost { get; private set; }

        /// <summary>
        /// Итоговый вес бургера
        /// </summary>
        public double TotalWeight { get; private set; }

        /// <summary>
        /// Итоговая калорийсность бургера
        /// </summary>
        public double TotalCcal { get; private set; }

        public Burger(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

    }

}
