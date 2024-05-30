using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    class Program
    {
        static List<Recipe> recipes = new List<Recipe>(); // List to store all recipes

        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMainMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewRecipe();
                        break;
                    case "2":
                        DisplayRecipes();
                        break;
                    case "3":
                        ScaleSelectedRecipe();
                        break;
                    case "4":
                        ResetQuantities();
                        break;
                    case "5":
                        ClearAllData();
                        break;
                    case "6":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        /// <summary>
        /// Displays the main menu options.
        /// </summary>
        static void DisplayMainMenu()
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Enter Recipe Details");
            Console.WriteLine("2. Display Recipes");
            Console.WriteLine("3. Scale Recipe");
            Console.WriteLine("4. Reset Quantities");
            Console.WriteLine("5. Clear All Data");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
        }

        /// <summary>
        /// Adds a new recipe based on user input.
        /// </summary>
        static void AddNewRecipe()
        {
            Console.Write("Enter the recipe name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            Recipe recipe = new Recipe { Name = name };
            recipe.OnCalorieAlert += message => Console.WriteLine(message);

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter details for ingredient {i + 1}:");
                Console.Write("Name: ");
                string ingredientName = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit: ");
                string unit = Console.ReadLine();
                Console.Write("Calories: ");
                int calories = int.Parse(Console.ReadLine());
                Console.Write("Food Group: ");
                string foodGroup = Console.ReadLine();

                recipe.AddIngredient(new Ingredient { Name = ingredientName, Quantity = quantity, Unit = unit, Calories = calories, FoodGroup = foodGroup });
///////////////////////////////////////////////////////////////////////End Of File///////////////////////////////////////////////////////////////////////////////////////


