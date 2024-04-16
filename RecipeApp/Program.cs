using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = null;

            while (true)
            {
                DisplayMainMenu();

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        recipe = EnterRecipeDetails();
                        break;
                    case "2":
                        if (recipe != null)
                        {
                            recipe.DisplayRecipe();
                        }
                        else
                        {
                            Console.WriteLine("No recipe entered yet. Please enter a recipe first.");
                        }
                        break;
                    case "3":
                        if (recipe != null)
                        {
                            ScaleRecipe(recipe);
                        }
                        else
                        {
                            Console.WriteLine("No recipe entered yet. Please enter a recipe first.");
                        }
                        break;
                    case "4":
                        if (recipe != null)
                        {
                            recipe.ResetQuantities();
                            Console.WriteLine("Quantities reset successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No recipe entered yet. Please enter a recipe first.");
                        }
                        break;
                    case "5":
                        if (recipe != null)
                        {
                            recipe.ClearData();
                            Console.WriteLine("All data cleared successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No recipe entered yet. Please enter a recipe first.");
                        }
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

        static void DisplayMainMenu()
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Enter Recipe Details");
            Console.WriteLine("2. Display Recipe");
            Console.WriteLine("3. Scale Recipe");
            Console.WriteLine("4. Reset Quantities");
            Console.WriteLine("5. Clear All Data");
            Console.WriteLine("6. Exit");
        }

        static Recipe EnterRecipeDetails()
        {
            Console.WriteLine("\nEnter details for the recipe:");

            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            Recipe recipe = new Recipe(ingredientCount, stepCount);

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"\nEnter details for ingredient {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write("Unit: ");
                string unit = Console.ReadLine();

                recipe.AddIngredient(new Ingredient { Name = name, Quantity = quantity, Unit = unit });
            }

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"\nEnter details for step {i + 1}:");

                Console.Write("Description: ");
                string description = Console.ReadLine();

                recipe.AddStep(new Step { Description = description });
            }

            Console.WriteLine("\nRecipe entered successfully.");
            return recipe;
        }

        static void ScaleRecipe(Recipe recipe)
        {
            Console.Write("\nEnter scale factor (0.5, 2, or 3): ");
            double factor;
            if (double.TryParse(Console.ReadLine(), out factor))
            {
                recipe.ScaleRecipe(factor);
                Console.WriteLine("Recipe scaled successfully.");
            }
            else
            {
                Console.WriteLine("Invalid scale factor.");
            }
        }
    }
}


