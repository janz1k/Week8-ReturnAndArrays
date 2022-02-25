using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomFood();
            DisplayRandomMovie();

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "wingsday", "pizzaday", "sushiday", "popcornday", "salad" };
            Console.WriteLine($"Arvuti valis teile päeva toiduks: {foods[GenerateRandomIndex(foods)]}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "cola", "fanta", "sprite", "water", "juice" };           
            Console.WriteLine($"Arvuti valis teile päeva joogiks: {drinks[GenerateRandomIndex(drinks)]}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Interstellar", "Home Alone", "James Bond" };
            Console.WriteLine($"Arvuti valis teile päeva filmiks: {movies[GenerateRandomIndex(movies)]}");
        }
    }
}
