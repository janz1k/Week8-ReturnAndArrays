using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "kana", "pizzat", "sushit", "popcorni", "salatit" };
            string[] drinks = { "colat", "fantat", "sprite-i", "vett", "mahla" };
            string[] films = { "Scary Movie-t", "Interstellarit", "Need For Speed-i" };
            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(films);


            Console.WriteLine($"Täna sa sööd {randomFood}, jood {randomDrink} ja vaatad telekast {randomMovie}.");


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
