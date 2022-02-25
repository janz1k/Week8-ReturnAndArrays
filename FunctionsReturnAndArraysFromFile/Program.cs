using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }


        private static void DisplayRandomFood()
        {
            string[] foods = { "wingsday", "pizzaday", "sushiday", "popcornday", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Arvuti valis teile päeva toiduks: {randomFood}");

        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "cola", "fanta", "sprite", "water", "juice" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Arvuti valis teile päeva joogiks: {randomDrink}");

        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Interstellar", "Fight Club", "Home Alone" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMovie = movies[randomIndex];
            Console.WriteLine($"Arvuti valis teile tänaseks filmiks: {randomMovie}");
        }
    }
}
