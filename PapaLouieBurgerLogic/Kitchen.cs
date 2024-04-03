using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaLouieBurgerLogic.Ingredients;

namespace PapaLouieBurgerLogic
{
    public static class Kitchen        
    {
        public static Burger NewBurger(List<Ingredient> Ingredients)           
        {
           
            

            return new Burger();
        }
   

        /// <summary>
        /// Метод проверяет список ингредиентов для создания бургера и возвращает true в случае, если условия соблюдены
        /// </summary>       
        public static bool Validated(List<Ingredient> Ingredients)
        {
            //Проверка на наличие ингредиентов
            if (Ingredients.Count < 4)
            {
                throw new ArgumentException("No ingredients found");
            }

            //Попытка получить булку для бургера, т.к. нельзя составить бургер без наличия булочек
            var ingr1 = Ingredients.Find(x => x is BotBun);

            if (ingr1 == null)
            {
                throw new ArgumentException("No buns found");
            }
            return true;
            
        }

    }
}
//    public class Medvedsi4
//    {
//        public string Name { get; set; }

//        public Medvedsi4(string name)
//        {
//            Name = name;
//        }
//    }

//    public static class NoraMedvedsi4ej
//    {
//        public static Medvedsi4 BornMedvedsi4(string hisName)
//        {
//            Medvedsi4 newChild = new Medvedsi4(hisName);
//            return newChild;
//        }
//    }
//}
