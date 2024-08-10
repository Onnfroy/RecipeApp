using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class Program
    {
        public static List<Recipe> recipes = new List<Recipe>(); // List to store all recipes

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
            }

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter details for step {i + 1}:");
                Console.Write("Description: ");
                string description = Console.ReadLine();

                recipe.AddStep(new Step { Description = description });
            }

            recipes.Add(recipe);
            Console.WriteLine("Recipe entered successfully.");
        }

        /// <summary>
        /// Displays all recipes in alphabetical order.
        /// </summary>
        static void DisplayRecipes()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            var sortedRecipes = recipes.OrderBy(r => r.Name).ToList();

            Console.WriteLine("Recipes:");
            for (int i = 0; i < sortedRecipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sortedRecipes[i].Name}");
            }

            Console.Write("Enter the number of the recipe to display: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < sortedRecipes.Count)
            {
                sortedRecipes[index].DisplayRecipe();
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        /// <summary>
        /// Scales the quantities of a selected recipe.
        /// </summary>
        static void ScaleSelectedRecipe()
        {
            Console.Write("Enter the name of the recipe to scale: ");
            string name = Console.ReadLine();

            Recipe recipe = recipes.FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (recipe != null)
            {
                Console.Write("Enter scale factor (0.5, 2, or 3): ");
                if (double.TryParse(Console.ReadLine(), out double factor))
                {
                    recipe.ScaleRecipe(factor);
                }
                else
                {
                    Console.WriteLine("Invalid scale factor.");
                }
            }
            else
            {
                Console.WriteLine("Recipe not found.");
            }
        }

        /// <summary>
        /// Resets the quantities of ingredients in a selected recipe.
        /// </summary>
        static void ResetQuantities()
        {
            Console.Write("Enter the name of the recipe to reset quantities: ");
            string name = Console.ReadLine();

            Recipe recipe = recipes.FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (recipe != null)
            {
                recipe.ResetQuantities();
                Console.WriteLine("Quantities reset successfully.");
            }
            else
            {
                Console.WriteLine("Recipe not found.");
            }
        }

        /// <summary>
        /// Clears all recipe data.
        /// </summary>
        static void ClearAllData()
        {
            recipes.Clear();
            Console.WriteLine("All data cleared successfully.");
        }
    }
}

//--------------------------------------------------------EOF--------------------------------------------------------------------------------//

