namespace PapaLouieBurgerLogic.Ingredients
{
    public enum BunType
    {
        ClassicBun,
        SesameBun,
        RyeBun,
        Ciabatta,
        Toast
    }

    public class BotBun : Ingredient
    {
        private BunType _type { get; set; }
        public BunType Type
        {
            get { return _type; }
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
                        throw new ArgumentException("Unknown type");
                }
            }
        }      

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