using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {

            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            string[] drinks = { "Apple juice", "coke", "fanta", "sprite", "water" };
            string[] movies = { "Harry Potter and sorcerer's stone", "Die Hard", "Don't look up", "Spiderman no way home", "Jungle cruise" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(movies);

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
        }
    }
}
