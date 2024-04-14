// See https://aka.ms/new-console-template for more information
using PapaLouieBurgerLogic;
using PapaLouieBurgerLogic.Ingredients;


#region это будет вводить пользователь
DateOnly dateOnly = new DateOnly();

Ingredient bun = new BotBun(1, dateOnly, BunType.ClassicBun);
Ingredient topBun = new TopBun(1, dateOnly, BunType.ClassicBun);

Ingredient cotleta = new BurgerPatty(1, dateOnly, PattyType.Pork);

Ingredient veg = new Vegetable(1, dateOnly, VegType.Onion);

Ingredient souce = new Sauce(1, dateOnly, SauceType.Ketchup);


//List<Ingredient> burgerRaw = new List<Ingredient> { bun, topBun, cotleta, veg, souce};
List<Ingredient> burgerRaw = new List<Ingredient>
{
    bun,
    topBun,
    cotleta,
    veg,
    souce
};

# endregion

var bakedBurger = Kitchen.NewBurger(burgerRaw);

int q = 2;
