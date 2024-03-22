namespace FactoryDesignPattern.RerstaurantExample
{
    public  class Class1
    {
    }


    #region Factory Method Design Pattern section
        //interface IBurger
        //{

        //    void CookBurger();
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

        //abstract class BurgerFactory
        //{
        //    public abstract IBurger MakeBurger(string type);

        //    public IBurger OrderBurger(string type)
        //    {
        //        IBurger burger = MakeBurger(type);
        //        burger.CookBurger();
        //        return burger;
        //    }
        //}

        //class RestaurantA : BurgerFactory
        //{
        //    public override IBurger MakeBurger(string type)
        //    {
        //        Console.WriteLine("Cooking on RestaurantA");
        //        if (type.ToLower() == "veggie")
        //         {
        //            return new VeggieBurger();
        //         }
        //         return new ChessBurger();
        //    }
        //}


        //class RestaurantB : BurgerFactory
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
        //}
    #endregion



    #region Abstract Factory Design Pattern - section
    interface IBurger
    {
        void CookBurger();
    }
    interface IPizza
    {
        void CookPizza();
    }

    class Margheritapizza : IPizza
    {
        public void CookPizza()
        {
            Console.WriteLine("Cooking a Margherita Pizza");
        }
    }


    class ChessBurger : IBurger
    {
        public void CookBurger()
        {
            Console.WriteLine("Cooking a Chess Burger");
        }
    }

    class VeggieBurger : IBurger
    {
        public void CookBurger()
        {
            Console.WriteLine("Cooking a veggie Burger");
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
            return new Margheritapizza();
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
            return new Margheritapizza();
        }
    }
    #endregion
}
