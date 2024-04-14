namespace PapaLouieBurgerLogic.Ingredients
{
    /// <summary>
    /// Типы булочек для бургера на выбор
    /// </summary>
    public enum BunType
    {
        ClassicBun,
        SesameBun,
        RyeBun,
        Ciabatta,
        Toast
    }

    /// <summary>
    /// Класс нижней булочки как ингредиента
    /// </summary>
    public class BotBun : Ingredient
    {
        /// <summary>
        /// Приватная переменная для работы с get;set; у BunType
        /// </summary>
        private BunType _type;

        public BunType Type
        {
            get { return _type; }

            /// <summary>
            /// Здесь настраивается информация о цене, весе и энергетической ценности нижней булочки, в зависимости от её типа 
            /// </summary>
            set
            {
                _type = value;
                switch (_type)
                {
                    case BunType.ClassicBun:
                        Cost = 16.0;
                        Weight = 30.0;
                        Ccal = 282.0;
                        break;
                    case BunType.SesameBun:
                        Cost = 18.0;
                        Weight = 30.0;
                        Ccal = 305.0;
                        break;
                    case BunType.RyeBun:
                        Cost = 16.0;
                        Weight = 30.0;
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
        /// Конструктор для создания нижней булочки
        /// </summary>
        /// <param name="batch">Номер партии продукта</param>
        /// <param name="release">Дата выпуска продукта</param>
        /// <param name="type">Тип нижней булочки</param>
        public BotBun(int batch, DateOnly release, BunType type) : base(batch, release)
        {
            Type = type;
        }



    }
}
//namespace Example
//{
//    public enum MyEnum
//    {
//        FirstEnum,
//        SecondEnum,
//        ThirdEnum,
//        FourthEnum
//    }
//    public class MyClass
//    {
//        public MyEnum Enummmmm { get; set; }

//        public MyClass(MyEnum enums) 
//        {
//            Enummmmm = enums;

//        }
//    }

//    public class Program
//    {
//        public static void main(string[] args)
//        {
//            MyClass class2 = new(MyEnum.);
//        }
//    }
//}