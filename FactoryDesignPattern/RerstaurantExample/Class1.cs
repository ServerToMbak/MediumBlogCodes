namespace FactoryDesignPattern.RerstaurantExample
{
    public  class Class1
    {
    }

    // Burger ve Pizza -->
    #region Factory Method Design Pattern section
    interface IBurger
    {
        
        void CookBurger();
    }

    class ChessBurger : IBurger
    {
        public void CookBurger()
        {
            Console.WriteLine("Cooking a Cheese Burger");
        }
    }

    class VeggieBurger : IBurger
    {
        public void CookBurger()
        {
            Console.WriteLine("Cooking a veggie Burger");
        }
    }


   interface IPizza
    {
        void CookPizza();
    }


    class MargheritaPizza : IPizza
    {
        public void CookPizza()
        {
            Console.WriteLine("Cooking a Margherita pizaa");
        }
    }



    abstract class RestaurantFactory
    {
        public abstract IBurger MakeBurger(string type);
        public abstract IPizza MakePizza();

        public IPizza OrderPizza()
        {
            IPizza pizza = MakePizza();
            pizza.CookPizza();
            return pizza;
        }
        
        public IBurger OrderBurger(string type)
        {
            IBurger burger = MakeBurger(type);
            burger.CookBurger();
            return burger;
        }
    }

    class RestaurantA : RestaurantFactory
    {
        public override IBurger MakeBurger(string type)
        {
            Console.WriteLine("Cooking on RestaurantA");
            if (type.ToLower() == "veggie")
            {
                return new VeggieBurger();
            }
            return new ChessBurger();
        }

        public override IPizza MakePizza()
        {
            Console.WriteLine("Cooking on RestaurantA");

            return new MargheritaPizza();
        }
    }


    class RestaurantB : RestaurantFactory
    {
        public override IBurger MakeBurger(string type)
        {
            Console.WriteLine("Cooking on RestaurantB");
            if (type.ToLower() == "veggie")
            {
                return new VeggieBurger();
            }
            return new ChessBurger();
        }

        public override IPizza MakePizza()
        {
            Console.WriteLine("Cooking on RestaurantB");

            return new MargheritaPizza();
        }
    }



    class RestaurantC: RestaurantFactory
    {
        public override IBurger MakeBurger(string type)
        {
            Console.WriteLine("Cooking on RestaurantC");
            if (type.ToLower() == "veggie")
            {
                return new VeggieBurger();
            }
            return new ChessBurger();
        }

        public override IPizza MakePizza()
        {
            Console.WriteLine("Cooking on RestaurantC");

            return new MargheritaPizza();
        }
    }

    #endregion



    #region Abstract Factory Design Pattern - section
    //interface IBurger
    //{
    //    void CookBurger();
    //}
    //interface IPizza
    //{
    //    void CookPizza();
    //}

    //class Margheritapizza : IPizza
    //{
    //    public void CookPizza()
    //    {
    //        Console.WriteLine("Cooking a Margherita Pizza");
    //    }
    //}


    //class ChessBurger : IBurger
    //{
    //    public void CookBurger()
    //    {
    //        Console.WriteLine("Cooking a Chess Burger");
    //    }
    //}

    //class VeggieBurger : IBurger
    //{
    //    public void CookBurger()
    //    {
    //        Console.WriteLine("Cooking a veggie Burger");
    //    }
    //}

    //abstract class restaurantfactory
    //{
    //    public abstract ıburger makeburger(string type);
    //    public abstract ıpizza makepizza();
    //    public ıpizza orderpizza()
    //    {
    //        ıpizza pizza = makepizza();
    //        pizza.cookpizza();
    //        return pizza;
    //    }

    //    public ıburger orderburger(string type)
    //    {
    //        ıburger burger = makeburger(type);
    //        burger.cookburger();
    //        return burger;
    //    }
    //}

    //class RestaurantA : RestaurantFactory
    //{
    //    public override IBurger MakeBurger(string type)
    //    {
    //        Console.WriteLine("Cooking on RestaurantA");
    //        if (type.ToLower() == "veggie")
    //        {
    //            return new VeggieBurger();
    //        }
    //        return new ChessBurger();
    //    }

    //    public override IPizza MakePizza()
    //    {
    //        Console.WriteLine("Cooking on RestaurantA");
    //        return new Margheritapizza();
    //    }
    //}


    //class RestaurantB : RestaurantFactory
    //{
    //    public override IBurger MakeBurger(string type)
    //    {
    //        Console.WriteLine("Cooking on RestaurantB");
    //        if (type.ToLower() == "veggie")
    //        {
    //            return new VeggieBurger();
    //        }
    //        return new ChessBurger();
    //    }

    //    public override IPizza MakePizza()
    //    {
    //        Console.WriteLine("Cooking on RestaurantB");
    //        return new Margheritapizza();
    //    }
    //}
    #endregion
}
