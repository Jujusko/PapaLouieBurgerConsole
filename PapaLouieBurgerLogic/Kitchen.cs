using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaLouieBurgerLogic.Ingredients;

namespace PapaLouieBurgerLogic
{
    /// <summary>
    /// Класс кухни, который работает с классом бургера
    /// </summary>
    public static class Kitchen
    {
        /// <summary>
        /// 
        /// </summary>        
        public static Burger NewBurger(List<Ingredient> Ingredients)
        {



            return new Burger();
        }


        /// <summary>
        /// Метод проверяет список ингредиентов для создания бургера и возвращает true в случае, если условия соблюдены
        /// </summary>       
        public static void Validated(List<Ingredient> Ingredients)
        {
            //Проверка на наличие ингредиентов, минимальное количество ингредиентов - 5
            if (Ingredients.Count < 5)
            {
                throw new ArgumentException("Недостаточно ингредиентов для создания бургера");
            }

            //Попытка получить булочки для бургера, т.к. нельзя составить бургер без наличия булочек
            var botbun = Ingredients.Find(x => x is BotBun);
            var topbun = Ingredients.Find(x => x is TopBun);

            if (botbun == null || topbun == null)
            {
                throw new ArgumentException("Отстуствуют булочки для создания бургера");
            }

            //Проверка на совпадение типов булочек для бургера
            if (((BotBun)botbun).Type != ((TopBun)topbun).Type)
            {
                throw new ArgumentException("Тип нижней и тип верхней булочки не совпадают");
            }

            //Проверка на наличие нижней булочки в количестве 1 шт.
            var botbuns = Ingredients.Where(x => x is BotBun).Count();
            if (botbuns > 1)
            {
                throw new ArgumentException("Необходимо удалить лишние нижние булочки");
            }

            //Проверка на наличие верхей булочки в количестве 1 шт.
            var topbuns = Ingredients.Where(x => x is TopBun).Count();
            if (topbuns > 1)
            {
                throw new ArgumentException("Необходимо удалить лишние верхние булочки");
            }

            //Проверка на наличие котлеты для бургера
            var patty = Ingredients.Find(x => x is BurgerPatty);
            if (patty == null)
            {
                throw new ArgumentException("Отстутвует котлета для создания бургера");
            }

            //Проверка на максимальное количество котлет в бургере
            var pattys = Ingredients.Where(x => x is BurgerPatty).Count();
            if (pattys > 3)
            {
                throw new ArgumentException($"Слишком большое количество котлет для бургера, необходимо убрать {pattys - 3} шт.");
            }

            //Проверка на максимальное количество ломтиков сыра в бургере
            var cheese = Ingredients.Where(x => x is Cheese).Count();
            if (cheese > 3)
            {
                throw new ArgumentException($"Слишком большое количество ломтиков сыра для бургера, необходимо убрать {cheese - 3} шт.");
            }

            //Проверка на максимальное количество соусов в бургере
            var sauce = Ingredients.Where(x => x is Sauce).Count();
            if (sauce > 2)
            {
                throw new ArgumentException($"Слишком большое количество соусов для бургера, необходимо убрать {sauce - 2} шт.");
            }

            //Проверка на максимальное количество овощей в бургере
            var vegetables = Ingredients.Where(x => x is Vegetable).Count();
            if (vegetables > 2)
            {
                throw new ArgumentException($"Слишком большое количество овощей для бургера, необходимо убрать {vegetables - 2} шт.");
            }
        }


        //Метод описывает логику правильной сборки бургера
        public static List<Ingredient> Sort(List<Ingredient> oldlist)
        {

            List<Ingredient> newlist = new List<Ingredient>(oldlist.Count); // Создание пустого списка для ингредиентов, выложенных в правильном порядке                      

            newlist[0] = oldlist.Find(x => x is BotBun); // Перемещение нижней булочки в начало нового списка ингредиентов
            newlist[oldlist.Count - 1] = oldlist.Find(x => x is TopBun); // Перемещение верхей булочки в конец нового списка ингредиентов

            oldlist.Remove(oldlist.Find(x => x is BotBun)); // Удаление нижней булочки из старого списка ингредиентов
            oldlist.Remove(oldlist.Find(x => x is TopBun)); // Удаление верхней булочки из старого списка ингредиентов

            var sauces = oldlist.Where(x => x is Sauce).ToList(); // Поиск соусов в списке ингредиентов

            if (sauces.Count == 1) // Если соус присутствует в количестве 1 шт., то он помещается поверх нижней булочки
            {
                newlist[1] = sauces[0];
            }
            else if (sauces.Count == 2)
            {
                newlist[1] = sauces[0];
                newlist[newlist.Count - 2] = sauces[1]; // Если соус присутствует в количестве 2 шт., то он помещается поверх нижней булочки и под верхнюю булочку
            }

            foreach (var everysauce in sauces) // Удаление соусов из старого списка
            {
                oldlist.Remove(everysauce); 
            }

            for (int i = 0; i < ; i++)
            {









            }



















            var sauce = oldlist.Where(x => x is Sauce).Count();
            if (sauce == 2)
            {
                newlist[1] = oldlist.Find(x => x is Sauce);

            }












            return 0;
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
