using FactoryDesignPattern.RerstaurantExample;

public class Program
{
    private static void Main(string[] args)
    {

        // Eating on Reasturan A
        RestaurantFactory restaurantA = new RestaurantA();
        restaurantA.OrderBurger("veggie");
        restaurantA.OrderPizza();


        // Eating on Restaurant B
        RestaurantFactory restaurantB = new RestaurantB();
        IBurger burger = restaurantB.OrderBurger("veggie");
        restaurantB.OrderPizza();

    }

   
}